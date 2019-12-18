using Caf.Etl.Models.CosmosDBSqlApi.Measurement;
using Caf.Etl.Models.Manual.TidyData;
using Caf.Etl.Nodes.CosmosDBSqlApi.Transform;
using Caf.Etl.TestUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Caf.Etl.UnitTests.Nodes.CosmosDBSqlApi
{
    public class ManualTidyDataTransformerTests
    {
        [Fact]
        public void Transform_ValidData_ExpectedResults()
        {
            // Arrange
            List<MeasurementV2> measurements = LoggerNetArranger.GetMeasurementV2TwoVariablesMultipleTimesteps();
            var sut = new ManualTidyDataTransformer();

            // Act
            TidyData actual = sut.Transform<DataTableTwoVar>(measurements);

            // Assert
            List<DataTableTwoVar> actualObs = actual.Observations.Cast<DataTableTwoVar>().ToList();
            Assert.Equal(3, actual.Observations.Count);
            Assert.Equal(3, actual.Metadata.Variables.Count);
            Assert.NotNull(actualObs.Where(m => m.ParDensityTsAvg == 1806.077).FirstOrDefault());
        }

        [Fact]
        public void Transform_GenericHasLessPropertiesThanMeasurements_ReturnsOnlyGenericProperties()
        {
            // Arrange
            List<MeasurementV2> measurements = LoggerNetArranger.GetMeasurementV2TwoVariablesMultipleTimesteps();
            var sut = new ManualTidyDataTransformer();

            // Act
            TidyData actual = sut.Transform<DataTableOneVar>(measurements);

            // Assert
            Assert.Equal(3, actual.Observations.Count);
            Assert.Equal(2, actual.Metadata.Variables.Count);
        }
    }

    public class DataTableTwoVar : IObservation
    {
        public DateTimeOffset DateTimeUtc { get; set; }
        public double ParDensityTsAvg { get; set; }
        public double TemperatureAirTsAvg { get; set; }
    }

    public class DataTableOneVar : IObservation
    {
        public DateTimeOffset DateTimeUtc { get; set; }
        public double ParDensityTsAvg { get; set; }
    }
}
