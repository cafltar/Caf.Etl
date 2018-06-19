using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Models.LoggerNet.TOA5
{
    /// <summary></summary>
    public class Variable : IEquatable<Variable>
    {
        /// <summary></summary>
        public string FieldName { get; set; }

        /// <summary></summary>
        public string Units { get; set; }

        /// <summary></summary>
        public string Processing { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Variable);
        }

        public bool Equals(Variable other)
        {
            return other != null &&
                   FieldName == other.FieldName &&
                   Units == other.Units &&
                   Processing == other.Processing;
        }

        public override int GetHashCode()
        {
            var hashCode = 596817126;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FieldName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Units);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Processing);
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
