using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Models.CosmosDBSqlApi.Sample
{
    public class SoilSample : SampleV2
    {
        /// <summary></summary>
        [JsonProperty("depthTop")]
        public double DepthTop { get; set; }
        
        /// <summary></summary>
        [JsonProperty("depthBottom")]
        public double DepthBottom { get; set; }

        /// <summary></summary>
        [JsonProperty("yearSampled")]
        public int Year { get; set; }
    }
}
