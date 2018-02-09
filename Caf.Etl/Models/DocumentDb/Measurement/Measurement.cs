using System;
using System.Collections.Generic;
using Caf.Etl.Models.CosmosDBSqlApi;
using Newtonsoft.Json;

namespace Caf.Etl.Models.CosmosDBSqlApi.Measurement
{
    /// <summary>
    /// Dto class for data as described by json-schema located in schema\v1\measurement.json or https://raw.githubusercontent.com/bryanrcarlson/Nsar.Nodes/master/Models/DocumentDb/schema/v1/measurement.json#
    /// </summary>
    public class Measurement
    {
        /// <summary>
        /// PartitionKey maps partionKey
        /// </summary>
        [JsonProperty("partitionKey")]
        public string PartitionKey { get; private set; }

        /// <summary>
        /// ID maps id
        /// </summary>
        [JsonProperty("id")]
        public string ID { get; private set; }

        /// <summary>
        /// Type maps type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }

        /// <summary>
        /// Name maps name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }

        /// <summary>
        /// SchemaVersion maps schemaVersion
        /// </summary>
        [JsonProperty("schemaVersion")]
        public string SchemaVersion { get; private set; }

        /// <summary>
        /// MetadataID maps metadataId
        /// </summary>
        [JsonProperty("metadataId")]
        public string MetadataID { get; private set; }

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

        /// <summary>
        /// FiledID maps fieldId
        /// </summary>
        [JsonProperty("fieldId")]
        public string FieldID { get; private set; }

        /// <summary>
        /// Location maps location
        /// </summary>
        [JsonProperty("location")]
        public Location Location { get; private set; }

        /// <summary>
        /// MeasurementDateTime maps measurementDateTime
        /// </summary>
        [JsonProperty("measurementDateTime")]
        public DateTime MeasurementDateTime { get; private set; }

        /// <summary>
        /// PhysicalQuantities maps physicalQuantities
        /// </summary>
        [JsonProperty("physicalQuantities")]
        public List<PhysicalQuantity> PhysicalQuantities { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="partitionKey"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="schemaVersion"></param>
        /// <param name="metadataID"></param>
        /// <param name="_rid"></param>
        /// <param name="_self"></param>
        /// <param name="_etag"></param>
        /// <param name="_attachements"></param>
        /// <param name="_ts"></param>
        /// <param name="fieldId"></param>
        /// <param name="location"></param>
        /// <param name="measurementDateTime"></param>
        /// <param name="physicalQuantities"></param>
        public Measurement(
            string partitionKey, string id, string type, string name,
            string schemaVersion, string metadataID, string _rid,
            string _self, string _etag, string _attachements,
            int? _ts, string fieldId, Location location,
            DateTime measurementDateTime,
            List<PhysicalQuantity> physicalQuantities)
        {
            PartitionKey = partitionKey;
            ID = id;
            Type = type;
            Name = name;
            SchemaVersion = schemaVersion;
            MetadataID = metadataID;
            this._rid = _rid;
            this._self = _self;
            this._etag = _etag;
            this._attachments = _attachments;
            this._ts = _ts;
            FieldID = fieldId;
            Location = location;
            MeasurementDateTime = measurementDateTime;
            PhysicalQuantities = physicalQuantities;
        }
    }
}
