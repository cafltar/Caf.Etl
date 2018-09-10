using Caf.Etl.Models.CosmosDBSqlApi.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Models.CosmosDBSqlApi.Sample
{
    // TODO: This will likely get confused with CosmosDBSqlApi.Measurement.MeasurementV2 - can I consolidate?
    public class Measurement
    {
        /// <summary></summary>
        [JsonProperty("physicalQuantities")]
        public List<PhysicalQuantityV2> PhysicalQuantities { get; set; }

        /// <summary></summary>
        [JsonProperty("timestep")]
        public int? TimestepSec { get; private set; }
    }
}
