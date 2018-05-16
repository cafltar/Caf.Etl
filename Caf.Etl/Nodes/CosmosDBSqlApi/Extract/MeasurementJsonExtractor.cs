using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caf.Etl.Models.CosmosDBSqlApi.Measurement;
using Newtonsoft.Json;

namespace Caf.Etl.Nodes.CosmosDBSqlApi.Extract
{
    public class MeasurementJsonExtractor
    {
        public MeasurementJsonExtractor()
        {
            // TODO: Create client for Cosmos DB?
        }

        // TODO: Create Extract() function

        public List<Measurement> ToMeasurements(string jsonMeasurements)
        {
            List<Measurement> results = new List<Measurement>();
            results = JsonConvert.DeserializeObject<List<Measurement>>(jsonMeasurements);

            return results;
        }
    }
}
