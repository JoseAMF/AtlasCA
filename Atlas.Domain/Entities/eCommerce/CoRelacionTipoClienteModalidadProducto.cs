using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoRelacionTipoClienteModalidadProducto
    {
        public CoRelacionTipoClienteModalidadProducto()
        {
            CoComisionesTipoClienteModalidadProducto = new HashSet<CoComisionesTipoClienteModalidadProducto>();
        }

        public int IdTipoRelacionClienteProducto { get; set; }
        public int IdTipoCliente { get; set; }
        public int IdModalidadProducto { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual PrModalidadProducto IdModalidadProductoNavigation { get; set; }
        public virtual CoTiposCliente IdTipoClienteNavigation { get; set; }
        public virtual ICollection<CoComisionesTipoClienteModalidadProducto> CoComisionesTipoClienteModalidadProducto { get; set; }
    }
}
