using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caf.Etl.Models.Manual.Tidy
{
    public class Metadata : IEquatable<Metadata>
    {
        public List<Variable> Variables { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Metadata);
        }

        public bool Equals(Metadata other)
        {
            return other != null &&
                Variables.SequenceEqual(other.Variables);
        }

        public override int GetHashCode()
        {
            return -1853421134 + EqualityComparer<List<Variable>>.Default.GetHashCode(Variables);
        }

        public static bool operator ==(Metadata metadata1, Metadata metadata2)
        {
            return EqualityComparer<Metadata>.Default.Equals(metadata1, metadata2);
        }

        public static bool operator !=(Metadata metadata1, Metadata metadata2)
        {
            return !(metadata1 == metadata2);
        }
    }
}
