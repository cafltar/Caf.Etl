using System;
using System.Collections.Generic;
using Caf.Etl.Models.CosmosDBSqlApi;
using Newtonsoft.Json;

namespace Caf.Etl.Models.CosmosDBSqlApi.EtlEvent
{
    /// <summary>
    /// Dto class for data as described by json-schema located in schema\v2\measurement.json or http://files.cafltar.org/data/schema/documentDb/v2/measurement.json
    /// </summary>
    public class EtlEvent : IAmDocument
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
        [JsonProperty("version")]
        public string Version { get; private set; }

        /// <summary></summary>
        [JsonProperty("source")]
        public string Source { get; private set; }

        /// <summary></summary>
        [JsonProperty("dateTimeStart")]
        public DateTime DateTimeStart { get; private set; }

        /// <summary></summary>
        [JsonProperty("dateTimeEnd")]
        public DateTime DateTimeEnd { get; set; }

        /// <summary></summary>
        [JsonProperty("inputs")]
        public List<string> Inputs { get; set; }

        /// <summary></summary>
        [JsonProperty("outputs")]
        public List<string> Outputs { get; set; }

        [JsonProperty("logs")]
        public List<string> Logs { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public EtlEvent(
            string partitionKey, string id, string type, string name,
            string schema, string project, string _rid,
            string _self, string _etag, string _attachements, int? _ts,
            string version, string source,
            DateTime dateTimeStart, DateTime dateTimeEnd,
            List<string> inputs, List<string> outputs, List<string> logs)
        {
            this.PartitionKey = partitionKey;
            this.Id = id;
            Type = type;
            Name = name;
            Schema = schema;
            Project = project;
            this._rid = _rid;
            this._self = _self;
            this._etag = _etag;
            this._attachments = _attachments;
            this._ts = _ts;
            Version = version;
            Source = source;
            DateTimeStart = dateTimeStart;
            DateTimeEnd = dateTimeEnd;
            Inputs = inputs;
            Outputs = outputs;
            Logs = logs;
        }

        /// <summary>
        /// Constructor, generates PartitionKey and Id
        /// </summary>
        public EtlEvent(
            string type, string name,
            string schema, string project, string _rid,
            string _self, string _etag, string _attachements, int? _ts,
            string version, string source,
            DateTime dateTimeStart, DateTime dateTimeEnd,
            List<string> inputs, List<string> outputs, List<string> logs)
        {
            PartitionKey = $"{type}_{name}";
            Id = $"{project}_{name}_{dateTimeStart.ToString("o")}";
            Type = type;
            Name = name;
            Schema = schema;
            Project = project;
            this._rid = _rid;
            this._self = _self;
            this._etag = _etag;
            this._attachments = _attachments;
            this._ts = _ts;
            Version = version;
            Source = source;
            DateTimeStart = dateTimeStart;
            DateTimeEnd = dateTimeEnd;
            Inputs = inputs;
            Outputs = outputs;
            Logs = logs;
        }

        /// <summary>
        /// Constructor, generates PartitionKey and Id, sets defaults
        /// </summary>
        public EtlEvent(
            string type, string name,
            string schema, string project,
            string version, string source,
            DateTime dateTimeStart)
        {
            PartitionKey = $"{type}_{name}";
            Id = $"{project}_{name}_{dateTimeStart.ToString("o")}";
            Type = type;
            Name = name;
            Schema = schema;
            Project = project;
            Version = version;
            Source = source;
            DateTimeStart = dateTimeStart;
            this._rid = "";
            this._self = "";
            this._etag = "";
            this._attachments = "";
            this._ts = null;
            Inputs = new List<string>();
            Outputs = new List<string>();
            Logs = new List<string>();
        }
    }
}
