using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Models.LoggerNet.TOA5.DataTables
{
    /// <summary></summary>
    public class Meteorology : IObservation
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
    }
}