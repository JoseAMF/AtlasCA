using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrFormasPagoProducto
    {
        public int IdFormasPagoProducto { get; set; }
        public int IdProducto { get; set; }
        public int IdFormaPago { get; set; }
        public int CantidadCuotas { get; set; }
        public int? IdTipoInteres { get; set; }
        public decimal Interes { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual PoFormasPago IdFormaPagoNavigation { get; set; }
        public virtual PrProducto IdProductoNavigation { get; set; }
    }
}
