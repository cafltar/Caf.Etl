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
    public class CosmosDBSqlApiSampleV2Transformer<T> 
        where T : IObservation
    {
        private IMap<T> Map { get; }
        private string Schema { get; }
        private string EtlEventId { get; }
        private string Project { get; }
        private string AreaOfInterest { get; }
        private string DocumentType { get; }

        public CosmosDBSqlApiSampleV2Transformer(
            IMap<T> map,
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

        public List<SampleV2> Transform(TidyData tidyData)
        {
            List<SampleV2> samples = new List<SampleV2>();

            foreach(T observation in tidyData.Observations)
            {
                // TODO: Change SampleV2 to VegetationSample (or make this function more generic)
                // TODO: add sample.Crop and sample.HarvestYear
                SampleV2 sample = new SampleV2();
                sample.Id = Map.GetSampleId(observation);
                sample.Type = DocumentType;
                sample.Name = Map.GetSampleName(observation);
                sample.Project = Project;
                sample.AreaOfInterest = AreaOfInterest;
                sample.Location = Map.GetLocation(observation);
                sample.DateTime = Map.GetDateTimeSample(observation);
                sample.PartitionKey =
                    $"{sample.Type}_{sample.AreaOfInterest}_{sample.Name}";
                
                //if(observation.GetType() == typeof(HandHarvestYieldV1))
                //{
                //    sample.PlantName = 
                //        (MapFromHandHarvestYieldV1ToVegetationSample)Map.GetPlantName(observation);
                //}
                
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
                }

                samples.Add(sample);
            }

            return samples;
        }

        // TODO: Much of this is copy/pasted from DocumentDbMeasurementV2Transformer, consider move logic to a shared class
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
            // Ensure value is a number
            if(!(value is double? 
                || value is decimal? 
                || value is int?
                || value is null))
            {
                return null;
            }

            string measurementName = Map.GetMeasurementName(variable.FieldName);
            // Check if variable is in list to be mapped
            if (String.IsNullOrEmpty(measurementName))
            {
                return null;
            }

            DateTime measurementDateTime = 
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
                null,
                null,
                null,
                null,
                measurementDateTime,
                physicalQuantities,
                null);

            return m;
        }
    }
}
