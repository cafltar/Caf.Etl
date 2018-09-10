using Caf.Etl.Models.Manual.Tidy;
using Caf.Etl.Models.Manual.Tidy.DataTables;
using Caf.Etl.Nodes.Manual.Extract;
using Caf.Etl.TestUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Caf.Etl.UnitTests.Nodes.Manual
{
    public class TidyExtractorTest
    {
        string pathToFileWithValidDataSlimV1 =
                @"Nodes/Manual/Assets/L1_Aggregated2013-2016_20180625_slim.csv";
        string pathToFileWithValidDictionaryV1 =
                @"Nodes/Manual/Assets/L1_Aggregated2013-2016_DataDictionary_20180625.csv";

        [Fact]
        public void TidyExtractor_InvalidFilePaths_ThrowsArgumentException()
        {
            // Arrange
            TidyCsvExtractor sut;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => sut  = new TidyCsvExtractor(
                @"Nodes/Manual/Assets/foo.csv",
                pathToFileWithValidDictionaryV1));
        }

        [Fact]
        public void ExtractMetadata_ValidData_ReturnsExpected()
        {
            // Arrange
            TidyCsvExtractor sut = new TidyCsvExtractor(
                pathToFileWithValidDataSlimV1,
                pathToFileWithValidDictionaryV1);
            Metadata expected = 
                ManualArranger.GetMetadataDerivedFromActualDataV1();

            // Act
            Metadata actual = sut.ExtractMetadata();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ExtractObservations_ValidData_ReturnsExpected()
        {
            // Arrange
            TidyCsvExtractor sut = new TidyCsvExtractor(
                pathToFileWithValidDataSlimV1,
                pathToFileWithValidDictionaryV1);
            List<IObservation> expected =
                ManualArranger.GetObservationsDerivedFromActualDataV1();

            // Act
            List<HandHarvestYieldV1> actual = 
                sut.ExtractObservations<HandHarvestYieldV1>();

            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void Extract_ValidData_ReturnsExpected()
        {
            // Arrange
            TidyCsvExtractor sut = new TidyCsvExtractor(
                pathToFileWithValidDataSlimV1,
                pathToFileWithValidDictionaryV1);
            DataSet expected = new DataSet()
            {
                Metadata = ManualArranger.GetMetadataDerivedFromActualDataV1(),
                Observations = ManualArranger.GetObservationsDerivedFromActualDataV1()
            };

            // Act
            DataSet actual = sut.Extract<HandHarvestYieldV1>();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}