using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrSellerIdhabilitadosPromocion
    {
        public int IdSellerIdhabilitadoPromocion { get; set; }
        public int IdSellerIdcanalesVentas { get; set; }
        public int IdPromocion { get; set; }
        public DateTime FechaVigenciaDesde { get; set; }
        public DateTime? FechaVigenciaHasta { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual PrPromociones IdPromocionNavigation { get; set; }
        public virtual CoSellerIdcanalesVentas IdSellerIdcanalesVentasNavigation { get; set; }
    }
}
