using Caf.Etl.Models.LoggerNet.TOA5;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Models.LoggerNet.TOA5.DataTables
{
    /// <summary></summary>
    public class Flux : IObservation, IEquatable<Flux>
    {
        /// <summary></summary>
        public DateTime TIMESTAMP{ get; set; }
        /// <summary></summary>
        public int RECORD{ get; set; }
        /// <summary></summary>
        public double? old_L{ get; set; }
        /// <summary></summary>
        public double? old_u_star{ get; set; }
        /// <summary></summary>
        public double? old_Fc_wpl{ get; set; }
        /// <summary></summary>
        public double? old_Fc_hf_wpl{ get; set; }
        /// <summary></summary>
        public double? old_LE_wpl{ get; set; }
        /// <summary></summary>
        public double? old_Hc{ get; set; }
        /// <summary></summary>
        public double? old_Uz_Std{ get; set; }
        /// <summary></summary>
        public double? old_CO2_mg_m3_Avg{ get; set; }
        /// <summary></summary>
        public double? old_CO2_mg_m3_Std{ get; set; }
        /// <summary></summary>
        public double? old_CO2_hf_mg_m3_Avg{ get; set; }
        /// <summary></summary>
        public double? old_CO2_hf_mg_m3_Std{ get; set; }
        /// <summary></summary>
        public double? old_Tc_Avg{ get; set; }
        /// <summary></summary>
        public double? old_amb_press_Avg{ get; set; }
        /// <summary></summary>
        public double? Fc_molar{ get; set; }
        /// <summary></summary>
        public double? Fc_mass{ get; set; }
        /// <summary></summary>
        public double? Fc_qc_grade{ get; set; }
        /// <summary></summary>
        public double? Fc_samples_Tot{ get; set; }
        /// <summary></summary>
        public double? LE{ get; set; }
        /// <summary></summary>
        public double? LE_qc_grade{ get; set; }
        /// <summary></summary>
        public double? LE_samples_Tot{ get; set; }
        /// <summary></summary>
        public double? H{ get; set; }
        /// <summary></summary>
        public double? H_qc_grade{ get; set; }
        /// <summary></summary>
        public double? H_samples_Tot{ get; set; }
        /// <summary></summary>
        public double? Rn{ get; set; }
        /// <summary></summary>
        public double? G_surface{ get; set; }
        /// <summary></summary>
        public double? energy_closure{ get; set; }
        /// <summary></summary>
        public double? Bowen_ratio{ get; set; }
        /// <summary></summary>
        public double? tau{ get; set; }
        /// <summary></summary>
        public double? tau_qc_grade{ get; set; }
        /// <summary></summary>
        public double? u_star{ get; set; }
        /// <summary></summary>
        public double? T_star{ get; set; }
        /// <summary></summary>
        public double? TKE{ get; set; }
        /// <summary></summary>
        public double? amb_tmpr_Avg{ get; set; }
        /// <summary></summary>
        public double? Td_Avg{ get; set; }
        /// <summary></summary>
        public double? RH_Avg{ get; set; }
        /// <summary></summary>
        public double? e_sat_Avg{ get; set; }
        /// <summary></summary>
        public double? e_Avg{ get; set; }
        /// <summary></summary>
        public double? amb_press_Avg{ get; set; }
        /// <summary></summary>
        public double? VPD_air{ get; set; }
        /// <summary></summary>
        public double? Ux_Avg{ get; set; }
        /// <summary></summary>
        public double? Ux_Std{ get; set; }
        /// <summary></summary>
        public double? Uy_Avg{ get; set; }
        /// <summary></summary>
        public double? Uy_Std{ get; set; }
        /// <summary></summary>
        public double? Uz_Avg{ get; set; }
        /// <summary></summary>
        public double? Uz_Std{ get; set; }
        /// <summary></summary>
        public double? Ts_Avg{ get; set; }
        /// <summary></summary>
        public double? Ts_Std{ get; set; }
        /// <summary></summary>
        public double? sonic_azimuth{ get; set; }
        /// <summary></summary>
        public double? wnd_spd{ get; set; }
        /// <summary></summary>
        public double? rslt_wnd_spd{ get; set; }
        /// <summary></summary>
        public double? wnd_dir_sonic{ get; set; }
        /// <summary></summary>
        public double? std_wnd_dir{ get; set; }
        /// <summary></summary>
        public double? wnd_dir_compass{ get; set; }
        /// <summary></summary>
        public double? CO2_molfrac_Avg{ get; set; }
        /// <summary></summary>
        public double? CO2_mixratio_Avg{ get; set; }
        /// <summary></summary>
        public double? CO2_Avg{ get; set; }
        /// <summary></summary>
        public double? CO2_Std{ get; set; }
        /// <summary></summary>
        public double? H2O_molfrac_Avg{ get; set; }
        /// <summary></summary>
        public double? H2O_mixratio_Avg{ get; set; }
        /// <summary></summary>
        public double? H2O_Avg{ get; set; }
        /// <summary></summary>
        public double? H2O_Std{ get; set; }
        /// <summary></summary>
        public double? CO2_sig_strgth_Min{ get; set; }
        /// <summary></summary>
        public double? H2O_sig_strgth_Min{ get; set; }
        /// <summary></summary>
        public double? T_probe_Avg{ get; set; }
        /// <summary></summary>
        public double? e_probe_Avg{ get; set; }
        /// <summary></summary>
        public double? e_sat_probe_Avg{ get; set; }
        /// <summary></summary>
        public double? Td_probe_Avg{ get; set; }
        /// <summary></summary>
        public double? H2O_probe_Avg{ get; set; }
        /// <summary></summary>
        public double? RH_probe_Avg{ get; set; }
        /// <summary></summary>
        public double? rho_a_probe_Avg{ get; set; }
        /// <summary></summary>
        public double? rho_d_probe_Avg{ get; set; }
        /// <summary></summary>
        public double? Precipitation_Tot{ get; set; }
        /// <summary></summary>
        public double? Rn_meas_Avg{ get; set; }
        /// <summary></summary>
        public double? NRLITE_SENS{ get; set; }
        /// <summary></summary>
        public double? PAR_density_Avg{ get; set; }
        /// <summary></summary>
        public double? QUANTUM_SENS{ get; set; }
        /// <summary></summary>
        public double? cupvane_WS_Avg{ get; set; }
        /// <summary></summary>
        public double? cupvane_WS_rslt_Avg{ get; set; }
        /// <summary></summary>
        public double? cupvane_WD_rslt_Avg{ get; set; }
        /// <summary></summary>
        public double? cupvane_WD_csi_Std{ get; set; }
        /// <summary></summary>
        public double? Tsoil_Avg{ get; set; }
        
        public double? tdr31X_wc_Avg{ get; set; }
        public double? tdr31X_tmpr_Avg{ get; set; }
        public double? tdr31X_E_Avg{ get; set; }
        public double? tdr31X_bulkEC_Avg{ get; set; }
        public double? tdr31X_poreEC_Avg{ get; set; }

        /// <summary></summary>
        public double? tdr315_wc_Avg1{ get; set; }
        public double? tdr31X_wc_Avg1 { get; set; }
        /// <summary></summary>
        public double? tdr315_wc_Avg2{ get; set; }
        public double? tdr31X_wc_Avg2{ get; set; }
        /// <summary></summary>
        public double? tdr315_tmpr_Avg1{ get; set; }
        public double? tdr31X_tmpr_Avg1{ get; set; }
        /// <summary></summary>
        public double? tdr315_tmpr_Avg2{ get; set; }
        public double? tdr31X_tmpr_Avg2{ get; set; }
        /// <summary></summary>
        public double? tdr315_E_Avg1{ get; set; }
        public double? tdr31X_E_Avg1{ get; set; }
        /// <summary></summary>
        public double? tdr315_E_Avg2{ get; set; }
        public double? tdr31X_E_Avg2{ get; set; }
        /// <summary></summary>
        public double? tdr315_bulkEC_Avg1{ get; set; }
        public double? tdr31X_bulkEC_Avg1{ get; set; }
        /// <summary></summary>
        public double? tdr315_bulkEC_Avg2{ get; set; }
        public double? tdr31X_bulkEC_Avg2{ get; set; }
        /// <summary></summary>
        public double? tdr315_poreEC_Avg1{ get; set; }
        public double? tdr31X_poreEC_Avg1{ get; set; }
        /// <summary></summary>
        public double? tdr315_poreEC_Avg2{ get; set; }
        public double? tdr31X_poreEC_Avg2{ get; set; }
        /// <summary></summary>
        public double? shf_plate_avg{ get; set; }
        /// <summary></summary>
        public double? SHFP_1_SENS{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_wc_Avg1{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_wc_Avg2{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_wc_Avg3{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_wc_Avg4{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_wc_Avg5{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_wc_Avg6{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_tmpr_Avg1{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_tmpr_Avg2{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_tmpr_Avg3{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_tmpr_Avg4{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_tmpr_Avg5{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_tmpr_Avg6{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_E_Avg1{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_E_Avg2{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_E_Avg3{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_E_Avg4{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_E_Avg5{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_E_Avg6{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_bulkEC_Avg1{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_bulkEC_Avg2{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_bulkEC_Avg3{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_bulkEC_Avg4{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_bulkEC_Avg5{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_bulkEC_Avg6{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_poreEC_Avg1{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_poreEC_Avg2{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_poreEC_Avg3{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_poreEC_Avg4{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_poreEC_Avg5{ get; set; }
        /// <summary></summary>
        public double? profile_tdr315_poreEC_Avg6{ get; set; }
        public double? profile_tdr31X_wc_Avg1{ get; set; }
        public double? profile_tdr31X_wc_Avg2{ get; set; }
        public double? profile_tdr31X_wc_Avg3{ get; set; }
        public double? profile_tdr31X_wc_Avg4{ get; set; }
        public double? profile_tdr31X_wc_Avg5{ get; set; }
        public double? profile_tdr31X_wc_Avg6{ get; set; }
        public double? profile_tdr31X_tmpr_Avg1{ get; set; }
        public double? profile_tdr31X_tmpr_Avg2{ get; set; }
        public double? profile_tdr31X_tmpr_Avg3{ get; set; }
        public double? profile_tdr31X_tmpr_Avg4{ get; set; }
        public double? profile_tdr31X_tmpr_Avg5{ get; set; }
        public double? profile_tdr31X_tmpr_Avg6{ get; set; }
        public double? profile_tdr31X_E_Avg1{ get; set; }
        public double? profile_tdr31X_E_Avg2{ get; set; }
        public double? profile_tdr31X_E_Avg3{ get; set; }
        public double? profile_tdr31X_E_Avg4{ get; set; }
        public double? profile_tdr31X_E_Avg5{ get; set; }
        public double? profile_tdr31X_E_Avg6{ get; set; }
        public double? profile_tdr31X_bulkEC_Avg1{ get; set; }
        public double? profile_tdr31X_bulkEC_Avg2{ get; set; }
        public double? profile_tdr31X_bulkEC_Avg3{ get; set; }
        public double? profile_tdr31X_bulkEC_Avg4{ get; set; }
        public double? profile_tdr31X_bulkEC_Avg5{ get; set; }
        public double? profile_tdr31X_bulkEC_Avg6{ get; set; }
        public double? profile_tdr31X_poreEC_Avg1{ get; set; }
        public double? profile_tdr31X_poreEC_Avg2{ get; set; }
        public double? profile_tdr31X_poreEC_Avg3{ get; set; }
        public double? profile_tdr31X_poreEC_Avg4{ get; set; }
        public double? profile_tdr31X_poreEC_Avg5{ get; set; }
        public double? profile_tdr31X_poreEC_Avg6{ get; set; }
        /// <summary></summary>
        public double? upwnd_dist_intrst{ get; set; }
        /// <summary></summary>
        public double? FP_dist_intrst{ get; set; }
        /// <summary></summary>
        public double? FP_max{ get; set; }
        /// <summary></summary>
        public double? FP_40{ get; set; }
        /// <summary></summary>
        public double? FP_55{ get; set; }
        /// <summary></summary>
        public double? FP_90{ get; set; }
        /// <summary></summary>
        public string FP_Equation{ get; set; }
        /// <summary></summary>
        public double? UxUy_Cov{ get; set; }
        /// <summary></summary>
        public double? UxUz_Cov{ get; set; }
        /// <summary></summary>
        public double? UyUz_Cov{ get; set; }
        /// <summary></summary>
        public double? TsUx_Cov{ get; set; }
        /// <summary></summary>
        public double? TsUy_Cov{ get; set; }
        /// <summary></summary>
        public double? TsUz_Cov{ get; set; }
        /// <summary></summary>
        public double? u_star_R{ get; set; }
        /// <summary></summary>
        public double? u_Avg_R{ get; set; }
        /// <summary></summary>
        public double? u_Std_R{ get; set; }
        /// <summary></summary>
        public double? v_Avg_R{ get; set; }
        /// <summary></summary>
        public double? v_Std_R{ get; set; }
        /// <summary></summary>
        public double? w_Avg_R{ get; set; }
        /// <summary></summary>
        public double? w_Std_R{ get; set; }
        /// <summary></summary>
        public double? uv_Cov_R{ get; set; }
        /// <summary></summary>
        public double? uw_Cov_R{ get; set; }
        /// <summary></summary>
        public double? vw_Cov_R{ get; set; }
        /// <summary></summary>
        public double? uTs_Cov_R{ get; set; }
        /// <summary></summary>
        public double? vTs_Cov_R{ get; set; }
        /// <summary></summary>
        public double? wTs_Cov_R{ get; set; }
        /// <summary></summary>
        public double? uw_Cov_R_F{ get; set; }
        /// <summary></summary>
        public double? vw_Cov_R_F{ get; set; }
        /// <summary></summary>
        public double? wTs_Cov_R_F{ get; set; }
        /// <summary></summary>
        public double? wTs_Cov_R_F_SND{ get; set; }
        /// <summary></summary>
        public double? sonic_samples_Tot{ get; set; }
        /// <summary></summary>
        public double? no_sonic_head_Tot{ get; set; }
        /// <summary></summary>
        public double? no_new_sonic_data_Tot{ get; set; }
        /// <summary></summary>
        public double? sonic_amp_l_f_Tot{ get; set; }
        /// <summary></summary>
        public double? sonic_amp_h_f_Tot{ get; set; }
        /// <summary></summary>
        public double? sonic_sig_lck_f_Tot{ get; set; }
        /// <summary></summary>
        public double? sonic_del_T_f_Tot{ get; set; }
        /// <summary></summary>
        public double? sonic_aq_sig_f_Tot{ get; set; }
        /// <summary></summary>
        public double? sonic_cal_err_f_Tot{ get; set; }
        /// <summary></summary>
        public double? UxCO2_Cov{ get; set; }
        /// <summary></summary>
        public double? UyCO2_Cov{ get; set; }
        /// <summary></summary>
        public double? UzCO2_Cov{ get; set; }
        /// <summary></summary>
        public double? UxH2O_Cov{ get; set; }
        /// <summary></summary>
        public double? UyH2O_Cov{ get; set; }
        /// <summary></summary>
        public double? UzH2O_Cov{ get; set; }
        /// <summary></summary>
        public double? uCO2_Cov_R{ get; set; }
        /// <summary></summary>
        public double? vCO2_Cov_R{ get; set; }
        /// <summary></summary>
        public double? wCO2_Cov_R{ get; set; }
        /// <summary></summary>
        public double? uH2O_Cov_R{ get; set; }
        /// <summary></summary>
        public double? vH2O_Cov_R{ get; set; }
        /// <summary></summary>
        public double? wH2O_Cov_R{ get; set; }
        /// <summary></summary>
        public double? wCO2_Cov_R_F{ get; set; }
        /// <summary></summary>
        public double? wH2O_Cov_R_F{ get; set; }
        /// <summary></summary>
        public double? CO2_E_WPL_R_F{ get; set; }
        /// <summary></summary>
        public double? CO2_T_WPL_R_F{ get; set; }
        /// <summary></summary>
        public double? H2O_E_WPL_R_F{ get; set; }
        /// <summary></summary>
        public double? H2O_T_WPL_R_F{ get; set; }
        /// <summary></summary>
        public double? CO2_samples_Tot{ get; set; }
        /// <summary></summary>
        public double? H2O_samples_Tot{ get; set; }
        /// <summary></summary>
        public double? no_irga_head_Tot{ get; set; }
        /// <summary></summary>
        public double? no_new_irga_data_Tot{ get; set; }
        /// <summary></summary>
        public double? irga_bad_data_f_Tot{ get; set; }
        /// <summary></summary>
        public double? irga_gen_fault_f_Tot{ get; set; }
        /// <summary></summary>
        public double? irga_startup_f_Tot{ get; set; }
        /// <summary></summary>
        public double? irga_motor_spd_f_Tot{ get; set; }
        /// <summary></summary>
        public double? irga_tec_tmpr_f_Tot{ get; set; }
        /// <summary></summary>
        public double? irga_src_pwr_f_Tot{ get; set; }
        /// <summary></summary>
        public double? irga_src_tmpr_f_Tot{ get; set; }
        /// <summary></summary>
        public double? irga_src_curr_f_Tot{ get; set; }
        /// <summary></summary>
        public double? irga_off_f_Tot{ get; set; }
        /// <summary></summary>
        public double? irga_sync_f_Tot{ get; set; }
        /// <summary></summary>
        public double? irga_amb_tmpr_f_Tot{ get; set; }
        /// <summary></summary>
        public double? irga_amb_press_f_Tot{ get; set; }
        /// <summary></summary>
        public double? irga_CO2_I_f_Tot{ get; set; }
        /// <summary></summary>
        public double? irga_CO2_Io_f_Tot{ get; set; }
        /// <summary></summary>
        public double? irga_H2O_I_f_Tot{ get; set; }
        /// <summary></summary>
        public double? irga_H2O_Io_f_Tot{ get; set; }
        /// <summary></summary>
        public double? irga_CO2_Io_var_f_Tot{ get; set; }
        /// <summary></summary>
        public double? irga_H2O_Io_var_f_Tot{ get; set; }
        /// <summary></summary>
        public double? irga_CO2_sig_strgth_f_Tot{ get; set; }
        /// <summary></summary>
        public double? irga_H2O_sig_strgth_f_Tot{ get; set; }
        /// <summary></summary>
        public double? irga_cal_err_f_Tot{ get; set; }
        /// <summary></summary>
        public double? irga_htr_ctrl_off_f_Tot{ get; set; }
        /// <summary></summary>
        public double? alpha{ get; set; }
        /// <summary></summary>
        public double? beta{ get; set; }
        /// <summary></summary>
        public double? gamma{ get; set; }
        /// <summary></summary>
        public double? height_measurement{ get; set; }
        /// <summary></summary>
        public double? height_canopy{ get; set; }
        /// <summary></summary>
        public string surface_type_text{ get; set; }
        /// <summary></summary>
        public double? displacement_user{ get; set; }
        /// <summary></summary>
        public double? d{ get; set; }
        /// <summary></summary>
        public double? roughness_user{ get; set; }
        /// <summary></summary>
        public double? z0{ get; set; }
        /// <summary></summary>
        public double? z{ get; set; }
        /// <summary></summary>
        public double? L{ get; set; }
        /// <summary></summary>
        public double? stability_zL{ get; set; }
        /// <summary></summary>
        public double? iteration_FreqFactor{ get; set; }
        /// <summary></summary>
        public double? latitude{ get; set; }
        /// <summary></summary>
        public double? longitude{ get; set; }
        /// <summary></summary>
        public double? separation_x_irga{ get; set; }
        /// <summary></summary>
        public double? separation_y_irga{ get; set; }
        /// <summary></summary>
        public double? separation_lat_dist_irga{ get; set; }
        /// <summary></summary>
        public double? separation_lag_dist_irga{ get; set; }
        /// <summary></summary>
        public double? separation_lag_scan_irga{ get; set; }
        /// <summary></summary>
        public double? MAX_LAG{ get; set; }
        /// <summary></summary>
        public double? lag_irga{ get; set; }
        /// <summary></summary>
        public double? FreqFactor_uw_vw{ get; set; }
        /// <summary></summary>
        public double? FreqFactor_wTs{ get; set; }
        /// <summary></summary>
        public double? FreqFactor_wCO2_wH2O{ get; set; }
        /// <summary></summary>
        public double? rho_d_Avg{ get; set; }
        /// <summary></summary>
        public double? rho_a_Avg{ get; set; }
        /// <summary></summary>
        public double? Cp{ get; set; }
        /// <summary></summary>
        public double? Lv{ get; set; }
        /// <summary></summary>
        public double? door_is_open_Hst{ get; set; }
        /// <summary></summary>
        public double? panel_tmpr_Avg{ get; set; }
        /// <summary></summary>
        public double? batt_volt_Avg{ get; set; }
        /// <summary></summary>
        public double? slowsequence_Tot{ get; set; }
        /// <summary></summary>
        public double? process_time_Avg{ get; set; }
        /// <summary></summary>
        public double? process_time_Max{ get; set; }
        /// <summary></summary>
        public double? buff_depth_Max{ get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Flux);
        }

        public bool Equals(Flux other)
        {
            return other != null &&
                   TIMESTAMP == other.TIMESTAMP &&
                   RECORD == other.RECORD &&
                   EqualityComparer<double?>.Default.Equals(old_L, other.old_L) &&
                   EqualityComparer<double?>.Default.Equals(old_u_star, other.old_u_star) &&
                   EqualityComparer<double?>.Default.Equals(old_Fc_wpl, other.old_Fc_wpl) &&
                   EqualityComparer<double?>.Default.Equals(old_Fc_hf_wpl, other.old_Fc_hf_wpl) &&
                   EqualityComparer<double?>.Default.Equals(old_LE_wpl, other.old_LE_wpl) &&
                   EqualityComparer<double?>.Default.Equals(old_Hc, other.old_Hc) &&
                   EqualityComparer<double?>.Default.Equals(old_Uz_Std, other.old_Uz_Std) &&
                   EqualityComparer<double?>.Default.Equals(old_CO2_mg_m3_Avg, other.old_CO2_mg_m3_Avg) &&
                   EqualityComparer<double?>.Default.Equals(old_CO2_mg_m3_Std, other.old_CO2_mg_m3_Std) &&
                   EqualityComparer<double?>.Default.Equals(old_CO2_hf_mg_m3_Avg, other.old_CO2_hf_mg_m3_Avg) &&
                   EqualityComparer<double?>.Default.Equals(old_CO2_hf_mg_m3_Std, other.old_CO2_hf_mg_m3_Std) &&
                   EqualityComparer<double?>.Default.Equals(old_Tc_Avg, other.old_Tc_Avg) &&
                   EqualityComparer<double?>.Default.Equals(old_amb_press_Avg, other.old_amb_press_Avg) &&
                   EqualityComparer<double?>.Default.Equals(Fc_molar, other.Fc_molar) &&
                   EqualityComparer<double?>.Default.Equals(Fc_mass, other.Fc_mass) &&
                   EqualityComparer<double?>.Default.Equals(Fc_qc_grade, other.Fc_qc_grade) &&
                   EqualityComparer<double?>.Default.Equals(Fc_samples_Tot, other.Fc_samples_Tot) &&
                   EqualityComparer<double?>.Default.Equals(LE, other.LE) &&
                   EqualityComparer<double?>.Default.Equals(LE_qc_grade, other.LE_qc_grade) &&
                   EqualityComparer<double?>.Default.Equals(LE_samples_Tot, other.LE_samples_Tot) &&
                   EqualityComparer<double?>.Default.Equals(H, other.H) &&
                   EqualityComparer<double?>.Default.Equals(H_qc_grade, other.H_qc_grade) &&
                   EqualityComparer<double?>.Default.Equals(H_samples_Tot, other.H_samples_Tot) &&
                   EqualityComparer<double?>.Default.Equals(Rn, other.Rn) &&
                   EqualityComparer<double?>.Default.Equals(G_surface, other.G_surface) &&
                   EqualityComparer<double?>.Default.Equals(energy_closure, other.energy_closure) &&
                   EqualityComparer<double?>.Default.Equals(Bowen_ratio, other.Bowen_ratio) &&
                   EqualityComparer<double?>.Default.Equals(tau, other.tau) &&
                   EqualityComparer<double?>.Default.Equals(tau_qc_grade, other.tau_qc_grade) &&
                   EqualityComparer<double?>.Default.Equals(u_star, other.u_star) &&
                   EqualityComparer<double?>.Default.Equals(T_star, other.T_star) &&
                   EqualityComparer<double?>.Default.Equals(TKE, other.TKE) &&
                   EqualityComparer<double?>.Default.Equals(amb_tmpr_Avg, other.amb_tmpr_Avg) &&
                   EqualityComparer<double?>.Default.Equals(Td_Avg, other.Td_Avg) &&
                   EqualityComparer<double?>.Default.Equals(RH_Avg, other.RH_Avg) &&
                   EqualityComparer<double?>.Default.Equals(e_sat_Avg, other.e_sat_Avg) &&
                   EqualityComparer<double?>.Default.Equals(e_Avg, other.e_Avg) &&
                   EqualityComparer<double?>.Default.Equals(amb_press_Avg, other.amb_press_Avg) &&
                   EqualityComparer<double?>.Default.Equals(VPD_air, other.VPD_air) &&
                   EqualityComparer<double?>.Default.Equals(Ux_Avg, other.Ux_Avg) &&
                   EqualityComparer<double?>.Default.Equals(Ux_Std, other.Ux_Std) &&
                   EqualityComparer<double?>.Default.Equals(Uy_Avg, other.Uy_Avg) &&
                   EqualityComparer<double?>.Default.Equals(Uy_Std, other.Uy_Std) &&
                   EqualityComparer<double?>.Default.Equals(Uz_Avg, other.Uz_Avg) &&
                   EqualityComparer<double?>.Default.Equals(Uz_Std, other.Uz_Std) &&
                   EqualityComparer<double?>.Default.Equals(Ts_Avg, other.Ts_Avg) &&
                   EqualityComparer<double?>.Default.Equals(Ts_Std, other.Ts_Std) &&
                   EqualityComparer<double?>.Default.Equals(sonic_azimuth, other.sonic_azimuth) &&
                   EqualityComparer<double?>.Default.Equals(wnd_spd, other.wnd_spd) &&
                   EqualityComparer<double?>.Default.Equals(rslt_wnd_spd, other.rslt_wnd_spd) &&
                   EqualityComparer<double?>.Default.Equals(wnd_dir_sonic, other.wnd_dir_sonic) &&
                   EqualityComparer<double?>.Default.Equals(std_wnd_dir, other.std_wnd_dir) &&
                   EqualityComparer<double?>.Default.Equals(wnd_dir_compass, other.wnd_dir_compass) &&
                   EqualityComparer<double?>.Default.Equals(CO2_molfrac_Avg, other.CO2_molfrac_Avg) &&
                   EqualityComparer<double?>.Default.Equals(CO2_mixratio_Avg, other.CO2_mixratio_Avg) &&
                   EqualityComparer<double?>.Default.Equals(CO2_Avg, other.CO2_Avg) &&
                   EqualityComparer<double?>.Default.Equals(CO2_Std, other.CO2_Std) &&
                   EqualityComparer<double?>.Default.Equals(H2O_molfrac_Avg, other.H2O_molfrac_Avg) &&
                   EqualityComparer<double?>.Default.Equals(H2O_mixratio_Avg, other.H2O_mixratio_Avg) &&
                   EqualityComparer<double?>.Default.Equals(H2O_Avg, other.H2O_Avg) &&
                   EqualityComparer<double?>.Default.Equals(H2O_Std, other.H2O_Std) &&
                   EqualityComparer<double?>.Default.Equals(CO2_sig_strgth_Min, other.CO2_sig_strgth_Min) &&
                   EqualityComparer<double?>.Default.Equals(H2O_sig_strgth_Min, other.H2O_sig_strgth_Min) &&
                   EqualityComparer<double?>.Default.Equals(T_probe_Avg, other.T_probe_Avg) &&
                   EqualityComparer<double?>.Default.Equals(e_probe_Avg, other.e_probe_Avg) &&
                   EqualityComparer<double?>.Default.Equals(e_sat_probe_Avg, other.e_sat_probe_Avg) &&
                   EqualityComparer<double?>.Default.Equals(Td_probe_Avg, other.Td_probe_Avg) &&
                   EqualityComparer<double?>.Default.Equals(H2O_probe_Avg, other.H2O_probe_Avg) &&
                   EqualityComparer<double?>.Default.Equals(RH_probe_Avg, other.RH_probe_Avg) &&
                   EqualityComparer<double?>.Default.Equals(rho_a_probe_Avg, other.rho_a_probe_Avg) &&
                   EqualityComparer<double?>.Default.Equals(rho_d_probe_Avg, other.rho_d_probe_Avg) &&
                   EqualityComparer<double?>.Default.Equals(Precipitation_Tot, other.Precipitation_Tot) &&
                   EqualityComparer<double?>.Default.Equals(Rn_meas_Avg, other.Rn_meas_Avg) &&
                   EqualityComparer<double?>.Default.Equals(NRLITE_SENS, other.NRLITE_SENS) &&
                   EqualityComparer<double?>.Default.Equals(PAR_density_Avg, other.PAR_density_Avg) &&
                   EqualityComparer<double?>.Default.Equals(QUANTUM_SENS, other.QUANTUM_SENS) &&
                   EqualityComparer<double?>.Default.Equals(cupvane_WS_Avg, other.cupvane_WS_Avg) &&
                   EqualityComparer<double?>.Default.Equals(cupvane_WS_rslt_Avg, other.cupvane_WS_rslt_Avg) &&
                   EqualityComparer<double?>.Default.Equals(cupvane_WD_rslt_Avg, other.cupvane_WD_rslt_Avg) &&
                   EqualityComparer<double?>.Default.Equals(cupvane_WD_csi_Std, other.cupvane_WD_csi_Std) &&
                   EqualityComparer<double?>.Default.Equals(Tsoil_Avg, other.Tsoil_Avg) &&
                   EqualityComparer<double?>.Default.Equals(tdr315_wc_Avg1, other.tdr315_wc_Avg1) &&
                   EqualityComparer<double?>.Default.Equals(tdr31X_wc_Avg1, other.tdr31X_wc_Avg1) &&
                   EqualityComparer<double?>.Default.Equals(tdr315_wc_Avg2, other.tdr315_wc_Avg2) &&
                   EqualityComparer<double?>.Default.Equals(tdr31X_wc_Avg2, other.tdr31X_wc_Avg2) &&
                   EqualityComparer<double?>.Default.Equals(tdr315_tmpr_Avg1, other.tdr315_tmpr_Avg1) &&
                   EqualityComparer<double?>.Default.Equals(tdr31X_tmpr_Avg1, other.tdr31X_tmpr_Avg1) &&
                   EqualityComparer<double?>.Default.Equals(tdr315_tmpr_Avg2, other.tdr315_tmpr_Avg2) &&
                   EqualityComparer<double?>.Default.Equals(tdr31X_tmpr_Avg2, other.tdr31X_tmpr_Avg2) &&
                   EqualityComparer<double?>.Default.Equals(tdr315_E_Avg1, other.tdr315_E_Avg1) &&
                   EqualityComparer<double?>.Default.Equals(tdr31X_E_Avg1, other.tdr31X_E_Avg1) &&
                   EqualityComparer<double?>.Default.Equals(tdr315_E_Avg2, other.tdr315_E_Avg2) &&
                   EqualityComparer<double?>.Default.Equals(tdr31X_E_Avg2, other.tdr31X_E_Avg2) &&
                   EqualityComparer<double?>.Default.Equals(tdr315_bulkEC_Avg1, other.tdr315_bulkEC_Avg1) &&
                   EqualityComparer<double?>.Default.Equals(tdr31X_bulkEC_Avg1, other.tdr31X_bulkEC_Avg1) &&
                   EqualityComparer<double?>.Default.Equals(tdr315_bulkEC_Avg2, other.tdr315_bulkEC_Avg2) &&
                   EqualityComparer<double?>.Default.Equals(tdr31X_bulkEC_Avg2, other.tdr31X_bulkEC_Avg2) &&
                   EqualityComparer<double?>.Default.Equals(tdr315_poreEC_Avg1, other.tdr315_poreEC_Avg1) &&
                   EqualityComparer<double?>.Default.Equals(tdr31X_poreEC_Avg1, other.tdr31X_poreEC_Avg1) &&
                   EqualityComparer<double?>.Default.Equals(tdr315_poreEC_Avg2, other.tdr315_poreEC_Avg2) &&
                   EqualityComparer<double?>.Default.Equals(tdr31X_poreEC_Avg2, other.tdr31X_poreEC_Avg2) &&
                   EqualityComparer<double?>.Default.Equals(shf_plate_avg, other.shf_plate_avg) &&
                   EqualityComparer<double?>.Default.Equals(SHFP_1_SENS, other.SHFP_1_SENS) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_wc_Avg1, other.profile_tdr315_wc_Avg1) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_wc_Avg2, other.profile_tdr315_wc_Avg2) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_wc_Avg3, other.profile_tdr315_wc_Avg3) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_wc_Avg4, other.profile_tdr315_wc_Avg4) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_wc_Avg5, other.profile_tdr315_wc_Avg5) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_wc_Avg6, other.profile_tdr315_wc_Avg6) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_tmpr_Avg1, other.profile_tdr315_tmpr_Avg1) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_tmpr_Avg2, other.profile_tdr315_tmpr_Avg2) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_tmpr_Avg3, other.profile_tdr315_tmpr_Avg3) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_tmpr_Avg4, other.profile_tdr315_tmpr_Avg4) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_tmpr_Avg5, other.profile_tdr315_tmpr_Avg5) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_tmpr_Avg6, other.profile_tdr315_tmpr_Avg6) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_E_Avg1, other.profile_tdr315_E_Avg1) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_E_Avg2, other.profile_tdr315_E_Avg2) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_E_Avg3, other.profile_tdr315_E_Avg3) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_E_Avg4, other.profile_tdr315_E_Avg4) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_E_Avg5, other.profile_tdr315_E_Avg5) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_E_Avg6, other.profile_tdr315_E_Avg6) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_bulkEC_Avg1, other.profile_tdr315_bulkEC_Avg1) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_bulkEC_Avg2, other.profile_tdr315_bulkEC_Avg2) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_bulkEC_Avg3, other.profile_tdr315_bulkEC_Avg3) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_bulkEC_Avg4, other.profile_tdr315_bulkEC_Avg4) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_bulkEC_Avg5, other.profile_tdr315_bulkEC_Avg5) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_bulkEC_Avg6, other.profile_tdr315_bulkEC_Avg6) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_poreEC_Avg1, other.profile_tdr315_poreEC_Avg1) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_poreEC_Avg2, other.profile_tdr315_poreEC_Avg2) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_poreEC_Avg3, other.profile_tdr315_poreEC_Avg3) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_poreEC_Avg4, other.profile_tdr315_poreEC_Avg4) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_poreEC_Avg5, other.profile_tdr315_poreEC_Avg5) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr315_poreEC_Avg6, other.profile_tdr315_poreEC_Avg6) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_wc_Avg1, other.profile_tdr31X_wc_Avg1) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_wc_Avg2, other.profile_tdr31X_wc_Avg2) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_wc_Avg3, other.profile_tdr31X_wc_Avg3) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_wc_Avg4, other.profile_tdr31X_wc_Avg4) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_wc_Avg5, other.profile_tdr31X_wc_Avg5) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_wc_Avg6, other.profile_tdr31X_wc_Avg6) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_tmpr_Avg1, other.profile_tdr31X_tmpr_Avg1) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_tmpr_Avg2, other.profile_tdr31X_tmpr_Avg2) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_tmpr_Avg3, other.profile_tdr31X_tmpr_Avg3) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_tmpr_Avg4, other.profile_tdr31X_tmpr_Avg4) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_tmpr_Avg5, other.profile_tdr31X_tmpr_Avg5) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_tmpr_Avg6, other.profile_tdr31X_tmpr_Avg6) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_E_Avg1, other.profile_tdr31X_E_Avg1) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_E_Avg2, other.profile_tdr31X_E_Avg2) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_E_Avg3, other.profile_tdr31X_E_Avg3) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_E_Avg4, other.profile_tdr31X_E_Avg4) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_E_Avg5, other.profile_tdr31X_E_Avg5) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_E_Avg6, other.profile_tdr31X_E_Avg6) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_bulkEC_Avg1, other.profile_tdr31X_bulkEC_Avg1) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_bulkEC_Avg2, other.profile_tdr31X_bulkEC_Avg2) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_bulkEC_Avg3, other.profile_tdr31X_bulkEC_Avg3) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_bulkEC_Avg4, other.profile_tdr31X_bulkEC_Avg4) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_bulkEC_Avg5, other.profile_tdr31X_bulkEC_Avg5) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_bulkEC_Avg6, other.profile_tdr31X_bulkEC_Avg6) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_poreEC_Avg1, other.profile_tdr31X_poreEC_Avg1) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_poreEC_Avg2, other.profile_tdr31X_poreEC_Avg2) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_poreEC_Avg3, other.profile_tdr31X_poreEC_Avg3) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_poreEC_Avg4, other.profile_tdr31X_poreEC_Avg4) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_poreEC_Avg5, other.profile_tdr31X_poreEC_Avg5) &&
                   EqualityComparer<double?>.Default.Equals(profile_tdr31X_poreEC_Avg6, other.profile_tdr31X_poreEC_Avg6) &&
                   EqualityComparer<double?>.Default.Equals(upwnd_dist_intrst, other.upwnd_dist_intrst) &&
                   EqualityComparer<double?>.Default.Equals(FP_dist_intrst, other.FP_dist_intrst) &&
                   EqualityComparer<double?>.Default.Equals(FP_max, other.FP_max) &&
                   EqualityComparer<double?>.Default.Equals(FP_40, other.FP_40) &&
                   EqualityComparer<double?>.Default.Equals(FP_55, other.FP_55) &&
                   EqualityComparer<double?>.Default.Equals(FP_90, other.FP_90) &&
                   FP_Equation == other.FP_Equation &&
                   EqualityComparer<double?>.Default.Equals(UxUy_Cov, other.UxUy_Cov) &&
                   EqualityComparer<double?>.Default.Equals(UxUz_Cov, other.UxUz_Cov) &&
                   EqualityComparer<double?>.Default.Equals(UyUz_Cov, other.UyUz_Cov) &&
                   EqualityComparer<double?>.Default.Equals(TsUx_Cov, other.TsUx_Cov) &&
                   EqualityComparer<double?>.Default.Equals(TsUy_Cov, other.TsUy_Cov) &&
                   EqualityComparer<double?>.Default.Equals(TsUz_Cov, other.TsUz_Cov) &&
                   EqualityComparer<double?>.Default.Equals(u_star_R, other.u_star_R) &&
                   EqualityComparer<double?>.Default.Equals(u_Avg_R, other.u_Avg_R) &&
                   EqualityComparer<double?>.Default.Equals(u_Std_R, other.u_Std_R) &&
                   EqualityComparer<double?>.Default.Equals(v_Avg_R, other.v_Avg_R) &&
                   EqualityComparer<double?>.Default.Equals(v_Std_R, other.v_Std_R) &&
                   EqualityComparer<double?>.Default.Equals(w_Avg_R, other.w_Avg_R) &&
                   EqualityComparer<double?>.Default.Equals(w_Std_R, other.w_Std_R) &&
                   EqualityComparer<double?>.Default.Equals(uv_Cov_R, other.uv_Cov_R) &&
                   EqualityComparer<double?>.Default.Equals(uw_Cov_R, other.uw_Cov_R) &&
                   EqualityComparer<double?>.Default.Equals(vw_Cov_R, other.vw_Cov_R) &&
                   EqualityComparer<double?>.Default.Equals(uTs_Cov_R, other.uTs_Cov_R) &&
                   EqualityComparer<double?>.Default.Equals(vTs_Cov_R, other.vTs_Cov_R) &&
                   EqualityComparer<double?>.Default.Equals(wTs_Cov_R, other.wTs_Cov_R) &&
                   EqualityComparer<double?>.Default.Equals(uw_Cov_R_F, other.uw_Cov_R_F) &&
                   EqualityComparer<double?>.Default.Equals(vw_Cov_R_F, other.vw_Cov_R_F) &&
                   EqualityComparer<double?>.Default.Equals(wTs_Cov_R_F, other.wTs_Cov_R_F) &&
                   EqualityComparer<double?>.Default.Equals(wTs_Cov_R_F_SND, other.wTs_Cov_R_F_SND) &&
                   EqualityComparer<double?>.Default.Equals(sonic_samples_Tot, other.sonic_samples_Tot) &&
                   EqualityComparer<double?>.Default.Equals(no_sonic_head_Tot, other.no_sonic_head_Tot) &&
                   EqualityComparer<double?>.Default.Equals(no_new_sonic_data_Tot, other.no_new_sonic_data_Tot) &&
                   EqualityComparer<double?>.Default.Equals(sonic_amp_l_f_Tot, other.sonic_amp_l_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(sonic_amp_h_f_Tot, other.sonic_amp_h_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(sonic_sig_lck_f_Tot, other.sonic_sig_lck_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(sonic_del_T_f_Tot, other.sonic_del_T_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(sonic_aq_sig_f_Tot, other.sonic_aq_sig_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(sonic_cal_err_f_Tot, other.sonic_cal_err_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(UxCO2_Cov, other.UxCO2_Cov) &&
                   EqualityComparer<double?>.Default.Equals(UyCO2_Cov, other.UyCO2_Cov) &&
                   EqualityComparer<double?>.Default.Equals(UzCO2_Cov, other.UzCO2_Cov) &&
                   EqualityComparer<double?>.Default.Equals(UxH2O_Cov, other.UxH2O_Cov) &&
                   EqualityComparer<double?>.Default.Equals(UyH2O_Cov, other.UyH2O_Cov) &&
                   EqualityComparer<double?>.Default.Equals(UzH2O_Cov, other.UzH2O_Cov) &&
                   EqualityComparer<double?>.Default.Equals(uCO2_Cov_R, other.uCO2_Cov_R) &&
                   EqualityComparer<double?>.Default.Equals(vCO2_Cov_R, other.vCO2_Cov_R) &&
                   EqualityComparer<double?>.Default.Equals(wCO2_Cov_R, other.wCO2_Cov_R) &&
                   EqualityComparer<double?>.Default.Equals(uH2O_Cov_R, other.uH2O_Cov_R) &&
                   EqualityComparer<double?>.Default.Equals(vH2O_Cov_R, other.vH2O_Cov_R) &&
                   EqualityComparer<double?>.Default.Equals(wH2O_Cov_R, other.wH2O_Cov_R) &&
                   EqualityComparer<double?>.Default.Equals(wCO2_Cov_R_F, other.wCO2_Cov_R_F) &&
                   EqualityComparer<double?>.Default.Equals(wH2O_Cov_R_F, other.wH2O_Cov_R_F) &&
                   EqualityComparer<double?>.Default.Equals(CO2_E_WPL_R_F, other.CO2_E_WPL_R_F) &&
                   EqualityComparer<double?>.Default.Equals(CO2_T_WPL_R_F, other.CO2_T_WPL_R_F) &&
                   EqualityComparer<double?>.Default.Equals(H2O_E_WPL_R_F, other.H2O_E_WPL_R_F) &&
                   EqualityComparer<double?>.Default.Equals(H2O_T_WPL_R_F, other.H2O_T_WPL_R_F) &&
                   EqualityComparer<double?>.Default.Equals(CO2_samples_Tot, other.CO2_samples_Tot) &&
                   EqualityComparer<double?>.Default.Equals(H2O_samples_Tot, other.H2O_samples_Tot) &&
                   EqualityComparer<double?>.Default.Equals(no_irga_head_Tot, other.no_irga_head_Tot) &&
                   EqualityComparer<double?>.Default.Equals(no_new_irga_data_Tot, other.no_new_irga_data_Tot) &&
                   EqualityComparer<double?>.Default.Equals(irga_bad_data_f_Tot, other.irga_bad_data_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(irga_gen_fault_f_Tot, other.irga_gen_fault_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(irga_startup_f_Tot, other.irga_startup_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(irga_motor_spd_f_Tot, other.irga_motor_spd_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(irga_tec_tmpr_f_Tot, other.irga_tec_tmpr_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(irga_src_pwr_f_Tot, other.irga_src_pwr_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(irga_src_tmpr_f_Tot, other.irga_src_tmpr_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(irga_src_curr_f_Tot, other.irga_src_curr_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(irga_off_f_Tot, other.irga_off_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(irga_sync_f_Tot, other.irga_sync_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(irga_amb_tmpr_f_Tot, other.irga_amb_tmpr_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(irga_amb_press_f_Tot, other.irga_amb_press_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(irga_CO2_I_f_Tot, other.irga_CO2_I_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(irga_CO2_Io_f_Tot, other.irga_CO2_Io_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(irga_H2O_I_f_Tot, other.irga_H2O_I_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(irga_H2O_Io_f_Tot, other.irga_H2O_Io_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(irga_CO2_Io_var_f_Tot, other.irga_CO2_Io_var_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(irga_H2O_Io_var_f_Tot, other.irga_H2O_Io_var_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(irga_CO2_sig_strgth_f_Tot, other.irga_CO2_sig_strgth_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(irga_H2O_sig_strgth_f_Tot, other.irga_H2O_sig_strgth_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(irga_cal_err_f_Tot, other.irga_cal_err_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(irga_htr_ctrl_off_f_Tot, other.irga_htr_ctrl_off_f_Tot) &&
                   EqualityComparer<double?>.Default.Equals(alpha, other.alpha) &&
                   EqualityComparer<double?>.Default.Equals(beta, other.beta) &&
                   EqualityComparer<double?>.Default.Equals(gamma, other.gamma) &&
                   EqualityComparer<double?>.Default.Equals(height_measurement, other.height_measurement) &&
                   EqualityComparer<double?>.Default.Equals(height_canopy, other.height_canopy) &&
                   surface_type_text == other.surface_type_text &&
                   EqualityComparer<double?>.Default.Equals(displacement_user, other.displacement_user) &&
                   EqualityComparer<double?>.Default.Equals(d, other.d) &&
                   EqualityComparer<double?>.Default.Equals(roughness_user, other.roughness_user) &&
                   EqualityComparer<double?>.Default.Equals(z0, other.z0) &&
                   EqualityComparer<double?>.Default.Equals(z, other.z) &&
                   EqualityComparer<double?>.Default.Equals(L, other.L) &&
                   EqualityComparer<double?>.Default.Equals(stability_zL, other.stability_zL) &&
                   EqualityComparer<double?>.Default.Equals(iteration_FreqFactor, other.iteration_FreqFactor) &&
                   EqualityComparer<double?>.Default.Equals(latitude, other.latitude) &&
                   EqualityComparer<double?>.Default.Equals(longitude, other.longitude) &&
                   EqualityComparer<double?>.Default.Equals(separation_x_irga, other.separation_x_irga) &&
                   EqualityComparer<double?>.Default.Equals(separation_y_irga, other.separation_y_irga) &&
                   EqualityComparer<double?>.Default.Equals(separation_lat_dist_irga, other.separation_lat_dist_irga) &&
                   EqualityComparer<double?>.Default.Equals(separation_lag_dist_irga, other.separation_lag_dist_irga) &&
                   EqualityComparer<double?>.Default.Equals(separation_lag_scan_irga, other.separation_lag_scan_irga) &&
                   EqualityComparer<double?>.Default.Equals(MAX_LAG, other.MAX_LAG) &&
                   EqualityComparer<double?>.Default.Equals(lag_irga, other.lag_irga) &&
                   EqualityComparer<double?>.Default.Equals(FreqFactor_uw_vw, other.FreqFactor_uw_vw) &&
                   EqualityComparer<double?>.Default.Equals(FreqFactor_wTs, other.FreqFactor_wTs) &&
                   EqualityComparer<double?>.Default.Equals(FreqFactor_wCO2_wH2O, other.FreqFactor_wCO2_wH2O) &&
                   EqualityComparer<double?>.Default.Equals(rho_d_Avg, other.rho_d_Avg) &&
                   EqualityComparer<double?>.Default.Equals(rho_a_Avg, other.rho_a_Avg) &&
                   EqualityComparer<double?>.Default.Equals(Cp, other.Cp) &&
                   EqualityComparer<double?>.Default.Equals(Lv, other.Lv) &&
                   EqualityComparer<double?>.Default.Equals(door_is_open_Hst, other.door_is_open_Hst) &&
                   EqualityComparer<double?>.Default.Equals(panel_tmpr_Avg, other.panel_tmpr_Avg) &&
                   EqualityComparer<double?>.Default.Equals(batt_volt_Avg, other.batt_volt_Avg) &&
                   EqualityComparer<double?>.Default.Equals(slowsequence_Tot, other.slowsequence_Tot) &&
                   EqualityComparer<double?>.Default.Equals(process_time_Avg, other.process_time_Avg) &&
                   EqualityComparer<double?>.Default.Equals(process_time_Max, other.process_time_Max) &&
                   EqualityComparer<double?>.Default.Equals(buff_depth_Max, other.buff_depth_Max);
        }

        public override int GetHashCode()
        {
            var hashCode = 617394300;
            hashCode = hashCode * -1521134295 + TIMESTAMP.GetHashCode();
            hashCode = hashCode * -1521134295 + RECORD.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(old_L);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(old_u_star);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(old_Fc_wpl);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(old_Fc_hf_wpl);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(old_LE_wpl);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(old_Hc);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(old_Uz_Std);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(old_CO2_mg_m3_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(old_CO2_mg_m3_Std);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(old_CO2_hf_mg_m3_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(old_CO2_hf_mg_m3_Std);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(old_Tc_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(old_amb_press_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Fc_molar);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Fc_mass);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Fc_qc_grade);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Fc_samples_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(LE);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(LE_qc_grade);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(LE_samples_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(H);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(H_qc_grade);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(H_samples_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Rn);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(G_surface);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(energy_closure);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Bowen_ratio);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tau);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tau_qc_grade);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(u_star);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(T_star);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(TKE);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(amb_tmpr_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Td_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(RH_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(e_sat_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(e_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(amb_press_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(VPD_air);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Ux_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Ux_Std);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Uy_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Uy_Std);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Uz_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Uz_Std);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Ts_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Ts_Std);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(sonic_azimuth);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(wnd_spd);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(rslt_wnd_spd);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(wnd_dir_sonic);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(std_wnd_dir);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(wnd_dir_compass);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(CO2_molfrac_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(CO2_mixratio_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(CO2_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(CO2_Std);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(H2O_molfrac_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(H2O_mixratio_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(H2O_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(H2O_Std);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(CO2_sig_strgth_Min);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(H2O_sig_strgth_Min);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(T_probe_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(e_probe_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(e_sat_probe_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Td_probe_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(H2O_probe_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(RH_probe_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(rho_a_probe_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(rho_d_probe_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Precipitation_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Rn_meas_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(NRLITE_SENS);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(PAR_density_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(QUANTUM_SENS);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(cupvane_WS_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(cupvane_WS_rslt_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(cupvane_WD_rslt_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(cupvane_WD_csi_Std);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Tsoil_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tdr315_wc_Avg1);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tdr31X_wc_Avg1);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tdr315_wc_Avg2);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tdr31X_wc_Avg2);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tdr315_tmpr_Avg1);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tdr31X_tmpr_Avg1);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tdr315_tmpr_Avg2);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tdr31X_tmpr_Avg2);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tdr315_E_Avg1);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tdr31X_E_Avg1);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tdr315_E_Avg2);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tdr31X_E_Avg2);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tdr315_bulkEC_Avg1);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tdr31X_bulkEC_Avg1);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tdr315_bulkEC_Avg2);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tdr31X_bulkEC_Avg2);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tdr315_poreEC_Avg1);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tdr31X_poreEC_Avg1);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tdr315_poreEC_Avg2);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tdr31X_poreEC_Avg2);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(shf_plate_avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(SHFP_1_SENS);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_wc_Avg1);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_wc_Avg2);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_wc_Avg3);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_wc_Avg4);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_wc_Avg5);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_wc_Avg6);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_tmpr_Avg1);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_tmpr_Avg2);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_tmpr_Avg3);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_tmpr_Avg4);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_tmpr_Avg5);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_tmpr_Avg6);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_E_Avg1);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_E_Avg2);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_E_Avg3);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_E_Avg4);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_E_Avg5);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_E_Avg6);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_bulkEC_Avg1);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_bulkEC_Avg2);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_bulkEC_Avg3);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_bulkEC_Avg4);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_bulkEC_Avg5);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_bulkEC_Avg6);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_poreEC_Avg1);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_poreEC_Avg2);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_poreEC_Avg3);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_poreEC_Avg4);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_poreEC_Avg5);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr315_poreEC_Avg6);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_wc_Avg1);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_wc_Avg2);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_wc_Avg3);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_wc_Avg4);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_wc_Avg5);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_wc_Avg6);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_tmpr_Avg1);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_tmpr_Avg2);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_tmpr_Avg3);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_tmpr_Avg4);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_tmpr_Avg5);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_tmpr_Avg6);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_E_Avg1);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_E_Avg2);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_E_Avg3);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_E_Avg4);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_E_Avg5);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_E_Avg6);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_bulkEC_Avg1);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_bulkEC_Avg2);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_bulkEC_Avg3);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_bulkEC_Avg4);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_bulkEC_Avg5);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_bulkEC_Avg6);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_poreEC_Avg1);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_poreEC_Avg2);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_poreEC_Avg3);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_poreEC_Avg4);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_poreEC_Avg5);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(profile_tdr31X_poreEC_Avg6);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(upwnd_dist_intrst);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(FP_dist_intrst);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(FP_max);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(FP_40);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(FP_55);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(FP_90);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FP_Equation);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(UxUy_Cov);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(UxUz_Cov);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(UyUz_Cov);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(TsUx_Cov);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(TsUy_Cov);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(TsUz_Cov);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(u_star_R);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(u_Avg_R);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(u_Std_R);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(v_Avg_R);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(v_Std_R);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(w_Avg_R);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(w_Std_R);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(uv_Cov_R);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(uw_Cov_R);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(vw_Cov_R);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(uTs_Cov_R);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(vTs_Cov_R);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(wTs_Cov_R);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(uw_Cov_R_F);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(vw_Cov_R_F);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(wTs_Cov_R_F);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(wTs_Cov_R_F_SND);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(sonic_samples_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(no_sonic_head_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(no_new_sonic_data_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(sonic_amp_l_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(sonic_amp_h_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(sonic_sig_lck_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(sonic_del_T_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(sonic_aq_sig_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(sonic_cal_err_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(UxCO2_Cov);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(UyCO2_Cov);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(UzCO2_Cov);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(UxH2O_Cov);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(UyH2O_Cov);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(UzH2O_Cov);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(uCO2_Cov_R);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(vCO2_Cov_R);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(wCO2_Cov_R);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(uH2O_Cov_R);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(vH2O_Cov_R);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(wH2O_Cov_R);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(wCO2_Cov_R_F);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(wH2O_Cov_R_F);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(CO2_E_WPL_R_F);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(CO2_T_WPL_R_F);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(H2O_E_WPL_R_F);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(H2O_T_WPL_R_F);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(CO2_samples_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(H2O_samples_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(no_irga_head_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(no_new_irga_data_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(irga_bad_data_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(irga_gen_fault_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(irga_startup_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(irga_motor_spd_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(irga_tec_tmpr_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(irga_src_pwr_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(irga_src_tmpr_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(irga_src_curr_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(irga_off_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(irga_sync_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(irga_amb_tmpr_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(irga_amb_press_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(irga_CO2_I_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(irga_CO2_Io_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(irga_H2O_I_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(irga_H2O_Io_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(irga_CO2_Io_var_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(irga_H2O_Io_var_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(irga_CO2_sig_strgth_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(irga_H2O_sig_strgth_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(irga_cal_err_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(irga_htr_ctrl_off_f_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(alpha);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(beta);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(gamma);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(height_measurement);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(height_canopy);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(surface_type_text);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(displacement_user);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(d);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(roughness_user);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(z0);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(z);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(L);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(stability_zL);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(iteration_FreqFactor);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(latitude);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(longitude);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(separation_x_irga);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(separation_y_irga);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(separation_lat_dist_irga);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(separation_lag_dist_irga);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(separation_lag_scan_irga);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(MAX_LAG);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(lag_irga);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(FreqFactor_uw_vw);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(FreqFactor_wTs);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(FreqFactor_wCO2_wH2O);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(rho_d_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(rho_a_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Cp);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Lv);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(door_is_open_Hst);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(panel_tmpr_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(batt_volt_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(slowsequence_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(process_time_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(process_time_Max);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(buff_depth_Max);
            return hashCode;
        }

        public static bool operator ==(Flux flux1, Flux flux2)
        {
            return EqualityComparer<Flux>.Default.Equals(flux1, flux2);
        }

        public static bool operator !=(Flux flux1, Flux flux2)
        {
            return !(flux1 == flux2);
        }
    }
}