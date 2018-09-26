using Caf.Etl.Models.CosmosDBSqlApi.Core;
using Caf.Etl.Models.CosmosDBSqlApi.Measurement;
using Microsoft.Azure.Documents;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Models.CosmosDBSqlApi.Sample
{
    public class SampleV2 : IAmDocument, IEquatable<SampleV2>
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
        public DateTime? DateTime { get; set; }

        [JsonProperty("measurements")]
        public List<MeasurementV2> Measurements { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as SampleV2);
        }

        public bool Equals(SampleV2 other)
        {
            return other != null &&
                   _rid == other._rid &&
                   _self == other._self &&
                   _etag == other._etag &&
                   _attachments == other._attachments &&
                   EqualityComparer<int?>.Default.Equals(_ts, other._ts) &&
                   PartitionKey == other.PartitionKey &&
                   Id == other.Id &&
                   Type == other.Type &&
                   Name == other.Name &&
                   Schema == other.Schema &&
                   Project == other.Project &&
                   AreaOfInterest == other.AreaOfInterest &&
                   EqualityComparer<LocationV2>.Default.Equals(Location, other.Location) &&
                   EqualityComparer<DateTime?>.Default.Equals(DateTime, other.DateTime) &&
                   EqualityComparer<List<MeasurementV2>>.Default.Equals(Measurements, other.Measurements);
        }

        public override int GetHashCode()
        {
            var hashCode = 1629339559;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_rid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_self);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_etag);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_attachments);
            hashCode = hashCode * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(_ts);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PartitionKey);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Schema);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Project);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AreaOfInterest);
            hashCode = hashCode * -1521134295 + EqualityComparer<LocationV2>.Default.GetHashCode(Location);
            hashCode = hashCode * -1521134295 + EqualityComparer<DateTime?>.Default.GetHashCode(DateTime);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<MeasurementV2>>.Default.GetHashCode(Measurements);
            return hashCode;
        }

        public static bool operator ==(SampleV2 v1, SampleV2 v2)
        {
            return EqualityComparer<SampleV2>.Default.Equals(v1, v2);
        }

        public static bool operator !=(SampleV2 v1, SampleV2 v2)
        {
            return !(v1 == v2);
        }
    }
}
