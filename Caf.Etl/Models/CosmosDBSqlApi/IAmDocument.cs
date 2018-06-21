using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Models.CosmosDBSqlApi
{
    public interface IAmDocument
    {
        /// <summary></summary>
        [JsonProperty("partitionKey")]
        string partitionKey { get; }

        /// <summary></summary>
        [JsonProperty("id")]
        string id { get; }

        /// <summary></summary>
        [JsonProperty("type")]
        string Type { get; }

        /// <summary></summary>
        string _rid { get; }

        /// <summary></summary>
        string _self { get; }

        /// <summary></summary>
        string _etag { get; }

        /// <summary></summary>
        string _attachments { get; }

        /// <summary></summary>
        int? _ts { get; }
    }
}
