using Caf.Etl.Models.CosmosDBSqlApi.Sample;
using Caf.Etl.Models.Manual.TidyData;
using Caf.Etl.Models.Manual.TidyData.DataTables;
using Caf.Etl.Nodes.Manual.Extract;
using Caf.Etl.Nodes.Manual.Mappers;
using Caf.Etl.Nodes.Manual.Transform;
using Caf.Etl.TestUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Caf.Etl.UnitTests.Nodes.Manual
{
    public class CosmosDBSqlApiSampleV2TransformerTest
    {
        [Fact]
        public void Transform_ValidData_ReturnsExpected()
        {
            // Arrange

            CosmosDBSqlApiSampleV2Transformer sut = 
                new CosmosDBSqlApiSampleV2Transformer(
                    new MapFromTidyDataToSampleV2(),
                    "http://files.cafltar.org/data/schema/documentDb/v2/sample.json",
                    "",
                    "CookEastCropHandHarvest",
                    "VegetationSample");

            TidyData tidyData = 
                ManualArranger.GetTidyDataDerivedFromActualDataV1();

            List<SampleV2> expected = 
                ManualArranger.GeHandHarvestSampleDerivedFromActualDataV1();
            
            // Act
            List<SampleV2> actual = sut.Transform(tidyData);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}