using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caf.Etl.Models.LtarDataPortal.CORe
{
    /// <summary></summary>
    public class Observation
    {
        /// <summary></summary>
        public string LTARSiteAcronym { get; private set; }

        /// <summary></summary>
        public string StationID { get; private set; }

        /// <summary></summary>
        public DateTimeOffset DateTime { get; private set; }

        /// <summary></summary>
        public char RecordType { get; private set; }

        /// <summary></summary>
        public decimal? AirTemperature { get; private set; }

        /// <summary></summary>
        public decimal? WindSpeed { get; private set; }

        /// <summary></summary>
        public decimal? WindDirection { get; private set; }

        /// <summary></summary>
        public decimal? RelativeHumidity { get; private set; }

        /// <summary></summary>
        public decimal? Precipitation { get; private set; }

        /// <summary></summary>
        public decimal? AirPressure { get; private set; }

        /// <summary></summary>
        public decimal? PAR { get; private set; }

        /// <summary></summary>
        public decimal? ShortWaveIn { get; private set; }

        /// <summary></summary>
        public decimal? LongWaveIn { get; private set; }

        /// <summary></summary>
        public decimal? BatteryVoltage { get; private set; }

        /// <summary></summary>
        public decimal? LoggerTemperature { get; private set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ltarSiteAcronym"></param>
        /// <param name="stationID"></param>
        /// <param name="dateTime"></param>
        /// <param name="utcOffset"></param>
        /// <param name="recordType"></param>
        /// <param name="airTemperature"></param>
        /// <param name="windSpeed"></param>
        /// <param name="windDirection"></param>
        /// <param name="relativeHumidity"></param>
        /// <param name="precipitation"></param>
        /// <param name="airPressure"></param>
        /// <param name="par"></param>
        /// <param name="shortWaveIn"></param>
        /// <param name="longWaveIn"></param>
        /// <param name="batteryVoltage"></param>
        /// <param name="loggerTemperature"></param>
        public Observation(
            string ltarSiteAcronym,
            string stationID,
            DateTimeOffset dateTime,
            int utcOffset,
            char recordType,
            decimal? airTemperature,
            decimal? windSpeed,
            decimal? windDirection,
            decimal? relativeHumidity,
            decimal? precipitation,
            decimal? airPressure,
            decimal? par,
            decimal? shortWaveIn,
            decimal? longWaveIn,
            decimal? batteryVoltage,
            decimal? loggerTemperature)
        {
            if(dateTime.Offset.Hours != utcOffset)
            {
                throw new ArgumentException(
                    "dateTime hour offset does not match utcOffset");
            }
            this.LTARSiteAcronym = ltarSiteAcronym;
            this.StationID = stationID;
            this.DateTime = dateTime;
            this.RecordType = recordType;
            this.AirTemperature = airTemperature;
            this.WindSpeed = windSpeed;
            this.WindDirection = windDirection;
            this.RelativeHumidity = relativeHumidity;
            this.Precipitation = precipitation;
            this.AirPressure = airPressure;
            this.PAR = par;
            this.ShortWaveIn = shortWaveIn;
            this.LongWaveIn = LongWaveIn;
            this.BatteryVoltage = batteryVoltage;
            this.LoggerTemperature = loggerTemperature;
        }
    }
}
