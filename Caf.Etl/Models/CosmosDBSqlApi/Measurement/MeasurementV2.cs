using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Caf.Etl.Models.CosmosDBSqlApi.Measurement
{
    /// <summary>
    /// Dto class for data as described by json-schema located in schema\v2\measurement.json or http://files.cafltar.org/data/schema/documentDb/v2/measurement.json
    /// </summary>
    public class MeasurementV2 : IEquatable<MeasurementV2>, IAmDocument
    {
        /// <summary></summary>
        [JsonProperty("partitionKey")]
        public string partitionKey { get; private set; }

        /// <summary></summary>
        [JsonProperty("id")]
        public string id { get; private set; }

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
        /// Basic constructor
        /// </summary>
        [JsonConstructor]
        public MeasurementV2(
            string partitionKey, string id, string type, string name,
            string schema, string project, string rid,
            string self, string etag, string attachments,
            int? ts, string areaOfInterest, LocationV2 location,
            DateTime dateTime,
            List<PhysicalQuantityV2> physicalQuantities,
            int? timestep)
        {
            this.partitionKey = partitionKey;
            this.id = id;
            Type = type;
            Name = name;
            Schema = schema;
            Project = project;
            this._rid = rid;
            this._self = self;
            this._etag = etag;
            this._attachments = attachments;
            this._ts = ts;
            AreaOfInterest = areaOfInterest;
            Location = location;
            DateTime = dateTime;
            PhysicalQuantities = physicalQuantities;
            TimestepSec = timestep;
        }

        /// <summary>
        /// Constructor, generates PartitionKey and Id
        /// </summary>
        /// <remarks>PartitionKey = {project}_{areaOfInterest}_{name}</remarks>
        /// <remarks>Id = {areaOfInterest}_{name}_{dateTime.ToString("o")}</remarks>
        public MeasurementV2(
            string type, string name,
            string schema, string project, string rid,
            string self, string etag, string attachments,
            int? ts, string areaOfInterest, LocationV2 location,
            DateTime dateTime,
            List<PhysicalQuantityV2> physicalQuantities,
            int? timestep)
        {
            partitionKey = $"{project}_{areaOfInterest}_{name}";
            id = $"{areaOfInterest}_{name}_{dateTime.ToString("o")}";
            Type = type;
            Name = name;
            Schema = schema;
            Project = project;
            this._rid = rid;
            this._self = self;
            this._etag = etag;
            this._attachments = attachments;
            this._ts = ts;
            AreaOfInterest = areaOfInterest;
            Location = location;
            DateTime = dateTime;
            PhysicalQuantities = physicalQuantities;
            TimestepSec = timestep;
        }

        /// <summary>
        /// Constructor, generates PartitionKey and Id, sets defaults
        /// </summary>
        /// <remarks>PartitionKey = {project}_{areaOfInterest}_{name}</remarks>
        /// <remarks>If timestep == null: Id = {areaOfInterest}_{name}_{dateTime.ToString("o")}</remarks>
        /// <remarks>If timestep != null: Id = {areaOfInterest}_{name}_Ts{timestep}_{dateTime.ToString("o")}</remarks>
        public MeasurementV2(
            string type, string name,
            string schema, string project,
            string areaOfInterest, LocationV2 location,
            DateTime dateTime,
            List<PhysicalQuantityV2> physicalQuantities,
            int? timestep)
        {
            partitionKey = $"{project}_{areaOfInterest}_{name}";
            id = $"{areaOfInterest}_{name}{(timestep != null ? ("_Ts" + timestep.ToString()) : "")}_{dateTime.ToString("o")}";
            Type = type;
            Name = name;
            Schema = schema;
            Project = project;
            this._rid = "";
            this._self = "";
            this._etag = "";
            this._attachments = "";
            this._ts = null;
            AreaOfInterest = areaOfInterest;
            Location = location;
            DateTime = dateTime;
            PhysicalQuantities = physicalQuantities;
            TimestepSec = timestep;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as MeasurementV2);
        }

        public bool Equals(MeasurementV2 other)
        {
            return other != null &&
                   partitionKey == other.partitionKey &&
                   id == other.id &&
                   Type == other.Type &&
                   Name == other.Name &&
                   Schema == other.Schema &&
                   Project == other.Project &&
                   _rid == other._rid &&
                   _self == other._self &&
                   _etag == other._etag &&
                   _attachments == other._attachments &&
                   EqualityComparer<int?>.Default.Equals(_ts, other._ts) &&
                   AreaOfInterest == other.AreaOfInterest &&
                   EqualityComparer<LocationV2>.Default.Equals(Location, other.Location) &&
                   DateTime == other.DateTime &&
                   EqualityComparer<List<PhysicalQuantityV2>>.Default.Equals(PhysicalQuantities, other.PhysicalQuantities) &&
                   EqualityComparer<int?>.Default.Equals(TimestepSec, other.TimestepSec);
        }

        public override int GetHashCode()
        {
            var hashCode = -329364641;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(partitionKey);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Schema);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Project);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_rid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_self);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_etag);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_attachments);
            hashCode = hashCode * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(_ts);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AreaOfInterest);
            hashCode = hashCode * -1521134295 + EqualityComparer<LocationV2>.Default.GetHashCode(Location);
            hashCode = hashCode * -1521134295 + DateTime.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<PhysicalQuantityV2>>.Default.GetHashCode(PhysicalQuantities);
            hashCode = hashCode * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(TimestepSec);
            return hashCode;
        }

        public static bool operator ==(MeasurementV2 v1, MeasurementV2 v2)
        {
            return EqualityComparer<MeasurementV2>.Default.Equals(v1, v2);
        }

        public static bool operator !=(MeasurementV2 v1, MeasurementV2 v2)
        {
            return !(v1 == v2);
        }


    }
}
