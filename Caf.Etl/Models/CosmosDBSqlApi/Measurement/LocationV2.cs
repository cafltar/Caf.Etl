using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Models.CosmosDBSqlApi.Measurement
{
    /// <summary></summary>
    /// <todo>Consider using a proper GeoJSON library: https://github.com/GeoJSON-Net/GeoJSON.Net</todo>
    public class LocationV2 : IEquatable<LocationV2>
    {
        /// <summary>
        /// Type maps type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }

        /// <summary>
        /// Coordinates maps coordinates
        /// </summary>
        /// <returns>
        /// List of two doubles; Latitude, Longitude
        /// </returns>
        [JsonProperty("coordinates")]
        public List<double> Coordinates { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="type"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        [JsonConstructor]
        public LocationV2(
            string type,
            double latitude,
            double longitude)
        {
            Type = type;
            Coordinates = new List<double>()
            {
                latitude,
                longitude
            };
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as LocationV2);
        }

        public bool Equals(LocationV2 other)
        {
            return other != null &&
                   Type == other.Type &&
                   //EqualityComparer<List<double>>.Default.Equals(Coordinates, other.Coordinates);
                   Coordinates[0] == other.Coordinates[0] &&
                   Coordinates[1] == other.Coordinates[1];
        }

        public override int GetHashCode()
        {
            var hashCode = 1743564093;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<double>>.Default.GetHashCode(Coordinates);
            return hashCode;
        }

        public static bool operator ==(LocationV2 v1, LocationV2 v2)
        {
            return EqualityComparer<LocationV2>.Default.Equals(v1, v2);
        }

        public static bool operator !=(LocationV2 v1, LocationV2 v2)
        {
            return !(v1 == v2);
        }


    }
}
