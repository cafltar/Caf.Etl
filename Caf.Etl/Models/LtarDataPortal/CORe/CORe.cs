using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caf.Etl.Models.LtarDataPortal.CORe
{
    /// <summary></summary>
    public class CORe
    {
        /// <summary></summary>
        public Metadata Metadata { get; private set; }

        /// <summary></summary>
        public List<Observation> Observations { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="observations"></param>
        public CORe(
            Metadata metadata,
            List<Observation> observations)
        {
            this.Metadata = metadata;
            this.Observations = observations;
        }
    }
}
