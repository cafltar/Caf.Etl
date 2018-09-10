using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Models.Manual.Tidy.DataTables
{
    public class HandHarvestYieldV1 : IObservation, IEquatable<HandHarvestYieldV1>
    {
        public int? HarvestYear { get; set; }
        public string Crop { get; set; }
        public string SampleID { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int? ID2 { get; set; }
        public double? GrainWeight { get; set; }
        public double? Area { get; set; }
        public double? Yield_g_m2 { get; set; }
        public double? Yield_lb_ac { get; set; }
        public double? Yield_bu_ac { get; set; }
        public double? TestWeight { get; set; }
        public double? OilDM { get; set; }
        public double? Protein { get; set; }
        public double? Moisture { get; set; }
        public double? Starch { get; set; }
        public double? WGlutDM { get; set; }
        public string Notes { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as HandHarvestYieldV1);
        }

        public bool Equals(HandHarvestYieldV1 other)
        {
            return other != null &&
                   EqualityComparer<int?>.Default.Equals(HarvestYear, other.HarvestYear) &&
                   Crop == other.Crop &&
                   SampleID == other.SampleID &&
                   EqualityComparer<double?>.Default.Equals(Latitude, other.Latitude) &&
                   EqualityComparer<double?>.Default.Equals(Longitude, other.Longitude) &&
                   EqualityComparer<int?>.Default.Equals(ID2, other.ID2) &&
                   EqualityComparer<double?>.Default.Equals(GrainWeight, other.GrainWeight) &&
                   EqualityComparer<double?>.Default.Equals(Area, other.Area) &&
                   EqualityComparer<double?>.Default.Equals(Yield_g_m2, other.Yield_g_m2) &&
                   EqualityComparer<double?>.Default.Equals(Yield_lb_ac, other.Yield_lb_ac) &&
                   EqualityComparer<double?>.Default.Equals(Yield_bu_ac, other.Yield_bu_ac) &&
                   EqualityComparer<double?>.Default.Equals(TestWeight, other.TestWeight) &&
                   EqualityComparer<double?>.Default.Equals(OilDM, other.OilDM) &&
                   EqualityComparer<double?>.Default.Equals(Protein, other.Protein) &&
                   EqualityComparer<double?>.Default.Equals(Moisture, other.Moisture) &&
                   EqualityComparer<double?>.Default.Equals(Starch, other.Starch) &&
                   EqualityComparer<double?>.Default.Equals(WGlutDM, other.WGlutDM) &&
                   Notes == other.Notes;
        }

        public override int GetHashCode()
        {
            var hashCode = 2086036091;
            hashCode = hashCode * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(HarvestYear);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Crop);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SampleID);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Latitude);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Longitude);
            hashCode = hashCode * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(ID2);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(GrainWeight);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Area);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Yield_g_m2);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Yield_lb_ac);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Yield_bu_ac);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(TestWeight);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(OilDM);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Protein);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Moisture);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Starch);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(WGlutDM);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Notes);
            return hashCode;
        }

        public static bool operator ==(HandHarvestYieldV1 v1, HandHarvestYieldV1 v2)
        {
            return EqualityComparer<HandHarvestYieldV1>.Default.Equals(v1, v2);
        }

        public static bool operator !=(HandHarvestYieldV1 v1, HandHarvestYieldV1 v2)
        {
            return !(v1 == v2);
        }
    }

}
