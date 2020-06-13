using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrModalidadProducto
    {
        public PrModalidadProducto()
        {
            CoRelacionTipoClienteModalidadProducto = new HashSet<CoRelacionTipoClienteModalidadProducto>();
            CoVentaPacksOnline = new HashSet<CoVentaPacksOnline>();
            CoVentas = new HashSet<CoVentas>();
            PrProductoPrecio = new HashSet<PrProductoPrecio>();
            PrRelacionProductoModalidad = new HashSet<PrRelacionProductoModalidad>();
        }

        public int IdModalidadProducto { get; set; }
        public string CodigoModalidad { get; set; }
        public string DescripcionModalidad { get; set; }
        public int IdTipoUso { get; set; }
        public int IdTipoFacturacionProducto { get; set; }
        public string RequiereCtaCte { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual PrTipoFacturacionProducto IdTipoFacturacionProductoNavigation { get; set; }
        public virtual PrProductoTiposUso IdTipoUsoNavigation { get; set; }
        public virtual ICollection<CoRelacionTipoClienteModalidadProducto> CoRelacionTipoClienteModalidadProducto { get; set; }
        public virtual ICollection<CoVentaPacksOnline> CoVentaPacksOnline { get; set; }
        public virtual ICollection<CoVentas> CoVentas { get; set; }
        public virtual ICollection<PrProductoPrecio> PrProductoPrecio { get; set; }
        public virtual ICollection<PrRelacionProductoModalidad> PrRelacionProductoModalidad { get; set; }
    }
}
