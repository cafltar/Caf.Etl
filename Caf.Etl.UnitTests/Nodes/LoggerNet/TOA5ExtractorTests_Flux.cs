using Xunit;
using Caf.Etl.Nodes.LoggerNet.Extract;
using System.Collections.Generic;
using Caf.Etl.Models.LoggerNet.TOA5;
using System;
using Caf.Etl.Models.LoggerNet.TOA5.DataTables;
using System.Linq;
using Caf.Etl.TestUtils;

namespace Caf.Etl.UnitTests.Nodes.LoggerNet
{
    public class TOA5ExtractorTests_Flux
    {
        private readonly string pathToFileWithValidContentV1;
        private readonly string pathToFileWithTestLoggerOutputV2;

        public TOA5ExtractorTests_Flux()
        {
            pathToFileWithValidContentV1 = 
                @"Nodes/LoggerNet/Assets/CookEastEcTower_Flux_Raw_2018_01_08_1330.dat";
            pathToFileWithTestLoggerOutputV2 =
                @"Nodes/LoggerNet/Assets/TOA5_11205.Flux_0_2018_06_15_1400.dat";
        }

        [Fact]
        public void GetObservations_ValidContentV1_ReturnsCorrectObservations()
        {
            //# Arrange
            List<IObservation> expectedObservations = 
                LoggerNetArranger.GetFluxObservationsDerivedFromActualDataV1();
            List<IObservation> actualObservations = new List<IObservation>();
            TOA5Extractor sut = new TOA5Extractor(pathToFileWithValidContentV1);

            //# Act
            actualObservations = sut.GetObservations<Flux>()
                .Cast<IObservation>()
                .ToList();

            //# Assert
            Assert.Equal(expectedObservations[0], actualObservations[0]);
        }

        [Fact]
        public void GetObservations_TestContentV2_ReturnsCorrectObservations()
        {
            //# Arrange
            List<IObservation> expectedObservations = 
                LoggerNetArranger.GetFluxObservationsDerivedFromTestDataV2();
            List<IObservation> actualObservations = new List<IObservation>();
            TOA5Extractor sut = new TOA5Extractor(pathToFileWithTestLoggerOutputV2);

            //# Act
            actualObservations = sut.GetObservations<Flux>()
                .Cast<IObservation>()
                .ToList();

            //# Assert
            Assert.Equal(expectedObservations[0], actualObservations[0]);
        }

        [Fact]
        public void GetTOA5_ValidContentV1_ReturnsCorrectTOA5()
        {
            TOA5Extractor sut = new TOA5Extractor(pathToFileWithValidContentV1);
            List<IObservation> expectedObservations = 
                LoggerNetArranger.GetFluxObservationsDerivedFromActualDataV1();

            TOA5 fluxTable = sut.GetTOA5<Flux>();

            Assert.Equal(expectedObservations, fluxTable.Observations);
            //TODO: Test actual metadata
        }

        [Fact]
        public void GetTOA5_TestContentV2_ReturnsCorrectTOA5()
        {
            // Arrange
            TOA5 expected =
                LoggerNetArranger.GetToa5FluxDerivedFromTestDataV2();
            TOA5Extractor sut = new TOA5Extractor(
                pathToFileWithTestLoggerOutputV2);

            // Act
            TOA5 actual = sut.GetTOA5<Flux>();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}