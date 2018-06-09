using Caf.Etl.Models.CosmosDBSqlApi;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.TestUtils
{
    public class DocumentBase : IAmDocument
    {
        public string PartitionKey { get; set; }

        public string Id { get; set; }

        public string Type { get; set; }

        public string _rid { get; set; }

        public string _self { get; set; }

        public string _etag { get; set; }

        public string _attachments { get; set; }

        public int? _ts { get; set; }
    }
}
