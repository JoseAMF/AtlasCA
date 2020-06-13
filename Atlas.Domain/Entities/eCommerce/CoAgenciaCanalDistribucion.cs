using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoAgenciaCanalDistribucion
    {
        public int IdAgenciaCanalDistribucion { get; set; }
        public int IdAgencia { get; set; }
        public int IdCanalDistribucion { get; set; }
        public string SolicitaCondicionesGenerales { get; set; }

        public virtual CoAgencias IdAgenciaNavigation { get; set; }
        public virtual CoCanalDistribucion IdCanalDistribucionNavigation { get; set; }
    }
}
