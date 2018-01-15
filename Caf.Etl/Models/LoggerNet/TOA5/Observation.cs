using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Models.LoggerNet.TOA5
{
    /// <summary></summary>
    public interface IObservation
    {
        /// <summary></summary>
        DateTime TIMESTAMP { get; set; }

        /// <summary></summary>
        int RECORD { get; set; }
    }
}