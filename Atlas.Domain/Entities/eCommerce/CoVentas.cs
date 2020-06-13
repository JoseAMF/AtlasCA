using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoVentas
    {
        public CoVentas()
        {
            CoDetallesVenta = new HashSet<CoDetallesVenta>();
            CoVentasFormaPago = new HashSet<CoVentasFormaPago>();
        }

        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaVenta { get; set; }
        public int IdModalidadProducto { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public double? Comision { get; set; }
        public int? IdVendedor { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public decimal? PeriodoVigencia { get; set; }
        public string RenovacionAutomatica { get; set; }

        public virtual CoClientes IdClienteNavigation { get; set; }
        public virtual PrModalidadProducto IdModalidadProductoNavigation { get; set; }
        public virtual CoVendedoresAgencias IdVendedorNavigation { get; set; }
        public virtual ICollection<CoDetallesVenta> CoDetallesVenta { get; set; }
        public virtual ICollection<CoVentasFormaPago> CoVentasFormaPago { get; set; }
    }
}
