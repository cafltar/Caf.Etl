using System.Threading.Tasks;
using System.Net;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Caf.Etl.Models.CosmosDBSqlApi;

namespace Caf.Etl.Nodes.CosmosDBSqlApi.Load
{
    public class DocumentLoader
    {
        private readonly DocumentClient client;
        private readonly string databaseId;
        private readonly string collectionId;


        public DocumentLoader(
            DocumentClient client,
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
    }
}
