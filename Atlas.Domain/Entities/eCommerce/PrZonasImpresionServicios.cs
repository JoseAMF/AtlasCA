using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrZonasImpresionServicios
    {
        public int IdZonaImpresion { get; set; }
        public string CodigoZonaImpresion { get; set; }
        public string DescripcionZonaImpresion { get; set; }
        public int IdCompania { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual BsCompanias IdCompaniaNavigation { get; set; }
    }
}
