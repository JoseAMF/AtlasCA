using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrLineaProducto
    {
        public PrLineaProducto()
        {
            PrMarcasProductos = new HashSet<PrMarcasProductos>();
        }

        public int IdLineaProducto { get; set; }
        public int IdCompania { get; set; }
        public string CodigoLineaProducto { get; set; }
        public string DescripcionLineaProducto { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual BsCompanias IdCompaniaNavigation { get; set; }
        public virtual ICollection<PrMarcasProductos> PrMarcasProductos { get; set; }
    }
}
