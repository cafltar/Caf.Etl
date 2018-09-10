using Caf.Etl.Models.Manual.TidyData;
using Caf.Etl.Models.Manual.TidyData.DataTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.TestUtils
{
    public static class ManualArranger
    {
        public static Metadata GetMetadataDerivedFromActualDataV1()
        {
            Metadata m = new Metadata();

            m.Variables = new List<Variable>()
            {
                new Variable() { FieldName = "HarvestYear", Units = "unitless", Description = "Year crop was harvested" },
                new Variable() { FieldName = "Crop", Units = "unitless", Description = "Crop identifier {SW = spring wheat, GB = garbonzo beans, SB = spring barley, WW = winter wheat, SC = spring canola}" },
                new Variable() { FieldName = "SampleID", Units = "unitless", Description = "Sample ID given based on other descriptive attributes, but not consistency" },
                new Variable() { FieldName = "Latitude", Units = "dd", Description = "Latitude of georeference point near where sample was collected" },
                new Variable() { FieldName = "Longitude", Units = "dd", Description = "Longnitude of georeference point near where sample was collected" },
                new Variable() { FieldName = "ID2", Units = "unitless", Description = "Number ID of georeference point near sample collection" },
                new Variable() { FieldName = "GrainWeight", Units = "g", Description = "Mass of grain after sample dried in greenhouse and threshed" },
                new Variable() { FieldName = "Area", Units = "m^2", Description = "Area that crop was harvested from" },
                new Variable() { FieldName = "Yield_g_m2", Units = "g/m^2", Description = "Calculated yield of sample" },
                new Variable() { FieldName = "Yield_lb_ac", Units = "lb/ac", Description = "Calculated yield of sample" },
                new Variable() { FieldName = "Yield_bu_ac", Units = "bu/ac", Description = "Calculated yield of sample" },
                new Variable() { FieldName = "TestWeight", Units = "g", Description = "Weight of grain subsample analyzed for protein, moisture, starch, gluten, oil" },
                new Variable() { FieldName = "OilDM", Units = "%", Description = "Percent oil in sample (after removing moisture?)" },
                new Variable() { FieldName = "Protein", Units = "%", Description = "Percent of protein in sample (dry mass?)" },
                new Variable() { FieldName = "Moisture", Units = "%", Description = "Percent of moisture in sample" },
                new Variable() { FieldName = "Starch", Units = "%", Description = "Percent of starch in dry mass" },
                new Variable() { FieldName = "WGlutDM", Units = "%", Description = "Percent of Gluten (after accouting for moisture?)" },
                new Variable() { FieldName = "Notes", Units = "unitless", Description = "Notes, aggregated from all steps of processing" }
            };

            return m;
        }

        public static List<IObservation> GetObservationsDerivedFromActualDataV1()
        {
            List<IObservation> obs = new List<IObservation>()
            {
                new HandHarvestYieldV1() { HarvestYear = 2013, Crop = "SW", SampleID = "cf13gpsw_0_5-a", Latitude = 46.77873, Longitude = -117.08751, ID2 = 1, GrainWeight = 461, Area = 2, Yield_g_m2 = 230.5, Yield_lb_ac = 2056.472595, Yield_bu_ac = 34.27454325, TestWeight = 54.8, OilDM = null, Protein = 11.9, Moisture = 7.6, Starch = 72, WGlutDM = 30.1, Notes = null },
                new HandHarvestYieldV1() { HarvestYear = 2013, Crop = "GB", SampleID = "cf13gpgb_1_6-a", Latitude = 46.77869, Longitude = -117.08706, ID2 = 2, GrainWeight = 205, Area = 2, Yield_g_m2 = 102.5, Yield_lb_ac = 914.483475, Yield_bu_ac = null, TestWeight = null, OilDM = null, Protein = null, Moisture = null, Starch = null, WGlutDM = null, Notes = null },
                new HandHarvestYieldV1() { HarvestYear = 2013, Crop = "GB", SampleID = "cf13gpgb_2_7-A", Latitude = 46.77879, Longitude = -117.08668, ID2 = 3, GrainWeight = 368, Area = 2, Yield_g_m2 = 184, Yield_lb_ac = 1641.60936, Yield_bu_ac = null, TestWeight = null, OilDM = null, Protein = null, Moisture = null, Starch = null, WGlutDM = null, Notes = null },
                new HandHarvestYieldV1() { HarvestYear = 2013, Crop = "SB", SampleID = "cf13gpsb_3_8-a", Latitude = 46.77876, Longitude = -117.08626, ID2 = 4, GrainWeight = 826, Area = 2, Yield_g_m2 = 413, Yield_lb_ac = 3684.69927, Yield_bu_ac = null, TestWeight = 53.3, OilDM = null, Protein = 12.2, Moisture = 9.2, Starch = 63, WGlutDM = null, Notes = null },
                new HandHarvestYieldV1() { HarvestYear = 2013, Crop = "GB", SampleID = "cf13gpgb_4_9-a", Latitude = 46.77867, Longitude = -117.08584, ID2 = 5, GrainWeight = 444, Area = 2, Yield_g_m2 = 222, Yield_lb_ac = 1980.63738, Yield_bu_ac = null, TestWeight = null, OilDM = null, Protein = null, Moisture = null, Starch = null, WGlutDM = null, Notes = null },
                new HandHarvestYieldV1() { HarvestYear = 2013, Crop = "GB", SampleID = "CF13GPGB_5_10-A", Latitude = 46.77877, Longitude = -117.08542, ID2 = 6, GrainWeight = 307, Area = 2, Yield_g_m2 = 153.5, Yield_lb_ac = 1369.494765, Yield_bu_ac = null, TestWeight = null, OilDM = null, Protein = null, Moisture = null, Starch = null, WGlutDM = null, Notes = null },
                new HandHarvestYieldV1() { HarvestYear = 2013, Crop = "GB", SampleID = "cf13gpgb_6_11-a", Latitude = 46.77863, Longitude = -117.08501, ID2 = 7, GrainWeight = 296, Area = 2, Yield_g_m2 = 148, Yield_lb_ac = 1320.42492, Yield_bu_ac = null, TestWeight = null, OilDM = null, Protein = null, Moisture = null, Starch = null, WGlutDM = null, Notes = null },
                new HandHarvestYieldV1() { HarvestYear = 2013, Crop = null, SampleID = null, Latitude = 46.77872, Longitude = -117.08459, ID2 = 8, GrainWeight = null, Area = null, Yield_g_m2 = null, Yield_lb_ac = null, Yield_bu_ac = null, TestWeight = null, OilDM = null, Protein = null, Moisture = null, Starch = null, WGlutDM = null, Notes = null },
                new HandHarvestYieldV1() { HarvestYear = 2013, Crop = "GB", SampleID = "cf13gpgb_8_13-a", Latitude = 46.77867, Longitude = -117.08417, ID2 = 9, GrainWeight = 490, Area = 2, Yield_g_m2 = 245, Yield_lb_ac = 2185.83855, Yield_bu_ac = null, TestWeight = null, OilDM = null, Protein = null, Moisture = null, Starch = null, WGlutDM = null, Notes = null },
                new HandHarvestYieldV1() { HarvestYear = 2013, Crop = "SW", SampleID = "cf13gpsw_9_14-a", Latitude = 46.77874, Longitude = -117.08375, ID2 = 10, GrainWeight = 568, Area = 2, Yield_g_m2 = 284, Yield_lb_ac = 2533.78836, Yield_bu_ac = 42.229806, TestWeight = 57.9, OilDM = null, Protein = 10.8, Moisture = 6.3, Starch = 78.1, WGlutDM = 24, Notes = null },
                new HandHarvestYieldV1() { HarvestYear = 2013, Crop = "SW", SampleID = "cf13gpsw_10_15-a", Latitude = 46.77866, Longitude = -117.08333, ID2 = 11, GrainWeight = 769, Area = 2, Yield_g_m2 = 384.5, Yield_lb_ac = 3430.428255, Yield_bu_ac = 57.17380425, TestWeight = 60.3, OilDM = null, Protein = 10.6, Moisture = 9.7, Starch = 70, WGlutDM = 28.8, Notes = null },
                new HandHarvestYieldV1() { HarvestYear = 2013, Crop = "SW", SampleID = "cf13gpsw_11_16-a", Latitude = 46.77873, Longitude = -117.08294, ID2 = 12, GrainWeight = 739, Area = 2, Yield_g_m2 = 369.5, Yield_lb_ac = 3296.601405, Yield_bu_ac = 54.94335675, TestWeight = 57.1, OilDM = null, Protein = 13.2, Moisture = 9.5, Starch = 67.6, WGlutDM = 35.2, Notes = null },
                new HandHarvestYieldV1() { HarvestYear = 2013, Crop = "WW", SampleID = "CF13GPWW_13_17-A", Latitude = 46.77876, Longitude = -117.0825, ID2 = 13, GrainWeight = 802, Area = 2, Yield_g_m2 = 401, Yield_lb_ac = 3577.63779, Yield_bu_ac = 59.6272965, TestWeight = 58, OilDM = null, Protein = 10, Moisture = 9.1, Starch = 73.5, WGlutDM = 25.5, Notes = null },
                new HandHarvestYieldV1() { HarvestYear = 2013, Crop = "WW", SampleID = "CF13GPWW_14_19-A", Latitude = 46.77869, Longitude = -117.08163, ID2 = 14, GrainWeight = 351, Area = 2, Yield_g_m2 = 175.5, Yield_lb_ac = 1565.774145, Yield_bu_ac = 26.09623575, TestWeight = null, OilDM = null, Protein = 8.9, Moisture = 9.4, Starch = 72.9, WGlutDM = 23, Notes = "insufficient sample" }
            };

            return obs;
        }
    }
}
