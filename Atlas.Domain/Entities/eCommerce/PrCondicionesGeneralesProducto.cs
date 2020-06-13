using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrCondicionesGeneralesProducto
    {
        public int IdCondicionesGeneralesProducto { get; set; }
        public int IdCondicionesGenerales { get; set; }
        public int IdProducto { get; set; }
    }
}
