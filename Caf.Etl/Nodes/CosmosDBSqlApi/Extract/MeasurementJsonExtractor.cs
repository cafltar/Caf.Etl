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

        public List<MeasurementV1> ToMeasurements(string jsonMeasurements)
        {
            List<MeasurementV1> results = new List<MeasurementV1>();
            results = JsonConvert.DeserializeObject<List<MeasurementV1>>(jsonMeasurements);

            return results;
        }
    }
}
