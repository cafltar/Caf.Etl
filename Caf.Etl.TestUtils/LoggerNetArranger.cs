using Caf.Etl.Models.CosmosDBSqlApi.Measurement;
using Caf.Etl.Models.LoggerNet.TOA5;
using Caf.Etl.Models.LoggerNet.TOA5.DataTables;
using System;
using System.Collections.Generic;

namespace Caf.Etl.TestUtils
{
    public static class LoggerNetArranger
    {
        public static List<IObservation> GetFluxObservationsDerivedFromActualDataV1()
        {
            List<IObservation> r = new List<IObservation>();

            Flux flux = new Flux()
            {
                TIMESTAMP = new DateTime(2018, 01, 08, 13, 30, 00),
                RECORD = 3173,
                old_L = -183.8949,
                old_u_star = 0.3737741,
                old_Fc_wpl = -0.01177279,
                old_Fc_hf_wpl = -0.003472358,
                old_LE_wpl = 60.15265,
                old_Hc = 2.954164,
                old_Uz_Std = 0.406423,
                old_CO2_mg_m3_Avg = 688.1329,
                old_CO2_mg_m3_Std = 0.4237751,
                old_CO2_hf_mg_m3_Avg = 690.6694,
                old_CO2_hf_mg_m3_Std = 0.3913721,
                old_Tc_Avg = 7.146155,
                old_amb_press_Avg = 92.50146,
                Fc_molar = 0.5573161,
                Fc_mass = 0.0245272,
                Fc_qc_grade = 3,
                Fc_samples_Tot = 18000,
                LE = 65.18005,
                LE_qc_grade = 3,
                LE_samples_Tot = 18000,
                H = 20.29806,
                H_qc_grade = 3,
                H_samples_Tot = 18000,
                Rn = 93.90979,
                G_surface = 26.42146,
                energy_closure = 1.266561,
                Bowen_ratio = 0.3114153,
                tau = 0.1652448,
                tau_qc_grade = 2,
                u_star = 0.3795369,
                T_star = -0.04626383,
                TKE = 0.7279687,
                amb_tmpr_Avg = 7.146155,
                Td_Avg = -0.7282106,
                RH_Avg = 57.28835,
                e_sat_Avg = 1.015924,
                e_Avg = 0.5820282,
                amb_press_Avg = 92.50146,
                VPD_air = 0.4338953,
                Ux_Avg = 0.9146236,
                Ux_Std = 0.7104049,
                Uy_Avg = 4.703513,
                Uy_Std = 0.886613,
                Uz_Avg = 0.02759224,
                Uz_Std = 0.406423,
                Ts_Avg = 7.331906,
                Ts_Std = 0.1228317,
                sonic_azimuth = 185,
                wnd_spd = 4.846028,
                rslt_wnd_spd = 4.791603,
                wnd_dir_sonic = 78.9958,
                std_wnd_dir = 8.584023,
                wnd_dir_compass = 106.0042,
                CO2_molfrac_Avg = 393.9265,
                CO2_mixratio_Avg = 396.423,
                CO2_Avg = 688.1329,
                CO2_Std = 0.4237751,
                H2O_molfrac_Avg = 6.290682,
                H2O_mixratio_Avg = 6.330607,
                H2O_Avg = 4.499438,
                H2O_Std = 0.1552989,
                CO2_sig_strgth_Min = 0.963259,
                H2O_sig_strgth_Min = 0.9334315,
                T_probe_Avg = 7.02306,
                e_probe_Avg = 0.7072247,
                e_sat_probe_Avg = 1.007384,
                Td_probe_Avg = 1.971855,
                H2O_probe_Avg = 5.469703,
                RH_probe_Avg = 70.20408,
                rho_a_probe_Avg = 1.147064,
                rho_d_probe_Avg = 1.141595,
                Precipitation_Tot = 0,
                Rn_meas_Avg = 93.44282,
                NRLITE_SENS = 12.13,
                PAR_density_Avg = 467.1641,
                QUANTUM_SENS = 6,
                cupvane_WS_Avg = 4.847,
                cupvane_WS_rslt_Avg = 4.798,
                cupvane_WD_rslt_Avg = 103.3,
                cupvane_WD_csi_Std = 6.212,
                Tsoil_Avg = 5.290007,
                tdr315_wc_Avg1 = 26.60778,
                tdr315_wc_Avg2 = null,
                tdr315_tmpr_Avg1 = 6.86,
                tdr315_tmpr_Avg2 = 6.86,
                tdr315_E_Avg1 = 14.36889,
                tdr315_E_Avg2 = 14.36833,
                tdr315_bulkEC_Avg1 = 100.9833,
                tdr315_bulkEC_Avg2 = 100.9833,
                tdr315_poreEC_Avg1 = 778.7722,
                tdr315_poreEC_Avg2 = 778.8167,
                shf_plate_avg = 26.42146,
                SHFP_1_SENS = 61.47,
                profile_tdr315_wc_Avg1 = 29.63278,
                profile_tdr315_wc_Avg2 = 32.20333,
                profile_tdr315_wc_Avg3 = null,
                profile_tdr315_wc_Avg4 = null,
                profile_tdr315_wc_Avg5 = null,
                profile_tdr315_wc_Avg6 = null,
                profile_tdr315_tmpr_Avg1 = 4.166667,
                profile_tdr315_tmpr_Avg2 = 3.4,
                profile_tdr315_tmpr_Avg3 = 3.4,
                profile_tdr315_tmpr_Avg4 = 3.4,
                profile_tdr315_tmpr_Avg5 = 3.4,
                profile_tdr315_tmpr_Avg6 = 3.4,
                profile_tdr315_E_Avg1 = 16.39,
                profile_tdr315_E_Avg2 = 18.17722,
                profile_tdr315_E_Avg3 = 18.17722,
                profile_tdr315_E_Avg4 = 18.17722,
                profile_tdr315_E_Avg5 = 18.17722,
                profile_tdr315_E_Avg6 = 18.17722,
                profile_tdr315_bulkEC_Avg1 = 144.3,
                profile_tdr315_bulkEC_Avg2 = 226.9889,
                profile_tdr315_bulkEC_Avg3 = 226.9889,
                profile_tdr315_bulkEC_Avg4 = 226.9889,
                profile_tdr315_bulkEC_Avg5 = 226.9889,
                profile_tdr315_bulkEC_Avg6 = 226.9889,
                profile_tdr315_poreEC_Avg1 = 931.5056,
                profile_tdr315_poreEC_Avg2 = 1280.556,
                profile_tdr315_poreEC_Avg3 = 1280.556,
                profile_tdr315_poreEC_Avg4 = 1280.556,
                profile_tdr315_poreEC_Avg5 = 1280.556,
                profile_tdr315_poreEC_Avg6 = 1280.556,
                upwnd_dist_intrst = 208.4886,
                FP_dist_intrst = 99.60601,
                FP_max = 40.0555,
                FP_40 = 43.10836,
                FP_55 = 56.95799,
                FP_90 = 110.5907,
                FP_Equation = "Kljun et al",
                UxUy_Cov = -0.03038211,
                UxUz_Cov = 0.001716286,
                UyUz_Cov = -0.1396965,
                TsUx_Cov = -0.01000383,
                TsUy_Cov = -0.0628771,
                TsUz_Cov = 0.02030434,
                u_star_R = 0.3783804,
                u_Avg_R = 4.791694,
                u_Std_R = 0.873412,
                v_Avg_R = 0,
                v_Std_R = 0.7254749,
                w_Avg_R = 1.862645E-09,
                w_Std_R = 0.4083809,
                uv_Cov_R = 0.08073118,
                uw_Cov_R = -0.140242,
                vw_Cov_R = -0.02881548,
                uTs_Cov_R = -0.06351256,
                vTs_Cov_R = -0.002182142,
                wTs_Cov_R = 0.02067041,
                uw_Cov_R_F = -0.1411006,
                vw_Cov_R_F = -0.0289919,
                wTs_Cov_R_F = 0.02081664,
                wTs_Cov_R_F_SND = 0.01755883,
                sonic_samples_Tot = 18000,
                no_sonic_head_Tot = 0,
                no_new_sonic_data_Tot = 0,
                sonic_amp_l_f_Tot = 0,
                sonic_amp_h_f_Tot = 0,
                sonic_sig_lck_f_Tot = 0,
                sonic_del_T_f_Tot = 0,
                sonic_aq_sig_f_Tot = 0,
                sonic_cal_err_f_Tot = 0,
                UxCO2_Cov = 0.09748445,
                UyCO2_Cov = 0.1134349,
                UzCO2_Cov = -0.04178881,
                UxH2O_Cov = -0.003684159,
                UyH2O_Cov = -0.1009904,
                UzH2O_Cov = 0.02445646,
                uCO2_Cov_R = 0.1297143,
                vCO2_Cov_R = -0.07403947,
                wCO2_Cov_R = -0.04253646,
                uH2O_Cov_R = -0.09969425,
                vH2O_Cov_R = -0.01566072,
                wH2O_Cov_R = 0.02503095,
                wCO2_Cov_R_F = -0.04382965,
                wH2O_Cov_R_F = 0.02579194,
                CO2_E_WPL_R_F = 0.02497661,
                CO2_T_WPL_R_F = 0.04338025,
                H2O_E_WPL_R_F = 0.0001633125,
                H2O_T_WPL_R_F = 0.0002836469,
                CO2_samples_Tot = 18000,
                H2O_samples_Tot = 18000,
                no_irga_head_Tot = 0,
                no_new_irga_data_Tot = 0,
                irga_bad_data_f_Tot = 0,
                irga_gen_fault_f_Tot = 0,
                irga_startup_f_Tot = 0,
                irga_motor_spd_f_Tot = 0,
                irga_tec_tmpr_f_Tot = 0,
                irga_src_pwr_f_Tot = 0,
                irga_src_tmpr_f_Tot = 0,
                irga_src_curr_f_Tot = 0,
                irga_off_f_Tot = 0,
                irga_sync_f_Tot = 0,
                irga_amb_tmpr_f_Tot = 0,
                irga_amb_press_f_Tot = 0,
                irga_CO2_I_f_Tot = 0,
                irga_CO2_Io_f_Tot = 0,
                irga_H2O_I_f_Tot = 0,
                irga_H2O_Io_f_Tot = 0,
                irga_CO2_Io_var_f_Tot = 0,
                irga_H2O_Io_var_f_Tot = 0,
                irga_CO2_sig_strgth_f_Tot = 0,
                irga_H2O_sig_strgth_f_Tot = 0,
                irga_cal_err_f_Tot = 0,
                irga_htr_ctrl_off_f_Tot = 0,
                alpha = -0.3299308,
                beta = 0,
                gamma = 78.9958,
                height_measurement = 2.23,
                height_canopy = 0.2,
                surface_type_text = "Crop",
                displacement_user = 0,
                d = 0.1451137,
                roughness_user = 0,
                z0 = 0.01177848,
                z = 2.084886,
                L = -183.1485,
                stability_zL = -0.01138359,
                iteration_FreqFactor = 1,
                latitude = 46.78152,
                longitude = 117,
                separation_x_irga = 0.04066,
                separation_y_irga = 0.02905,
                separation_lat_dist_irga = -0.0343673,
                separation_lag_dist_irga = 0.03627708,
                separation_lag_scan_irga = 0.0757097,
                MAX_LAG = 2,
                lag_irga = 0,
                FreqFactor_uw_vw = 1.006122,
                FreqFactor_wTs = 1.007074,
                FreqFactor_wCO2_wH2O = 1.030402,
                rho_d_Avg = 1.14265,
                rho_a_Avg = 1.147149,
                Cp = 1007.718,
                Lv = 2484.099,
                door_is_open_Hst = 0,
                panel_tmpr_Avg = 9.453013,
                batt_volt_Avg = 12.87643,
                slowsequence_Tot = 180,
                process_time_Avg = 92.20594,
                process_time_Max = 7608.585,
                buff_depth_Max = 76
            };

            r.Add(flux);

            return r;
        }

        public static List<IObservation> GetFluxObservationsDerivedFromTestDataV2()
        {
            List<IObservation> r = new List<IObservation>();

            Flux flux = new Flux()
            {
                TIMESTAMP = new DateTime(2018, 06, 15, 14, 00, 00),
                RECORD = 0,
                Fc_molar = null,
                Fc_mass = null,
                Fc_qc_grade = 0,
                Fc_samples_Tot = 0,
                LE = null,
                LE_qc_grade = 0,
                LE_samples_Tot = 0,
                H = null,
                H_qc_grade = 0,
                H_samples_Tot = 0,
                Rn = 25151.79,
                G_surface = null,
                energy_closure = 1,
                Bowen_ratio = null,
                tau = null,
                tau_qc_grade = 0,
                u_star = null,
                T_star = null,
                TKE = null,
                amb_tmpr_Avg = null,
                Td_Avg = null,
                RH_Avg = null,
                e_sat_Avg = null,
                e_Avg = null,
                amb_press_Avg = null,
                VPD_air = null,
                Ux_Avg = null,
                Ux_Std = null,
                Uy_Avg = null,
                Uy_Std = null,
                Uz_Avg = null,
                Uz_Std = null,
                Ts_Avg = null,
                Ts_Std = null,
                sonic_azimuth = 0,
                wnd_spd = null,
                rslt_wnd_spd = null,
                wnd_dir_sonic = null,
                std_wnd_dir = null,
                wnd_dir_compass = null,
                CO2_molfrac_Avg = null,
                CO2_mixratio_Avg = null,
                CO2_Avg = null,
                CO2_Std = null,
                H2O_molfrac_Avg = null,
                H2O_mixratio_Avg = null,
                H2O_Avg = null,
                H2O_Std = null,
                CO2_sig_strgth_Min = null,
                H2O_sig_strgth_Min = null,
                T_probe_Avg = null,
                e_probe_Avg = null,
                e_sat_probe_Avg = 0,
                Td_probe_Avg = 0,
                H2O_probe_Avg = null,
                RH_probe_Avg = null,
                rho_a_probe_Avg = null,
                rho_d_probe_Avg = null,
                Precipitation_Tot = 0,
                Rn_meas_Avg = 25151.79,
                NRLITE_SENS = 11.65,
                PAR_density_Avg = null,
                QUANTUM_SENS = 6.5,
                cupvane_WS_Avg = 0,
                cupvane_WS_rslt_Avg = 0,
                cupvane_WD_rslt_Avg = 0,
                cupvane_WD_csi_Std = 0,
                Tsoil_Avg = -76071.11,
                tdr31X_wc_Avg = null,
                tdr31X_tmpr_Avg = 0,
                tdr31X_E_Avg = 0,
                tdr31X_bulkEC_Avg = 0,
                tdr31X_poreEC_Avg = 0,
                shf_plate_avg = 4617.834,
                SHFP_1_SENS = 66.47,
                profile_tdr31X_wc_Avg1 = null,
                profile_tdr31X_wc_Avg2 = null,
                profile_tdr31X_wc_Avg3 = null,
                profile_tdr31X_wc_Avg4 = null,
                profile_tdr31X_wc_Avg5 = null,
                profile_tdr31X_wc_Avg6 = null,
                profile_tdr31X_tmpr_Avg1 = 0,
                profile_tdr31X_tmpr_Avg2 = 0,
                profile_tdr31X_tmpr_Avg3 = 0,
                profile_tdr31X_tmpr_Avg4 = 0,
                profile_tdr31X_tmpr_Avg5 = 0,
                profile_tdr31X_tmpr_Avg6 = 0,
                profile_tdr31X_E_Avg1 = 0,
                profile_tdr31X_E_Avg2 = 0,
                profile_tdr31X_E_Avg3 = 0,
                profile_tdr31X_E_Avg4 = 0,
                profile_tdr31X_E_Avg5 = 0,
                profile_tdr31X_E_Avg6 = 0,
                profile_tdr31X_bulkEC_Avg1 = 0,
                profile_tdr31X_bulkEC_Avg2 = 0,
                profile_tdr31X_bulkEC_Avg3 = 0,
                profile_tdr31X_bulkEC_Avg4 = 0,
                profile_tdr31X_bulkEC_Avg5 = 0,
                profile_tdr31X_bulkEC_Avg6 = 0,
                profile_tdr31X_poreEC_Avg1 = 0,
                profile_tdr31X_poreEC_Avg2 = 0,
                profile_tdr31X_poreEC_Avg3 = 0,
                profile_tdr31X_poreEC_Avg4 = 0,
                profile_tdr31X_poreEC_Avg5 = 0,
                profile_tdr31X_poreEC_Avg6 = 0,
                upwnd_dist_intrst = 300,
                FP_dist_intrst = null,
                FP_max = null,
                FP_40 = null,
                FP_55 = null,
                FP_90 = null,
                FP_Equation = "KormannMeixner",
                UxUy_Cov = null,
                UxUz_Cov = null,
                UyUz_Cov = null,
                TsUx_Cov = null,
                TsUy_Cov = null,
                TsUz_Cov = null,
                u_star_R = null,
                u_Avg_R = null,
                u_Std_R = null,
                v_Avg_R = 0,
                v_Std_R = null,
                w_Avg_R = null,
                w_Std_R = null,
                uv_Cov_R = null,
                uw_Cov_R = null,
                vw_Cov_R = null,
                uTs_Cov_R = null,
                vTs_Cov_R = null,
                wTs_Cov_R = null,
                uw_Cov_R_F = null,
                vw_Cov_R_F = null,
                wTs_Cov_R_F = null,
                wTs_Cov_R_F_SND = null,
                sonic_samples_Tot = 0,
                no_sonic_head_Tot = 0,
                no_new_sonic_data_Tot = 11404,
                sonic_amp_l_f_Tot = 0,
                sonic_amp_h_f_Tot = 0,
                sonic_sig_lck_f_Tot = 0,
                sonic_del_T_f_Tot = 0,
                sonic_aq_sig_f_Tot = 0,
                sonic_cal_err_f_Tot = 0,
                UxCO2_Cov = null,
                UyCO2_Cov = null,
                UzCO2_Cov = null,
                UxH2O_Cov = null,
                UyH2O_Cov = null,
                UzH2O_Cov = null,
                uCO2_Cov_R = null,
                vCO2_Cov_R = null,
                wCO2_Cov_R = null,
                uH2O_Cov_R = null,
                vH2O_Cov_R = null,
                wH2O_Cov_R = null,
                wCO2_Cov_R_F = null,
                wH2O_Cov_R_F = null,
                CO2_E_WPL_R_F = null,
                CO2_T_WPL_R_F = null,
                H2O_E_WPL_R_F = null,
                H2O_T_WPL_R_F = null,
                CO2_samples_Tot = 0,
                H2O_samples_Tot = 0,
                no_irga_head_Tot = 0,
                no_new_irga_data_Tot = 11404,
                irga_bad_data_f_Tot = 0,
                irga_gen_fault_f_Tot = 0,
                irga_startup_f_Tot = 0,
                irga_motor_spd_f_Tot = 0,
                irga_tec_tmpr_f_Tot = 0,
                irga_src_pwr_f_Tot = 0,
                irga_src_tmpr_f_Tot = 0,
                irga_src_curr_f_Tot = 0,
                irga_off_f_Tot = 0,
                irga_sync_f_Tot = 0,
                irga_amb_tmpr_f_Tot = 0,
                irga_amb_press_f_Tot = 0,
                irga_CO2_I_f_Tot = 0,
                irga_CO2_Io_f_Tot = 0,
                irga_H2O_I_f_Tot = 0,
                irga_H2O_Io_f_Tot = 0,
                irga_CO2_Io_var_f_Tot = 0,
                irga_H2O_Io_var_f_Tot = 0,
                irga_CO2_sig_strgth_f_Tot = 0,
                irga_H2O_sig_strgth_f_Tot = 0,
                irga_cal_err_f_Tot = 0,
                irga_htr_ctrl_off_f_Tot = 0,
                alpha = null,
                beta = 0,
                gamma = null,
                height_measurement = 3,
                height_canopy = 0,
                surface_type_text = "Bare land",
                displacement_user = 0,
                d = 0,
                roughness_user = 0,
                z0 = 0.01,
                z = 3,
                L = null,
                stability_zL = null,
                iteration_FreqFactor = 1,
                latitude = 41.766,
                longitude = 111.855,
                separation_x_irga = 0,
                separation_y_irga = 0,
                separation_lat_dist_irga = null,
                separation_lag_dist_irga = null,
                separation_lag_scan_irga = null,
                MAX_LAG = 2,
                lag_irga = 0,
                FreqFactor_uw_vw = 1,
                FreqFactor_wTs = 1,
                FreqFactor_wCO2_wH2O = 1,
                rho_d_Avg = null,
                rho_a_Avg = null,
                Cp = null,
                Lv = null,
                door_is_open_Hst = 0.999,
                panel_tmpr_Avg = 24.94208,
                batt_volt_Avg = 13.61839,
                slowsequence_Tot = 229,
                process_time_Avg = 56.48518,
                process_time_Max = 159.203,
                buff_depth_Max = 4
            };

            r.Add(flux);

            return r;        
        }

        public static List<IObservation> GetMeteorologyObservationsDerivedFromTestDataV2()
        {
            List<IObservation> r = new List<IObservation>();

            Meteorology met = new Meteorology()
            {
                TIMESTAMP = new DateTime(2018, 06, 15, 13, 45, 00),
                RECORD = 0,
                amb_tmpr_Avg = null,
                rslt_wnd_spd = null,
                wnd_dir_compass = null,
                RH_Avg = null,
                Precipitation_Tot = 0,
                amb_press_Avg = null,
                PAR_density_Avg = null,
                batt_volt_Avg = 13.39749,
                panel_tmpr_Avg = 24.75595,
                std_wnd_dir = null,
                VPD_air = null,
                Rn_meas_Avg = 22857.77,
                e_sat = null,
                e = null,
                tdr31X_wc_Avg = null,
                tdr31X_tmpr_Avg = 0,
                tdr31X_E_Avg = 0,
                tdr31X_bulkEC_Avg = 0,
                tdr31X_poreEC_Avg = 0,
                Tsoil_Avg = -18129.55,
                profile_tdr31X_wc_Avg1 = 0,
                profile_tdr31X_wc_Avg2 = 0,
                profile_tdr31X_wc_Avg3 = 0,
                profile_tdr31X_wc_Avg4 = 0,
                profile_tdr31X_wc_Avg5 = 0,
                profile_tdr31X_wc_Avg6 = 0,
                profile_tdr31X_tmpr_Avg1 = 0,
                profile_tdr31X_tmpr_Avg2 = 0,
                profile_tdr31X_tmpr_Avg3 = 0,
                profile_tdr31X_tmpr_Avg4 = 0,
                profile_tdr31X_tmpr_Avg5 = 0,
                profile_tdr31X_tmpr_Avg6 = 0,
                profile_tdr31X_E_Avg1 = 0,
                profile_tdr31X_E_Avg2 = 0,
                profile_tdr31X_E_Avg3 = 0,
                profile_tdr31X_E_Avg4 = 0,
                profile_tdr31X_E_Avg5 = 0,
                profile_tdr31X_E_Avg6 = 0,
                profile_tdr31X_bulkEC_Avg1 = 0,
                profile_tdr31X_bulkEC_Avg2 = 0,
                profile_tdr31X_bulkEC_Avg3 = 0,
                profile_tdr31X_bulkEC_Avg4 = 0,
                profile_tdr31X_bulkEC_Avg5 = 0,
                profile_tdr31X_bulkEC_Avg6 = 0,
                profile_tdr31X_poreEC_Avg1 = 0,
                profile_tdr31X_poreEC_Avg2 = 0,
                profile_tdr31X_poreEC_Avg3 = 0,
                profile_tdr31X_poreEC_Avg4 = 0,
                profile_tdr31X_poreEC_Avg5 = 0,
                profile_tdr31X_poreEC_Avg6 = 0,
                shf_plate_avg = 0,
                SHFP_1_SENS = 66.47
            };

            r.Add(met);

            return r;
        }

        public static TOA5 GetToa5FluxDerivedFromActualDataV1()
        {
            TOA5 flux = new TOA5();

            flux.Observations = new List<IObservation>();
            flux.Observations.Add(new Flux()
            {
                TIMESTAMP = new DateTime(2018, 01, 08, 13, 30, 00),
                RECORD = 3173,
                old_L = -183.8949,
                old_u_star = 0.3737741,
                old_Fc_wpl = -0.01177279,
                old_Fc_hf_wpl = -0.003472358,
                old_LE_wpl = 60.15265,
                old_Hc = 2.954164,
                old_Uz_Std = 0.406423,
                old_CO2_mg_m3_Avg = 688.1329,
                old_CO2_mg_m3_Std = 0.4237751,
                old_CO2_hf_mg_m3_Avg = 690.6694,
                old_CO2_hf_mg_m3_Std = 0.3913721,
                old_Tc_Avg = 7.146155,
                old_amb_press_Avg = 92.50146,
                Fc_molar = 0.5573161,
                Fc_mass = 0.0245272,
                Fc_qc_grade = 3,
                Fc_samples_Tot = 18000,
                LE = 65.18005,
                LE_qc_grade = 3,
                LE_samples_Tot = 18000,
                H = 20.29806,
                H_qc_grade = 3,
                H_samples_Tot = 18000,
                Rn = 93.90979,
                G_surface = 26.42146,
                energy_closure = 1.266561,
                Bowen_ratio = 0.3114153,
                tau = 0.1652448,
                tau_qc_grade = 2,
                u_star = 0.3795369,
                T_star = -0.04626383,
                TKE = 0.7279687,
                amb_tmpr_Avg = 7.146155,
                Td_Avg = -0.7282106,
                RH_Avg = 57.28835,
                e_sat_Avg = 1.015924,
                e_Avg = 0.5820282,
                amb_press_Avg = 92.50146,
                VPD_air = 0.4338953,
                Ux_Avg = 0.9146236,
                Ux_Std = 0.7104049,
                Uy_Avg = 4.703513,
                Uy_Std = 0.886613,
                Uz_Avg = 0.02759224,
                Uz_Std = 0.406423,
                Ts_Avg = 7.331906,
                Ts_Std = 0.1228317,
                sonic_azimuth = 185,
                wnd_spd = 4.846028,
                rslt_wnd_spd = 4.791603,
                wnd_dir_sonic = 78.9958,
                std_wnd_dir = 8.584023,
                wnd_dir_compass = 106.0042,
                CO2_molfrac_Avg = 393.9265,
                CO2_mixratio_Avg = 396.423,
                CO2_Avg = 688.1329,
                CO2_Std = 0.4237751,
                H2O_molfrac_Avg = 6.290682,
                H2O_mixratio_Avg = 6.330607,
                H2O_Avg = 4.499438,
                H2O_Std = 0.1552989,
                CO2_sig_strgth_Min = 0.963259,
                H2O_sig_strgth_Min = 0.9334315,
                T_probe_Avg = 7.02306,
                e_probe_Avg = 0.7072247,
                e_sat_probe_Avg = 1.007384,
                Td_probe_Avg = 1.971855,
                H2O_probe_Avg = 5.469703,
                RH_probe_Avg = 70.20408,
                rho_a_probe_Avg = 1.147064,
                rho_d_probe_Avg = 1.141595,
                Precipitation_Tot = 0,
                Rn_meas_Avg = 93.44282,
                NRLITE_SENS = 12.13,
                PAR_density_Avg = 467.1641,
                QUANTUM_SENS = 6,
                cupvane_WS_Avg = 4.847,
                cupvane_WS_rslt_Avg = 4.798,
                cupvane_WD_rslt_Avg = 103.3,
                cupvane_WD_csi_Std = 6.212,
                Tsoil_Avg = 5.290007,
                tdr315_wc_Avg1 = 26.60778,
                tdr315_wc_Avg2 = null,
                tdr315_tmpr_Avg1 = 6.86,
                tdr315_tmpr_Avg2 = 6.86,
                tdr315_E_Avg1 = 14.36889,
                tdr315_E_Avg2 = 14.36833,
                tdr315_bulkEC_Avg1 = 100.9833,
                tdr315_bulkEC_Avg2 = 100.9833,
                tdr315_poreEC_Avg1 = 778.7722,
                tdr315_poreEC_Avg2 = 778.8167,
                shf_plate_avg = 26.42146,
                SHFP_1_SENS = 61.47,
                profile_tdr315_wc_Avg1 = 29.63278,
                profile_tdr315_wc_Avg2 = 32.20333,
                profile_tdr315_wc_Avg3 = null,
                profile_tdr315_wc_Avg4 = null,
                profile_tdr315_wc_Avg5 = null,
                profile_tdr315_wc_Avg6 = null,
                profile_tdr315_tmpr_Avg1 = 4.166667,
                profile_tdr315_tmpr_Avg2 = 3.4,
                profile_tdr315_tmpr_Avg3 = 3.4,
                profile_tdr315_tmpr_Avg4 = 3.4,
                profile_tdr315_tmpr_Avg5 = 3.4,
                profile_tdr315_tmpr_Avg6 = 3.4,
                profile_tdr315_E_Avg1 = 16.39,
                profile_tdr315_E_Avg2 = 18.17722,
                profile_tdr315_E_Avg3 = 18.17722,
                profile_tdr315_E_Avg4 = 18.17722,
                profile_tdr315_E_Avg5 = 18.17722,
                profile_tdr315_E_Avg6 = 18.17722,
                profile_tdr315_bulkEC_Avg1 = 144.3,
                profile_tdr315_bulkEC_Avg2 = 226.9889,
                profile_tdr315_bulkEC_Avg3 = 226.9889,
                profile_tdr315_bulkEC_Avg4 = 226.9889,
                profile_tdr315_bulkEC_Avg5 = 226.9889,
                profile_tdr315_bulkEC_Avg6 = 226.9889,
                profile_tdr315_poreEC_Avg1 = 931.5056,
                profile_tdr315_poreEC_Avg2 = 1280.556,
                profile_tdr315_poreEC_Avg3 = 1280.556,
                profile_tdr315_poreEC_Avg4 = 1280.556,
                profile_tdr315_poreEC_Avg5 = 1280.556,
                profile_tdr315_poreEC_Avg6 = 1280.556,
                upwnd_dist_intrst = 208.4886,
                FP_dist_intrst = 99.60601,
                FP_max = 40.0555,
                FP_40 = 43.10836,
                FP_55 = 56.95799,
                FP_90 = 110.5907,
                FP_Equation = "Kljun et al",
                UxUy_Cov = -0.03038211,
                UxUz_Cov = 0.001716286,
                UyUz_Cov = -0.1396965,
                TsUx_Cov = -0.01000383,
                TsUy_Cov = -0.0628771,
                TsUz_Cov = 0.02030434,
                u_star_R = 0.3783804,
                u_Avg_R = 4.791694,
                u_Std_R = 0.873412,
                v_Avg_R = 0,
                v_Std_R = 0.7254749,
                w_Avg_R = 1.862645E-09,
                w_Std_R = 0.4083809,
                uv_Cov_R = 0.08073118,
                uw_Cov_R = -0.140242,
                vw_Cov_R = -0.02881548,
                uTs_Cov_R = -0.06351256,
                vTs_Cov_R = -0.002182142,
                wTs_Cov_R = 0.02067041,
                uw_Cov_R_F = -0.1411006,
                vw_Cov_R_F = -0.0289919,
                wTs_Cov_R_F = 0.02081664,
                wTs_Cov_R_F_SND = 0.01755883,
                sonic_samples_Tot = 18000,
                no_sonic_head_Tot = 0,
                no_new_sonic_data_Tot = 0,
                sonic_amp_l_f_Tot = 0,
                sonic_amp_h_f_Tot = 0,
                sonic_sig_lck_f_Tot = 0,
                sonic_del_T_f_Tot = 0,
                sonic_aq_sig_f_Tot = 0,
                sonic_cal_err_f_Tot = 0,
                UxCO2_Cov = 0.09748445,
                UyCO2_Cov = 0.1134349,
                UzCO2_Cov = -0.04178881,
                UxH2O_Cov = -0.003684159,
                UyH2O_Cov = -0.1009904,
                UzH2O_Cov = 0.02445646,
                uCO2_Cov_R = 0.1297143,
                vCO2_Cov_R = -0.07403947,
                wCO2_Cov_R = -0.04253646,
                uH2O_Cov_R = -0.09969425,
                vH2O_Cov_R = -0.01566072,
                wH2O_Cov_R = 0.02503095,
                wCO2_Cov_R_F = -0.04382965,
                wH2O_Cov_R_F = 0.02579194,
                CO2_E_WPL_R_F = 0.02497661,
                CO2_T_WPL_R_F = 0.04338025,
                H2O_E_WPL_R_F = 0.0001633125,
                H2O_T_WPL_R_F = 0.0002836469,
                CO2_samples_Tot = 18000,
                H2O_samples_Tot = 18000,
                no_irga_head_Tot = 0,
                no_new_irga_data_Tot = 0,
                irga_bad_data_f_Tot = 0,
                irga_gen_fault_f_Tot = 0,
                irga_startup_f_Tot = 0,
                irga_motor_spd_f_Tot = 0,
                irga_tec_tmpr_f_Tot = 0,
                irga_src_pwr_f_Tot = 0,
                irga_src_tmpr_f_Tot = 0,
                irga_src_curr_f_Tot = 0,
                irga_off_f_Tot = 0,
                irga_sync_f_Tot = 0,
                irga_amb_tmpr_f_Tot = 0,
                irga_amb_press_f_Tot = 0,
                irga_CO2_I_f_Tot = 0,
                irga_CO2_Io_f_Tot = 0,
                irga_H2O_I_f_Tot = 0,
                irga_H2O_Io_f_Tot = 0,
                irga_CO2_Io_var_f_Tot = 0,
                irga_H2O_Io_var_f_Tot = 0,
                irga_CO2_sig_strgth_f_Tot = 0,
                irga_H2O_sig_strgth_f_Tot = 0,
                irga_cal_err_f_Tot = 0,
                irga_htr_ctrl_off_f_Tot = 0,
                alpha = -0.3299308,
                beta = 0,
                gamma = 78.9958,
                height_measurement = 2.23,
                height_canopy = 0.2,
                surface_type_text = "Crop",
                displacement_user = 0,
                d = 0.1451137,
                roughness_user = 0,
                z0 = 0.01177848,
                z = 2.084886,
                L = -183.1485,
                stability_zL = -0.01138359,
                iteration_FreqFactor = 1,
                latitude = 46.78152,
                longitude = 117,
                separation_x_irga = 0.04066,
                separation_y_irga = 0.02905,
                separation_lat_dist_irga = -0.0343673,
                separation_lag_dist_irga = 0.03627708,
                separation_lag_scan_irga = 0.0757097,
                MAX_LAG = 2,
                lag_irga = 0,
                FreqFactor_uw_vw = 1.006122,
                FreqFactor_wTs = 1.007074,
                FreqFactor_wCO2_wH2O = 1.030402,
                rho_d_Avg = 1.14265,
                rho_a_Avg = 1.147149,
                Cp = 1007.718,
                Lv = 2484.099,
                door_is_open_Hst = 0,
                panel_tmpr_Avg = 9.453013,
                batt_volt_Avg = 12.87643,
                slowsequence_Tot = 180,
                process_time_Avg = 92.20594,
                process_time_Max = 7608.585,
                buff_depth_Max = 76
            });

            flux.Metadata = new Metadata()
            {
                FileFormat = "TOA5",
                StationName = "LTAR_CookEast",
                DataLoggerType = "CR3000",
                SerialNumber = 6503,
                OperatingSystemVersion = "CR3000.Std.31.09",
                DataloggerProgramName = "CPU:default.cr3",
                DataloggerProgramSignature = 28444,
                TableName = "Flux",

                Variables = new List<Variable>()
                {
                    new Variable() { FieldName = "TIMESTAMP", Units = "TS", Processing = "" },
                    new Variable() { FieldName = "RECORD", Units = "RN", Processing = "" },
                    new Variable() { FieldName = "old_L", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "old_u_star", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "old_Fc_wpl", Units = "mg/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "old_Fc_hf_wpl", Units = "mg/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "old_LE_wpl", Units = "W/m^2", Processing = "Smp" },
                    new Variable() { FieldName = "old_Hc", Units = "W/m^2", Processing = "Smp" },
                    new Variable() { FieldName = "old_Uz_Std", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "old_CO2_mg_m3_Avg", Units = "mg/m^3", Processing = "Smp" },
                    new Variable() { FieldName = "old_CO2_mg_m3_Std", Units = "mg/m^3", Processing = "Smp" },
                    new Variable() { FieldName = "old_CO2_hf_mg_m3_Avg", Units = "", Processing = "Smp" },
                    new Variable() { FieldName = "old_CO2_hf_mg_m3_Std", Units = "mg/m^3", Processing = "Smp" },
                    new Variable() { FieldName = "old_Tc_Avg", Units = "C", Processing = "Smp" },
                    new Variable() { FieldName = "old_amb_press_Avg", Units = "kPa", Processing = "Smp" },
                    new Variable() { FieldName = "Fc_molar", Units = "umol/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "Fc_mass", Units = "mg/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "Fc_qc_grade", Units = "Grade", Processing = "Smp" },
                    new Variable() { FieldName = "Fc_samples_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "LE", Units = "W/m^2", Processing = "Smp" },
                    new Variable() { FieldName = "LE_qc_grade", Units = "Grade", Processing = "Smp" },
                    new Variable() { FieldName = "LE_samples_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "H", Units = "W/m^2", Processing = "Smp" },
                    new Variable() { FieldName = "H_qc_grade", Units = "Grade", Processing = "Smp" },
                    new Variable() { FieldName = "H_samples_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "Rn", Units = "W/m^2", Processing = "Smp" },
                    new Variable() { FieldName = "G_surface", Units = "W/m^2", Processing = "Smp" },
                    new Variable() { FieldName = "energy_closure", Units = "Fraction", Processing = "Smp" },
                    new Variable() { FieldName = "Bowen_ratio", Units = "fraction", Processing = "Smp" },
                    new Variable() { FieldName = "tau", Units = "(kg m/s)/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "tau_qc_grade", Units = "Grade", Processing = "Smp" },
                    new Variable() { FieldName = "u_star", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "T_star", Units = "C", Processing = "Smp" },
                    new Variable() { FieldName = "TKE", Units = "m^2/s^2", Processing = "Smp" },
                    new Variable() { FieldName = "amb_tmpr_Avg", Units = "C", Processing = "Smp" },
                    new Variable() { FieldName = "Td_Avg", Units = "C", Processing = "Avg" },
                    new Variable() { FieldName = "RH_Avg", Units = "%", Processing = "Smp" },
                    new Variable() { FieldName = "e_sat_Avg", Units = "kPa", Processing = "Smp" },
                    new Variable() { FieldName = "e_Avg", Units = "kPa", Processing = "Smp" },
                    new Variable() { FieldName = "amb_press_Avg", Units = "kPa", Processing = "Smp" },
                    new Variable() { FieldName = "VPD_air", Units = "kpa", Processing = "Smp" },
                    new Variable() { FieldName = "Ux_Avg", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "Ux_Std", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "Uy_Avg", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "Uy_Std", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "Uz_Avg", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "Uz_Std", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "Ts_Avg", Units = "C", Processing = "Smp" },
                    new Variable() { FieldName = "Ts_Std", Units = "C", Processing = "Smp" },
                    new Variable() { FieldName = "sonic_azimuth", Units = "degrees", Processing = "Smp" },
                    new Variable() { FieldName = "wnd_spd", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "rslt_wnd_spd", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "wnd_dir_sonic", Units = "degrees", Processing = "Smp" },
                    new Variable() { FieldName = "std_wnd_dir", Units = "degrees", Processing = "Smp" },
                    new Variable() { FieldName = "wnd_dir_compass", Units = "degrees", Processing = "Smp" },
                    new Variable() { FieldName = "CO2_molfrac_Avg", Units = "umol/mol", Processing = "Smp" },
                    new Variable() { FieldName = "CO2_mixratio_Avg", Units = "umol/mol", Processing = "Avg" },
                    new Variable() { FieldName = "CO2_Avg", Units = "mg/m^3", Processing = "Smp" },
                    new Variable() { FieldName = "CO2_Std", Units = "mg/m^3", Processing = "Smp" },
                    new Variable() { FieldName = "H2O_molfrac_Avg", Units = "mmol/mol", Processing = "Smp" },
                    new Variable() { FieldName = "H2O_mixratio_Avg", Units = "mmol/mol", Processing = "Avg" },
                    new Variable() { FieldName = "H2O_Avg", Units = "g/m^3", Processing = "Smp" },
                    new Variable() { FieldName = "H2O_Std", Units = "g/m^3", Processing = "Smp" },
                    new Variable() { FieldName = "CO2_sig_strgth_Min", Units = "fraction", Processing = "Min" },
                    new Variable() { FieldName = "H2O_sig_strgth_Min", Units = "fraction", Processing = "Min" },
                    new Variable() { FieldName = "T_probe_Avg", Units = "C", Processing = "Smp" },
                    new Variable() { FieldName = "e_probe_Avg", Units = "kPa", Processing = "Smp" },
                    new Variable() { FieldName = "e_sat_probe_Avg", Units = "kPa", Processing = "Smp" },
                    new Variable() { FieldName = "Td_probe_Avg", Units = "C", Processing = "Avg" },
                    new Variable() { FieldName = "H2O_probe_Avg", Units = "g/m^3", Processing = "Smp" },
                    new Variable() { FieldName = "RH_probe_Avg", Units = "%", Processing = "Smp" },
                    new Variable() { FieldName = "rho_a_probe_Avg", Units = "kg/m^3", Processing = "Smp" },
                    new Variable() { FieldName = "rho_d_probe_Avg", Units = "kg/m^3", Processing = "Smp" },
                    new Variable() { FieldName = "Precipitation_Tot", Units = "mm", Processing = "Tot" },
                    new Variable() { FieldName = "Rn_meas_Avg", Units = "W/m^2", Processing = "Avg" },
                    new Variable() { FieldName = "NRLITE_SENS", Units = "uV/W/m^2", Processing = "Smp" },
                    new Variable() { FieldName = "PAR_density_Avg", Units = "umol/(s m^2)", Processing = "Avg" },
                    new Variable() { FieldName = "QUANTUM_SENS", Units = "uA/mmol/m^2/s", Processing = "Smp" },
                    new Variable() { FieldName = "cupvane_WS_Avg", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "cupvane_WS_rslt_Avg", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "cupvane_WD_rslt_Avg", Units = "degrees", Processing = "Smp" },
                    new Variable() { FieldName = "cupvane_WD_csi_Std", Units = "degrees", Processing = "Smp" },
                    new Variable() { FieldName = "Tsoil_Avg", Units = "C", Processing = "Avg" },
                    new Variable() { FieldName = "tdr315_wc_Avg(1)", Units = "%", Processing = "Avg" },
                    new Variable() { FieldName = "tdr315_wc_Avg(2)", Units = "%", Processing = "Avg" },
                    new Variable() { FieldName = "tdr315_tmpr_Avg(1)", Units = "C", Processing = "Avg" },
                    new Variable() { FieldName = "tdr315_tmpr_Avg(2)", Units = "C", Processing = "Avg" },
                    new Variable() { FieldName = "tdr315_E_Avg(1)", Units = "unitless", Processing = "Avg" },
                    new Variable() { FieldName = "tdr315_E_Avg(2)", Units = "unitless", Processing = "Avg" },
                    new Variable() { FieldName = "tdr315_bulkEC_Avg(1)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "tdr315_bulkEC_Avg(2)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "tdr315_poreEC_Avg(1)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "tdr315_poreEC_Avg(2)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "shf_plate_avg", Units = "W/m^2", Processing = "Smp" },
                    new Variable() { FieldName = "SHFP_1_SENS", Units = "uv/W/m^2", Processing = "Smp" },
                    new Variable() { FieldName = "profile_tdr315_wc_Avg(1)", Units = "%", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_wc_Avg(2)", Units = "%", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_wc_Avg(3)", Units = "%", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_wc_Avg(4)", Units = "%", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_wc_Avg(5)", Units = "%", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_wc_Avg(6)", Units = "%", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_tmpr_Avg(1)", Units = "C", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_tmpr_Avg(2)", Units = "C", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_tmpr_Avg(3)", Units = "C", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_tmpr_Avg(4)", Units = "C", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_tmpr_Avg(5)", Units = "C", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_tmpr_Avg(6)", Units = "C", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_E_Avg(1)", Units = "unitless", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_E_Avg(2)", Units = "unitless", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_E_Avg(3)", Units = "unitless", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_E_Avg(4)", Units = "unitless", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_E_Avg(5)", Units = "unitless", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_E_Avg(6)", Units = "unitless", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_bulkEC_Avg(1)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_bulkEC_Avg(2)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_bulkEC_Avg(3)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_bulkEC_Avg(4)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_bulkEC_Avg(5)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_bulkEC_Avg(6)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_poreEC_Avg(1)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_poreEC_Avg(2)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_poreEC_Avg(3)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_poreEC_Avg(4)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_poreEC_Avg(5)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr315_poreEC_Avg(6)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "upwnd_dist_intrst", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "FP_dist_intrst", Units = "%", Processing = "Smp" },
                    new Variable() { FieldName = "FP_max", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "FP_40", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "FP_55", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "FP_90", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "FP_Equation", Units = "authors", Processing = "Smp" },
                    new Variable() { FieldName = "UxUy_Cov", Units = "(m/s)^2", Processing = "Smp" },
                    new Variable() { FieldName = "UxUz_Cov", Units = "(m/s)^2", Processing = "Smp" },
                    new Variable() { FieldName = "UyUz_Cov", Units = "(m/s)^2", Processing = "Smp" },
                    new Variable() { FieldName = "TsUx_Cov", Units = "C m/s", Processing = "Smp" },
                    new Variable() { FieldName = "TsUy_Cov", Units = "C m/s", Processing = "Smp" },
                    new Variable() { FieldName = "TsUz_Cov", Units = "C m/s", Processing = "Smp" },
                    new Variable() { FieldName = "u_star_R", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "u_Avg_R", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "u_Std_R", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "v_Avg_R", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "v_Std_R", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "w_Avg_R", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "w_Std_R", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "uv_Cov_R", Units = "(m/s)^2", Processing = "Smp" },
                    new Variable() { FieldName = "uw_Cov_R", Units = "(m/s)^2", Processing = "Smp" },
                    new Variable() { FieldName = "vw_Cov_R", Units = "(m/s)^2", Processing = "Smp" },
                    new Variable() { FieldName = "uTs_Cov_R", Units = "C m/s", Processing = "Smp" },
                    new Variable() { FieldName = "vTs_Cov_R", Units = "C m/s", Processing = "Smp" },
                    new Variable() { FieldName = "wTs_Cov_R", Units = "C m/s", Processing = "Smp" },
                    new Variable() { FieldName = "uw_Cov_R_F", Units = "(m/s)^2", Processing = "Smp" },
                    new Variable() { FieldName = "vw_Cov_R_F", Units = "(m/s)^2", Processing = "Smp" },
                    new Variable() { FieldName = "wTs_Cov_R_F", Units = "C m/s", Processing = "Smp" },
                    new Variable() { FieldName = "wTs_Cov_R_F_SND", Units = "C m/s", Processing = "Smp" },
                    new Variable() { FieldName = "sonic_samples_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "no_sonic_head_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "no_new_sonic_data_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "sonic_amp_l_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "sonic_amp_h_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "sonic_sig_lck_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "sonic_del_T_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "sonic_aq_sig_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "sonic_cal_err_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "UxCO2_Cov", Units = "mg/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "UyCO2_Cov", Units = "mg/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "UzCO2_Cov", Units = "mg/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "UxH2O_Cov", Units = "g/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "UyH2O_Cov", Units = "g/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "UzH2O_Cov", Units = "g/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "uCO2_Cov_R", Units = "mg/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "vCO2_Cov_R", Units = "mg/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "wCO2_Cov_R", Units = "mg/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "uH2O_Cov_R", Units = "g/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "vH2O_Cov_R", Units = "g/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "wH2O_Cov_R", Units = "g/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "wCO2_Cov_R_F", Units = "mg/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "wH2O_Cov_R_F", Units = "g/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "CO2_E_WPL_R_F", Units = "mg/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "CO2_T_WPL_R_F", Units = "mg/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "H2O_E_WPL_R_F", Units = "g/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "H2O_T_WPL_R_F", Units = "g/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "CO2_samples_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "H2O_samples_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "no_irga_head_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "no_new_irga_data_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_bad_data_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_gen_fault_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_startup_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_motor_spd_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_tec_tmpr_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_src_pwr_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_src_tmpr_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_src_curr_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_off_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_sync_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_amb_tmpr_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_amb_press_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_CO2_I_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_CO2_Io_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_H2O_I_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_H2O_Io_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_CO2_Io_var_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_H2O_Io_var_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_CO2_sig_strgth_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_H2O_sig_strgth_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_cal_err_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_htr_ctrl_off_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "alpha", Units = "degrees", Processing = "Smp" },
                    new Variable() { FieldName = "beta", Units = "degrees", Processing = "Smp" },
                    new Variable() { FieldName = "gamma", Units = "degrees", Processing = "Smp" },
                    new Variable() { FieldName = "height_measurement", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "height_canopy", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "surface_type_text", Units = "", Processing = "Smp" },
                    new Variable() { FieldName = "displacement_user", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "d", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "roughness_user", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "z0", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "z", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "L", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "stability_zL", Units = "unitless", Processing = "Smp" },
                    new Variable() { FieldName = "iteration_FreqFactor", Units = "", Processing = "Smp" },
                    new Variable() { FieldName = "latitude", Units = "degrees", Processing = "Smp" },
                    new Variable() { FieldName = "longitude", Units = "degrees", Processing = "Smp" },
                    new Variable() { FieldName = "separation_x_irga", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "separation_y_irga", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "separation_lat_dist_irga", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "separation_lag_dist_irga", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "separation_lag_scan_irga", Units = "scans", Processing = "Smp" },
                    new Variable() { FieldName = "MAX_LAG", Units = "", Processing = "Smp" },
                    new Variable() { FieldName = "lag_irga", Units = "scans", Processing = "Smp" },
                    new Variable() { FieldName = "FreqFactor_uw_vw", Units = "unitless", Processing = "Smp" },
                    new Variable() { FieldName = "FreqFactor_wTs", Units = "unitless", Processing = "Smp" },
                    new Variable() { FieldName = "FreqFactor_wCO2_wH2O", Units = "unitless", Processing = "Smp" },
                    new Variable() { FieldName = "rho_d_Avg", Units = "kg/m^3", Processing = "Smp" },
                    new Variable() { FieldName = "rho_a_Avg", Units = "kg/m^3", Processing = "Smp" },
                    new Variable() { FieldName = "Cp", Units = "J/(kg C)", Processing = "Smp" },
                    new Variable() { FieldName = "Lv", Units = "J/g", Processing = "Smp" },
                    new Variable() { FieldName = "door_is_open_Hst", Units = "", Processing = "Hst,1,1.0000e+00,5.0000e-01,1.5000e+00" },
                    new Variable() { FieldName = "panel_tmpr_Avg", Units = "C", Processing = "Avg" },
                    new Variable() { FieldName = "batt_volt_Avg", Units = "V", Processing = "Avg" },
                    new Variable() { FieldName = "slowsequence_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "process_time_Avg", Units = "ms", Processing = "Avg" },
                    new Variable() { FieldName = "process_time_Max", Units = "ms", Processing = "Max" },
                    new Variable() { FieldName = "buff_depth_Max", Units = "scans", Processing = "Max" }
                }
            };

            return flux;
        }

        public static TOA5 GetToa5FluxDerivedFromTestDataV2()
        {
            TOA5 flux = new TOA5();

            flux.Observations = GetFluxObservationsDerivedFromTestDataV2();
            flux.Metadata = new Metadata()
            {
                FileFormat = "TOA5",
                StationName = "LTAR_CookEast",
                DataLoggerType = "CR3000",
                SerialNumber = 11205,
                OperatingSystemVersion = "CR3000.Std.28.02",
                DataloggerProgramName = "CPU:default.cr3",
                DataloggerProgramSignature = 64331,
                TableName = "Flux",

                Variables = new List<Variable>()
                {
                    new Variable() { FieldName = "TIMESTAMP", Units = "TS", Processing = "" },
                    new Variable() { FieldName = "RECORD", Units = "RN", Processing = "" },
                    new Variable() { FieldName = "Fc_molar", Units = "umol/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "Fc_mass", Units = "mg/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "Fc_qc_grade", Units = "Grade", Processing = "Smp" },
                    new Variable() { FieldName = "Fc_samples_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "LE", Units = "W/m^2", Processing = "Smp" },
                    new Variable() { FieldName = "LE_qc_grade", Units = "Grade", Processing = "Smp" },
                    new Variable() { FieldName = "LE_samples_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "H", Units = "W/m^2", Processing = "Smp" },
                    new Variable() { FieldName = "H_qc_grade", Units = "Grade", Processing = "Smp" },
                    new Variable() { FieldName = "H_samples_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "Rn", Units = "W/m^2", Processing = "Smp" },
                    new Variable() { FieldName = "G_surface", Units = "W/m^2", Processing = "Smp" },
                    new Variable() { FieldName = "energy_closure", Units = "Fraction", Processing = "Smp" },
                    new Variable() { FieldName = "Bowen_ratio", Units = "fraction", Processing = "Smp" },
                    new Variable() { FieldName = "tau", Units = "(kg m/s)/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "tau_qc_grade", Units = "Grade", Processing = "Smp" },
                    new Variable() { FieldName = "u_star", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "T_star", Units = "C", Processing = "Smp" },
                    new Variable() { FieldName = "TKE", Units = "m^2/s^2", Processing = "Smp" },
                    new Variable() { FieldName = "amb_tmpr_Avg", Units = "C", Processing = "Smp" },
                    new Variable() { FieldName = "Td_Avg", Units = "C", Processing = "Avg" },
                    new Variable() { FieldName = "RH_Avg", Units = "%", Processing = "Smp" },
                    new Variable() { FieldName = "e_sat_Avg", Units = "kPa", Processing = "Smp" },
                    new Variable() { FieldName = "e_Avg", Units = "kPa", Processing = "Smp" },
                    new Variable() { FieldName = "amb_press_Avg", Units = "kPa", Processing = "Smp" },
                    new Variable() { FieldName = "VPD_air", Units = "kpa", Processing = "Smp" },
                    new Variable() { FieldName = "Ux_Avg", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "Ux_Std", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "Uy_Avg", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "Uy_Std", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "Uz_Avg", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "Uz_Std", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "Ts_Avg", Units = "C", Processing = "Smp" },
                    new Variable() { FieldName = "Ts_Std", Units = "C", Processing = "Smp" },
                    new Variable() { FieldName = "sonic_azimuth", Units = "degrees", Processing = "Smp" },
                    new Variable() { FieldName = "wnd_spd", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "rslt_wnd_spd", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "wnd_dir_sonic", Units = "degrees", Processing = "Smp" },
                    new Variable() { FieldName = "std_wnd_dir", Units = "degrees", Processing = "Smp" },
                    new Variable() { FieldName = "wnd_dir_compass", Units = "degrees", Processing = "Smp" },
                    new Variable() { FieldName = "CO2_molfrac_Avg", Units = "umol/mol", Processing = "Smp" },
                    new Variable() { FieldName = "CO2_mixratio_Avg", Units = "umol/mol", Processing = "Avg" },
                    new Variable() { FieldName = "CO2_Avg", Units = "mg/m^3", Processing = "Smp" },
                    new Variable() { FieldName = "CO2_Std", Units = "mg/m^3", Processing = "Smp" },
                    new Variable() { FieldName = "H2O_molfrac_Avg", Units = "mmol/mol", Processing = "Smp" },
                    new Variable() { FieldName = "H2O_mixratio_Avg", Units = "mmol/mol", Processing = "Avg" },
                    new Variable() { FieldName = "H2O_Avg", Units = "g/m^3", Processing = "Smp" },
                    new Variable() { FieldName = "H2O_Std", Units = "g/m^3", Processing = "Smp" },
                    new Variable() { FieldName = "CO2_sig_strgth_Min", Units = "fraction", Processing = "Min" },
                    new Variable() { FieldName = "H2O_sig_strgth_Min", Units = "fraction", Processing = "Min" },
                    new Variable() { FieldName = "T_probe_Avg", Units = "C", Processing = "Smp" },
                    new Variable() { FieldName = "e_probe_Avg", Units = "kPa", Processing = "Smp" },
                    new Variable() { FieldName = "e_sat_probe_Avg", Units = "kPa", Processing = "Smp" },
                    new Variable() { FieldName = "Td_probe_Avg", Units = "C", Processing = "Avg" },
                    new Variable() { FieldName = "H2O_probe_Avg", Units = "g/m^3", Processing = "Smp" },
                    new Variable() { FieldName = "RH_probe_Avg", Units = "%", Processing = "Smp" },
                    new Variable() { FieldName = "rho_a_probe_Avg", Units = "kg/m^3", Processing = "Smp" },
                    new Variable() { FieldName = "rho_d_probe_Avg", Units = "kg/m^3", Processing = "Smp" },
                    new Variable() { FieldName = "Precipitation_Tot", Units = "mm", Processing = "Tot" },
                    new Variable() { FieldName = "Rn_meas_Avg", Units = "W/m^2", Processing = "Avg" },
                    new Variable() { FieldName = "NRLITE_SENS", Units = "uV/W/m^2", Processing = "Smp" },
                    new Variable() { FieldName = "PAR_density_Avg", Units = "umol/(s m^2)", Processing = "Avg" },
                    new Variable() { FieldName = "QUANTUM_SENS", Units = "uA/mmol/m^2/s", Processing = "Smp" },
                    new Variable() { FieldName = "cupvane_WS_Avg", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "cupvane_WS_rslt_Avg", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "cupvane_WD_rslt_Avg", Units = "degrees", Processing = "Smp" },
                    new Variable() { FieldName = "cupvane_WD_csi_Std", Units = "degrees", Processing = "Smp" },
                    new Variable() { FieldName = "Tsoil_Avg", Units = "C", Processing = "Avg" },
                    new Variable() { FieldName = "tdr31X_wc_Avg", Units = "%", Processing = "Avg" },
                    new Variable() { FieldName = "tdr31X_tmpr_Avg", Units = "C", Processing = "Avg" },
                    new Variable() { FieldName = "tdr31X_E_Avg", Units = "unitless", Processing = "Avg" },
                    new Variable() { FieldName = "tdr31X_bulkEC_Avg", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "tdr31X_poreEC_Avg", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "shf_plate_avg", Units = "W/m^2", Processing = "Smp" },
                    new Variable() { FieldName = "SHFP_1_SENS", Units = "uv/W/m^2", Processing = "Smp" },
                    new Variable() { FieldName = "profile_tdr31X_wc_Avg(1)", Units = "%", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_wc_Avg(2)", Units = "%", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_wc_Avg(3)", Units = "%", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_wc_Avg(4)", Units = "%", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_wc_Avg(5)", Units = "%", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_wc_Avg(6)", Units = "%", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_tmpr_Avg(1)", Units = "C", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_tmpr_Avg(2)", Units = "C", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_tmpr_Avg(3)", Units = "C", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_tmpr_Avg(4)", Units = "C", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_tmpr_Avg(5)", Units = "C", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_tmpr_Avg(6)", Units = "C", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_E_Avg(1)", Units = "unitless", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_E_Avg(2)", Units = "unitless", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_E_Avg(3)", Units = "unitless", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_E_Avg(4)", Units = "unitless", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_E_Avg(5)", Units = "unitless", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_E_Avg(6)", Units = "unitless", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_bulkEC_Avg(1)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_bulkEC_Avg(2)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_bulkEC_Avg(3)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_bulkEC_Avg(4)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_bulkEC_Avg(5)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_bulkEC_Avg(6)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_poreEC_Avg(1)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_poreEC_Avg(2)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_poreEC_Avg(3)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_poreEC_Avg(4)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_poreEC_Avg(5)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "profile_tdr31X_poreEC_Avg(6)", Units = "uS/cm", Processing = "Avg" },
                    new Variable() { FieldName = "upwnd_dist_intrst", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "FP_dist_intrst", Units = "%", Processing = "Smp" },
                    new Variable() { FieldName = "FP_max", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "FP_40", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "FP_55", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "FP_90", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "FP_Equation", Units = "authors", Processing = "Smp" },
                    new Variable() { FieldName = "UxUy_Cov", Units = "(m/s)^2", Processing = "Smp" },
                    new Variable() { FieldName = "UxUz_Cov", Units = "(m/s)^2", Processing = "Smp" },
                    new Variable() { FieldName = "UyUz_Cov", Units = "(m/s)^2", Processing = "Smp" },
                    new Variable() { FieldName = "TsUx_Cov", Units = "C m/s", Processing = "Smp" },
                    new Variable() { FieldName = "TsUy_Cov", Units = "C m/s", Processing = "Smp" },
                    new Variable() { FieldName = "TsUz_Cov", Units = "C m/s", Processing = "Smp" },
                    new Variable() { FieldName = "u_star_R", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "u_Avg_R", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "u_Std_R", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "v_Avg_R", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "v_Std_R", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "w_Avg_R", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "w_Std_R", Units = "m/s", Processing = "Smp" },
                    new Variable() { FieldName = "uv_Cov_R", Units = "(m/s)^2", Processing = "Smp" },
                    new Variable() { FieldName = "uw_Cov_R", Units = "(m/s)^2", Processing = "Smp" },
                    new Variable() { FieldName = "vw_Cov_R", Units = "(m/s)^2", Processing = "Smp" },
                    new Variable() { FieldName = "uTs_Cov_R", Units = "C m/s", Processing = "Smp" },
                    new Variable() { FieldName = "vTs_Cov_R", Units = "C m/s", Processing = "Smp" },
                    new Variable() { FieldName = "wTs_Cov_R", Units = "C m/s", Processing = "Smp" },
                    new Variable() { FieldName = "uw_Cov_R_F", Units = "(m/s)^2", Processing = "Smp" },
                    new Variable() { FieldName = "vw_Cov_R_F", Units = "(m/s)^2", Processing = "Smp" },
                    new Variable() { FieldName = "wTs_Cov_R_F", Units = "C m/s", Processing = "Smp" },
                    new Variable() { FieldName = "wTs_Cov_R_F_SND", Units = "C m/s", Processing = "Smp" },
                    new Variable() { FieldName = "sonic_samples_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "no_sonic_head_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "no_new_sonic_data_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "sonic_amp_l_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "sonic_amp_h_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "sonic_sig_lck_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "sonic_del_T_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "sonic_aq_sig_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "sonic_cal_err_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "UxCO2_Cov", Units = "mg/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "UyCO2_Cov", Units = "mg/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "UzCO2_Cov", Units = "mg/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "UxH2O_Cov", Units = "g/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "UyH2O_Cov", Units = "g/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "UzH2O_Cov", Units = "g/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "uCO2_Cov_R", Units = "mg/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "vCO2_Cov_R", Units = "mg/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "wCO2_Cov_R", Units = "mg/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "uH2O_Cov_R", Units = "g/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "vH2O_Cov_R", Units = "g/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "wH2O_Cov_R", Units = "g/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "wCO2_Cov_R_F", Units = "mg/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "wH2O_Cov_R_F", Units = "g/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "CO2_E_WPL_R_F", Units = "mg/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "CO2_T_WPL_R_F", Units = "mg/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "H2O_E_WPL_R_F", Units = "g/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "H2O_T_WPL_R_F", Units = "g/(m^2 s)", Processing = "Smp" },
                    new Variable() { FieldName = "CO2_samples_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "H2O_samples_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "no_irga_head_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "no_new_irga_data_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_bad_data_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_gen_fault_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_startup_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_motor_spd_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_tec_tmpr_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_src_pwr_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_src_tmpr_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_src_curr_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_off_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_sync_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_amb_tmpr_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_amb_press_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_CO2_I_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_CO2_Io_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_H2O_I_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_H2O_Io_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_CO2_Io_var_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_H2O_Io_var_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_CO2_sig_strgth_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_H2O_sig_strgth_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_cal_err_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "irga_htr_ctrl_off_f_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "alpha", Units = "degrees", Processing = "Smp" },
                    new Variable() { FieldName = "beta", Units = "degrees", Processing = "Smp" },
                    new Variable() { FieldName = "gamma", Units = "degrees", Processing = "Smp" },
                    new Variable() { FieldName = "height_measurement", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "height_canopy", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "surface_type_text", Units = "", Processing = "Smp" },
                    new Variable() { FieldName = "displacement_user", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "d", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "roughness_user", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "z0", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "z", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "L", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "stability_zL", Units = "unitless", Processing = "Smp" },
                    new Variable() { FieldName = "iteration_FreqFactor", Units = "", Processing = "Smp" },
                    new Variable() { FieldName = "latitude", Units = "degrees", Processing = "Smp" },
                    new Variable() { FieldName = "longitude", Units = "degrees", Processing = "Smp" },
                    new Variable() { FieldName = "separation_x_irga", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "separation_y_irga", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "separation_lat_dist_irga", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "separation_lag_dist_irga", Units = "m", Processing = "Smp" },
                    new Variable() { FieldName = "separation_lag_scan_irga", Units = "scans", Processing = "Smp" },
                    new Variable() { FieldName = "MAX_LAG", Units = "", Processing = "Smp" },
                    new Variable() { FieldName = "lag_irga", Units = "scans", Processing = "Smp" },
                    new Variable() { FieldName = "FreqFactor_uw_vw", Units = "unitless", Processing = "Smp" },
                    new Variable() { FieldName = "FreqFactor_wTs", Units = "unitless", Processing = "Smp" },
                    new Variable() { FieldName = "FreqFactor_wCO2_wH2O", Units = "unitless", Processing = "Smp" },
                    new Variable() { FieldName = "rho_d_Avg", Units = "kg/m^3", Processing = "Smp" },
                    new Variable() { FieldName = "rho_a_Avg", Units = "kg/m^3", Processing = "Smp" },
                    new Variable() { FieldName = "Cp", Units = "J/(kg C)", Processing = "Smp" },
                    new Variable() { FieldName = "Lv", Units = "J/g", Processing = "Smp" },
                    new Variable() { FieldName = "door_is_open_Hst", Units = "", Processing = "Hst,1,1.0000e+00,5.0000e-01,1.5000e+00" },
                    new Variable() { FieldName = "panel_tmpr_Avg", Units = "C", Processing = "Avg" },
                    new Variable() { FieldName = "batt_volt_Avg", Units = "V", Processing = "Avg" },
                    new Variable() { FieldName = "slowsequence_Tot", Units = "samples", Processing = "Tot" },
                    new Variable() { FieldName = "process_time_Avg", Units = "ms", Processing = "Avg" },
                    new Variable() { FieldName = "process_time_Max", Units = "ms", Processing = "Max" },
                    new Variable() { FieldName = "buff_depth_Max", Units = "scans", Processing = "Max" }
                }
            };

            return flux;
        }

        public static TOA5 GetToa5MeteorologyDerivedFromTestDataV2()
        {
            TOA5 met = new TOA5();

            met.Observations = GetMeteorologyObservationsDerivedFromTestDataV2();
            met.Metadata = new Metadata()
            {
                FileFormat = "TOA5",
                StationName = "LTAR_CookEast",
                DataLoggerType = "CR3000",
                SerialNumber = 11205,
                OperatingSystemVersion = "CR3000.Std.28.02",
                DataloggerProgramName = "CPU:default.cr3",
                DataloggerProgramSignature = 64331,
                TableName = "LTAR_Met",

                Variables = new List<Variable>()
                {
                    new Variable() { FieldName = "TIMESTAMP", Units = "TS", Processing = "" },
new Variable() { FieldName = "RECORD", Units = "RN", Processing = "" },
new Variable() { FieldName = "amb_tmpr_Avg", Units = "C", Processing = "Avg" },
new Variable() { FieldName = "rslt_wnd_spd", Units = "m/s", Processing = "Smp" },
new Variable() { FieldName = "wnd_dir_compass", Units = "degrees", Processing = "Smp" },
new Variable() { FieldName = "RH_Avg", Units = "%", Processing = "Avg" },
new Variable() { FieldName = "Precipitation_Tot", Units = "mm", Processing = "Tot" },
new Variable() { FieldName = "amb_press_Avg", Units = "kPa", Processing = "Avg" },
new Variable() { FieldName = "PAR_density_Avg", Units = "umol/(s m^2)", Processing = "Avg" },
new Variable() { FieldName = "batt_volt_Avg", Units = "V", Processing = "Avg" },
new Variable() { FieldName = "panel_tmpr_Avg", Units = "C", Processing = "Avg" },
new Variable() { FieldName = "std_wnd_dir", Units = "degrees", Processing = "Smp" },
new Variable() { FieldName = "VPD_air", Units = "kpa", Processing = "Smp" },
new Variable() { FieldName = "Rn_meas_Avg", Units = "W/m^2", Processing = "Avg" },
new Variable() { FieldName = "e_sat", Units = "kPa", Processing = "Smp" },
new Variable() { FieldName = "e", Units = "kPa", Processing = "Smp" },
new Variable() { FieldName = "tdr31X_wc_Avg", Units = "%", Processing = "Avg" },
new Variable() { FieldName = "tdr31X_tmpr_Avg", Units = "C", Processing = "Avg" },
new Variable() { FieldName = "tdr31X_E_Avg", Units = "unitless", Processing = "Avg" },
new Variable() { FieldName = "tdr31X_bulkEC_Avg", Units = "uS/cm", Processing = "Avg" },
new Variable() { FieldName = "tdr31X_poreEC_Avg", Units = "uS/cm", Processing = "Avg" },
new Variable() { FieldName = "Tsoil_Avg", Units = "C", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_wc_Avg(1)", Units = "%", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_wc_Avg(2)", Units = "%", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_wc_Avg(3)", Units = "%", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_wc_Avg(4)", Units = "%", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_wc_Avg(5)", Units = "%", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_wc_Avg(6)", Units = "%", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_tmpr_Avg(1)", Units = "C", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_tmpr_Avg(2)", Units = "C", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_tmpr_Avg(3)", Units = "C", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_tmpr_Avg(4)", Units = "C", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_tmpr_Avg(5)", Units = "C", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_tmpr_Avg(6)", Units = "C", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_E_Avg(1)", Units = "unitless", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_E_Avg(2)", Units = "unitless", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_E_Avg(3)", Units = "unitless", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_E_Avg(4)", Units = "unitless", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_E_Avg(5)", Units = "unitless", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_E_Avg(6)", Units = "unitless", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_bulkEC_Avg(1)", Units = "uS/cm", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_bulkEC_Avg(2)", Units = "uS/cm", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_bulkEC_Avg(3)", Units = "uS/cm", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_bulkEC_Avg(4)", Units = "uS/cm", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_bulkEC_Avg(5)", Units = "uS/cm", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_bulkEC_Avg(6)", Units = "uS/cm", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_poreEC_Avg(1)", Units = "uS/cm", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_poreEC_Avg(2)", Units = "uS/cm", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_poreEC_Avg(3)", Units = "uS/cm", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_poreEC_Avg(4)", Units = "uS/cm", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_poreEC_Avg(5)", Units = "uS/cm", Processing = "Avg" },
new Variable() { FieldName = "profile_tdr31X_poreEC_Avg(6)", Units = "uS/cm", Processing = "Avg" },
new Variable() { FieldName = "shf_plate_avg", Units = "W/m^2", Processing = "Smp" },
new Variable() { FieldName = "SHFP_1_SENS", Units = "uv/W/m^2", Processing = "Smp" },

                }
            };

            return met;
        }

        public static List<MeasurementV2> GetMeasurementsV2DerivedFromActualDataV1()
        {
            List<MeasurementV2> measurements = new List<MeasurementV2>();
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_PressureAirTsAvg", "CookEast_PressureAirTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "PressureAirTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(92.50146, "kPa",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_TemperatureAirTsAvg", "CookEast_TemperatureAirTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "TemperatureAirTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(7.146155, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_BatteryVoltageTsAvg", "CookEast_BatteryVoltageTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "BatteryVoltageTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(12.87643, "V",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_BowenRatio", "CookEast_BowenRatio_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "BowenRatio", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.3114153, "fraction",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_CO2MassDensityTsAvg", "CookEast_CO2MassDensityTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "CO2MassDensityTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(688.1329, "mg/m^3",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_CO2MixingRatioDryTsAvg", "CookEast_CO2MixingRatioDryTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "CO2MixingRatioDryTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(396.423, "umol/mol",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_CO2MolFractionWetTsAvg", "CookEast_CO2MolFractionWetTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "CO2MolFractionWetTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(393.9265, "umol/mol",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_CO2SampleCountTsAccum", "CookEast_CO2SampleCountTsAccum_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "CO2SampleCountTsAccum", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(18000, "samples",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_CO2SignalStrengthTsMin", "CookEast_CO2SignalStrengthTsMin_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "CO2SignalStrengthTsMin", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.963259, "fraction",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_CO2MassDensityTsStdDev", "CookEast_CO2MassDensityTsStdDev_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "CO2MassDensityTsStdDev", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.4237751, "mg/m^3",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_RoughnessLength", "CookEast_RoughnessLength_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "RoughnessLength", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.1451137, "m",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WasEnclosureOpenedTsAvg", "CookEast_WasEnclosureOpenedTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "WasEnclosureOpenedTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_VaporPressureSaturationTsAvg", "CookEast_VaporPressureSaturationTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "VaporPressureSaturationTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.5820282, "kPa",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_VaporPressureTsAvg", "CookEast_VaporPressureTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "VaporPressureTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(1.015924, "kPa",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_CO2CorrectedMass", "CookEast_CO2CorrectedMass_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "CO2CorrectedMass", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.0245272, "mg/(m^2 s)",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_CO2CorrectedMolar", "CookEast_CO2CorrectedMolar_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "CO2CorrectedMolar", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.5573161, "umol/(m^2 s)",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_CO2CorrectedQuality", "CookEast_CO2CorrectedQuality_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "CO2CorrectedQuality", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(3, "Grade",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_FootprintContributionDist40Perc", "CookEast_FootprintContributionDist40Perc_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "FootprintContributionDist40Perc", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(43.10836, "m",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_FootprintContributionDist55Perc", "CookEast_FootprintContributionDist55Perc_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "FootprintContributionDist55Perc", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(56.95799, "m",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_FootprintContributionDist90Perc", "CookEast_FootprintContributionDist90Perc_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "FootprintContributionDist90Perc", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(110.5907, "m",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_FootprintContributionDistMax", "CookEast_FootprintContributionDistMax_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "FootprintContributionDistMax", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(40.0555, "m",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_HeatFluxSensible", "CookEast_HeatFluxSensible_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "HeatFluxSensible", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(20.29806, "W/m^2",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_HeatFluxSensibleQuality", "CookEast_HeatFluxSensibleQuality_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "HeatFluxSensibleQuality", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(3, "Grade",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_H2OMassDensityTsAvg", "CookEast_H2OMassDensityTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "H2OMassDensityTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(4.499438, "g/m^3",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_H2OMixingRatioDryTsAvg", "CookEast_H2OMixingRatioDryTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "H2OMixingRatioDryTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(6.330607, "mmol/mol",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_H2OMolFractionWetTsAvg", "CookEast_H2OMolFractionWetTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "H2OMolFractionWetTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(6.290682, "mmol/mol",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_H2OSampleCountTsAccum", "CookEast_H2OSampleCountTsAccum_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "H2OSampleCountTsAccum", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(18000, "samples",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_H2OSignalStrengthTsMin", "CookEast_H2OSignalStrengthTsMin_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "H2OSignalStrengthTsMin", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.9334315, "fraction",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_H2OMassDensityTsStdDev", "CookEast_H2OMassDensityTsStdDev_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "H2OMassDensityTsStdDev", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.1552989, "g/m^3",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_HeightCanopy", "CookEast_HeightCanopy_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "HeightCanopy", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.2, "m",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_HeightECMeasurement", "CookEast_HeightECMeasurement_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "HeightECMeasurement", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(2.23, "m",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ObukhovLength", "CookEast_ObukhovLength_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "ObukhovLength", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(-183.1485, "m",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_HeatFluxLatent", "CookEast_HeatFluxLatent_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "HeatFluxLatent", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(65.18005, "W/m^2",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_HeatFluxLatentQuality", "CookEast_HeatFluxLatentQuality_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "HeatFluxLatentQuality", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(3, "Grade",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_TemperaturePanelTsAvg", "CookEast_TemperaturePanelTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "TemperaturePanelTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(9.453013, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ParDensityTsAvg", "CookEast_ParDensityTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "ParDensityTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(467.1641, "umol/(s m^2)",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_PrecipitationTsAccum", "CookEast_PrecipitationTsAccum_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "PrecipitationTsAccum", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "mm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityBulk15cmTsAvg", "CookEast_ElectricConductivityBulk15cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "ElectricConductivityBulk15cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(144.3, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityBulk30cmTsAvg", "CookEast_ElectricConductivityBulk30cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "ElectricConductivityBulk30cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(226.9889, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityBulk60cmTsAvg", "CookEast_ElectricConductivityBulk60cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "ElectricConductivityBulk60cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(226.9889, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityBulk90cmTsAvg", "CookEast_ElectricConductivityBulk90cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "ElectricConductivityBulk90cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(226.9889, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityBulk120cmTsAvg", "CookEast_ElectricConductivityBulk120cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "ElectricConductivityBulk120cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(226.9889, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityBulk150cmTsAvg", "CookEast_ElectricConductivityBulk150cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "ElectricConductivityBulk150cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(226.9889, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Permittivity15cmTsAvg", "CookEast_Permittivity15cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "Permittivity15cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(16.39, "unitless",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Permittivity30cmTsAvg", "CookEast_Permittivity30cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "Permittivity30cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(18.17722, "unitless",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Permittivity60cmTsAvg", "CookEast_Permittivity60cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "Permittivity60cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(18.17722, "unitless",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Permittivity90cmTsAvg", "CookEast_Permittivity90cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "Permittivity90cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(18.17722, "unitless",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Permittivity120cmTsAvg", "CookEast_Permittivity120cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "Permittivity120cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(18.17722, "unitless",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Permittivity150cmTsAvg", "CookEast_Permittivity150cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "Permittivity150cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(18.17722, "unitless",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityPore15cmTsAvg", "CookEast_ElectricConductivityPore15cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "ElectricConductivityPore15cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(931.5056, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityPore30cmTsAvg", "CookEast_ElectricConductivityPore30cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "ElectricConductivityPore30cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(1280.556, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityPore60cmTsAvg", "CookEast_ElectricConductivityPore60cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "ElectricConductivityPore60cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(1280.556, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityPore90cmTsAvg", "CookEast_ElectricConductivityPore90cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "ElectricConductivityPore90cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(1280.556, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityPore120cmTsAvg", "CookEast_ElectricConductivityPore120cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "ElectricConductivityPore120cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(1280.556, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityPore150cmTsAvg", "CookEast_ElectricConductivityPore150cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "ElectricConductivityPore150cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(1280.556, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Temperature15cmTsAvg", "CookEast_Temperature15cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "Temperature15cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(4.166667, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Temperature30cmTsAvg", "CookEast_Temperature30cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "Temperature30cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(3.4, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Temperature60cmTsAvg", "CookEast_Temperature60cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "Temperature60cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(3.4, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Temperature90cmTsAvg", "CookEast_Temperature90cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "Temperature90cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(3.4, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Temperature120cmTsAvg", "CookEast_Temperature120cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "Temperature120cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(3.4, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Temperature150cmTsAvg", "CookEast_Temperature150cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "Temperature150cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(3.4, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Vwc15cmTsAvg", "CookEast_Vwc15cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "Vwc15cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(29.63278, "%",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Vwc30cmTsAvg", "CookEast_Vwc30cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "Vwc30cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(32.20333, "%",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Vwc60cmTsAvg", "CookEast_Vwc60cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "Vwc60cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "%",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Vwc90cmTsAvg", "CookEast_Vwc90cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "Vwc90cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "%",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Vwc120cmTsAvg", "CookEast_Vwc120cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "Vwc120cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "%",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Vwc150cmTsAvg", "CookEast_Vwc150cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "Vwc150cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "%",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_HumidityTsAvg", "CookEast_HumidityTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "HumidityTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(57.28835, "%",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_HeatFluxSensibleLatentRatioTsAvg", "CookEast_HeatFluxSensibleLatentRatioTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "HeatFluxSensibleLatentRatioTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(70.20408, "%",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_DensityAirWetTsAvg", "CookEast_DensityAirWetTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "DensityAirWetTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(1.147149, "kg/m^3",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_DensityAirDryTsAvg", "CookEast_DensityAirDryTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "DensityAirDryTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(1.14265, "kg/m^3",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_RadiationNet", "CookEast_RadiationNet_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "RadiationNet", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(93.90979, "W/m^2",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedTsResultant", "CookEast_WindSpeedTsResultant_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "WindSpeedTsResultant", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(4.791603, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_HeatFluxSoilTsAvg", "CookEast_HeatFluxSoilTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "HeatFluxSoilTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(26.42146, "W/m^2",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_SonicAnemometerSampleCountTsAccum", "CookEast_SonicAnemometerSampleCountTsAccum_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "SonicAnemometerSampleCountTsAccum", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(18000, "samples",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_StabilitySurfaceLayerParameter", "CookEast_StabilitySurfaceLayerParameter_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "StabilitySurfaceLayerParameter", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(-0.01138359, "unitless",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindDirectionTsStdDev", "CookEast_WindDirectionTsStdDev_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "WindDirectionTsStdDev", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(8.584023, "degrees",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ObukhovLengthTsAvg", "CookEast_ObukhovLengthTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "ObukhovLengthTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(7.02306, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_TemperatureScalingParameter", "CookEast_TemperatureScalingParameter_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "TemperatureScalingParameter", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(-0.04626383, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_MomentumFluxTotal", "CookEast_MomentumFluxTotal_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "MomentumFluxTotal", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.1652448, "(kg m/s)/(m^2 s)",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_MomentumFluxTotalQuality", "CookEast_MomentumFluxTotalQuality_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "MomentumFluxTotalQuality", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(2, "Grade",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_TemperatureDewpointTsAvg", "CookEast_TemperatureDewpointTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "TemperatureDewpointTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(-0.7282106, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ObukhovStabilityParamTsAvg", "CookEast_ObukhovStabilityParamTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "ObukhovStabilityParamTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(1.971855, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityBulkSoil5cmTsAvg", "CookEast_ElectricConductivityBulkSoil5cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "ElectricConductivityBulkSoil5cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(100.9833, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_PermittivitySoil5cmTsAvg", "CookEast_PermittivitySoil5cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "PermittivitySoil5cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(14.36889, "unitless",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityPoreSoil5cmTsAvg", "CookEast_ElectricConductivityPoreSoil5cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "ElectricConductivityPoreSoil5cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(778.7722, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_TemperatureSoil5cmTsAvg", "CookEast_TemperatureSoil5cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "TemperatureSoil5cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(6.86, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_VwcSoil5cmTsAvg", "CookEast_VwcSoil5cmTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "VwcSoil5cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(26.60778, "%",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_TurbulentKineticEnergy", "CookEast_TurbulentKineticEnergy_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "TurbulentKineticEnergy", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.7279687, "m^2/s^2",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_TemperatureSonicTsAvg", "CookEast_TemperatureSonicTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "TemperatureSonicTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(7.331906, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_TemperatureSonicTsStdDev", "CookEast_TemperatureSonicTsStdDev_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "TemperatureSonicTsStdDev", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.1228317, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_TemperatureSoilTsAvg", "CookEast_TemperatureSoilTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "TemperatureSoilTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(5.290007, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedAlongStreamlineTsAvg", "CookEast_WindSpeedAlongStreamlineTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "WindSpeedAlongStreamlineTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(4.791694, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_FrictionVelocity", "CookEast_FrictionVelocity_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "FrictionVelocity", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.3795369, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedAlongStreamlineTsStdDev", "CookEast_WindSpeedAlongStreamlineTsStdDev_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "WindSpeedAlongStreamlineTsStdDev", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.873412, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_MomentumFluxUVTsCovar", "CookEast_MomentumFluxUVTsCovar_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "MomentumFluxUVTsCovar", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.08073118, "(m/s)^2",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_MomentumFluxUWTsCovar", "CookEast_MomentumFluxUWTsCovar_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "MomentumFluxUWTsCovar", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(-0.140242, "(m/s)^2",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedSonicXTsAvg", "CookEast_WindSpeedSonicXTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "WindSpeedSonicXTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.9146236, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedSonicXTsStdDev", "CookEast_WindSpeedSonicXTsStdDev_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "WindSpeedSonicXTsStdDev", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.7104049, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedSonicYTsAvg", "CookEast_WindSpeedSonicYTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "WindSpeedSonicYTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(4.703513, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedSonicYTsStdDev", "CookEast_WindSpeedSonicYTsStdDev_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "WindSpeedSonicYTsStdDev", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.886613, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedSonicZTsAvg", "CookEast_WindSpeedSonicZTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "WindSpeedSonicZTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.02759224, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedSonicZTsStdDev", "CookEast_WindSpeedSonicZTsStdDev_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "WindSpeedSonicZTsStdDev", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.406423, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedAcrossSteamlineTsAvg", "CookEast_WindSpeedAcrossSteamlineTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "WindSpeedAcrossSteamlineTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedAcrossStreamlineTsStdDev", "CookEast_WindSpeedAcrossStreamlineTsStdDev_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "WindSpeedAcrossStreamlineTsStdDev", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.7254749, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_VaporPressureDeficit", "CookEast_VaporPressureDeficit_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "VaporPressureDeficit", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.4338953, "kpa",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_MomentumFluxVWTsCovar", "CookEast_MomentumFluxVWTsCovar_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "MomentumFluxVWTsCovar", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(-0.02881548, "(m/s)^2",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedVerticalVelocityTsAvg", "CookEast_WindSpeedVerticalVelocityTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "WindSpeedVerticalVelocityTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.000000001862645, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedVerticalVelocityTsStdDev", "CookEast_WindSpeedVerticalVelocityTsStdDev_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "WindSpeedVerticalVelocityTsStdDev", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.4083809, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_CO2FluxWCTsCovar", "CookEast_CO2FluxWCTsCovar_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "CO2FluxWCTsCovar", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(-0.04382965, "mg/(m^2 s)",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_H2OFluxWQTsCovar", "CookEast_H2OFluxWQTsCovar_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "H2OFluxWQTsCovar", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.02579194, "g/(m^2 s)",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindDirectionTsAvg", "CookEast_WindDirectionTsAvg_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "WindDirectionTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(106.0042, "degrees",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_HeatFluxKinematicWTTsCovar", "CookEast_HeatFluxKinematicWTTsCovar_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "HeatFluxKinematicWTTsCovar", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.01755883, "C m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_HeightDisplacement", "CookEast_HeightDisplacement_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "HeightDisplacement", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(2.084886, "m",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_HeightAerodynamic", "CookEast_HeightAerodynamic_Ts1800_2018-01-08T13:30:00.0000000Z", "Measurement", "HeightAerodynamic", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.01177848, "m",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));

            return measurements;
        }

        public static List<MeasurementV2> GetMeasurementsV2DerivedFromTestDataFluxV2()
        {
            List<MeasurementV2> measurements = new List<MeasurementV2>();
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_PressureAirTsAvg", "CookEast_PressureAirTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "PressureAirTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "kPa",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_TemperatureAirTsAvg", "CookEast_TemperatureAirTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "TemperatureAirTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_BatteryVoltageTsAvg", "CookEast_BatteryVoltageTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "BatteryVoltageTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(13.61839, "V",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_BowenRatio", "CookEast_BowenRatio_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "BowenRatio", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "fraction",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_CO2MassDensityTsAvg", "CookEast_CO2MassDensityTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "CO2MassDensityTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "mg/m^3",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_CO2MixingRatioDryTsAvg", "CookEast_CO2MixingRatioDryTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "CO2MixingRatioDryTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "umol/mol",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_CO2MolFractionWetTsAvg", "CookEast_CO2MolFractionWetTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "CO2MolFractionWetTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "umol/mol",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_CO2SampleCountTsAccum", "CookEast_CO2SampleCountTsAccum_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "CO2SampleCountTsAccum", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "samples",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_CO2SignalStrengthTsMin", "CookEast_CO2SignalStrengthTsMin_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "CO2SignalStrengthTsMin", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "fraction",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_CO2MassDensityTsStdDev", "CookEast_CO2MassDensityTsStdDev_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "CO2MassDensityTsStdDev", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "mg/m^3",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_RoughnessLength", "CookEast_RoughnessLength_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "RoughnessLength", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "m",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WasEnclosureOpenedTsAvg", "CookEast_WasEnclosureOpenedTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "WasEnclosureOpenedTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.999, "",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_VaporPressureSaturationTsAvg", "CookEast_VaporPressureSaturationTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "VaporPressureSaturationTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "kPa",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_VaporPressureTsAvg", "CookEast_VaporPressureTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "VaporPressureTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "kPa",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_CO2CorrectedMass", "CookEast_CO2CorrectedMass_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "CO2CorrectedMass", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "mg/(m^2 s)",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_CO2CorrectedMolar", "CookEast_CO2CorrectedMolar_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "CO2CorrectedMolar", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "umol/(m^2 s)",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_CO2CorrectedQuality", "CookEast_CO2CorrectedQuality_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "CO2CorrectedQuality", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "Grade",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_FootprintContributionDist40Perc", "CookEast_FootprintContributionDist40Perc_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "FootprintContributionDist40Perc", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "m",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_FootprintContributionDist55Perc", "CookEast_FootprintContributionDist55Perc_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "FootprintContributionDist55Perc", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "m",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_FootprintContributionDist90Perc", "CookEast_FootprintContributionDist90Perc_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "FootprintContributionDist90Perc", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "m",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_FootprintContributionDistMax", "CookEast_FootprintContributionDistMax_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "FootprintContributionDistMax", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "m",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_HeatFluxSensible", "CookEast_HeatFluxSensible_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "HeatFluxSensible", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "W/m^2",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_HeatFluxSensibleQuality", "CookEast_HeatFluxSensibleQuality_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "HeatFluxSensibleQuality", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "Grade",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_H2OMassDensityTsAvg", "CookEast_H2OMassDensityTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "H2OMassDensityTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "g/m^3",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_H2OMixingRatioDryTsAvg", "CookEast_H2OMixingRatioDryTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "H2OMixingRatioDryTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "mmol/mol",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_H2OMolFractionWetTsAvg", "CookEast_H2OMolFractionWetTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "H2OMolFractionWetTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "mmol/mol",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_H2OSampleCountTsAccum", "CookEast_H2OSampleCountTsAccum_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "H2OSampleCountTsAccum", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "samples",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_H2OSignalStrengthTsMin", "CookEast_H2OSignalStrengthTsMin_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "H2OSignalStrengthTsMin", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "fraction",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_H2OMassDensityTsStdDev", "CookEast_H2OMassDensityTsStdDev_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "H2OMassDensityTsStdDev", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "g/m^3",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_HeightCanopy", "CookEast_HeightCanopy_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "HeightCanopy", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "m",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_HeightECMeasurement", "CookEast_HeightECMeasurement_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "HeightECMeasurement", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(3, "m",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ObukhovLength", "CookEast_ObukhovLength_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "ObukhovLength", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "m",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_HeatFluxLatent", "CookEast_HeatFluxLatent_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "HeatFluxLatent", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "W/m^2",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_HeatFluxLatentQuality", "CookEast_HeatFluxLatentQuality_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "HeatFluxLatentQuality", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "Grade",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_TemperaturePanelTsAvg", "CookEast_TemperaturePanelTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "TemperaturePanelTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(24.94208, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ParDensityTsAvg", "CookEast_ParDensityTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "ParDensityTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "umol/(s m^2)",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_PrecipitationTsAccum", "CookEast_PrecipitationTsAccum_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "PrecipitationTsAccum", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "mm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityBulk15cmTsAvg", "CookEast_ElectricConductivityBulk15cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "ElectricConductivityBulk15cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityBulk30cmTsAvg", "CookEast_ElectricConductivityBulk30cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "ElectricConductivityBulk30cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityBulk60cmTsAvg", "CookEast_ElectricConductivityBulk60cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "ElectricConductivityBulk60cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityBulk90cmTsAvg", "CookEast_ElectricConductivityBulk90cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "ElectricConductivityBulk90cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityBulk120cmTsAvg", "CookEast_ElectricConductivityBulk120cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "ElectricConductivityBulk120cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityBulk150cmTsAvg", "CookEast_ElectricConductivityBulk150cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "ElectricConductivityBulk150cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Permittivity15cmTsAvg", "CookEast_Permittivity15cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "Permittivity15cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "unitless",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Permittivity30cmTsAvg", "CookEast_Permittivity30cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "Permittivity30cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "unitless",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Permittivity60cmTsAvg", "CookEast_Permittivity60cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "Permittivity60cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "unitless",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Permittivity90cmTsAvg", "CookEast_Permittivity90cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "Permittivity90cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "unitless",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Permittivity120cmTsAvg", "CookEast_Permittivity120cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "Permittivity120cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "unitless",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Permittivity150cmTsAvg", "CookEast_Permittivity150cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "Permittivity150cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "unitless",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityPore15cmTsAvg", "CookEast_ElectricConductivityPore15cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "ElectricConductivityPore15cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityPore30cmTsAvg", "CookEast_ElectricConductivityPore30cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "ElectricConductivityPore30cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityPore60cmTsAvg", "CookEast_ElectricConductivityPore60cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "ElectricConductivityPore60cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityPore90cmTsAvg", "CookEast_ElectricConductivityPore90cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "ElectricConductivityPore90cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityPore120cmTsAvg", "CookEast_ElectricConductivityPore120cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "ElectricConductivityPore120cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityPore150cmTsAvg", "CookEast_ElectricConductivityPore150cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "ElectricConductivityPore150cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Temperature15cmTsAvg", "CookEast_Temperature15cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "Temperature15cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Temperature30cmTsAvg", "CookEast_Temperature30cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "Temperature30cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Temperature60cmTsAvg", "CookEast_Temperature60cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "Temperature60cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Temperature90cmTsAvg", "CookEast_Temperature90cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "Temperature90cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Temperature120cmTsAvg", "CookEast_Temperature120cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "Temperature120cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Temperature150cmTsAvg", "CookEast_Temperature150cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "Temperature150cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Vwc15cmTsAvg", "CookEast_Vwc15cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "Vwc15cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "%",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Vwc30cmTsAvg", "CookEast_Vwc30cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "Vwc30cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "%",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Vwc60cmTsAvg", "CookEast_Vwc60cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "Vwc60cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "%",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Vwc90cmTsAvg", "CookEast_Vwc90cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "Vwc90cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "%",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Vwc120cmTsAvg", "CookEast_Vwc120cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "Vwc120cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "%",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_Vwc150cmTsAvg", "CookEast_Vwc150cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "Vwc150cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "%",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_HumidityTsAvg", "CookEast_HumidityTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "HumidityTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "%",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_HeatFluxSensibleLatentRatioTsAvg", "CookEast_HeatFluxSensibleLatentRatioTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "HeatFluxSensibleLatentRatioTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "%",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_DensityAirWetTsAvg", "CookEast_DensityAirWetTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "DensityAirWetTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "kg/m^3",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_DensityAirDryTsAvg", "CookEast_DensityAirDryTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "DensityAirDryTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "kg/m^3",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_RadiationNet", "CookEast_RadiationNet_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "RadiationNet", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(25151.79, "W/m^2",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedTsResultant", "CookEast_WindSpeedTsResultant_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "WindSpeedTsResultant", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_HeatFluxSoilTsAvg", "CookEast_HeatFluxSoilTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "HeatFluxSoilTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(4617.834, "W/m^2",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_SonicAnemometerSampleCountTsAccum", "CookEast_SonicAnemometerSampleCountTsAccum_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "SonicAnemometerSampleCountTsAccum", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "samples",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_StabilitySurfaceLayerParameter", "CookEast_StabilitySurfaceLayerParameter_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "StabilitySurfaceLayerParameter", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "unitless",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindDirectionTsStdDev", "CookEast_WindDirectionTsStdDev_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "WindDirectionTsStdDev", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "degrees",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ObukhovLengthTsAvg", "CookEast_ObukhovLengthTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "ObukhovLengthTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_TemperatureScalingParameter", "CookEast_TemperatureScalingParameter_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "TemperatureScalingParameter", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_MomentumFluxTotal", "CookEast_MomentumFluxTotal_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "MomentumFluxTotal", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "(kg m/s)/(m^2 s)",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_MomentumFluxTotalQuality", "CookEast_MomentumFluxTotalQuality_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "MomentumFluxTotalQuality", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "Grade",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_TemperatureDewpointTsAvg", "CookEast_TemperatureDewpointTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "TemperatureDewpointTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ObukhovStabilityParamTsAvg", "CookEast_ObukhovStabilityParamTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "ObukhovStabilityParamTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityBulkSoil5cmTsAvg", "CookEast_ElectricConductivityBulkSoil5cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "ElectricConductivityBulkSoil5cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_PermittivitySoil5cmTsAvg", "CookEast_PermittivitySoil5cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "PermittivitySoil5cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "unitless",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_ElectricConductivityPoreSoil5cmTsAvg", "CookEast_ElectricConductivityPoreSoil5cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "ElectricConductivityPoreSoil5cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "uS/cm",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_TemperatureSoil5cmTsAvg", "CookEast_TemperatureSoil5cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "TemperatureSoil5cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_VwcSoil5cmTsAvg", "CookEast_VwcSoil5cmTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "VwcSoil5cmTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "%",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_TurbulentKineticEnergy", "CookEast_TurbulentKineticEnergy_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "TurbulentKineticEnergy", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "m^2/s^2",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_TemperatureSonicTsAvg", "CookEast_TemperatureSonicTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "TemperatureSonicTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_TemperatureSonicTsStdDev", "CookEast_TemperatureSonicTsStdDev_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "TemperatureSonicTsStdDev", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_TemperatureSoilTsAvg", "CookEast_TemperatureSoilTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "TemperatureSoilTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(-76071.11, "C",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedAlongStreamlineTsAvg", "CookEast_WindSpeedAlongStreamlineTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "WindSpeedAlongStreamlineTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_FrictionVelocity", "CookEast_FrictionVelocity_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "FrictionVelocity", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedAlongStreamlineTsStdDev", "CookEast_WindSpeedAlongStreamlineTsStdDev_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "WindSpeedAlongStreamlineTsStdDev", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_MomentumFluxUVTsCovar", "CookEast_MomentumFluxUVTsCovar_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "MomentumFluxUVTsCovar", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "(m/s)^2",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_MomentumFluxUWTsCovar", "CookEast_MomentumFluxUWTsCovar_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "MomentumFluxUWTsCovar", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "(m/s)^2",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedSonicXTsAvg", "CookEast_WindSpeedSonicXTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "WindSpeedSonicXTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedSonicXTsStdDev", "CookEast_WindSpeedSonicXTsStdDev_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "WindSpeedSonicXTsStdDev", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedSonicYTsAvg", "CookEast_WindSpeedSonicYTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "WindSpeedSonicYTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedSonicYTsStdDev", "CookEast_WindSpeedSonicYTsStdDev_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "WindSpeedSonicYTsStdDev", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedSonicZTsAvg", "CookEast_WindSpeedSonicZTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "WindSpeedSonicZTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedSonicZTsStdDev", "CookEast_WindSpeedSonicZTsStdDev_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "WindSpeedSonicZTsStdDev", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedAcrossSteamlineTsAvg", "CookEast_WindSpeedAcrossSteamlineTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "WindSpeedAcrossSteamlineTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedAcrossStreamlineTsStdDev", "CookEast_WindSpeedAcrossStreamlineTsStdDev_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "WindSpeedAcrossStreamlineTsStdDev", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_VaporPressureDeficit", "CookEast_VaporPressureDeficit_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "VaporPressureDeficit", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "kpa",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_MomentumFluxVWTsCovar", "CookEast_MomentumFluxVWTsCovar_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "MomentumFluxVWTsCovar", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "(m/s)^2",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedVerticalVelocityTsAvg", "CookEast_WindSpeedVerticalVelocityTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "WindSpeedVerticalVelocityTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindSpeedVerticalVelocityTsStdDev", "CookEast_WindSpeedVerticalVelocityTsStdDev_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "WindSpeedVerticalVelocityTsStdDev", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_CO2FluxWCTsCovar", "CookEast_CO2FluxWCTsCovar_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "CO2FluxWCTsCovar", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "mg/(m^2 s)",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_H2OFluxWQTsCovar", "CookEast_H2OFluxWQTsCovar_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "H2OFluxWQTsCovar", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "g/(m^2 s)",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_WindDirectionTsAvg", "CookEast_WindDirectionTsAvg_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "WindDirectionTsAvg", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "degrees",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_HeatFluxKinematicWTTsCovar", "CookEast_HeatFluxKinematicWTTsCovar_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "HeatFluxKinematicWTTsCovar", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(null, "C m/s",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_HeightDisplacement", "CookEast_HeightDisplacement_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "HeightDisplacement", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(3, "m",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));
            measurements.Add(new MeasurementV2("CafMeteorologyEcTower_CookEast_HeightAerodynamic", "CookEast_HeightAerodynamic_Ts1800_2018-06-15T14:00:00.0000000Z", "Measurement", "HeightAerodynamic", "http://files.cafltar.org/data/schema/documentDb/v2/measurement.json", "CafMeteorologyEcTower","","","","",null,"CookEast", new LocationV2("Point", 46.78152, -117.08205), new DateTime(2018, 1, 8, 13, 30, 0), new List<PhysicalQuantityV2>() { new PhysicalQuantityV2(0.01, "m",DateTime.Now, "DocumentDbMeasurementTransformer")}, 1800));

            return measurements;
        }

        public static List<MeasurementV2> GetMeasurementsV2DerivedFromTestDataMeteorologyV2()
        {
            List<MeasurementV2> measurements = new List<MeasurementV2>();
            
            return measurements;
        }

    }
}
