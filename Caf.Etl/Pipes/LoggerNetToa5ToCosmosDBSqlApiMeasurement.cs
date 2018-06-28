using Caf.Etl.Models.CosmosDBSqlApi.EtlEvent;
using Caf.Etl.Nodes.CosmosDBSqlApi.Load;
using Microsoft.Azure.Documents.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Caf.Etl.Pipes
{
    public class LoggerNetToa5ToCosmosDBSqlApiMeasurement : IPipeData
    {
        private readonly EtlEvent etlEvent;
        private readonly string contents;
        private readonly DocumentClient client;

        public LoggerNetToa5ToCosmosDBSqlApiMeasurement(
            EtlEvent etlEvent,
            string contents,
            DocumentClient client)
        {
            this.etlEvent = etlEvent;
            this.contents = contents;
            this.client = client;

            DocumentLoader loader = new DocumentLoader(
                client,
                "cafdb",
                "items");


        }

        public void Extract()
        {
            throw new NotImplementedException();
        }

        public void Transform()
        {
            throw new NotImplementedException();
        }

        public void Load()
        {
            throw new NotImplementedException();
        }
    }
}
