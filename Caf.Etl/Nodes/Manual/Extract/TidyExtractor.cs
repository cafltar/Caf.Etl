using Caf.Etl.Models.Manual.TidyData;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Caf.Etl.Nodes.Manual.Extract
{
    // TODO: Create a sister class for streaming data?
    public class TidyCsvExtractor
    {
        public string DataFilePath { get; private set; }
        public string DictionaryFilePath { get; private set; }

        public TidyCsvExtractor(
            string dataFilePath,
            string dataDictionaryPath)
        {
            if(isFileValid(dataFilePath))
                DataFilePath = dataFilePath;
            else
                throw new ArgumentException("Data file not found");

            if (isFileValid(dataDictionaryPath))
                DictionaryFilePath = dataDictionaryPath;
            else
                throw new ArgumentException("Dictionary file not found");
        }

        public TidyData Extract<T>() where T : IObservation
        {
            TidyData dataSet = new TidyData();
            dataSet.Metadata = ExtractMetadata();
            dataSet.Observations = ExtractObservations<T>()
                .Cast<IObservation>().ToList();

            return dataSet;
        }

        public Metadata ExtractMetadata()
        {
            Metadata m = new Metadata();

            // TODO: Convert this to streamreader
            using (var sr = new StringReader(
                File.ReadAllText(DictionaryFilePath)))
            {
                CsvReader csv = new CsvReader(sr);
                csv.Configuration.HasHeaderRecord = true;

                m.Variables = csv.GetRecords<Variable>().ToList<Variable>();
            }

            return m;
        }

        public List<T> ExtractObservations<T>() where T : IObservation
        {
            List<T> obs = new List<T>();

            using (var sr = new StringReader(
                File.ReadAllText(DataFilePath)))
            {
                CsvReader csv = new CsvReader(sr);
                csv.Configuration.TypeConverterOptionsCache.GetOptions<string>().NullValues.Add("");
                
                obs = csv.GetRecords<T>().ToList<T>();
            }

            return obs;
        }

        private bool isFileValid(string filePath)
        {
            if (!File.Exists(filePath))
                return false;
            if (Path.GetExtension(filePath) != ".csv")
                return false;

            return true;
        }
    }
}
