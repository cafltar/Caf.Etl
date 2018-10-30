using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Caf.Etl.Models.LoggerNet.TOA5;
using Caf.Etl.Models.CosmosDBSqlApi.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Reflection;
using Caf.Etl.Nodes.LoggerNet.Core;
using Caf.Etl.Models.CosmosDBSqlApi.Measurement;

namespace Caf.Etl.Nodes.LoggerNet.Transform
{
    public class CosmosDBSqlApiV1Transformer
    {
        private readonly string targetSchemaVersion;
        private readonly string documentType;
        private readonly string metadataId;

        private readonly IMapper map;
        
        public string TargetSchemaVersion { get { return targetSchemaVersion; } }
        public string DocumentType { get { return documentType; } }
        public string MetadataId { get { return metadataId; } }

        public CosmosDBSqlApiV1Transformer(IMapper map,
            string targetSchemaVersion,
            string documentType = "Measurement",
            string metadataId = "CafMeteorologyEcTower")
        {
            this.targetSchemaVersion = targetSchemaVersion;
            this.documentType = documentType;
            this.metadataId = metadataId;
            this.map = map;
        }

        public List<MeasurementV1> ToMeasurements(TOA5 meteorology)
        {
            List<MeasurementV1> measurements = new List<MeasurementV1>();

            foreach(IObservation obs in meteorology.Observations)
            {
                foreach (Variable variable in meteorology.Metadata.Variables)
                {
                    // Skip TIMESTAMP and RECORD
                    if (variable.FieldName == "TIMESTAMP" ||
                        variable.FieldName == "RECORD")
                        continue;

                    MeasurementV1 measurement = CreateMeasurementFromVariable(variable, obs, meteorology.Metadata);
                    measurements.Add(measurement);
                }
            }

            return measurements;
        }

        private MeasurementV1 CreateMeasurementFromVariable(Variable variable, IObservation observation, Metadata metadata)
        {
            // Look up property based on string, get value
            var value = observation.GetType().GetProperty(variable.FieldName).GetValue(observation, null);

            Nsar.Common.Measure.Models.PhysicalQuantity pq = new Nsar.Common.Measure.Models.PhysicalQuantity(
                        Convert.ToDecimal(value),
                        variable.Units);

            // TODO: create interface, use constructor injection
            Nsar.Common.Measure.PhysicalQuantityConverter pqConverter = new Nsar.Common.Measure.PhysicalQuantityConverter();

            Nsar.Common.Measure.Models.PhysicalQuantity pqMetric = pqConverter.Convert(pq);
            string name = map.GetMeasurementName(variable.FieldName);
            DateTime measurementDateTime = new DateTime(observation.TIMESTAMP.Ticks, DateTimeKind.Utc);

            List<PhysicalQuantityV1> physicalQuantitis = new List<PhysicalQuantityV1>() {
                new PhysicalQuantityV1(pqMetric.Value, pqMetric.Unit, 0, 0, 0, DateTime.UtcNow, "CosmosDBSqlApiTransformer")
            };

            LocationV1 location = new LocationV1("Point",
                map.GetLatFromStation(metadata),
                map.GetLonFromStation(metadata));

            string fieldId = map.GetFieldID(metadata);

            string partitionKey = "EcTower_" + fieldId + "_" + name;
            string id = fieldId + "_" + name + "_" + measurementDateTime.ToString("o");

            return new MeasurementV1(partitionKey, id, DocumentType, name, TargetSchemaVersion, metadataId,
                "", "", "", "", null, fieldId, location, measurementDateTime, physicalQuantitis);
        }
    }
}
