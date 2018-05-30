using System;
using Xunit;
using Microsoft.Azure.Documents.Client;
using Caf.Etl.Nodes.CosmosDBSqlApi.Load;
using Caf.Etl.TestUtils;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using System.Net;

namespace Caf.Etl.IntegrationTests
{
    /// <summary>
    /// These tests require the Azure Cosmos DB Emulator to be running locally
    /// Also, the emulator must be configured correctly.
    /// 
    /// Expects:
    ///     EtlEvent with id "EtlEvent_2018-05-22T01:00:00.000000Z"
    ///     EtlEvent with id "EtlEvent_2018-06-22T01:00:00.000000Z"
    /// </summary>
    public class EtlEventLoaderTests
    {

        [Fact]
        public async Task LoadNoReplace_RecordExists_ReturnsOldRecord()
        {
            // ARRANGE
            DocumentClient client = new DocumentClient(
                new Uri("https://localhost:8081"),
                "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==");
            var e = CosmosDBSqlApiArranger.GetEtlEventMock("EtlEvent_2018-05-22T01:00:00.000000Z");
            var datetime = DateTime.UtcNow;

            EtlEventLoader sut = new EtlEventLoader(
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
        public async Task LoadReplace_RecordExists_ReturnsNewRecord()
        {
            // ARRANGE
            DocumentClient client = new DocumentClient(
                new Uri("https://localhost:8081"),
                "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==");
            var e = CosmosDBSqlApiArranger.GetEtlEventMock("EtlEvent_2018-06-22T01:00:00.000000Z");
            var datetime = DateTime.UtcNow;

            EtlEventLoader sut = new EtlEventLoader(
                client,
                "cafdb",
                "items");

            // ACT
            ResourceResponse<Document> result = await sut.LoadReplace(e);

            // ASSERT
            Assert.True(result.StatusCode == HttpStatusCode.OK);
            Assert.True(result.Resource.Timestamp > datetime);
        }
    }
}
