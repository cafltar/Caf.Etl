using Xunit;
using Caf.Etl.Nodes.LoggerNet.Extract;
using System.Collections.Generic;
using Caf.Etl.Models.LoggerNet.TOA5;
using System;
using Caf.Etl.Models.LoggerNet.TOA5.DataTables;
using System.Linq;
using Caf.Etl.TestUtils;

namespace Caf.Etl.Nodes.LoggerNet.Tests
{
    public class TOA5ExtractorTests_Meteorology
    {
        private readonly string pathToFileWithValidContentV2;
        private readonly string pathToFileToTestTimeZoneV2;
        private readonly string pathToFileWithTestLoggerOutputV2;
        private readonly string pathToFileWithActualLoggerOutputV2;

        public TOA5ExtractorTests_Meteorology()
        {
            pathToFileWithValidContentV2 = 
                @"Nodes/LoggerNet/Assets/CookEastEcTower_Met_Raw_2017_06_20_1115.dat";
            pathToFileToTestTimeZoneV2 = 
                @"Nodes/LoggerNet/Assets/CookEastEcTower_Met_Raw_TestTimeZone.dat";
            pathToFileWithTestLoggerOutputV2 =
                @"Nodes/LoggerNet/Assets/TOA5_11205.LTAR_Met_0_2018_06_15_1345.dat";
            pathToFileWithActualLoggerOutputV2 =
                @"Nodes/LoggerNet/Assets/CookEastEcTower_Met_Raw_2018_06_27_1315.dat";
        }

        [Fact]
        public void FilePathConstructor_ValidContentV1_SetsData()
        {
            //# Arrange 
            string expectedFileName = 
                "CookEastEcTower_Met_Raw_2017_06_20_1115.dat";
            int expectedContentLength = 710;

            //# Act
            TOA5Extractor sut = new TOA5Extractor(pathToFileWithValidContentV2);

            //# Assert
            Assert.Equal(expectedFileName, sut.FileName);
            Assert.Equal(expectedContentLength, sut.FileContent.Length);
        }

        [Fact]
        public void GetObservations_ValidContentV1_ReturnsCorrectObservations()
        {
            //# Arrange
            List<IObservation> actualObservations = new List<IObservation>();

            Meteorology expectedRecord = new Meteorology()
            {
                TIMESTAMP = new System.DateTime(2017, 6, 20, 11, 30, 00),
                RECORD = 15,
                amb_tmpr_Avg = 23.13316,
                rslt_wnd_spd = 4.940109,
                wnd_dir_compass = 259.7,
                RH_Avg = 56.22676,
                Precipitation_Tot = 0,
                amb_press_Avg = 93.25672,
                PAR_density_Avg = 1956.598,
                batt_volt_Avg = 13.63667,
                panel_tmpr_Avg = 25.22728,
                std_wnd_dir = 14.26,
                VPD_air = 1.244421,
                Rn_meas_Avg = 643.2509
            };

            //# Act
            TOA5Extractor sut = new TOA5Extractor(pathToFileWithValidContentV2);
            actualObservations = sut.GetObservations<Meteorology>().Cast<IObservation>().ToList();

            //# Assert
            // TODO: Override obj.Equals for better test

            Assert.Equal(expectedRecord.amb_tmpr_Avg, actualObservations[1]
                .GetType()
                .GetProperty("amb_tmpr_Avg")
                .GetValue(actualObservations[1], null));
            Assert.Equal(expectedRecord.RECORD, actualObservations[1].RECORD);
            Assert.Equal(expectedRecord.Rn_meas_Avg, actualObservations[1]
                .GetType()
                .GetProperty("Rn_meas_Avg")
                .GetValue(actualObservations[1], null));
        }
        
        [Fact]
        public void GetMetadata_ValidContentV1_ReturnsCorrectMetadata()
        {
            //# Arrange
            Metadata actualMetadata = new Metadata();
            Metadata expectedMetadata = new Metadata()
            {
                FileFormat = "TOA5",
                StationName = "LTAR_CookEast",
                DataLoggerType = "CR3000",
                SerialNumber = 6503,
                OperatingSystemVersion = "CR3000.Std.31",
                DataloggerProgramName = "CPU:DEFAULT.CR3",
                DataloggerProgramSignature = 13636,
                TableName = "LTAR_Met",

                Variables = new List<Variable>()
                {
                    new Variable()
                    {
                        FieldName = "TIMESTAMP",
                        Units = "TS",
                        Processing = ""
                    },
                    new Variable()
                    {
                        FieldName = "RECORD",
                        Units = "",
                        Processing = ""
                    },
                    new Variable()
                    {
                        FieldName = "amb_tmpr_Avg",
                        Units = "C",
                        Processing = "Avg"
                    },
                    new Variable()
                    {
                        FieldName = "rslt_wnd_spd",
                        Units = "m/s",
                        Processing = "Smp"
                    },
                    new Variable()
                    {
                        FieldName = "wnd_dir_compass",
                        Units = "degrees",
                        Processing = "Smp"
                    },
                    new Variable()
                    {
                        FieldName = "RH_Avg",
                        Units = "%",
                        Processing = "Avg"
                    },
                    new Variable()
                    {
                        FieldName = "Precipitation_Tot",
                        Units = "mm",
                        Processing = "Tot"
                    },
                    new Variable()
                    {
                        FieldName = "amb_press_Avg",
                        Units = "kPa",
                        Processing = "Avg"
                    },
                    new Variable()
                    {
                        FieldName = "PAR_density_Avg",
                        Units = "umol/(s m^2)",
                        Processing = "Avg"
                    },
                    new Variable()
                    {
                        FieldName = "batt_volt_Avg",
                        Units = "V",
                        Processing = "Avg"
                    },
                    new Variable()
                    {
                        FieldName = "panel_tmpr_Avg",
                        Units = "C",
                        Processing = "Avg"
                    },
                    new Variable()
                    {
                        FieldName = "std_wnd_dir",
                        Units = "degrees",
                        Processing = "Smp"
                    },
                    new Variable()
                    {
                        FieldName = "VPD_air",
                        Units = "kpa",
                        Processing = "Smp"
                    },
                    new Variable()
                    {
                        FieldName = "Rn_meas_Avg",
                        Units = "W/m^2",
                        Processing = "Avg"
                    }
                }
            };

            //# Act
            TOA5Extractor sut = new TOA5Extractor(pathToFileWithValidContentV2);
            actualMetadata = sut.GetMetadata();

            //# Assert
            // TODO: Override obj.Equals for better testing
            Assert.Equal(expectedMetadata.FileFormat, actualMetadata.FileFormat);
            Assert.Equal(expectedMetadata.TableName, actualMetadata.TableName);
            Assert.Equal(expectedMetadata.SerialNumber, actualMetadata.SerialNumber);

            Assert.Equal(
                expectedMetadata.Variables.Find(mv => mv.FieldName == "TIMESTAMP").Processing,
                actualMetadata.Variables.Find(mv => mv.FieldName == "TIMESTAMP").Processing);
            Assert.Equal(
                expectedMetadata.Variables.Find(mv => mv.FieldName == "amb_tmpr_Avg").Units,
                actualMetadata.Variables.Find(mv => mv.FieldName == "amb_tmpr_Avg").Units);
            Assert.Equal(
                expectedMetadata.Variables.Find(mv => mv.FieldName == "Rn_meas_Avg").Units,
                actualMetadata.Variables.Find(mv => mv.FieldName == "Rn_meas_Avg").Units);
        }

        [Fact]
        public void GetTOA5_TestContentV2_ReturnsCorrectTOA5()
        {
            // Arrange
            TOA5 expected =
                LoggerNetArranger.GetToa5MeteorologyDerivedFromTestDataV2();
            TOA5Extractor sut = new TOA5Extractor(
                pathToFileWithTestLoggerOutputV2);

            // Act
            TOA5 actual = sut.GetTOA5<Meteorology>();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetTOA5_ActualContentV2_ReturnsCorrectTOA5()
        {
            // Arrange
            TOA5 expected =
                LoggerNetArranger.GetToa5MeteorologyDerivedFromActualDataV2();
            TOA5Extractor sut = new TOA5Extractor(
                pathToFileWithActualLoggerOutputV2);

            // Act
            TOA5 actual = sut.GetTOA5<Meteorology>();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetObservations_AdjustedTimezoneV1_ReturnsCorrectTimes()
        {
            //# Arrange
            List<IObservation> actualObservations = new List<IObservation>();

            //# Act
            TOA5Extractor sut = new TOA5Extractor(pathToFileToTestTimeZoneV2, -8);
            actualObservations = sut.GetObservations<Meteorology>().Cast<IObservation>().ToList();

            //# Assert
            Assert.Equal(actualObservations[0].TIMESTAMP, new DateTime(2017, 06, 20, 8, 30, 0));
            Assert.Equal(actualObservations[1].TIMESTAMP, new DateTime(2017, 06, 20, 19, 30, 0));
            Assert.Equal(actualObservations[2].TIMESTAMP, new DateTime(2017, 06, 21, 7, 15, 0));
        }

        [Fact]
        public void GetObservations_ContentWithNanV1_DoesNotErrorSetsNull()
        {
            // Arrange
            string dataPath = @"Nodes/LoggerNet/Assets/CookEastEcTower_Met_Raw_2017_10_24_0615.dat";
            TOA5Extractor sut = new TOA5Extractor(dataPath);

            // Act
            List<IObservation> actualObs = sut.GetObservations<Meteorology>()
                .Cast<IObservation>()
                .ToList();

            // Assert
            //            //observation.GetType().GetProperty(variable.FieldName).GetValue(observation, null)
            Assert.Null(actualObs[0]
                .GetType()
                .GetProperty("VPD_air")
                .GetValue(actualObs[0], null));
            Assert.Null(actualObs[0]
                .GetType()
                .GetProperty("RH_Avg")
                .GetValue(actualObs[0], null));
        }
    }
}