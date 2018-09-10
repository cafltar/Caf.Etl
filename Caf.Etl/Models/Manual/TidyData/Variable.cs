using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Models.Manual.TidyData
{
    public class Variable : IEquatable<Variable>
    {
        public string FieldName { get; set; }
        public string Units { get; set; }
        public string Description { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Variable);
        }

        public bool Equals(Variable other)
        {
            return other != null &&
                   FieldName == other.FieldName &&
                   Units == other.Units &&
                   Description == other.Description;
        }

        public override int GetHashCode()
        {
            var hashCode = 1437570313;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FieldName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Units);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            return hashCode;
        }

        public static bool operator ==(Variable variable1, Variable variable2)
        {
            return EqualityComparer<Variable>.Default.Equals(variable1, variable2);
        }

        public static bool operator !=(Variable variable1, Variable variable2)
        {
            return !(variable1 == variable2);
        }
    }
}
