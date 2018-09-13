using Caf.Etl.Models.CosmosDBSqlApi.Core;
using Caf.Etl.Models.Manual.TidyData;
using Caf.Etl.Models.Manual.TidyData.DataTables;
using Caf.Etl.Nodes.Manual.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Nodes.Manual.Mappers
{
    public class MapFromHandHarvestYieldV1ToVegetationSample : IMap<HandHarvestYieldV1>
    {
        private Dictionary<string, string> mapDataFieldsToMeasurementName;

        public MapFromHandHarvestYieldV1ToVegetationSample()
        {
            mapDataFieldsToMeasurementName =
                getMapDataFieldsToMeasurementName();                
        }

        public string GetSampleId(HandHarvestYieldV1 observation)
        {
            return observation.SampleID;
        }
        public string GetSampleName(HandHarvestYieldV1 observation)
        {
            return "GridPointSurvey";
        }
        public LocationV2 GetLocation(HandHarvestYieldV1 observation)
        {
            return new LocationV2(
                "Point",
                Convert.ToDouble(observation.Latitude),
                Convert.ToDouble(observation.Longitude));
        }
        public int? GetHarvestYear(HandHarvestYieldV1 observation)
        {
            return observation.HarvestYear;
        }
        public DateTime GetDateTimeSample(HandHarvestYieldV1 observation)
        {
            throw new NotImplementedException();
        }
        public DateTime GetDateTimeMeasurement(HandHarvestYieldV1 observation)
        {
            throw new NotImplementedException();
        }
        public string GetMeasurementName(string dataField)
        {
            if(mapDataFieldsToMeasurementName.ContainsKey(dataField))
            {
                return mapDataFieldsToMeasurementName[dataField];
            }
            else { return null; } 
        }
        public string GetPlantName(HandHarvestYieldV1 observation)
        {
            return observation.Crop;
        }

        private Dictionary<string, string> getMapDataFieldsToMeasurementName()
        {
            return new Dictionary<string, string>()
            {
                {"GrainWeight", "GrainMassWet" },
                {"Yield_g_m2", "YieldWet" },
                {"OilDM", "GrainOilConcentration" },
                { "Protein", "GrainProteinConcentration" },
                { "Moisture", "GrainMoistureConcentration" },
                { "Starch", "GrainStarchConcentration" },
                { "WGlutDM", "GrainGlutenConcentration" }
            };
        }
    }
}
