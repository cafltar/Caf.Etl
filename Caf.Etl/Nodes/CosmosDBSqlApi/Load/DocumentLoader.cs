using System.Threading.Tasks;
using System.Net;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Caf.Etl.Models.CosmosDBSqlApi;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Caf.Etl.Nodes.CosmosDBSqlApi.Load
{
    public class DocumentLoader
    {
        private readonly IDocumentClient client;
        private readonly string databaseId;
        private readonly string collectionId;


        public DocumentLoader(
            IDocumentClient client,
            string databaseId,
            string collectionId)
        {
            this.client = client;
            this.databaseId = databaseId;
            this.collectionId = collectionId;
        }

        public async Task<ResourceResponse<Document>> LoadNoReplace(
            IAmDocument doc)
        {
            ResourceResponse<Document> r;

            try
            {
                r = await client.ReadDocumentAsync(
                    UriFactory.CreateDocumentUri(
                        databaseId, 
                        collectionId, 
                        doc.Id),
                    new RequestOptions {
                        PartitionKey = new PartitionKey(doc.PartitionKey)
                    });
            }
            catch (DocumentClientException de)
            {
                if(de.StatusCode == HttpStatusCode.NotFound)
                {
                    r = await client.CreateDocumentAsync(
                        UriFactory.CreateDocumentCollectionUri(
                            databaseId,
                            collectionId),
                        doc);
                }
                else
                {
                    throw;
                }
            }

            return r;
        }

        public async Task<ResourceResponse<Document>> LoadReplace(
            IAmDocument doc)
        {
            var r = await this.client.ReplaceDocumentAsync(
                UriFactory.CreateDocumentUri(
                    databaseId,
                    collectionId,
                    doc.Id),
                doc);

            return r;
        }

        /// <summary>
        /// Loads multple IAmDocuments, split by partitionKey, using 
        /// the bulkImport stored procedure.  The stored procedure is
        /// not generated so must be created.  Function fails if stored
        /// procedure is not found
        /// </summary>
        /// <remarks>Assumed name of stored procedure is "bulkImport"</remarks>
        /// <param name="docs"></param>
        /// <returns></returns>
        public async Task<StoredProcedureResponse<bool>[]> LoadBulk(
            IEnumerable<IAmDocument> docs)
        {
            // TODO: Replace with BulkExecutor once it's netstandard2 complient
            List<Task<StoredProcedureResponse<bool>>> tasks =
                new List<Task<StoredProcedureResponse<bool>>>();
            var groupedDocs = docs.GroupBy(d => d.PartitionKey);

            foreach(var groupedDoc in groupedDocs)
            {
                try
                {
                    tasks.Add(client.ExecuteStoredProcedureAsync<bool>(
                            $"/dbs/{databaseId}/colls/{collectionId}/sprocs/bulkImport/",
                            new RequestOptions
                            {
                                PartitionKey = 
                                    new PartitionKey(
                                        groupedDoc.Key.ToString())
                            },
                            groupedDoc));
                }
                catch(Exception e)
                {
                    throw new Exception(
                        "Error initializing tasks for bulk import", e);
                }
            }

            StoredProcedureResponse<bool>[] result;

            try
            {
                result = await Task.WhenAll(tasks);
            }
            catch(Exception e)
            {
                IEnumerable<Exception> exceptions = tasks
                    .Where(t => t.Exception != null)
                    .Select(t => t.Exception);
                Exception exampleException = exceptions.FirstOrDefault();
                string exceptionMessage =
                    exampleException.InnerException != null
                    ? exampleException.InnerException.Message
                    : exampleException.Message;

                throw new Exception(
                    $"{exceptions.Count().ToString()} stored procedures failed out of a total of {tasks.Count()} sprocs for {docs.Count()} measurements. Example exception message from first exception: {exceptionMessage}", 
                    e);
            }

            return result;
        }
    }
}
