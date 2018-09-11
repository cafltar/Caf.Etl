using Caf.Etl.Models.CosmosDBSqlApi.Sample;
using Caf.Etl.Models.Manual.TidyData;
using Caf.Etl.Nodes.Manual.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Nodes.Manual.Transform
{
    public class CosmosDBSqlApiSampleV2Transformer
    {
        private readonly IMap map;
        // EtlEventId, DocumentType, Project, ...

        public CosmosDBSqlApiSampleV2Transformer(
            IMap map,
            string schema,
            string etlEventId,
            string project,
            string documentType = "Sample")
        {
            this.map = map;
        }

        public List<SampleV2> Transform(TidyData tidyData)
        {
            List<SampleV2> samples = new List<SampleV2>();

            foreach(IObservation obs in tidyData.Observations)
            {
                SampleV2 sample = new SampleV2();
                
                
                foreach(Variable variable in tidyData.Metadata.Variables)
                {
                    // Create MeasurementV2s
                    // Use a mapper that defines the variables to keep
                    // if(variable in mappers.VariablesToKeep)

                }
            }

            return samples;
        }
    }
}
