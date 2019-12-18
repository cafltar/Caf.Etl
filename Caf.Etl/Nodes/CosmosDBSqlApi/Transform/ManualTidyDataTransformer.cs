using Caf.Etl.Models.CosmosDBSqlApi.Measurement;
using Caf.Etl.Models.Manual.TidyData;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Caf.Etl.Nodes.CosmosDBSqlApi.Transform
{
    public class ManualTidyDataTransformer
    {
        // https://stackoverflow.com/a/10445840/1621156
        /// <summary>
        /// Transforms a list of MeasurementsV2 to TidyData
        /// 
        /// Assumes measurements are timeseries and spreads on DateTime. For spreading on other keys, use overloaded functions
        /// Assumes DateTime is in UTC
        /// </summary>
        /// <param name="measurements"></param>
        /// <returns></returns>
        public TidyData Transform<T>(List<MeasurementV2> measurements) 
            where T: IObservation
        {
            if (measurements.Count == 0)
                throw new ArgumentNullException("No measurements to convert");

            if (typeof(T).GetProperty("DateTimeUtc") == null)
                throw new ArgumentException("Generic class needs a 'DateTimeUtc' property");

            TidyData tidyData = new TidyData();
            tidyData.Metadata = new Metadata()
            {
                Variables = new List<Variable>()
                { 
                    new Variable()
                    {
                        FieldName = "DateTimeUtc",
                        Units = "unitless",
                        Description = "Date and time when measurement was collected, in UTC"
                    }
                }
            };

            // Build metadata
            // TODO: Add m.Description, once it's implemented in schema
            var variables = measurements
                .Select(m => new { m.Name, m.PhysicalQuantities.First().Unit })
                .Distinct();

            foreach (var variable in variables)
            {
                if (typeof(T).GetProperty(variable.Name) != null)
                {
                    tidyData.Metadata.Variables.Add(
                   new Variable()
                   {
                       FieldName = variable.Name,
                       Units = variable.Unit
                   });
                }    
            }

            // Build observations
            var groupedTypes = measurements
                .GroupBy(m => m.DateTime)
                .ToList();

            List<IObservation> observations = new List<IObservation>();

            foreach(var group in groupedTypes)
            {
                var observation = (T)Activator.CreateInstance(typeof(T));

                DateTime dateTimeUtc = group.Key ?? DateTime.MinValue;
                dateTimeUtc = DateTime.SpecifyKind(dateTimeUtc, DateTimeKind.Utc);

                observation
                    .GetType()
                    .GetProperty("DateTimeUtc")
                    .SetValue(observation, new DateTimeOffset(dateTimeUtc));

                foreach (var dataPoint in group)
                {
                    var prop = observation
                        .GetType()
                        .GetProperty(dataPoint.Name);

                    if(prop != null)
                        prop.SetValue(observation, dataPoint.PhysicalQuantities.First().Value);
                }

                observations.Add(observation);
            }

            tidyData.Observations = observations;

            return tidyData;
        }
    }
}
