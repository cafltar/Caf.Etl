using Caf.Etl.Models.CosmosDBSqlApi.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Models.CosmosDBSqlApi.Sample
{
    public class Sample : IAmDocument
    {
        /// <summary></summary>
        [JsonProperty("partitionKey")]
        public string PartitionKey { get; private set; }

        /// <summary></summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

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
        [JsonProperty("areaOfInterest")]
        public string AreaOfInterest { get; private set; }

        /// <summary></summary>
        [JsonProperty("location")]
        public LocationV2 Location { get; private set; }

        /// <summary></summary>
        [JsonProperty("dateTime")]
        public DateTime DateTime { get; private set; }

        /// <summary></summary>
        [JsonProperty("_rid")]
        public string _rid { get; private set; }

        /// <summary></summary>
        [JsonProperty("_self")]
        public string _self { get; private set; }

        /// <summary></summary>
        [JsonProperty("_etag")]
        public string _etag { get; private set; }

        /// <summary></summary>
        [JsonProperty("_attachments")]
        public string _attachments { get; private set; }

        /// <summary></summary>
        [JsonProperty("_ts")]
        public int? _ts { get; private set; }

        

    }
}
