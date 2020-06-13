using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrProductoMotivoViaje
    {
        public int IdProductoMotivoViaje { get; set; }
        public int IdProducto { get; set; }
        public int IdMotivoViaje { get; set; }
    }
}
