using Caf.Etl.Models.CosmosDBSqlApi.Core;
using Caf.Etl.Models.CosmosDBSqlApi.Measurement;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Models.CosmosDBSqlApi.Sample
{
    public class SampleV2 : IAmDocument
    {
        /// <summary></summary>
        [JsonProperty("_rid")]
        public string _rid { get; set; }

        /// <summary></summary>
        [JsonProperty("_self")]
        public string _self { get; set; }

        /// <summary></summary>
        [JsonProperty("_etag")]
        public string _etag { get; set; }

        /// <summary></summary>
        [JsonProperty("_attachments")]
        public string _attachments { get; set; }

        /// <summary></summary>
        [JsonProperty("_ts")]
        public int? _ts { get; set; }

        /// <summary></summary>
        [JsonProperty("partitionKey")]
        public string PartitionKey { get; set; }

        /// <summary></summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary></summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary></summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary></summary>
        [JsonProperty("schema")]
        public string Schema { get; set; }

        /// <summary></summary>
        [JsonProperty("project")]
        public string Project { get; set; }

        /// <summary></summary>
        [JsonProperty("areaOfInterest")]
        public string AreaOfInterest { get; set; }

        /// <summary></summary>
        [JsonProperty("location")]
        public LocationV2 Location { get; set; }

        /// <summary></summary>
        [JsonProperty("dateTime")]
        public DateTime DateTime { get; set; }

        [JsonProperty("measurements")]
        public List<MeasurementV2> Measurements { get; set; }
    }
}
