using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class AmivPrProductosAdicionales
    {
        public int Idproducto { get; set; }
        public string ProductoOriginal { get; set; }
        public int Golf { get; set; }
        public int Compraprotegida { get; set; }
        public int? CoberturaAnual { get; set; }
        public string ProductoResultante { get; set; }
    }
}
