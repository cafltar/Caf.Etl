using System;
using System.Collections.Generic;
using System.Linq;

namespace Caf.Etl.Models.LoggerNet.TOA5
{
    /// <summary></summary>
    public class Metadata : IEquatable<Metadata>
    {
        /// <summary></summary>
        public string   FileFormat                  { get; set; }

        /// <summary></summary>
        public string   StationName                 { get; set; }

        /// <summary></summary>
        public string   DataLoggerType              { get; set; }

        /// <summary></summary>
        public int      SerialNumber                { get; set; }

        /// <summary></summary>
        public string   OperatingSystemVersion      { get; set; }

        /// <summary></summary>
        public string   DataloggerProgramName       { get; set; }

        /// <summary></summary>
        public int      DataloggerProgramSignature  { get; set; }

        /// <summary></summary>
        public string   TableName                   { get; set; }

        /// <summary></summary>
        public List<Variable> Variables { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Metadata);
        }

        public bool Equals(Metadata other)
        {
            return other != null &&
                   FileFormat == other.FileFormat &&
                   StationName == other.StationName &&
                   DataLoggerType == other.DataLoggerType &&
                   SerialNumber == other.SerialNumber &&
                   OperatingSystemVersion == other.OperatingSystemVersion &&
                   DataloggerProgramName == other.DataloggerProgramName &&
                   DataloggerProgramSignature == other.DataloggerProgramSignature &&
                   TableName == other.TableName &&
                   Variables.SequenceEqual(other.Variables);
                   //EqualityComparer<List<Variable>>.Default.Equals(Variables, other.Variables);

        }

        public override int GetHashCode()
        {
            var hashCode = 1454258597;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FileFormat);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(StationName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DataLoggerType);
            hashCode = hashCode * -1521134295 + SerialNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(OperatingSystemVersion);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DataloggerProgramName);
            hashCode = hashCode * -1521134295 + DataloggerProgramSignature.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TableName);
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
