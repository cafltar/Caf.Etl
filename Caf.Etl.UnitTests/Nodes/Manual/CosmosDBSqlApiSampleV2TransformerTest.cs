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
        public void Transform_ValidDataHandHarvestYieldV1_ReturnsExpected()
        {
            // Arrange

            CosmosDBSqlApiSampleV2Transformer
                <HandHarvestYieldV1, VegetationSample> sut = 
                new CosmosDBSqlApiSampleV2Transformer
                    <HandHarvestYieldV1, VegetationSample>(
                        new MapFromHandHarvestYieldV1ToVegetationSample(),
                        "http://files.cafltar.org/data/schema/documentDb/v2/sample.json",
                        "",
                        "CookEastCropHandHarvest",
                        "CookEast",
                        "VegetationSample");

            TidyData tidyData =
                ManualArranger.GetTidyDataDerivedFromActualDataV1();

            List<VegetationSample> expected = 
                ManualArranger.GeHandHarvestSampleDerivedFromActualDataV1();
            
            // Act
            List<VegetationSample> actual = new List<VegetationSample>() {
                sut.Transform(tidyData).First()
            };

            // Assert
            Assert.Equal(expected.Count, actual.Count);
            Assert.True(ComparerUtil.AreVegetationSamplesRoughlyEqual(
                expected, actual));
        }

        [Fact]
        public void Transform_NullValuesHandHarvestYieldV1_DoesNotCreateSampleAndNoErrors()
        {
            CosmosDBSqlApiSampleV2Transformer
                <HandHarvestYieldV1, VegetationSample> sut = 
                new CosmosDBSqlApiSampleV2Transformer
                    <HandHarvestYieldV1, VegetationSample>(
                        new MapFromHandHarvestYieldV1ToVegetationSample(),
                        "http://files.cafltar.org/data/schema/documentDb/v2/sample.json",
                        "",
                        "CookEastCropHandHarvest",
                        "CookEast",
                        "VegetationSample");

            TidyData tidyData =
                ManualArranger.GetTidyDataWithNullsV1();

            int expectedCount = 4;

            // Act
            List<VegetationSample> actual = sut.Transform(tidyData);

            // Assert
            Assert.Equal(expectedCount, actual.Count);
        }
    }
}