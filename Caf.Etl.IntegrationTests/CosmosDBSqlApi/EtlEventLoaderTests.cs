using System;
using Xunit;
using Microsoft.Azure.Documents.Client;
using Caf.Etl.Nodes.CosmosDBSqlApi.Load;
using Caf.Etl.TestUtils;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using System.Net;
using System.Collections.Generic;
using Caf.Etl.Models.CosmosDBSqlApi;
using Caf.Etl.Models.CosmosDBSqlApi.EtlEvent;
using System.Linq;

namespace Caf.Etl.IntegrationTests
{
    /// <summary>
    /// These tests require the Azure Cosmos DB Emulator to be running locally
    /// Also, the emulator must be configured correctly.
    /// 
    /// Expects:
    ///     Database = cafdb
    ///     Collection = items
    /// </summary>
    public class EntityLoaderTests
    {
        private DocumentClient client;

        public EntityLoaderTests()
            :base()
        {
            client = new DocumentClient(
                new Uri(
                    "https://localhost:8081"),
                    "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==");

            // Setup, deletes all Measurements
            deleteAllDocuments(getAllEtlEvents().ToList<IAmDocument>());

            var collectionLink = UriFactory.CreateDocumentCollectionUri("cafdb", "items");
            client.CreateDocumentAsync(collectionLink,
                CosmosDBSqlApiArranger.GetEtlEventMock("EtlEvent_2018-05-22T01:00:00.000000Z")).Wait();
            client.CreateDocumentAsync(collectionLink,
                CosmosDBSqlApiArranger.GetEtlEventMock("EtlEvent_2018-06-22T01:00:00.000000Z")).Wait();
        }

        [Fact]
        public async Task LoadNoReplace_RecordExists_ReturnsOldRecord()
        {
            // ARRANGE
            var e = CosmosDBSqlApiArranger.GetEtlEventMock("EtlEvent_2018-05-22T01:00:00.000000Z");
            var datetime = DateTime.UtcNow;

            DocumentLoader sut = new DocumentLoader(
                client,
                "cafdb",
                "items");

            // ACT
            ResourceResponse<Document> result = await sut.LoadNoReplace(e);

            // ASSERT
            Assert.True(result.StatusCode == HttpStatusCode.OK);
            Assert.True(result.Resource.Timestamp < datetime);
        }

        [Fact]
        public async Task LoadNoReplace_RecordDoesNotExist_ReturnsNewRecord()
        {
            // ARRANGE
            var datetime = DateTime.UtcNow;
            var e = CosmosDBSqlApiArranger.GetEtlEventMock($"EtlEvent_{DateTime.UtcNow.ToString("o")}");

            DocumentLoader sut = new DocumentLoader(
                client,
                "cafdb",
                "items");

            // ACT
            ResourceResponse<Document> result = await sut.LoadNoReplace(e);

            // ASSERT
            Assert.True(result.StatusCode == HttpStatusCode.Created);
            Assert.InRange<DateTime>(
                result.Resource.Timestamp, 
                datetime.Add(new TimeSpan(0, -1, 0)), 
                datetime.Add(new TimeSpan(0, 1, 0)));
        }

        [Fact]
        public async Task LoadReplace_RecordExists_ReturnsNewRecord()
        {
            // ARRANGE
            var datetime = DateTime.UtcNow;
            var e = CosmosDBSqlApiArranger.GetEtlEventMock("EtlEvent_2018-06-22T01:00:00.000000Z");

            DocumentLoader sut = new DocumentLoader(
                client,
                "cafdb",
                "items");

            // ACT
            ResourceResponse<Document> result = await sut.LoadReplace(e);

            // ASSERT
            Assert.True(result.StatusCode == HttpStatusCode.OK);
            Assert.InRange<DateTime>(
                result.Resource.Timestamp, 
                datetime.Add(new TimeSpan(0, -1, 0)), 
                datetime.Add(new TimeSpan(0, 1, 0)));
        }

        private IQueryable<EtlEvent> getAllEtlEvents()
        {
            IQueryable<EtlEvent> events =
                client.CreateDocumentQuery<EtlEvent>(
                    UriFactory.CreateDocumentCollectionUri("cafdb", "items"),
                    new FeedOptions { EnableCrossPartitionQuery = true })
                    .Where(m => m.Type == "EtlEvent");
            return events;
        }

        private bool deleteAllDocuments(List<IAmDocument> documents)
        {
            foreach(var doc in documents)
            {
                client.DeleteDocumentAsync(
                    UriFactory.CreateDocumentUri(
                        "cafdb", "items", doc.Id),
                    new RequestOptions {
                        PartitionKey = new PartitionKey(doc.PartitionKey)
                    }).Wait();
            }

            return true;
        }
    }
}
