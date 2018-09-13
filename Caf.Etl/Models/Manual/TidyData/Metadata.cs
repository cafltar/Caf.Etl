using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caf.Etl.Models.Manual.TidyData
{
    public class Metadata : IEquatable<Metadata>
    {
        public string FilenameDictionary { get; set; }
        public string FilenameData { get; set; }
        public List<Variable> Variables { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Metadata);
        }

        public bool Equals(Metadata other)
        {
            return other != null &&
                   FilenameDictionary == other.FilenameDictionary &&
                   FilenameData == other.FilenameData &&
                   Variables.SequenceEqual(other.Variables);
                   //EqualityComparer<List<Variable>>.Default.Equals(Variables, other.Variables);
        }

        public override int GetHashCode()
        {
            var hashCode = -863572658;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FilenameDictionary);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FilenameData);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Variable>>.Default.GetHashCode(Variables);
            return hashCode;
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
