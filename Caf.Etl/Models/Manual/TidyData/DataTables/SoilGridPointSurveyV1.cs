using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Models.Manual.TidyData.DataTables
{
    public class SoilGridPointSurveyV1 : IObservation, IEquatable<SoilGridPointSurveyV1>
    {
        public int? Year { get; set; }
        public int? ID2 { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public double? TopDepth { get; set; }
        public double? BottomDepth { get; set; }
        public string Horizon { get; set; }
        public double? BulkDensity { get; set; }
        public double? dC13 { get; set; }
        public double? dC13AcidWashed { get; set; }
        public double? TNConc { get; set; }
        public double? TNConcAcidWashed { get; set; }
        public double? TCConc { get; set; }
        public double? TCConcAcidWashed { get; set; }
        public double? TocConc { get; set; }
        public double? TocStock { get; set; }
        public double? TicConc { get; set; }
        public double? TicStock { get; set; }
        public double? TNStock { get; set; }
        public double? pH { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as SoilGridPointSurveyV1);
        }

        public bool Equals(SoilGridPointSurveyV1 other)
        {
            return other != null &&
                   EqualityComparer<int?>.Default.Equals(Year, other.Year) &&
                   EqualityComparer<int?>.Default.Equals(ID2, other.ID2) &&
                   EqualityComparer<double?>.Default.Equals(Latitude, other.Latitude) &&
                   EqualityComparer<double?>.Default.Equals(Longitude, other.Longitude) &&
                   EqualityComparer<double?>.Default.Equals(TopDepth, other.TopDepth) &&
                   EqualityComparer<double?>.Default.Equals(BottomDepth, other.BottomDepth) &&
                   Horizon == other.Horizon &&
                   EqualityComparer<double?>.Default.Equals(BulkDensity, other.BulkDensity) &&
                   EqualityComparer<double?>.Default.Equals(dC13, other.dC13) &&
                   EqualityComparer<double?>.Default.Equals(dC13AcidWashed, other.dC13AcidWashed) &&
                   EqualityComparer<double?>.Default.Equals(TNConc, other.TNConc) &&
                   EqualityComparer<double?>.Default.Equals(TNConcAcidWashed, other.TNConcAcidWashed) &&
                   EqualityComparer<double?>.Default.Equals(TCConc, other.TCConc) &&
                   EqualityComparer<double?>.Default.Equals(TCConcAcidWashed, other.TCConcAcidWashed) &&
                   EqualityComparer<double?>.Default.Equals(TocConc, other.TocConc) &&
                   EqualityComparer<double?>.Default.Equals(TocStock, other.TocStock) &&
                   EqualityComparer<double?>.Default.Equals(TicConc, other.TicConc) &&
                   EqualityComparer<double?>.Default.Equals(TicStock, other.TicStock) &&
                   EqualityComparer<double?>.Default.Equals(TNStock, other.TNStock) &&
                   EqualityComparer<double?>.Default.Equals(pH, other.pH);
        }

        public override int GetHashCode()
        {
            var hashCode = 1703980959;
            hashCode = hashCode * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(Year);
            hashCode = hashCode * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(ID2);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Latitude);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Longitude);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(TopDepth);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(BottomDepth);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Horizon);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(BulkDensity);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(dC13);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(dC13AcidWashed);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(TNConc);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(TNConcAcidWashed);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(TCConc);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(TCConcAcidWashed);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(TocConc);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(TocStock);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(TicConc);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(TicStock);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(TNStock);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(pH);
            return hashCode;
        }

        public static bool operator ==(SoilGridPointSurveyV1 v1, SoilGridPointSurveyV1 v2)
        {
            return EqualityComparer<SoilGridPointSurveyV1>.Default.Equals(v1, v2);
        }

        public static bool operator !=(SoilGridPointSurveyV1 v1, SoilGridPointSurveyV1 v2)
        {
            return !(v1 == v2);
        }
    }

}
