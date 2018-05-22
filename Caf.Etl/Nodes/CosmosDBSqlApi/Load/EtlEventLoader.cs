using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Newtonsoft.Json;
using Caf.Etl.Models.CosmosDBSqlApi.EtlEvent;

namespace Caf.Etl.Nodes.CosmosDBSqlApi.Load
{
    public class EtlEventLoader
    {
        private readonly DocumentClient client;
        private readonly string databaseId;
        private readonly string collectionId;


        public EtlEventLoader(
            DocumentClient client,
            string databaseId,
            string collectionId)
        {
            this.client = client;
            this.databaseId = databaseId;
            this.collectionId = collectionId;
        }

        //TODO: I think this should create the Id for the document?  Or should the calling function?  Or the Transformer?  Who has the rights?!!!
        public async Task<ResourceResponse<Document>> LoadNoReplace(
            EtlEvent etlEvent)
        {
            ResourceResponse<Document> r;

            try
            {
                r = await client.ReadDocumentAsync(
                    UriFactory.CreateDocumentUri(
                        databaseId, 
                        collectionId, 
                        etlEvent.Id),
                    new RequestOptions {
                        PartitionKey = new PartitionKey(etlEvent.PartitionKey)
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
                        etlEvent);
                }
                else
                {
                    throw;
                }
            }

            return r;
        }

        public async Task<ResourceResponse<Document>> LoadReplace(
            EtlEvent etlEvent)
        {
            var r = await this.client.ReplaceDocumentAsync(
                UriFactory.CreateDocumentUri(
                    databaseId,
                    collectionId,
                    etlEvent.Id),
                etlEvent);

            return r;
        }
    }
}
