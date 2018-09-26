using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caf.Etl.Models.Manual.TidyData
{
    public class TidyData : IEquatable<TidyData>
    {
        public Metadata Metadata { get; set; }

        public List<IObservation> Observations { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as TidyData);
        }

        public bool Equals(TidyData other)
        {
            return other != null &&
                   EqualityComparer<Metadata>.Default.Equals(Metadata, other.Metadata) &&
                   Observations.SequenceEqual(other.Observations);
                   //EqualityComparer<List<IObservation>>.Default.Equals(Observations, other.Observations);
        }

        public override int GetHashCode()
        {
            var hashCode = -1393435846;
            hashCode = hashCode * -1521134295 + EqualityComparer<Metadata>.Default.GetHashCode(Metadata);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<IObservation>>.Default.GetHashCode(Observations);
            return hashCode;
        }

        public static bool operator ==(TidyData set1, TidyData set2)
        {
            return EqualityComparer<TidyData>.Default.Equals(set1, set2);
        }

        public static bool operator !=(TidyData set1, TidyData set2)
        {
            return !(set1 == set2);
        }
    }
}
