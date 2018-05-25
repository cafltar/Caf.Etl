using Caf.Etl.Models.CosmosDBSqlApi.EtlEvent;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.TestUtils
{
    public static class CosmosDBSqlApiArranger
    {
        public static EtlEvent GetEtlEventMock(string id)
        {
            EtlEvent e = new EtlEvent(
                "EtlEvent_AzureFunction",
                id,
                "EtlEvent",
                "AzureFunction",
                "http://files.cafltar.org/data/schema/documentDb/v2/EtlEvent.json",
                "CafMeteorologyEcTower",
                "", "", "", "", null,
                "0.1",
                "AzureFunction",
                new DateTime(2018, 5, 22, 5, 0, 0).ToUniversalTime(),
                new DateTime(2018, 5, 22, 5, 2, 0).ToUniversalTime(),
                new List<string>()
                {
                    @"C:\Files\foo.csv"
                },
                new List<string>()
                {
                    @"C:\Files\Output\bah.csv"
                },
                new List<string>()
                {
                    "Operation message",
                    "Error: yo momma",
                    "2018-05-22T01:01:00.000000Z | Message"
                });

            return e;
        }
    }
}
