using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Models.Manual.Tidy
{
    public class DataSet
    {
        public Metadata Metadata { get; set; }

        public List<IObservation> Observations { get; set; }

    }
}
