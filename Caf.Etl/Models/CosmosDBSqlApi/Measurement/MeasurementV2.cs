using System;
using System.Collections.Generic;
using Caf.Etl.Models.CosmosDBSqlApi;
using Newtonsoft.Json;

namespace Caf.Etl.Models.CosmosDBSqlApi.Measurement
{
    /// <summary>
    /// Dto class for data as described by json-schema located in schema\v2\measurement.json or http://files.cafltar.org/data/schema/documentDb/v2/measurement.json
    /// </summary>
    public class MeasurementV2
    {
        /// <summary></summary>
        [JsonProperty("partitionKey")]
        public string PartitionKey { get; private set; }

        /// <summary></summary>
        [JsonProperty("id")]
        public string ID { get; private set; }

        /// <summary></summary>
        [JsonProperty("type")]
        public string Type { get; private set; }

        /// <summary></summary>
        [JsonProperty("name")]
        public string Name { get; private set; }

        /// <summary></summary>
        [JsonProperty("schema")]
        public string Schema { get; private set; }

        /// <summary></summary>
        [JsonProperty("project")]
        public string Project { get; private set; }

        /// <summary></summary>
        public string _rid { get; private set; }

        /// <summary></summary>
        public string _self { get; private set; }

        /// <summary></summary>
        public string _etag { get; private set; }

        /// <summary></summary>
        public string _attachments { get; private set; }

        /// <summary></summary>
        public int? _ts { get; private set; }

        /// <summary></summary>
        [JsonProperty("areaOfInterest")]
        public string AreaOfInterest { get; private set; }

        /// <summary></summary>
        [JsonProperty("location")]
        public LocationV2 Location { get; private set; }

        /// <summary></summary>
        [JsonProperty("dateTime")]
        public DateTime DateTime { get; private set; }

        /// <summary></summary>
        [JsonProperty("physicalQuantities")]
        public List<PhysicalQuantityV2> PhysicalQuantities { get; set; }

        /// <summary></summary>
        [JsonProperty("timestep")]
        public int? TimestepSec { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public MeasurementV2(
            string partitionKey, string id, string type, string name,
            string schema, string project, string _rid,
            string _self, string _etag, string _attachements,
            int? _ts, string areaOfInterest, LocationV2 location,
            DateTime dateTime,
            List<PhysicalQuantityV2> physicalQuantities,
            int? timestep)
        {
            PartitionKey = partitionKey;
            ID = id;
            Type = type;
            Name = name;
            Schema = schema;
            Project = project;
            this._rid = _rid;
            this._self = _self;
            this._etag = _etag;
            this._attachments = _attachments;
            this._ts = _ts;
            AreaOfInterest = areaOfInterest;
            Location = location;
            DateTime = dateTime;
            PhysicalQuantities = physicalQuantities;
            TimestepSec = timestep;
        }
    }
}
