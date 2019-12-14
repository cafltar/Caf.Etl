using Caf.Etl.Models.CosmosDBSqlApi.Measurement;
using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caf.Etl.Nodes.CosmosDBSqlApi.Extract
{
    public class CafDbExtractor
    {
        private readonly string accountUri;
        private readonly string accountKey;
        private readonly string databaseId;
        private readonly string containerId;

        public CafDbExtractor(
            string accountUri,
            string accountKey,
            string databaseId = "cafdb",
            string containerId = "items")
        {
            this.accountUri = accountUri;
            this.accountKey = accountKey;
            this.databaseId = databaseId;
            this.containerId = containerId;
        }

        public async Task<List<MeasurementV2>> ExtractMeasurementsV2(
            string projectId,
            string areaOfInterest,
            string measurementName,
            string dateTimeMinUtc,
            string dateTimeMaxUtc)
        {
            List<MeasurementV2> result = new List<MeasurementV2>();

            using (CosmosClient client = new CosmosClient(accountUri, accountKey))
            {
                Container container = client.GetContainer(databaseId, containerId);

                string partitionkey = $"{projectId}_{areaOfInterest}_{measurementName}";

                QueryDefinition query = new QueryDefinition(
                    "SELECT * FROM m WHERE m.partitionKey = @partitionKey AND m.dateTime > @dateTimeMin AND m.dateTime < @dateTimeMax")
                    .WithParameter("@partitionKey", partitionkey)
                    .WithParameter("@dateTimeMin", dateTimeMinUtc)
                    .WithParameter("@dateTimeMax", dateTimeMaxUtc);

                FeedIterator<MeasurementV2> feedIterator = container.GetItemQueryIterator<MeasurementV2>(
                    query,
                    null,
                    new QueryRequestOptions() { PartitionKey = new PartitionKey("CafMeteorologyEcTower_CookEast_ParDensityTsAvg") });

                while(feedIterator.HasMoreResults)
                {
                    foreach(var item in await feedIterator.ReadNextAsync())
                    {
                        result.Add(item);
                    }
                }
            }

            return result;
        }
    }
}
