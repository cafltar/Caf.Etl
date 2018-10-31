using Caf.Etl.Nodes.LoggerNet.Transform;
using Caf.Etl.Nodes.LoggerNet.Mappers;
using System.Collections.Generic;
using Xunit;
using Caf.Etl.Models.CosmosDBSqlApi.Core;
using Caf.Etl.Models.LoggerNet.TOA5;
using System;
using Caf.Etl.Models.LoggerNet.TOA5.DataTables;
using Caf.Etl.TestUtils;
using System.Linq;
using Caf.Etl.Models.CosmosDBSqlApi.Measurement;

namespace Caf.Etl.UnitTests.Nodes.LoggerNet
{
    public class CosmosDBSqlApiV2TransformerTests_Flux
    {
        [Fact]
        public void ToMeasurement_ValidDataMetV2_ReturnCorrectMeasurementsV2()
        {
            //# Arrange
            MapFromToa5DataTableToCafStandards map = 
                new MapFromToa5DataTableToCafStandards();
            TOA5 toa5 = LoggerNetArranger.GetToa5MeteorologyDerivedFromActualDataV2();

            List<MeasurementV2> expected = 
                LoggerNetArranger.GetMeasurementsV2DerivedFromActualDataMeteorologyV2();

            CosmosDBSqlApiV2Transformer sut =
                new CosmosDBSqlApiV2Transformer(
                    map,
                    "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json",
                    "CosmosDBSqlApiTransformer",
                    "Measurement",
                    "CafMeteorologyEcTower",
                    900);

            //# Act
            var actual = sut.ToMeasurements(toa5);

            //# Assert
            Assert.Equal(expected.Count, actual.Count);
            Assert.True(ComparerUtil.AreMeasurementsRoughlyEqual(expected, actual));
        }
    }
}
