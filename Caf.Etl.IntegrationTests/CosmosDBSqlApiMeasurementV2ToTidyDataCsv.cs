using Caf.Etl.Models.CosmosDBSqlApi.Measurement;
using Caf.Etl.Models.Manual.TidyData;
using Caf.Etl.Nodes.CosmosDBSqlApi.Extract;
using Caf.Etl.Nodes.CosmosDBSqlApi.Transform;
using Caf.Etl.Nodes.Manual.Load;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Caf.Etl.IntegrationTests
{
    public class CosmosDBSqlApiMeasurementV2ToTidyDataCsv
    {
        [Fact]
        public async void ExtractMeasurementV2FromCosmosTransformToTidyWriteToCsv()
        {
            // Arrange
            string uri = System.Configuration.ConfigurationManager.AppSettings["cosmosUri"];
            string key = System.Configuration.ConfigurationManager.AppSettings["cosmosKey"];
            string dirPath = @"Output";
            string fileName = "test";

            var extractor = new CafDbExtractor(uri, key);
            var transformer = new ManualTidyDataTransformer();
            var loader = new TidyDataCsvLoader();

            // Act
            List<MeasurementV2> measurements = 
                await extractor.ExtractMeasurementsV2(
                    "CafMeteorologyEcTower",
                    "CookEast",
                    "ParDensityTsAvg",
                    "2019-12-12",
                    "2019-12-13");

            TidyData tidyData = 
                transformer.Transform<ParDataTable>(measurements);

            loader.LoadToFile(tidyData, dirPath, fileName);

            // Assert
            var files = Directory.GetFiles(dirPath, $"{fileName}*");

            Assert.Equal(2, files.Length);

            // Cleanup
            if (files.Length > 0)
            {
                foreach (var file in files)
                {
                    File.Delete(file);
                }
            }
        }
    }

    public class ParDataTable : IObservation
    {
        public DateTimeOffset DateTimeUtc { get; set; }
        public double ParDensityTsAvg { get; set; }
    }
}
