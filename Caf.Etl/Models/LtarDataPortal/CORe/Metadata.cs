using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caf.Etl.Models.LtarDataPortal.CORe
{
    /// <summary></summary>
    public class Metadata
    {
        /// <summary></summary>
        public string LtarSiteAcronym { get; private set; }

        /// <summary></summary>
        public string StationID { get; private set; }

        /// <summary></summary>
        public char RecordType { get; private set; }

        /// <summary></summary>
        public string DataFormatVersion { get; private set; }

        /// <summary></summary>
        public string Year { get; private set; }

        /// <summary></summary>
        public string Month { get; private set; }

        /// <summary></summary>
        public string Day { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ltarSiteAcronym"></param>
        /// <param name="stationID"></param>
        /// <param name="recordType"></param>
        /// <param name="dataFormatVersion"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        public Metadata(
            string ltarSiteAcronym,
            string stationID,
            char recordType,
            string dataFormatVersion,
            string year,
            string month,
            string day)
        {
            this.LtarSiteAcronym = ltarSiteAcronym;
            this.StationID = stationID;
            this.RecordType = recordType;
            this.DataFormatVersion = dataFormatVersion;
            this.Year = year;
            this.Month = month;
            this.Day = day;
        }
    }
}
