using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caf.Etl.Models.LoggerNet.TOA5
{
    /// <summary></summary>
    public class TOA5 : IEquatable<TOA5>
    {
        /// <summary></summary>
        public Metadata Metadata { get; set; }

        /// <summary></summary>
        public List<IObservation> Observations { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as TOA5);
        }

        public bool Equals(TOA5 other)
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

        public static bool operator ==(TOA5 tOA1, TOA5 tOA2)
        {
            return EqualityComparer<TOA5>.Default.Equals(tOA1, tOA2);
        }

        public static bool operator !=(TOA5 tOA1, TOA5 tOA2)
        {
            return !(tOA1 == tOA2);
        }

    }
}