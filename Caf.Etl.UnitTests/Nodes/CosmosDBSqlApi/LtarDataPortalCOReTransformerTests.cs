using System;
using Xunit;
using Caf.Etl.Nodes.CosmosDBSqlApi.Extract;
using Caf.Etl.Models.CosmosDBSqlApi.Core;
using System.Collections.Generic;
using Caf.Etl.Nodes.CosmosDBSqlApi.Transform;
using Caf.Etl.Models.LtarDataPortal.CORe;
using System.Globalization;
using Caf.Etl.Models.CosmosDBSqlApi.Measurement;

namespace Caf.Etl.UnitTests.Nodes.CosmosDBSqlApi
{
    public class LtarDataPortalCOReTransformerTests
    {
        [Fact]
        public void ToCOReContent_ValidData_ReturnsCorrectCORe()
        {
            // Arrange
            LtarDataPortalCOReTransformer sut = new LtarDataPortalCOReTransformer();
            List<Observation> expected = getValidObservations();

            // Act
            List<Observation> actual = sut.ToCOReObservations("CAF", "001", 'L', -8, getValidMeasurements());

            // Assert
            // TODO: Add Equals functions to Measurement class
            Assert.Equal(expected[0].AirPressure, actual[0].AirPressure);
            Assert.Equal(expected[0].AirTemperature, actual[0].AirTemperature);
            Assert.Equal(expected[0].BatteryVoltage, actual[0].BatteryVoltage);
            Assert.Equal(expected[0].DateTime, actual[0].DateTime);
            Assert.Equal(expected[0].LoggerTemperature, actual[0].LoggerTemperature);
            Assert.Equal(expected[0].LongWaveIn, actual[0].LongWaveIn);
            Assert.Equal(expected[0].LTARSiteAcronym, actual[0].LTARSiteAcronym);
            Assert.Equal(expected[0].PAR, actual[0].PAR);
            Assert.Equal(expected[0].Precipitation, actual[0].Precipitation);
            Assert.Equal(expected[0].RecordType, actual[0].RecordType);
            Assert.Equal(expected[0].RelativeHumidity, actual[0].RelativeHumidity);
            Assert.Equal(expected[0].ShortWaveIn, actual[0].ShortWaveIn);
            Assert.Equal(expected[0].StationID, actual[0].StationID);
            Assert.Equal(expected[0].WindDirection, actual[0].WindDirection);
            Assert.Equal(expected[0].WindSpeed, actual[0].WindSpeed);
        }

        private List<MeasurementV1> getValidMeasurements()
        {
            List<MeasurementV1> results = new List<MeasurementV1>()
            {
                new MeasurementV1(
                    "", "", "", "WindSpeedTsResultant", "", "", "", "", "", "", null, "", null, DateTime.ParseExact("2017-09-06T00:00:00Z", "yyyy-MM-dd'T'HH:mm:ss'Z'", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal), new List<PhysicalQuantityV1>()
                    {
                        new PhysicalQuantityV1(3.014338m, "m/s", 0, 0, 0, DateTime.Parse("2017-09-06T00:04:15.9797575Z"), "CosmosDBSqlApiTransformer")
                    }),
                new MeasurementV1(
                    "", "", "", "TemperatureAirTsAvg", "", "", "", "", "", "", null, "", null, DateTime.ParseExact("2017-09-06T00:00:00Z", "yyyy-MM-dd'T'HH:mm:ss'Z'", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal), new List<PhysicalQuantityV1>()
                    {
                        new PhysicalQuantityV1(27.80702m, "C", 0, 0, 0, DateTime.Parse("2017-09-06T00:04:15.9797575Z"), "CosmosDBSqlApiTransformer")
                    }),

                new MeasurementV1(
                    "", "", "", "PrecipitationTsAccum", "", "", "", "", "", "", null, "", null, DateTime.ParseExact("2017-09-06T00:00:00Z", "yyyy-MM-dd'T'HH:mm:ss'Z'", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal), new List<PhysicalQuantityV1>()
                    {
                        new PhysicalQuantityV1(0m, "m", 0, 0, 0, DateTime.Parse("2017-09-06T00:04:15.9797575Z"), "CosmosDBSqlApiTransformer")
                    }),
                new MeasurementV1(
                    "", "", "", "WindDirection", "", "", "", "", "", "", null, "", null, DateTime.ParseExact("2017-09-06T00:00:00Z", "yyyy-MM-dd'T'HH:mm:ss'Z'", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal), new List<PhysicalQuantityV1>()
                    {
                        new PhysicalQuantityV1(125.9m, "deg", 0, 0, 0, DateTime.Parse("2017-09-06T00:04:15.9797575Z"), "CosmosDBSqlApiTransformer")
                    }),
                new MeasurementV1(
                    "", "", "", "RelativeHumidityTsAvg", "", "", "", "", "", "", null, "", null, DateTime.ParseExact("2017-09-06T00:00:00Z", "yyyy-MM-dd'T'HH:mm:ss'Z'", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal), new List<PhysicalQuantityV1>()
                    {
                        new PhysicalQuantityV1(22.4503m, "%", 0, 0, 0, DateTime.Parse("2017-09-06T00:04:15.9797575Z"), "CosmosDBSqlApiTransformer")
                    }),
                new MeasurementV1(
                    "", "", "", "BatteryVoltageTsAvg", "", "", "", "", "", "", null, "", null, DateTime.ParseExact("2017-09-06T00:00:00Z", "yyyy-MM-dd'T'HH:mm:ss'Z'", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal), new List<PhysicalQuantityV1>()
                    {
                        new PhysicalQuantityV1(13.01541m, "V", 0, 0, 0, DateTime.Parse("2017-09-06T00:04:15.9797575Z"), "CosmosDBSqlApiTransformer")
                    }),
                new MeasurementV1(
                    "", "", "", "PressureAirTsAvg", "", "", "", "", "", "", null, "", null, DateTime.ParseExact("2017-09-06T00:00:00Z", "yyyy-MM-dd'T'HH:mm:ss'Z'", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal), new List<PhysicalQuantityV1>()
                    {
                        new PhysicalQuantityV1(93334.82m, "Pa", 0, 0, 0, DateTime.Parse("2017-09-06T00:04:15.9797575Z"), "CosmosDBSqlApiTransformer")
                    }),
                new MeasurementV1(
                    "", "", "", "ParDensityTsAvg", "", "", "", "", "", "", null, "", null, DateTime.ParseExact("2017-09-06T00:00:00Z", "yyyy-MM-dd'T'HH:mm:ss'Z'", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal), new List<PhysicalQuantityV1>()
                    {
                        new PhysicalQuantityV1(0.0002833229m, "mol/(m^2 s)", 0, 0, 0, DateTime.Parse("2017-09-06T00:04:15.9797575Z"), "CosmosDBSqlApiTransformer")
                    }),
                new MeasurementV1(
                    "", "", "", "TemperaturePanelTsAvg", "", "", "", "", "", "", null, "", null, DateTime.ParseExact("2017-09-06T00:00:00Z", "yyyy-MM-dd'T'HH:mm:ss'Z'", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal), new List<PhysicalQuantityV1>()
                    {
                        new PhysicalQuantityV1(29.87764m, "C", 0, 0, 0, DateTime.Parse("2017-09-06T00:04:15.9797575Z"), "CosmosDBSqlApiTransformer")
                    })
            };

            return results;
        }

        private List<Observation> getValidObservations()
        {
            List<Observation> result = new List<Observation>()
           {
               new Observation("CAF", "001", new DateTimeOffset(2017, 09, 05, 16, 0, 0, new TimeSpan(-8, 0, 0)), -8, 'L', 27.80702m, 3.014338m, 125.9m, 22.4503m, 0, 93.33482m, 283.3229m, null, null, 13.01541m, 29.87764m)
           };

            return result;
        }
    }
}
