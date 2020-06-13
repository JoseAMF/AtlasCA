using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrTipoCobertura
    {
        public PrTipoCobertura()
        {
            PrProducto = new HashSet<PrProducto>();
        }

        public int IdTipoCobertura { get; set; }
        public string TipoCobertura { get; set; }
        public string DescripcionCobertura { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual ICollection<PrProducto> PrProducto { get; set; }
    }
}
