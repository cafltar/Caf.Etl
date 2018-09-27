using Caf.Etl.Models.CosmosDBSqlApi.Core;
using Caf.Etl.Models.CosmosDBSqlApi.Measurement;
using Caf.Etl.Models.CosmosDBSqlApi.Sample;
using Caf.Etl.Models.Manual.TidyData;
using Caf.Etl.Models.Manual.TidyData.DataTables;
using Caf.Etl.Nodes.Manual.Core;
using Caf.Etl.Nodes.Manual.Mappers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Nodes.Manual.Transform
{
    // TODO: U = SampleV2, so I can make this generic (VegetationSample, SoilSample)
    public class CosmosDBSqlApiSampleV2Transformer<T, U> 
        where T : IObservation
        where U : SampleV2
    {
        private IMap<T, U> Map { get; }
        private string Schema { get; }
        private string EtlEventId { get; }
        private string Project { get; }
        private string AreaOfInterest { get; }
        private string DocumentType { get; }

        public CosmosDBSqlApiSampleV2Transformer(
            IMap<T, U> map,
            string schema,
            string etlEventId,
            string project,
            string areaOfInterest = "",
            string documentType = "Sample")
        {
            Map = map;
            Schema = schema;
            EtlEventId = etlEventId;
            Project = project;
            AreaOfInterest = areaOfInterest;
            DocumentType = documentType;
        }

        public List<U> Transform(TidyData tidyData)
        {
            List<U> samples = new List<U>();

            foreach(T observation in tidyData.Observations)
            {
                // Maps class specific data, returns null if not able to map
                U sample = Map.GetSample(observation);

                if (sample == null)
                    continue;

                sample.Type = DocumentType;
                sample.Project = Project;
                sample.AreaOfInterest = AreaOfInterest;
                sample.PartitionKey =
                    $"{sample.Type}_{sample.AreaOfInterest}_{sample.Name}";
                sample.Schema = Schema;
                sample.Measurements = new List<MeasurementV2>();

                foreach(Variable variable in tidyData.Metadata.Variables)
                {
                    // Create MeasurementV2s
                    // Use a mapper that defines the variables to keep
                    // if(variable in mappers.VariablesToKeep)
                    MeasurementV2 measurement =
                        CreateMeasurementFromVariable(
                            variable,
                            observation,
                            tidyData.Metadata);

                    if(measurement != null)
                        sample.Measurements.Add(measurement);
                }

                samples.Add(sample);
            }

            return samples;
        }

        // TODO: Much of this is copy/pasted from DocumentDbMeasurementV2Transformer, consider move logic to a shared class
        // WARNING: This assumes one physicalQuantity per Measurement -- it returns null Measurement on first PhysicalQuantity with value of null
        private MeasurementV2 CreateMeasurementFromVariable(
            Variable variable, 
            T observation, 
            Metadata metadata)
        {
            // Look up property based on string, get value
            var value = observation
                .GetType()
                .GetProperty(
                    variable.FieldName
                        .Replace("(", "")
                        .Replace(")", ""))
                .GetValue(observation, null);
            // Ensure value is a number, don't create Measurement on null value (assumes Measurement only has one PhysicalQuantity)
            if(!(value is double? 
                || value is decimal? 
                || value is int?))
            {
                return null;
            }
        
            string measurementName = Map.GetMeasurementName(variable.FieldName);
            // Check if variable is in list to be mapped
            if (String.IsNullOrEmpty(measurementName))
            {
                return null;
            }
        
            DateTime? measurementDateTime = 
                Map.GetDateTimeMeasurement(observation);
        
            List<PhysicalQuantityV2> physicalQuantities = 
                new List<PhysicalQuantityV2>()
                {
                    new PhysicalQuantityV2(
                        (double?)value, 
                        variable.Units, 
                        DateTime.UtcNow, 
                        EtlEventId)
                };
        
            MeasurementV2 m = new MeasurementV2(
                "Measurement",
                measurementName,
                measurementDateTime,
                physicalQuantities);
        
            return m;
        }
    }
}
