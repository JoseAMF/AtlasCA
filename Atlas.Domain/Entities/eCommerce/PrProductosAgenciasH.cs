using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrProductosAgenciasH
    {
        public int IdProductoAgencia { get; set; }
        public int IdProducto { get; set; }
        public int? IdAgencia { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public DateTime FecCreaReg { get; set; }
        public DateTime? FecModReg { get; set; }
        public double? MarkUp { get; set; }
    }
}
