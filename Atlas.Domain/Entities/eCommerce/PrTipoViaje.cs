using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrTipoViaje
    {
        public PrTipoViaje()
        {
            CoCotizacionesIndividuosLog = new HashSet<CoCotizacionesIndividuosLog>();
            PrProducto = new HashSet<PrProducto>();
        }

        public int IdTipoViaje { get; set; }
        public string CodigoTipoViaje { get; set; }
        public string DescripcionTipoViaje { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual ICollection<CoCotizacionesIndividuosLog> CoCotizacionesIndividuosLog { get; set; }
        public virtual ICollection<PrProducto> PrProducto { get; set; }
    }
}
