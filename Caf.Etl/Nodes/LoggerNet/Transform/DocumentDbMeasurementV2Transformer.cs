using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Caf.Etl.Models.LoggerNet.TOA5;
using Caf.Etl.Models.CosmosDBSqlApi.Measurement;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Reflection;
using Caf.Etl.Nodes.LoggerNet.Core;

namespace Caf.Etl.Nodes.LoggerNet.Transform
{
    public class DocumentDbMeasurementV2Transformer
    {
        private readonly IMapper map;

        public string Schema { get; }
        public string EtlEventId { get; }
        public string DocumentType { get; }
        public string Project { get; }
        public int? Timestep { get; }
        

        public DocumentDbMeasurementV2Transformer(
            IMapper map,
            string schema,
            string etlEventId,
            string documentType = "Measurement",
            string project = "CafMeteorologyEcTower",
            int? timestep = null)
        {
            this.map = map;
            Schema = schema;
            EtlEventId = etlEventId;
            DocumentType = documentType;
            Project = project;
            Timestep = timestep;
        }

        public List<MeasurementV2> ToMeasurements(TOA5 toa5)
        {
            List<MeasurementV2> measurements = new List<MeasurementV2>();

            foreach(IObservation obs in toa5.Observations)
            {
                foreach (Variable variable in toa5.Metadata.Variables)
                {
                    // Skip TIMESTAMP and RECORD
                    if (variable.FieldName == "TIMESTAMP" ||
                        variable.FieldName == "RECORD")
                        continue;

                    MeasurementV2 measurement = 
                        CreateMeasurementFromVariable(
                            variable, obs, toa5.Metadata);

                    if(measurement != null)
                        measurements.Add(measurement);
                }
            }

            return measurements;
        }

        private MeasurementV2 CreateMeasurementFromVariable(
            Variable variable, 
            IObservation observation, 
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

            string name = map.GetMeasurementName(variable.FieldName);
            // Check if variable is in list to be mapped
            if (String.IsNullOrEmpty(name))
            {
                return null;
            }

            DateTime measurementDateTime = 
                new DateTime(observation.TIMESTAMP.Ticks, DateTimeKind.Utc);

            List<PhysicalQuantityV2> physicalQuantities = 
                new List<PhysicalQuantityV2>()
                {
                    new PhysicalQuantityV2(
                        (double?)value, 
                        variable.Units, 
                        DateTime.UtcNow, 
                        EtlEventId)
                };

            LocationV2 location = new LocationV2("Point",
                map.GetLatFromStation(metadata),
                map.GetLonFromStation(metadata));

            string areaOfInterest = map.GetFieldID(metadata);

            string partitionKey = 
                "EcTower_" 
                + areaOfInterest 
                + "_"
                + name;

            string id = 
                areaOfInterest 
                + "_" 
                + name 
                + (Timestep != null ? ("_Ts" + Timestep.ToString()) : "")
                + "_"
                + measurementDateTime.ToString("o");

            return new MeasurementV2(
                partitionKey,
                id,
                DocumentType,
                name,
                Schema,
                Project,
                "", "", "", "", null,
                areaOfInterest,
                location,
                measurementDateTime,
                physicalQuantities,
                Timestep);
        }
    }
}
