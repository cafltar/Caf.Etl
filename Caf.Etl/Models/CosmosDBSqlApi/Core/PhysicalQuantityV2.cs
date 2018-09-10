using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Models.CosmosDBSqlApi.Core
{
    /// <summary></summary>
    public class PhysicalQuantityV2 : IEquatable<PhysicalQuantityV2>
    // : Nsar.Common.Measure.Models.PhysicalQuantity
    {
        /// <summary></summary>
        [JsonProperty("value")]
        public double? Value { get; private set; }

        /// <summary></summary>        
        [JsonProperty("unit")]
        public string Unit { get; private set; }

        /// <summary></summary>        
        [JsonProperty("submissionDateTime")]
        public DateTime SubmissionDateTime { get; private set; }

        /// <summary></summary>        
        [JsonProperty("sourceId")]
        public string SourceID { get; private set; }

        [JsonProperty("qualityControlId")]
        public string QualityControlId { get; private set; }

        [JsonProperty("qcValues")]
        public List<Object> QCValues { get; private set; }

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
        [JsonConstructor]
        public PhysicalQuantityV2(
            double? value, string unit,
            DateTime submissionDateTime, string sourceID,
            List<Object> qcValues = null)
        {
            Value = value;
            Unit = unit;
            SubmissionDateTime = submissionDateTime;
            SourceID = sourceID;

            QCValues = qcValues;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as PhysicalQuantityV2);
        }

        public bool Equals(PhysicalQuantityV2 other)
        {
            return other != null &&
                   EqualityComparer<double?>.Default.Equals(Value, other.Value) &&
                   Unit == other.Unit &&
                   SubmissionDateTime == other.SubmissionDateTime &&
                   SourceID == other.SourceID &&
                   QualityControlId == other.QualityControlId &&
                   EqualityComparer<List<object>>.Default.Equals(QCValues, other.QCValues);
        }

        public override int GetHashCode()
        {
            var hashCode = 970703075;
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Value);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Unit);
            hashCode = hashCode * -1521134295 + SubmissionDateTime.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SourceID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(QualityControlId);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<object>>.Default.GetHashCode(QCValues);
            return hashCode;
        }

        public static bool operator ==(PhysicalQuantityV2 v1, PhysicalQuantityV2 v2)
        {
            return EqualityComparer<PhysicalQuantityV2>.Default.Equals(v1, v2);
        }

        public static bool operator !=(PhysicalQuantityV2 v1, PhysicalQuantityV2 v2)
        {
            return !(v1 == v2);
        }

    }
}
