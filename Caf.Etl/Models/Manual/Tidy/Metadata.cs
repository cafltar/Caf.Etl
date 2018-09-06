using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Models.Manual.Tidy
{
    public class Metadata
    {
        public string AreaOfInterest { get; set; }
        public List<Variable> Variables { get; set; }
    }
}
