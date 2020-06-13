using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoVentaPacksOnline
    {
        public CoVentaPacksOnline()
        {
            CoDetallesVentaPacksOnline = new HashSet<CoDetallesVentaPacksOnline>();
        }

        public int IdVentaPackOnline { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaVenta { get; set; }
        public int IdModalidadProducto { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public double Comision { get; set; }
        public int? IdVendedor { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }

        public virtual CoClientes IdClienteNavigation { get; set; }
        public virtual PrModalidadProducto IdModalidadProductoNavigation { get; set; }
        public virtual CoVendedoresAgencias IdVendedorNavigation { get; set; }
        public virtual ICollection<CoDetallesVentaPacksOnline> CoDetallesVentaPacksOnline { get; set; }
    }
}
