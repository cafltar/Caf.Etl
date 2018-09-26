using Caf.Etl.Nodes.Manual.Extract;
using Caf.Etl.Nodes.Manual.Transform;
using Caf.Etl.Nodes.Manual.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Caf.Etl.Models.CosmosDBSqlApi.EtlEvent;
using Caf.Etl.Models.CosmosDBSqlApi.Sample;
using Caf.Etl.Models.Manual.TidyData.DataTables;
using Microsoft.Azure.Documents.Client;
using Caf.Etl.Nodes.CosmosDBSqlApi.Load;
using Caf.Etl.Models.CosmosDBSqlApi.Measurement;
using Caf.Etl.Models.CosmosDBSqlApi;
using Microsoft.Azure.Documents;
using Caf.Etl.Models.Manual.TidyData;
using Newtonsoft.Json;

namespace Caf.Etl.IntegrationTests
{
    /// <summary>
    /// Integration tests requires Cosmos DB Emulator configured with:
    /// database = "cafdb", collection = "items"
    /// </summary>
    public class ManualTidyDataToCosmosDBSqlApiTests
    {
        string pathToFileWithValidHandHarvestYieldV1Data =
            @"Assets/Manual/L1_Aggregated2013-2016_20180625_slim.csv";
        string pathToFileWithValidHandHarvestYieldV1Dictionary =
            @"Assets/Manual/L1_Aggregated2013-2016_DataDictionary_20180625.csv";
        string pathToFileWithValidSoilGridPointSurveyV1Data =
            @"Assets/Manual/soilCore1998To2015ShallowDeepMergedByHorizon_20180925_slim.csv";
        string pathToFileWithValidSoilGridPointSurveyV1Dictionary =
            @"Assets/Manual/soilCore1998To2015ShallowDeepMergedByHorizon_Dictionary_20180925.csv";

        private DocumentClient client;

        public ManualTidyDataToCosmosDBSqlApiTests()
            :base()
        {
            JsonSerializerSettings serializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            client = new DocumentClient(
                new Uri(
                    "https://localhost:8081"),
                    "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==",
                    serializerSettings);

            // Setup, deletes all Measurements
            deleteAllDocuments(getAllVegetationSamples().ToList<IAmDocument>());
            deleteAllDocuments(getAllEtlEvents().ToList<IAmDocument>());
        }

        [Fact]
        public async Task HandHarvestYieldV1ToCosmos_ActualData_CreatesExpectedRecords()
        {
            // Arrange
            var extractor = new TidyDataCsvExtractor(
                pathToFileWithValidHandHarvestYieldV1Data,
                pathToFileWithValidHandHarvestYieldV1Dictionary);
            EtlEvent etlEvent = new EtlEvent(
                "EtlEvent",
                "LocalProcess",
                "http://files.cafltar.org/data/schema/documentDb/v2/etlEvent.json",
                "CookEastCropHandHarvest",
                "0.1",
                "",
                DateTime.UtcNow);
            var transformer = new CosmosDBSqlApiSampleV2Transformer
                    <HandHarvestYieldV1,VegetationSample>(
                new MapFromHandHarvestYieldV1ToVegetationSample(),
                "http://files.cafltar.org/data/schema/documentDb/v2/sample.json",
                etlEvent.Id,
                "CookEastCropHandHarvest",
                "CookEast",
                "VegetationSample");

            var loader = new DocumentLoader(
                client,
                "cafdb",
                "items");

            // Act
            TidyData extracted = extractor.Extract<HandHarvestYieldV1>();
            List<VegetationSample> transformed = transformer.Transform(extracted);
            StoredProcedureResponse<bool>[] results = await loader.LoadBulk(transformed);

            Assert.Equal(13, transformed.Count);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task SoilGridPointSurveyV1ToCosmos_ActualData_CreatesExpectedRecords()
        {
            // Arrange
            var extractor = new TidyDataCsvExtractor(
                pathToFileWithValidSoilGridPointSurveyV1Data,
                pathToFileWithValidSoilGridPointSurveyV1Dictionary);
            EtlEvent etlEvent = new EtlEvent(
                "EtlEvent",
                "LocalProcess",
                "http://files.cafltar.org/data/schema/documentDb/v2/etlEvent.json",
                "CookEastSoilGridPointSurvey",
                "0.1",
                "",
                DateTime.UtcNow);
            var transformer = new CosmosDBSqlApiSampleV2Transformer
                    <SoilGridPointSurveyV1,SoilSample>(
                new MapFromSoilGridPointSurveyToSoilSample(),
                "http://files.cafltar.org/data/schema/documentDb/v2/sample.json",
                etlEvent.Id,
                "CookEastSoilGridPointSurvey",
                "CookEast",
                "SoilSample");

            var loader = new DocumentLoader(
                client,
                "cafdb",
                "items");

            // Act
            TidyData extracted = extractor.Extract<SoilGridPointSurveyV1>();
            List<SoilSample> transformed = transformer.Transform(extracted);
            StoredProcedureResponse<bool>[] results = await loader.LoadBulk(transformed);

            Assert.Equal(29, transformed.Count);
            Assert.NotEmpty(results);
        }

        private IQueryable<MeasurementV2> getAllMeasurements()
        {
            IQueryable<MeasurementV2> measurements =
                client.CreateDocumentQuery<MeasurementV2>(
                    UriFactory.CreateDocumentCollectionUri("cafdb", "items"),
                    new FeedOptions { EnableCrossPartitionQuery = true })
                    .Where(m => m.Type == "Measurement");
            return measurements;
        }
        private IQueryable<VegetationSample> getAllVegetationSamples()
        {
            IQueryable<VegetationSample> vegSamples =
                client.CreateDocumentQuery<VegetationSample>(
                    UriFactory.CreateDocumentCollectionUri("cafdb", "items"),
                    new FeedOptions { EnableCrossPartitionQuery = true })
                    .Where(m => m.Type == "VegetationSample");
            return vegSamples;
        }
        private IQueryable<MeasurementV2> getAllEtlEvents()
        {
            IQueryable<MeasurementV2> events =
                client.CreateDocumentQuery<MeasurementV2>(
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
