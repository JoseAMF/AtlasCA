using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrTipoProducto
    {
        public PrTipoProducto()
        {
            CoCotizacionesIndividuosLog = new HashSet<CoCotizacionesIndividuosLog>();
            PrPromociones = new HashSet<PrPromociones>();
        }

        public int IdTipoProducto { get; set; }
        public string TipoProducto { get; set; }
        public string DenominacionTipoProducto { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual ICollection<CoCotizacionesIndividuosLog> CoCotizacionesIndividuosLog { get; set; }
        public virtual ICollection<PrPromociones> PrPromociones { get; set; }
    }
}
