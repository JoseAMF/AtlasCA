using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrProductoAdicionalH
    {
        public int IdProductoAdicional { get; set; }
        public int IdProducto { get; set; }
        public int Golf { get; set; }
        public int CompraProtegida { get; set; }
        public int IdProductoResultante { get; set; }
        public int? CoberturaAnual { get; set; }
    }
}
