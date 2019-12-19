using Caf.Etl.Models.Manual.TidyData;
using CsvHelper;
using CsvHelper.TypeConversion;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Text;

namespace Caf.Etl.Nodes.Manual.Load
{
    public class TidyDataCsvLoader
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data">Data to be written to CSV file</param>
        /// <param name="dirPath">Directory to write file to. Will be created if doesn't exist.</param>
        /// <param name="fileName">Name of the file, without extension. The current date, local to the machine, in ISO 8601 format, will be added.</param>
        /// <returns>A string containing the name of the data file</returns>
        public string LoadToFile(TidyData data, string dirPath, string fileName)
        {
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);

            DateTime dt = DateTime.Now;

            string dataFileName = 
                $"{fileName}_{dt.ToString("yyyyMMdd")}.csv";
            string dictFileName = 
                $"{fileName}_{dt.ToString("yyyyMMdd")}_Dictionary.csv";

            using (var writer = new StreamWriter(
                Path.Combine(dirPath, dataFileName), 
                false, 
                Encoding.UTF8))
            using (var csv = new CsvWriter(writer))
            {
                // Format datetime strings
                csv.Configuration.CultureInfo = CultureInfo.InvariantCulture;

                csv.Configuration.TypeConverterOptionsCache.GetOptions<DateTimeOffset>().Formats = new[] { "yyyy-MM-ddTHH:mm:ssK" };
                csv.Configuration.TypeConverterOptionsCache.GetOptions<DateTime>().Formats = new[] { "yyyy-MM-ddTHH:mm:ssK" };

                // Need to convert list of interface to list of obj: https://stackoverflow.com/a/54795960/1621156
                List<object> objects = new List<object>();
                foreach(var observation in data.Observations)
                {
                    objects.Add((object)observation);
                }
                csv.WriteRecords(objects);
            }

            using (var writer = new StreamWriter(
                Path.Combine(dirPath, dictFileName),
                false,
                Encoding.UTF8))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(data.Metadata.Variables);
            }

            return dataFileName;
        }
    }
}
