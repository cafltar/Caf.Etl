using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Models.CosmosDBSqlApi.Sample
{
    public class SoilSample : SampleV2
    {
        public int DepthTop { get; set; }
        public int DepthBottom { get; set; }
    }
}
