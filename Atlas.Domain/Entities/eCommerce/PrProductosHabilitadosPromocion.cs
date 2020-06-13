using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrProductosHabilitadosPromocion
    {
        public int IdProductoHabilitadoPromocion { get; set; }
        public int IdProducto { get; set; }
        public int IdPromocion { get; set; }
        public DateTime FechaVigenciaDesde { get; set; }
        public DateTime? FechaVigenciaHasta { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual PrProducto IdProductoNavigation { get; set; }
        public virtual PrPromociones IdPromocionNavigation { get; set; }
    }
}
