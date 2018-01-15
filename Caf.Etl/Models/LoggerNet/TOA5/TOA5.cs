using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Models.LoggerNet.TOA5
{
    /// <summary></summary>
    public class TOA5
    {
        /// <summary></summary>
        public Metadata Metadata { get; set; }

        /// <summary></summary>
        public List<IObservation> Observations { get; set; }
    }
}