using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoVentasFormaPago
    {
        public int IdVentaFormaPago { get; set; }
        public int IdVenta { get; set; }
        public int IdFormaPagoBs { get; set; }
        public double Importe { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual PoFormasPago IdFormaPagoBsNavigation { get; set; }
        public virtual CoVentas IdVentaNavigation { get; set; }
    }
}
