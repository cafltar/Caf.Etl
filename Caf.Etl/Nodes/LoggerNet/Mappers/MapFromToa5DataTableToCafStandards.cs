using Caf.Etl.Nodes.LoggerNet.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caf.Etl.Models.LoggerNet.TOA5;
using Newtonsoft.Json.Linq;

namespace Caf.Etl.Nodes.LoggerNet.Mappers
{
    public class MapFromToa5DataTableToCafStandards : IMapper
    {
        private readonly string stationMap;
        private readonly Dictionary<string, string> mapDataFieldsToMeasurementName;
        private readonly Dictionary<string, string> mapStationNameToFieldId;

        public MapFromToa5DataTableToCafStandards()
        {
            this.stationMap = getStationMapJson();
            this.mapDataFieldsToMeasurementName =
                getMapDataFieldsToMeasurementName();
            this.mapStationNameToFieldId =
                getMapStationNameToFieldId();
        }

        public MapFromToa5DataTableToCafStandards(string stationMapJsonString)
        {
            stationMap = stationMapJsonString;
            this.mapDataFieldsToMeasurementName =
                getMapDataFieldsToMeasurementName();
            this.mapStationNameToFieldId =
                getMapStationNameToFieldId();
        }

        public MapFromToa5DataTableToCafStandards(
            string stationMapJsonString,
            Dictionary<string, string> mapStationNameToFieldId)
        {
            stationMap = stationMapJsonString;
            this.mapStationNameToFieldId = mapStationNameToFieldId;
            this.mapDataFieldsToMeasurementName = 
                this.getMapDataFieldsToMeasurementName();
        }

        public string GetFieldID(Metadata metadata)
        {
            return mapStationNameToFieldId[metadata.StationName];
        }

        public double GetLatFromStation(Metadata metadata)
        {
            var stations = JObject.Parse(stationMap);

            double lat = stations.Property("stations")
                .Values()
                .Single(s => s.Value<string>("name") == metadata.StationName)
                ["lat"].Value<double>();

            return lat;
        }

        public double GetLonFromStation(Metadata metadata)
        {
            var stations = JObject.Parse(stationMap);
            double lon = stations.Property("stations")
                .Values()
                .Single(s => s.Value<string>("name") == metadata.StationName)
                ["lon"].Value<double>();

            return lon;
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
                { "TIMESTAMP", "DateTime"},
                { "RECORD", "RecordNumber"},
                { "Fc_molar", "CO2CorrectedMolarTsAvg"},
                { "Fc_mass", "CO2CorrectedMassTsAvg"},
                { "Fc_qc_grade", "CO2CorrectedQuality"},
                { "LE", "HeatFluxLatentTsAvg"},
                { "LE_qc_grade", "HeatFluxLatentQuality"},
                { "H", "HeatFluxSensibleTsAvg"},
                { "H_qc_grade", "HeatFluxSensibleQuality"},
                { "Rn", "RadiationNetCorrectedTsAvg"},
                { "Bowen_ratio", "BowenRatioTsAvg"},
                { "tau", "MomentumFluxTotalTsAvg"},
                { "tau_qc_grade", "MomentumFluxTotalQuality"},
                { "u_star", "FrictionVelocityTsAvg"},
                { "T_star", "TemperatureScalingParameterTsAvg"},
                { "TKE", "TurbulentKineticEnergyTsAvg"},
                { "amb_tmpr_Avg", "TemperatureAirTsAvg"},
                { "Td_Avg", "TemperatureDewpointTsAvg"},
                { "RH_Avg", "RelativeHumidityTsAvg"},
                { "e_sat_Avg", "VaporPressureSaturationTsAvg"},
                { "e_Avg", "VaporPressureTsAvg"},
                { "e_sat", "VaporPressureSaturationTsAvg"},
                { "e", "VaporPressureTsAvg"},
                { "amb_press_Avg", "PressureAirTsAvg"},
                { "VPD_air", "VaporPressureDeficitAirTsAvg"},
                { "Ux_Avg", "WindSpeedSonicXTsAvg"},
                { "Ux_Std", "WindSpeedSonicXTsStdDev"},
                { "Uy_Avg", "WindSpeedSonicYTsAvg"},
                { "Uy_Std", "WindSpeedSonicYTsStdDev"},
                { "Uz_Avg", "WindSpeedSonicZTsAvg"},
                { "Uz_Std", "WindSpeedSonicZTsStdDev"},
                { "Ts_Avg", "TemperatureSonicTsAvg"},
                { "Ts_Std", "TemperatureSonicTsStdDev"},
                { "rslt_wnd_spd", "WindSpeedTsResultant"},
                { "std_wnd_dir", "WindDirectionTsStdDev"},
                { "wnd_dir_compass", "WindDirectionCompassTsAvg"},
                { "CO2_molfrac_Avg", "CO2MolFractionWetTsAvg"},
                { "CO2_mixratio_Avg", "CO2MixingRatioDryTsAvg"},
                { "CO2_Avg", "CO2MassDensityTsAvg"},
                { "CO2_Std", "CO2MassDensityTsStdDev"},
                { "H2O_molfrac_Avg", "H2OMolFractionWetTsAvg"},
                { "H2O_mixratio_Avg", "H2OMixingRatioDryTsAvg"},
                { "H2O_Avg", "H2OMassDensityTsAvg"},
                { "H2O_Std", "H2OMassDensityTsStdDev"},
                { "CO2_sig_strgth_Min", "CO2SignalStrengthTsMin"},
                { "H2O_sig_strgth_Min", "H2OSignalStrengthTsMin"},
                { "T_probe_Avg", "TemperatureProbeTsAvg"},
                { "Td_probe_Avg", "TemperatureDewpointProbeTsAvg"},
                { "RH_probe_Avg", "RelativeHumidityProbeTsAvg"},
                { "Precipitation_Tot", "PrecipitationTsAccum"},
                { "PAR_density_Avg", "ParDensityTsAvg"},
                { "Tsoil_Avg", "TemperatureSoilTsAvg"},
                { "tdr315_wc_Avg(1)", "VwcSoil5cmTsAvg"},
                { "tdr315_tmpr_Avg(1)", "TemperatureSoil5cmTsAvg"},
                { "tdr315_E_Avg(1)", "PermittivitySoil5cmTsAvg"},
                { "tdr315_bulkEC_Avg(1)", "ElectricConductivityBulkSoil5cmTsAvg"},
                { "tdr315_poreEC_Avg(1)", "ElectricConductivityPoreSoil5cmTsAvg"},
                { "tdr31X_wc_Avg", "VwcSoil5cmTsAvg"},
                { "tdr31X_tmpr_Avg", "TemperatureSoil5cmTsAvg"},
                { "tdr31X_E_Avg", "PermittivitySoil5cmTsAvg"},
                { "tdr31X_bulkEC_Avg", "ElectricConductivityBulkSoil5cmTsAvg"},
                { "tdr31X_poreEC_Avg", "ElectricConductivityPoreSoil5cmTsAvg"},
                { "profile_tdr315_wc_Avg(1)", "VwcSoil15cmTsAvg"},
                { "profile_tdr315_wc_Avg(2)", "VwcSoil30cmTsAvg"},
                { "profile_tdr315_wc_Avg(3)", "VwcSoil60cmTsAvg"},
                { "profile_tdr315_wc_Avg(4)", "VwcSoil90cmTsAvg"},
                { "profile_tdr315_wc_Avg(5)", "VwcSoil120cmTsAvg"},
                { "profile_tdr315_wc_Avg(6)", "VwcSoil150cmTsAvg"},
                { "profile_tdr315_tmpr_Avg(1)", "TemperatureSoil15cmTsAvg"},
                { "profile_tdr315_tmpr_Avg(2)", "TemperatureSoil30cmTsAvg"},
                { "profile_tdr315_tmpr_Avg(3)", "TemperatureSoil60cmTsAvg"},
                { "profile_tdr315_tmpr_Avg(4)", "TemperatureSoil90cmTsAvg"},
                { "profile_tdr315_tmpr_Avg(5)", "TemperatureSoil120cmTsAvg"},
                { "profile_tdr315_tmpr_Avg(6)", "TemperatureSoil150cmTsAvg"},
                { "profile_tdr315_E_Avg(1)", "PermittivitySoil15cmTsAvg"},
                { "profile_tdr315_E_Avg(2)", "PermittivitySoil30cmTsAvg"},
                { "profile_tdr315_E_Avg(3)", "PermittivitySoil60cmTsAvg"},
                { "profile_tdr315_E_Avg(4)", "PermittivitySoil90cmTsAvg"},
                { "profile_tdr315_E_Avg(5)", "PermittivitySoil120cmTsAvg"},
                { "profile_tdr315_E_Avg(6)", "PermittivitySoil150cmTsAvg"},
                { "profile_tdr315_bulkEC_Avg(1)", "ElectricConductivityBulkSoil15cmTsAvg"},
                { "profile_tdr315_bulkEC_Avg(2)", "ElectricConductivityBulkSoil30cmTsAvg"},
                { "profile_tdr315_bulkEC_Avg(3)", "ElectricConductivityBulkSoil60cmTsAvg"},
                { "profile_tdr315_bulkEC_Avg(4)", "ElectricConductivityBulkSoil90cmTsAvg"},
                { "profile_tdr315_bulkEC_Avg(5)", "ElectricConductivityBulkSoil120cmTsAvg"},
                { "profile_tdr315_bulkEC_Avg(6)", "ElectricConductivityBulkSoil150cmTsAvg"},
                { "profile_tdr315_poreEC_Avg(1)", "ElectricConductivityPoreSoil15cmTsAvg"},
                { "profile_tdr315_poreEC_Avg(2)", "ElectricConductivityPoreSoil30cmTsAvg"},
                { "profile_tdr315_poreEC_Avg(3)", "ElectricConductivityPoreSoil60cmTsAvg"},
                { "profile_tdr315_poreEC_Avg(4)", "ElectricConductivityPoreSoil90cmTsAvg"},
                { "profile_tdr315_poreEC_Avg(5)", "ElectricConductivityPoreSoil120cmTsAvg"},
                { "profile_tdr315_poreEC_Avg(6)", "ElectricConductivityPoreSoil150cmTsAvg"},
                { "profile_tdr31X_wc_Avg(1)", "VwcSoil15cmTsAvg"},
                { "profile_tdr31X_wc_Avg(2)", "VwcSoil30cmTsAvg"},
                { "profile_tdr31X_wc_Avg(3)", "VwcSoil60cmTsAvg"},
                { "profile_tdr31X_wc_Avg(4)", "VwcSoil90cmTsAvg"},
                { "profile_tdr31X_wc_Avg(5)", "VwcSoil120cmTsAvg"},
                { "profile_tdr31X_wc_Avg(6)", "VwcSoil150cmTsAvg"},
                { "profile_tdr31X_tmpr_Avg(1)", "TemperatureSoil15cmTsAvg"},
                { "profile_tdr31X_tmpr_Avg(2)", "TemperatureSoil30cmTsAvg"},
                { "profile_tdr31X_tmpr_Avg(3)", "TemperatureSoil60cmTsAvg"},
                { "profile_tdr31X_tmpr_Avg(4)", "TemperatureSoil90cmTsAvg"},
                { "profile_tdr31X_tmpr_Avg(5)", "TemperatureSoil120cmTsAvg"},
                { "profile_tdr31X_tmpr_Avg(6)", "TemperatureSoil150cmTsAvg"},
                { "profile_tdr31X_E_Avg(1)", "PermittivitySoil15cmTsAvg"},
                { "profile_tdr31X_E_Avg(2)", "PermittivitySoil30cmTsAvg"},
                { "profile_tdr31X_E_Avg(3)", "PermittivitySoil60cmTsAvg"},
                { "profile_tdr31X_E_Avg(4)", "PermittivitySoil90cmTsAvg"},
                { "profile_tdr31X_E_Avg(5)", "PermittivitySoil120cmTsAvg"},
                { "profile_tdr31X_E_Avg(6)", "PermittivitySoil150cmTsAvg"},
                { "profile_tdr31X_bulkEC_Avg(1)", "ElectricConductivityBulkSoil15cmTsAvg"},
                { "profile_tdr31X_bulkEC_Avg(2)", "ElectricConductivityBulkSoil30cmTsAvg"},
                { "profile_tdr31X_bulkEC_Avg(3)", "ElectricConductivityBulkSoil60cmTsAvg"},
                { "profile_tdr31X_bulkEC_Avg(4)", "ElectricConductivityBulkSoil90cmTsAvg"},
                { "profile_tdr31X_bulkEC_Avg(5)", "ElectricConductivityBulkSoil120cmTsAvg"},
                { "profile_tdr31X_bulkEC_Avg(6)", "ElectricConductivityBulkSoil150cmTsAvg"},
                { "profile_tdr31X_poreEC_Avg(1)", "ElectricConductivityPoreSoil15cmTsAvg"},
                { "profile_tdr31X_poreEC_Avg(2)", "ElectricConductivityPoreSoil30cmTsAvg"},
                { "profile_tdr31X_poreEC_Avg(3)", "ElectricConductivityPoreSoil60cmTsAvg"},
                { "profile_tdr31X_poreEC_Avg(4)", "ElectricConductivityPoreSoil90cmTsAvg"},
                { "profile_tdr31X_poreEC_Avg(5)", "ElectricConductivityPoreSoil120cmTsAvg"},
                { "profile_tdr31X_poreEC_Avg(6)", "ElectricConductivityPoreSoil150cmTsAvg"},
                { "shf_plate_avg", "HeatFluxSoilTsAvg"},
                { "FP_max", "FootprintContributionDistMaxTsAvg"},
                { "FP_40", "FootprintContributionDist40PercTsAvg"},
                { "FP_55", "FootprintContributionDist55PercTsAvg"},
                { "FP_90", "FootprintContributionDist90PercTsAvg"},
                { "u_Avg_R", "WindSpeedAlongStreamlineTsAvg"},
                { "u_Std_R", "WindSpeedAlongStreamlineTsStdDev"},
                { "v_Avg_R", "WindSpeedAcrossSteamlineTsAvg"},
                { "v_Std_R", "WindSpeedAcrossStreamlineTsStdDev"},
                { "w_Avg_R", "WindSpeedVerticalVelocityTsAvg"},
                { "w_Std_R", "WindSpeedVerticalVelocityTsStdDev"},
                { "uv_Cov_R", "MomentumFluxUVTsCovar"},
                { "uw_Cov_R", "MomentumFluxUWTsCovar"},
                { "vw_Cov_R", "MomentumFluxVWTsCovar"},
                { "wTs_Cov_R_F_SND", "HeatFluxKinematicWTTsCovar"},
                { "sonic_samples_Tot", "SonicAnemometerSampleCountTsAccum"},
                { "wCO2_Cov_R_F", "CO2FluxWCTsCovar"},
                { "wH2O_Cov_R_F", "H2OFluxWQTsCovar"},
                { "CO2_samples_Tot", "CO2SampleCountTsAccum"},
                { "H2O_samples_Tot", "H2OSampleCountTsAccum"},
                { "height_measurement", "HeightECMeasurement"},
                { "height_canopy", "HeightCanopy"},
                { "d", "HeightDisplacement"},
                { "z0", "RoughnessLength"},
                { "z", "HeightAerodynamic"},
                { "L", "ObukhovLength"},
                { "stability_zL", "StabilitySurfaceLayerParameterTsAvg"},
                { "rho_d_Avg", "DensityAirDryTsAvg"},
                { "rho_a_Avg", "DensityAirWetTsAvg"},
                { "door_is_open_Hst", "WasEnclosureOpenedTsAvg"},
                { "panel_tmpr_Avg", "TemperaturePanelTsAvg"},
                { "batt_volt_Avg", "BatteryVoltageTsAvg"},
                { "Rn_meas_Avg", "RadiationNetTsAvg"}
            };
        }
        private Dictionary<string, string> getMapStationNameToFieldId()
        {
            return new Dictionary<string, string>()
            {
                {"LTAR_CookEast", "CookEast" },
                {"LTAR_CookWest", "CookWest" },
                {"LTAR_BoydNorth", "BoydNorth" },
                {"LTAR_BoydSouth", "BoydSouth" }
            };
        }
        private string getStationMapJson()
        {
            return "{\"stations\":[{\"name\":\"LTAR_CookEast\",\"lat\":46.78152,\"lon\":-117.08205},{\"name\":\"LTAR_CookWest\",\"lat\":46.78404,\"lon\":-117.09083},{\"name\":\"LTAR_BoydNorth\",\"lat\":46.7551,\"lon\":-117.12605},{\"name\":\"LTAR_BoydSouth\",\"lat\":46.7503,\"lon\":-117.1285}]}";
        }
    }
}
