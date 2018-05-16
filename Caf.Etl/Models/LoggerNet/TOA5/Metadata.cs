using System.Collections.Generic;

namespace Caf.Etl.Models.LoggerNet.TOA5
{
    /// <summary></summary>
    public class Metadata
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
    }
}
