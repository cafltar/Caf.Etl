using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Models.CosmosDBSqlApi.Sample
{
    public class SoilCoreSample : SampleV2
    {
        public int DepthTop { get; set; }
        public int DepthBottom { get; set; }
        public string HorizonDelegation { get; set; }
    }
}
