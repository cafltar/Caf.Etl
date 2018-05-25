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
    public class TOA5ExtractorTests_Flux
    {
        private readonly string pathToFileWithValidContent;

        public TOA5ExtractorTests_Flux()
        {
            pathToFileWithValidContent = 
                @"Nodes/LoggerNet/Assets/CookEastEcTower_Flux_Raw_2018_01_08_1330.dat";
        }

        [Fact]
        public void GetObservations_ValidContent_ReturnsCorrectObservations()
        {
            //# Arrange
            List<IObservation> expectedObservations = 
                LoggerNetArranger.GetObservationsDerivedFromActualData();
            List<IObservation> actualObservations = new List<IObservation>();
            TOA5Extractor sut = new TOA5Extractor(pathToFileWithValidContent);

            //# Act
            actualObservations = sut.GetObservations<Flux>()
                .Cast<IObservation>()
                .ToList();

            //# Assert
            Assert.Equal(expectedObservations[0], actualObservations[0]);
        }

        [Fact]
        public void GetTOA5_ValidContent_ReturnsCorrectTOA5()
        {
            TOA5Extractor sut = new TOA5Extractor(pathToFileWithValidContent);
            List<IObservation> expectedObservations = 
                LoggerNetArranger.GetObservationsDerivedFromActualData();

            TOA5 fluxTable = sut.GetTOA5<Flux>();

            Assert.Equal(expectedObservations, fluxTable.Observations);
            //TODO: Test actual metadata
        }
    }
}