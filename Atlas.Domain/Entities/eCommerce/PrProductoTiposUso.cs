using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrProductoTiposUso
    {
        public PrProductoTiposUso()
        {
            PrModalidadProducto = new HashSet<PrModalidadProducto>();
        }

        public int IdProductoTipoUso { get; set; }
        public string CodigoTipoUso { get; set; }
        public string DescripcionTipoUso { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual ICollection<PrModalidadProducto> PrModalidadProducto { get; set; }
    }
}
