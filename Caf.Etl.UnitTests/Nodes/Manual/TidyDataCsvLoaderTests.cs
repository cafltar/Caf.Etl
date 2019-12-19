using Caf.Etl.Nodes.Manual.Load;
using Caf.Etl.TestUtils;
using System.IO;
using Xunit;

namespace Caf.Etl.UnitTests.Nodes.Manual
{
    public class TidyDataCsvLoaderTests
    {
        [Fact]
        public void LoadToFile_ValidData_WritesFile()
        {
            // Arrange
            var sut = new TidyDataCsvLoader();
            var tidyData = ManualArranger.GetTidyDataDerivedFromActualDataV1();
            string dirPath = @"Assets\Output";

            // Act
            sut.LoadToFile(tidyData, dirPath, "test");

            // Assert
            var files = Directory.GetFiles(dirPath, "test*");

            Assert.Equal(2, files.Length);

            // Cleanup
            if (files.Length > 0)
            {
                foreach(var file in files)
                {
                    File.Delete(file);
                }
            }
        }

        [Fact]
        public void LoadToFile_ValidData_WritesDateTimeInIsoStandardFormat()
        {
            // Arrange
            var sut = new TidyDataCsvLoader();
            var tidyData = 
                ManualArranger.GetTidyDataDerivedFromMockDateTimeObservation();
            string dirPath = @"Assets\Output";

            // Act
            string fileName = sut.LoadToFile(tidyData, dirPath, "test");

            // Assert
            string fileContents = File.ReadAllText(
                Path.Combine(dirPath, fileName));
            Assert.Contains("2019-12-01T08:15:00+00:00", fileContents);

            // Cleanup
            var files = Directory.GetFiles(dirPath, "test*");
            if (files.Length > 0)
            {
                foreach (var file in files)
                {
                    File.Delete(file);
                }
            }
        }
    }
}
