using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class AmivPrProductosagencias
    {
        public int? Idagencia { get; set; }
        public string Razonsocial { get; set; }
        public int Idproducto { get; set; }
        public string Codigoproducto { get; set; }
        public string Denominacionproducto { get; set; }
    }
}
