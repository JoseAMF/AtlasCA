using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class AmivCoRelacionProductoModalidad
    {
        public int Idrelacion { get; set; }
        public int Idproducto { get; set; }
        public string Denominacionproducto { get; set; }
    }
}
