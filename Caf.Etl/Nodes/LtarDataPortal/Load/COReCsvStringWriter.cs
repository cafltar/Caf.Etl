using System;
using System.Collections.Generic;
using System.Linq;
using CsvHelper;
using Caf.Etl.Models.LtarDataPortal.CORe;
using System.IO;
using CsvHelper.TypeConversion;

namespace Caf.Etl.Nodes.LtarDataPortal.Load
{
    public class COReCsvStringWriter
    {
        /// <summary>
        /// Converts a list of observations to a string in csv format
        /// </summary>
        /// <param name="observations"></param>
        /// <returns></returns>
        public string GetContentString(List<Observation> observations)
        {
            List<Observation> sortedObservations = observations.OrderBy(o => o.DateTime).ToList();

            string fileContent;

            using (var stream = new MemoryStream())
            using (var reader = new StreamReader(stream))
            using (var writer = new StreamWriter(stream))
            using (var csvWriter = new CsvWriter(writer))
            {
                var formatDateTimeOffset = new TypeConverterOptions
                {
                    Formats = new string[] { "yyyy-MM-ddTHH:mmzzz" }
                };

                csvWriter.Context.WriterConfiguration
                    .TypeConverterOptionsCache
                    .AddOptions<DateTimeOffset>(formatDateTimeOffset);

                csvWriter.WriteRecords(sortedObservations);
                writer.Flush();
                stream.Position = 0;
                fileContent = reader.ReadToEnd();
            }

            return fileContent;
        }

        /// <summary>
        /// Returns a filename formatted as specified in CORe Concepts of Operation document
        /// Uses UTC timezone for the month and year
        /// </summary>
        /// <param name="observation"></param>
        /// <returns></returns>
        public string GetFilenameUtcDateTime(Observation observation)
        {
            DateTime dt = DateTime.UtcNow;

            string siteAcronym = observation.LTARSiteAcronym.ToLower();
            string measurementFlag = "MET";
            string stationID = observation.StationID;
            char recordType = observation.RecordType;
            string formatVersion = "01";
            string year = dt.ToString("yyyy");
            string month = dt.ToString("MM");
            string day = "00";
            string fileCount = "00";
            string fileExtension = "csv";

            string result = $"{siteAcronym}{measurementFlag}{stationID}{recordType}_{formatVersion}_{year}{month}{day}_{fileCount}.{fileExtension}";

            return result;
        }

        /// <summary>
        /// Returns a filename formatted as specified in CORe Concepts of Operation document
        /// Uses PST timezone (ignoring daylight savings time) for the month and year
        /// </summary>
        /// <param name="observation"></param>
        /// <returns></returns>
        public string GetFilenamePstDateTime(Observation observation)
        {
            DateTime dt = DateTime.UtcNow.AddHours(-8);

            string siteAcronym = observation.LTARSiteAcronym.ToLower();
            string measurementFlag = "MET";
            string stationID = observation.StationID;
            char recordType = observation.RecordType;
            string formatVersion = "01";
            string year = dt.ToString("yyyy");
            string month = dt.ToString("MM");
            string day = "00";
            string fileCount = "00";
            string fileExtension = "csv";

            string result = $"{siteAcronym}{measurementFlag}{stationID}{recordType}_{formatVersion}_{year}{month}{day}_{fileCount}.{fileExtension}";

            return result;
        }
    }
}
