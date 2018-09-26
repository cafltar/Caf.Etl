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
    public class MapFromSoilGridPointSurveyToSoilSample : 
        IMap<SoilGridPointSurveyV1, SoilSample>
    {
        private Dictionary<string, string> mapDataFieldsToMeasurementName;

        public MapFromSoilGridPointSurveyToSoilSample()
        {
            mapDataFieldsToMeasurementName =
                getMapDataFieldsToMeasurementName();                
        }

        public string GetSampleId(SoilGridPointSurveyV1 observation)
        {
            if (observation.ID2 == null)
                throw new ArgumentNullException();

            string id = $"CF_{GetYear(observation)}_GP{observation.ID2}_{GetDepthTop(observation)}-{GetDepthBottom(observation)}";

            return id;
        }
        public string GetSampleName(SoilGridPointSurveyV1 observation)
        {
            return "GridPointSurvey";
        }
        public LocationV2 GetLocation(SoilGridPointSurveyV1 observation)
        {
            if (observation.Latitude == null || observation.Longitude == null)
                throw new ArgumentNullException();

            return new LocationV2(
                "Point",
                Convert.ToDouble(observation.Latitude),
                Convert.ToDouble(observation.Longitude));
        }
        public DateTime? GetDateTimeSample(SoilGridPointSurveyV1 observation)
        {
            return null;
        }
        public DateTime? GetDateTimeMeasurement(SoilGridPointSurveyV1 observation)
        {
            return null;
        }
        public int GetDepthTop(SoilGridPointSurveyV1 observation)
        {
            if(observation.TopDepth == null)
                throw new ArgumentNullException();

            return observation.TopDepth.GetValueOrDefault();
        }
        public int GetDepthBottom(SoilGridPointSurveyV1 observation)
        {
            if(observation.BottomDepth == null)
                throw new ArgumentNullException();

            return observation.BottomDepth.GetValueOrDefault();
        }
        public int GetYear(SoilGridPointSurveyV1 observation)
        {
            if (observation.Year == null)
                throw new ArgumentNullException();

            return observation.Year.GetValueOrDefault();
        }

        public string GetMeasurementName(string dataField)
        {
            if(mapDataFieldsToMeasurementName.ContainsKey(dataField))
            {
                return mapDataFieldsToMeasurementName[dataField];
            }
            else { return null; } 
        }
        private Dictionary<string, string> getMapDataFieldsToMeasurementName()
        {
            return new Dictionary<string, string>()
            {
                { "Horizon", "Horizon" },
                { "BulkDensity", "BulkDensity" },
                { "dC13", "IsotopicSignatureC13" },
                { "dC13AcidWashed", "IsotopicSignatureC13AcidWashed" },
                { "TNConc", "TotalNitrogenConcentration" },
                { "TNConcAcidWashed", "TotalNitrogenConcentrationAcidWashed" }, 
                { "TCConc", "TotalCarbonConcentration" },
                { "TCConcAcidWashed", "TotalCarbonConcentrationAcidWashed" }, 
                { "TocConc", "TotalOrganicCarbonConcentration" },
                { "TocStock", "TotalOrganicCarbonStock" },
                { "TicConc", "TotalInorganicCarbonConcentration" },
                { "TicStock", "TotalInorganicCarbonStock" },
                { "TNStock", "TotalNitrogenStock" },
                { "pH", "pH" }
            };
        }

        public SoilSample GetSample(SoilGridPointSurveyV1 observation)
        {
            SoilSample sample = new SoilSample();
            sample.Id = GetSampleId(observation);
            sample.Name = GetSampleName(observation);
            sample.Location = GetLocation(observation);
            sample.DateTime = GetDateTimeSample(observation);

            sample.DepthTop = GetDepthTop(observation);
            sample.DepthBottom = GetDepthBottom(observation);
            sample.Year = GetYear(observation);

            if (sample.Id == null |
                sample.Location == null)
                return null;

            return sample;
        }
    }
}
