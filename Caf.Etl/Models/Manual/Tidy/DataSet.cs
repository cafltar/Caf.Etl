using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caf.Etl.Models.Manual.Tidy
{
    public class DataSet : IEquatable<DataSet>
    {
        public Metadata Metadata { get; set; }

        public List<IObservation> Observations { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as DataSet);
        }

        public bool Equals(DataSet other)
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

        public static bool operator ==(DataSet set1, DataSet set2)
        {
            return EqualityComparer<DataSet>.Default.Equals(set1, set2);
        }

        public static bool operator !=(DataSet set1, DataSet set2)
        {
            return !(set1 == set2);
        }
    }
}
