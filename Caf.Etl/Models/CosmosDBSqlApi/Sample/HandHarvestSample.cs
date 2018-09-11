using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Models.CosmosDBSqlApi.Sample
{
    public class HandHarvestSample : SampleV2
    {
        /// <summary></summary>
        [JsonProperty("crop")]
        public string Crop { get; set; }
    }
}
