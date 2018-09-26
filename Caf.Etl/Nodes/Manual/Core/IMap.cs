using Caf.Etl.Models.CosmosDBSqlApi.Sample;
using Caf.Etl.Models.Manual.TidyData;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Nodes.Manual.Core
{
    public interface IMap<T, U>
        where T : IObservation
        where U : SampleV2
    {
        U GetSample(T observation);
        string GetMeasurementName(string fieldName);
        DateTime? GetDateTimeMeasurement(T obs);
    }
}
