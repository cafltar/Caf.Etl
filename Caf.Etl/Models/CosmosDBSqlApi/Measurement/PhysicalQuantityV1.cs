using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Models.CosmosDBSqlApi.Measurement
{
    /// <summary></summary>
    public class PhysicalQuantityV1// : Nsar.Common.Measure.Models.PhysicalQuantity
    {
        /// <summary></summary>
        [JsonProperty("value")]
        public decimal Value { get; private set; }

        /// <summary></summary>        
        [JsonProperty("unit")]
        public string Unit { get; private set; }

        /// <summary></summary>        
        [JsonProperty("qualityCode")]
        public int QualityCode { get; private set; }

        /// <summary></summary>        
        [JsonProperty("qcAppliedCode")]
        public int QCAppliedCode { get; private set; }

        /// <summary></summary>       
        [JsonProperty("qcResultCode")]
        public int QCResultCode { get; private set; }

        /// <summary></summary>        
        [JsonProperty("submissionDateTime")]
        public DateTime SubmissionDateTime { get; private set; }

        /// <summary></summary>        
        [JsonProperty("sourceId")]
        public string SourceID { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="unit"></param>
        /// <param name="qualityCode"></param>
        /// <param name="qcAppliedCode"></param>
        /// <param name="qcResultCode"></param>
        /// <param name="submissionDateTime"></param>
        /// <param name="sourceID"></param>
        public PhysicalQuantityV1(
            decimal value, string unit, int qualityCode,
            int qcAppliedCode, int qcResultCode,
            DateTime submissionDateTime, string sourceID)
        {
            Value = value;
            Unit = unit;
            QualityCode = qualityCode;
            QCAppliedCode = qcAppliedCode;
            QCResultCode = qcResultCode;
            SubmissionDateTime = submissionDateTime;
            SourceID = sourceID;
        }
    }
}
