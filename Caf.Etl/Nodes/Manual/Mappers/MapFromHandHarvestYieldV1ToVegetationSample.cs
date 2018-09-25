using Caf.Etl.Models.CosmosDBSqlApi.Core;
using Caf.Etl.Models.CosmosDBSqlApi.Sample;
using Caf.Etl.Models.Manual.TidyData;
using Caf.Etl.Models.Manual.TidyData.DataTables;
using Caf.Etl.Nodes.Manual.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Nodes.Manual.Mappers
{
    public class MapFromHandHarvestYieldV1ToVegetationSample : 
        IMap<HandHarvestYieldV1, VegetationSample>
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
        public DateTime? GetDateTimeSample(HandHarvestYieldV1 observation)
        {
            return null;
        }
        public DateTime? GetDateTimeMeasurement(HandHarvestYieldV1 observation)
        {
            return null;
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

        public VegetationSample GetSample(HandHarvestYieldV1 observation)
        {
            VegetationSample sample = new VegetationSample();
            sample.Id = GetSampleId(observation);
            sample.Name = GetSampleName(observation);
            sample.Location = GetLocation(observation);
            sample.DateTime = GetDateTimeSample(observation);

            sample.HarvestYear = GetHarvestYear(observation);
            sample.PlantName = GetPlantName(observation);

            if (sample.Id == null)
                return null;
            if (sample.HarvestYear == null && sample.DateTime == null)
                return null;
            if (sample.PlantName == null)
                return null;
            

            return sample;
        }
    }
}
