using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoProductosAgenciasMarkUp
    {
        public int IdProductoAgenciaMarkUp { get; set; }
        public int? IdAgencia { get; set; }
        public int? IdProducto { get; set; }
        public DateTime? FecCreaReg { get; set; }
        public string CreadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public string ModificadoPor { get; set; }
    }
}
