using Caf.Etl.Models.CosmosDBSqlApi.Measurement;
using Caf.Etl.Nodes.CosmosDBSqlApi.Extract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Caf.Etl.UnitTests.CosmosDBSqlApi
{
    public class CafDbExtractorTests
    {
        // Expect certain data from live database, this is temp test
        [Fact]
        public async void ExtractMeasurements_Valid_ReturnsExpected()
        {
            string uri = System.Configuration.ConfigurationManager.AppSettings["cosmosUri"];
            string key = System.Configuration.ConfigurationManager.AppSettings["cosmosKey"];

            var sut = new CafDbExtractor(uri, key);
            var expected = new List<MeasurementV2>();
            var actual = await sut.ExtractMeasurementsV2(
                "CafMeteorologyEcTower",
                "CookEast",
                "ParDensityTsAvg",
                "2019-12-12",
                "2019-12-13");

            Assert.Equal(expected, actual);
        }
    }
}
