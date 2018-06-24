using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Models.LoggerNet.TOA5.DataTables
{
    /// <summary></summary>
    public class Meteorology : IObservation, IEquatable<Meteorology>
    {
        /// <summary></summary>
        public DateTime TIMESTAMP { get; set; }
        /// <summary></summary>
        public int RECORD { get; set; }
        /// <summary></summary>
        public double? amb_tmpr_Avg { get; set; }
        /// <summary></summary>
        public double? rslt_wnd_spd { get; set; }
        /// <summary></summary>
        public double? wnd_dir_compass { get; set; }
        /// <summary></summary>
        public double? RH_Avg { get; set; }
        /// <summary></summary>
        public double? Precipitation_Tot { get; set; }
        /// <summary></summary>
        public double? amb_press_Avg { get; set; }
        /// <summary></summary>
        public double? PAR_density_Avg { get; set; }
        /// <summary></summary>
        public double? batt_volt_Avg { get; set; }
        /// <summary></summary>
        public double? panel_tmpr_Avg { get; set; }
        /// <summary></summary>
        public double? std_wnd_dir { get; set; }
        /// <summary></summary>
        public double? VPD_air { get; set; }
        /// <summary></summary>
        public double? Rn_meas_Avg { get; set; }
        /// <summary></summary>
        public double? e_sat { get; set; }
        /// <summary></summary>
        public double? e { get; set; }
        /// <summary></summary>
        public double? tdr31X_wc_Avg { get; set; }
        /// <summary></summary>
        public double? tdr31X_tmpr_Avg { get; set; }
        /// <summary></summary>
        public double? tdr31X_E_Avg { get; set; }
        /// <summary></summary>
        public double? tdr31X_bulkEC_Avg { get; set; }
        /// <summary></summary>
        public double? tdr31X_poreEC_Avg { get; set; }
        /// <summary></summary>
        public double? Tsoil_Avg { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_wc_Avg1 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_wc_Avg2 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_wc_Avg3 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_wc_Avg4 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_wc_Avg5 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_wc_Avg6 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_tmpr_Avg1 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_tmpr_Avg2 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_tmpr_Avg3 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_tmpr_Avg4 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_tmpr_Avg5 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_tmpr_Avg6 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_E_Avg1 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_E_Avg2 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_E_Avg3 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_E_Avg4 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_E_Avg5 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_E_Avg6 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_bulkEC_Avg1 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_bulkEC_Avg2 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_bulkEC_Avg3 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_bulkEC_Avg4 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_bulkEC_Avg5 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_bulkEC_Avg6 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_poreEC_Avg1 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_poreEC_Avg2 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_poreEC_Avg3 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_poreEC_Avg4 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_poreEC_Avg5 { get; set; }
        /// <summary></summary>
        public double? profile_tdr31X_poreEC_Avg6 { get; set; }
        /// <summary></summary>
        public double? shf_plate_avg { get; set; }
        /// <summary></summary>
        public double? SHFP_1_SENS { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Meteorology);
        }

        public bool Equals(Meteorology other)
        {
            if(other != null &&
                   TIMESTAMP == other.TIMESTAMP &&
                   RECORD == other.RECORD &&
                   EqualityComparer<double?>.Default.Equals(amb_tmpr_Avg, other.amb_tmpr_Avg) &&
                   EqualityComparer<double?>.Default.Equals(rslt_wnd_spd, other.rslt_wnd_spd) &&
                   EqualityComparer<double?>.Default.Equals(wnd_dir_compass, other.wnd_dir_compass) &&
                   EqualityComparer<double?>.Default.Equals(RH_Avg, other.RH_Avg) &&
                   EqualityComparer<double?>.Default.Equals(Precipitation_Tot, other.Precipitation_Tot) &&
                   EqualityComparer<double?>.Default.Equals(amb_press_Avg, other.amb_press_Avg) &&
                   EqualityComparer<double?>.Default.Equals(PAR_density_Avg, other.PAR_density_Avg) &&
                   EqualityComparer<double?>.Default.Equals(batt_volt_Avg, other.batt_volt_Avg) &&
                   EqualityComparer<double?>.Default.Equals(panel_tmpr_Avg, other.panel_tmpr_Avg) &&
                   EqualityComparer<double?>.Default.Equals(std_wnd_dir, other.std_wnd_dir) &&
                   EqualityComparer<double?>.Default.Equals(VPD_air, other.VPD_air) &&
                   EqualityComparer<double?>.Default.Equals(Rn_meas_Avg, other.Rn_meas_Avg) &&
                   EqualityComparer<double?>.Default.Equals(e_sat, other.e_sat) &&
                   EqualityComparer<double?>.Default.Equals(e, other.e) &&
                   EqualityComparer<double?>.Default.Equals(tdr31X_wc_Avg, other.tdr31X_wc_Avg) &&
                   EqualityComparer<double?>.Default.Equals(tdr31X_tmpr_Avg, other.tdr31X_tmpr_Avg) &&
                   EqualityComparer<double?>.Default.Equals(tdr31X_E_Avg, other.tdr31X_E_Avg) &&
                   EqualityComparer<double?>.Default.Equals(tdr31X_bulkEC_Avg, other.tdr31X_bulkEC_Avg) &&
                   EqualityComparer<double?>.Default.Equals(tdr31X_poreEC_Avg, other.tdr31X_poreEC_Avg) &&
                   EqualityComparer<double?>.Default.Equals(Tsoil_Avg, other.Tsoil_Avg) &&
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
                   EqualityComparer<double?>.Default.Equals(shf_plate_avg, other.shf_plate_avg) &&
                   EqualityComparer<double?>.Default.Equals(SHFP_1_SENS, other.SHFP_1_SENS))
            {
                return true;
            }
            else { return false; }
        }

        public override int GetHashCode()
        {
            var hashCode = 732863020;
            hashCode = hashCode * -1521134295 + TIMESTAMP.GetHashCode();
            hashCode = hashCode * -1521134295 + RECORD.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(amb_tmpr_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(rslt_wnd_spd);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(wnd_dir_compass);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(RH_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Precipitation_Tot);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(amb_press_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(PAR_density_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(batt_volt_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(panel_tmpr_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(std_wnd_dir);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(VPD_air);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Rn_meas_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(e_sat);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(e);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tdr31X_wc_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tdr31X_tmpr_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tdr31X_E_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tdr31X_bulkEC_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(tdr31X_poreEC_Avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Tsoil_Avg);
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
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(shf_plate_avg);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(SHFP_1_SENS);
            return hashCode;
        }

        public static bool operator ==(Meteorology meteorology1, Meteorology meteorology2)
        {
            return EqualityComparer<Meteorology>.Default.Equals(meteorology1, meteorology2);
        }

        public static bool operator !=(Meteorology meteorology1, Meteorology meteorology2)
        {
            return !(meteorology1 == meteorology2);
        }

    }
}