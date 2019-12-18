using Caf.Etl.Nodes.Manual.Load;
using Caf.Etl.TestUtils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
