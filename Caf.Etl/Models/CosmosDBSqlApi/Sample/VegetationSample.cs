using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Models.CosmosDBSqlApi.Sample
{
    public class VegetationSample : SampleV2
    {
        /// <summary></summary>
        [JsonProperty("plantName")]
        public string PlantName { get; set; }
    }
}
