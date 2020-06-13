using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrTipoFacturacionProducto
    {
        public PrTipoFacturacionProducto()
        {
            PrModalidadProducto = new HashSet<PrModalidadProducto>();
        }

        public int IdTipoFacturacionProducto { get; set; }
        public string TipoFacturacion { get; set; }
        public string DescripcionTipoFacturacion { get; set; }
        public string RequiereNomina { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual ICollection<PrModalidadProducto> PrModalidadProducto { get; set; }
    }
}
