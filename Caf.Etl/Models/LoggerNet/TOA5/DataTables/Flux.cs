using Caf.Etl.Models.LoggerNet.TOA5;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Models.LoggerNet.TOA5.DataTables
{
    /// <summary></summary>
    public class Flux : IObservation
    {
        /// <summary></summary> 
        public DateTime TIMESTAMP { get; set; }
        /// <summary></summary> 
        public int RECORD { get; set; }
        /// <summary></summary> 
        public double? old_L { get; set; }
        /// <summary></summary> 
        public double? old_u_star { get; set; }
        /// <summary></summary> 
        public double? old_Fc_wpl { get; set; }
        /// <summary></summary> 
        public double? old_Fc_hf_wpl { get; set; }
        /// <summary></summary> 
        public double? old_LE_wpl { get; set; }
        /// <summary></summary> 
        public double? old_Hc { get; set; }
        /// <summary></summary> 
        public double? old_Uz_Std { get; set; }
        /// <summary></summary> 
        public double? old_CO2_mg_m3_Avg { get; set; }
        /// <summary></summary> 
        public double? old_CO2_mg_m3_Std { get; set; }
        /// <summary></summary> 
        public double? old_CO2_hf_mg_m3_Avg { get; set; }
        /// <summary></summary> 
        public double? old_CO2_hf_mg_m3_Std { get; set; }
        /// <summary></summary> 
        public double? old_Tc_Avg { get; set; }
        /// <summary></summary> 
        public double? old_amb_press_Avg { get; set; }
        /// <summary></summary> 
        public double? Fc_molar { get; set; }
        /// <summary></summary> 
        public double? Fc_mass { get; set; }
        /// <summary></summary> 
        public double? Fc_qc_grade { get; set; }
        /// <summary></summary> 
        public double? Fc_samples_Tot { get; set; }
        /// <summary></summary> 
        public double? LE { get; set; }
        /// <summary></summary> 
        public double? LE_qc_grade { get; set; }
        /// <summary></summary> 
        public double? LE_samples_Tot { get; set; }
        /// <summary></summary> 
        public double? H { get; set; }
        /// <summary></summary> 
        public double? H_qc_grade { get; set; }
        /// <summary></summary> 
        public double? H_samples_Tot { get; set; }
        /// <summary></summary> 
        public double? Rn { get; set; }
        /// <summary></summary> 
        public double? G_surface { get; set; }
        /// <summary></summary> 
        public double? energy_closure { get; set; }
        /// <summary></summary> 
        public double? Bowen_ratio { get; set; }
        /// <summary></summary> 
        public double? tau { get; set; }
        /// <summary></summary> 
        public double? tau_qc_grade { get; set; }
        /// <summary></summary> 
        public double? u_star { get; set; }
        /// <summary></summary> 
        public double? T_star { get; set; }
        /// <summary></summary> 
        public double? TKE { get; set; }
        /// <summary></summary> 
        public double? amb_tmpr_Avg { get; set; }
        /// <summary></summary> 
        public double? Td_Avg { get; set; }
        /// <summary></summary> 
        public double? RH_Avg { get; set; }
        /// <summary></summary> 
        public double? e_sat_Avg { get; set; }
        /// <summary></summary> 
        public double? e_Avg { get; set; }
        /// <summary></summary> 
        public double? amb_press_Avg { get; set; }
        /// <summary></summary> 
        public double? VPD_air { get; set; }
        /// <summary></summary> 
        public double? Ux_Avg { get; set; }
        /// <summary></summary> 
        public double? Ux_Std { get; set; }
        /// <summary></summary> 
        public double? Uy_Avg { get; set; }
        /// <summary></summary> 
        public double? Uy_Std { get; set; }
        /// <summary></summary> 
        public double? Uz_Avg { get; set; }
        /// <summary></summary> 
        public double? Uz_Std { get; set; }
        /// <summary></summary> 
        public double? Ts_Avg { get; set; }
        /// <summary></summary> 
        public double? Ts_Std { get; set; }
        /// <summary></summary> 
        public double? sonic_azimuth { get; set; }
        /// <summary></summary> 
        public double? wnd_spd { get; set; }
        /// <summary></summary> 
        public double? rslt_wnd_spd { get; set; }
        /// <summary></summary> 
        public double? wnd_dir_sonic { get; set; }
        /// <summary></summary> 
        public double? std_wnd_dir { get; set; }
        /// <summary></summary> 
        public double? wnd_dir_compass { get; set; }
        /// <summary></summary> 
        public double? CO2_molfrac_Avg { get; set; }
        /// <summary></summary> 
        public double? CO2_mixratio_Avg { get; set; }
        /// <summary></summary> 
        public double? CO2_Avg { get; set; }
        /// <summary></summary> 
        public double? CO2_Std { get; set; }
        /// <summary></summary> 
        public double? H2O_molfrac_Avg { get; set; }
        /// <summary></summary> 
        public double? H2O_mixratio_Avg { get; set; }
        /// <summary></summary> 
        public double? H2O_Avg { get; set; }
        /// <summary></summary> 
        public double? H2O_Std { get; set; }
        /// <summary></summary> 
        public double? CO2_sig_strgth_Min { get; set; }
        /// <summary></summary> 
        public double? H2O_sig_strgth_Min { get; set; }
        /// <summary></summary> 
        public double? T_probe_Avg { get; set; }
        /// <summary></summary> 
        public double? e_probe_Avg { get; set; }
        /// <summary></summary> 
        public double? e_sat_probe_Avg { get; set; }
        /// <summary></summary> 
        public double? Td_probe_Avg { get; set; }
        /// <summary></summary> 
        public double? H2O_probe_Avg { get; set; }
        /// <summary></summary> 
        public double? RH_probe_Avg { get; set; }
        /// <summary></summary> 
        public double? rho_a_probe_Avg { get; set; }
        /// <summary></summary> 
        public double? rho_d_probe_Avg { get; set; }
        /// <summary></summary> 
        public double? Precipitation_Tot { get; set; }
        /// <summary></summary> 
        public double? Rn_meas_Avg { get; set; }
        /// <summary></summary> 
        public double? NRLITE_SENS { get; set; }
        /// <summary></summary> 
        public double? PAR_density_Avg { get; set; }
        /// <summary></summary> 
        public double? QUANTUM_SENS { get; set; }
        /// <summary></summary> 
        public double? cupvane_WS_Avg { get; set; }
        /// <summary></summary> 
        public double? cupvane_WS_rslt_Avg { get; set; }
        /// <summary></summary> 
        public double? cupvane_WD_rslt_Avg { get; set; }
        /// <summary></summary> 
        public double? cupvane_WD_csi_Std { get; set; }
        /// <summary></summary> 
        public double? Tsoil_Avg { get; set; }
        /// <summary></summary> 
        public double? tdr315_wc_Avg1 { get; set; }
        /// <summary></summary> 
        public double? tdr315_wc_Avg2 { get; set; }
        /// <summary></summary> 
        public double? tdr315_tmpr_Avg1 { get; set; }
        /// <summary></summary> 
        public double? tdr315_tmpr_Avg2 { get; set; }
        /// <summary></summary> 
        public double? tdr315_E_Avg1 { get; set; }
        /// <summary></summary> 
        public double? tdr315_E_Avg2 { get; set; }
        /// <summary></summary> 
        public double? tdr315_bulkEC_Avg1 { get; set; }
        /// <summary></summary> 
        public double? tdr315_bulkEC_Avg2 { get; set; }
        /// <summary></summary> 
        public double? tdr315_poreEC_Avg1 { get; set; }
        /// <summary></summary> 
        public double? tdr315_poreEC_Avg2 { get; set; }
        /// <summary></summary> 
        public double? shf_plate_avg { get; set; }
        /// <summary></summary> 
        public double? SHFP_1_SENS { get; set; }
        /// <summary></summary> 
        public double? profile_tdr315_wc_Avg1 { get; set; }
        /// <summary></summary>             
        public double? profile_tdr315_wc_Avg2 { get; set; }
        /// <summary></summary>             
        public double? profile_tdr315_wc_Avg3 { get; set; }
        /// <summary></summary>             
        public double? profile_tdr315_wc_Avg4 { get; set; }
        /// <summary></summary>             
        public double? profile_tdr315_wc_Avg5 { get; set; }
        /// <summary></summary>             
        public double? profile_tdr315_wc_Avg6 { get; set; }
        /// <summary></summary> 
        public double? profile_tdr315_tmpr_Avg1 { get; set; }
        /// <summary></summary>               
        public double? profile_tdr315_tmpr_Avg2 { get; set; }
        /// <summary></summary>               
        public double? profile_tdr315_tmpr_Avg3 { get; set; }
        /// <summary></summary>               
        public double? profile_tdr315_tmpr_Avg4 { get; set; }
        /// <summary></summary>               
        public double? profile_tdr315_tmpr_Avg5 { get; set; }
        /// <summary></summary>               
        public double? profile_tdr315_tmpr_Avg6 { get; set; }
        /// <summary></summary> 
        public double? profile_tdr315_E_Avg1 { get; set; }
        /// <summary></summary>              
        public double? profile_tdr315_E_Avg2 { get; set; }
        /// <summary></summary>              
        public double? profile_tdr315_E_Avg3 { get; set; }
        /// <summary></summary>              
        public double? profile_tdr315_E_Avg4 { get; set; }
        /// <summary></summary>              
        public double? profile_tdr315_E_Avg5 { get; set; }
        /// <summary></summary>              
        public double? profile_tdr315_E_Avg6 { get; set; }
        /// <summary></summary> 
        public double? profile_tdr315_bulkEC_Avg1 { get; set; }
        /// <summary></summary>                 
        public double? profile_tdr315_bulkEC_Avg2 { get; set; }
        /// <summary></summary>                 
        public double? profile_tdr315_bulkEC_Avg3 { get; set; }
        /// <summary></summary>                 
        public double? profile_tdr315_bulkEC_Avg4 { get; set; }
        /// <summary></summary>                 
        public double? profile_tdr315_bulkEC_Avg5 { get; set; }
        /// <summary></summary>                 
        public double? profile_tdr315_bulkEC_Avg6 { get; set; }
        /// <summary></summary>                 
        public double? profile_tdr315_poreEC_Avg1 { get; set; }
        /// <summary></summary>                 
        public double? profile_tdr315_poreEC_Avg2 { get; set; }
        /// <summary></summary>                 
        public double? profile_tdr315_poreEC_Avg3 { get; set; }
        /// <summary></summary>                 
        public double? profile_tdr315_poreEC_Avg4 { get; set; }
        /// <summary></summary>                 
        public double? profile_tdr315_poreEC_Avg5 { get; set; }
        /// <summary></summary>                 
        public double? profile_tdr315_poreEC_Avg6 { get; set; }
        /// <summary></summary> 
        public double? upwnd_dist_intrst { get; set; }
        /// <summary></summary> 
        public double? FP_dist_intrst { get; set; }
        /// <summary></summary> 
        public double? FP_max { get; set; }
        /// <summary></summary> 
        public double? FP_40 { get; set; }
        /// <summary></summary> 
        public double? FP_55 { get; set; }
        /// <summary></summary> 
        public double? FP_90 { get; set; }
        /// <summary></summary> 
        public string FP_Equation { get; set; }
        /// <summary></summary> 
        public double? UxUy_Cov { get; set; }
        /// <summary></summary> 
        public double? UxUz_Cov { get; set; }
        /// <summary></summary> 
        public double? UyUz_Cov { get; set; }
        /// <summary></summary> 
        public double? TsUx_Cov { get; set; }
        /// <summary></summary> 
        public double? TsUy_Cov { get; set; }
        /// <summary></summary> 
        public double? TsUz_Cov { get; set; }
        /// <summary></summary> 
        public double? u_star_R { get; set; }
        /// <summary></summary> 
        public double? u_Avg_R { get; set; }
        /// <summary></summary> 
        public double? u_Std_R { get; set; }
        /// <summary></summary> 
        public double? v_Avg_R { get; set; }
        /// <summary></summary> 
        public double? v_Std_R { get; set; }
        /// <summary></summary> 
        public double? w_Avg_R { get; set; }
        /// <summary></summary> 
        public double? w_Std_R { get; set; }
        /// <summary></summary> 
        public double? uv_Cov_R { get; set; }
        /// <summary></summary> 
        public double? uw_Cov_R { get; set; }
        /// <summary></summary> 
        public double? vw_Cov_R { get; set; }
        /// <summary></summary> 
        public double? uTs_Cov_R { get; set; }
        /// <summary></summary> 
        public double? vTs_Cov_R { get; set; }
        /// <summary></summary> 
        public double? wTs_Cov_R { get; set; }
        /// <summary></summary> 
        public double? uw_Cov_R_F { get; set; }
        /// <summary></summary> 
        public double? vw_Cov_R_F { get; set; }
        /// <summary></summary> 
        public double? wTs_Cov_R_F { get; set; }
        /// <summary></summary> 
        public double? wTs_Cov_R_F_SND { get; set; }
        /// <summary></summary> 
        public double? sonic_samples_Tot { get; set; }
        /// <summary></summary> 
        public double? no_sonic_head_Tot { get; set; }
        /// <summary></summary> 
        public double? no_new_sonic_data_Tot { get; set; }
        /// <summary></summary> 
        public double? sonic_amp_l_f_Tot { get; set; }
        /// <summary></summary> 
        public double? sonic_amp_h_f_Tot { get; set; }
        /// <summary></summary> 
        public double? sonic_sig_lck_f_Tot { get; set; }
        /// <summary></summary> 
        public double? sonic_del_T_f_Tot { get; set; }
        /// <summary></summary> 
        public double? sonic_aq_sig_f_Tot { get; set; }
        /// <summary></summary> 
        public double? sonic_cal_err_f_Tot { get; set; }
        /// <summary></summary> 
        public double? UxCO2_Cov { get; set; }
        /// <summary></summary> 
        public double? UyCO2_Cov { get; set; }
        /// <summary></summary> 
        public double? UzCO2_Cov { get; set; }
        /// <summary></summary> 
        public double? UxH2O_Cov { get; set; }
        /// <summary></summary> 
        public double? UyH2O_Cov { get; set; }
        /// <summary></summary> 
        public double? UzH2O_Cov { get; set; }
        /// <summary></summary> 
        public double? uCO2_Cov_R { get; set; }
        /// <summary></summary> 
        public double? vCO2_Cov_R { get; set; }
        /// <summary></summary> 
        public double? wCO2_Cov_R { get; set; }
        /// <summary></summary> 
        public double? uH2O_Cov_R { get; set; }
        /// <summary></summary> 
        public double? vH2O_Cov_R { get; set; }
        /// <summary></summary> 
        public double? wH2O_Cov_R { get; set; }
        /// <summary></summary> 
        public double? wCO2_Cov_R_F { get; set; }
        /// <summary></summary> 
        public double? wH2O_Cov_R_F { get; set; }
        /// <summary></summary> 
        public double? CO2_E_WPL_R_F { get; set; }
        /// <summary></summary> 
        public double? CO2_T_WPL_R_F { get; set; }
        /// <summary></summary> 
        public double? H2O_E_WPL_R_F { get; set; }
        /// <summary></summary> 
        public double? H2O_T_WPL_R_F { get; set; }
        /// <summary></summary> 
        public double? CO2_samples_Tot { get; set; }
        /// <summary></summary> 
        public double? H2O_samples_Tot { get; set; }
        /// <summary></summary> 
        public double? no_irga_head_Tot { get; set; }
        /// <summary></summary> 
        public double? no_new_irga_data_Tot { get; set; }
        /// <summary></summary> 
        public double? irga_bad_data_f_Tot { get; set; }
        /// <summary></summary> 
        public double? irga_gen_fault_f_Tot { get; set; }
        /// <summary></summary> 
        public double? irga_startup_f_Tot { get; set; }
        /// <summary></summary> 
        public double? irga_motor_spd_f_Tot { get; set; }
        /// <summary></summary> 
        public double? irga_tec_tmpr_f_Tot { get; set; }
        /// <summary></summary> 
        public double? irga_src_pwr_f_Tot { get; set; }
        /// <summary></summary> 
        public double? irga_src_tmpr_f_Tot { get; set; }
        /// <summary></summary> 
        public double? irga_src_curr_f_Tot { get; set; }
        /// <summary></summary> 
        public double? irga_off_f_Tot { get; set; }
        /// <summary></summary> 
        public double? irga_sync_f_Tot { get; set; }
        /// <summary></summary> 
        public double? irga_amb_tmpr_f_Tot { get; set; }
        /// <summary></summary> 
        public double? irga_amb_press_f_Tot { get; set; }
        /// <summary></summary> 
        public double? irga_CO2_I_f_Tot { get; set; }
        /// <summary></summary> 
        public double? irga_CO2_Io_f_Tot { get; set; }
        /// <summary></summary> 
        public double? irga_H2O_I_f_Tot { get; set; }
        /// <summary></summary> 
        public double? irga_H2O_Io_f_Tot { get; set; }
        /// <summary></summary> 
        public double? irga_CO2_Io_var_f_Tot { get; set; }
        /// <summary></summary> 
        public double? irga_H2O_Io_var_f_Tot { get; set; }
        /// <summary></summary> 
        public double? irga_CO2_sig_strgth_f_Tot { get; set; }
        /// <summary></summary> 
        public double? irga_H2O_sig_strgth_f_Tot { get; set; }
        /// <summary></summary> 
        public double? irga_cal_err_f_Tot { get; set; }
        /// <summary></summary> 
        public double? irga_htr_ctrl_off_f_Tot { get; set; }
        /// <summary></summary> 
        public double? alpha { get; set; }
        /// <summary></summary> 
        public double? beta { get; set; }
        /// <summary></summary> 
        public double? gamma { get; set; }
        /// <summary></summary> 
        public double? height_measurement { get; set; }
        /// <summary></summary> 
        public double? height_canopy { get; set; }
        /// <summary></summary> 
        public string surface_type_text { get; set; }
        /// <summary></summary> 
        public double? displacement_user { get; set; }
        /// <summary></summary> 
        public double? d { get; set; }
        /// <summary></summary> 
        public double? roughness_user { get; set; }
        /// <summary></summary> 
        public double? z0 { get; set; }
        /// <summary></summary> 
        public double? z { get; set; }
        /// <summary></summary> 
        public double? L { get; set; }
        /// <summary></summary> 
        public double? stability_zL { get; set; }
        /// <summary></summary> 
        public double? iteration_FreqFactor { get; set; }
        /// <summary></summary> 
        public double? latitude { get; set; }
        /// <summary></summary> 
        public double? longitude { get; set; }
        /// <summary></summary> 
        public double? separation_x_irga { get; set; }
        /// <summary></summary> 
        public double? separation_y_irga { get; set; }
        /// <summary></summary> 
        public double? separation_lat_dist_irga { get; set; }
        /// <summary></summary> 
        public double? separation_lag_dist_irga { get; set; }
        /// <summary></summary> 
        public double? separation_lag_scan_irga { get; set; }
        /// <summary></summary> 
        public double? MAX_LAG { get; set; }
        /// <summary></summary> 
        public double? lag_irga { get; set; }
        /// <summary></summary> 
        public double? FreqFactor_uw_vw { get; set; }
        /// <summary></summary> 
        public double? FreqFactor_wTs { get; set; }
        /// <summary></summary> 
        public double? FreqFactor_wCO2_wH2O { get; set; }
        /// <summary></summary> 
        public double? rho_d_Avg { get; set; }
        /// <summary></summary> 
        public double? rho_a_Avg { get; set; }
        /// <summary></summary> 
        public double? Cp { get; set; }
        /// <summary></summary> 
        public double? Lv { get; set; }
        /// <summary></summary> 
        public double? door_is_open_Hst { get; set; }
        /// <summary></summary> 
        public double? panel_tmpr_Avg { get; set; }
        /// <summary></summary> 
        public double? batt_volt_Avg { get; set; }
        /// <summary></summary> 
        public double? slowsequence_Tot { get; set; }
        /// <summary></summary> 
        public double? process_time_Avg { get; set; }
        /// <summary></summary> 
        public double? process_time_Max { get; set; }
        /// <summary></summary> 
        public double? buff_depth_Max { get; set; }
    }
}