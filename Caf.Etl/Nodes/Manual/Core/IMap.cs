using Caf.Etl.Models.CosmosDBSqlApi.Core;
using Caf.Etl.Models.Manual.TidyData;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Nodes.Manual.Core
{
    public interface IMap<T> where T : IObservation
    {
        string GetSampleId(T obs);
        string GetSampleName(T obs);
        LocationV2 GetLocation(T obs);
        DateTime GetDateTimeSample(T obs);
        DateTime GetDateTimeMeasurement(T obs);
        string GetMeasurementName(string fieldName);

        // TODO: will likely need to include other SampleV2 properties to map
    }
}
