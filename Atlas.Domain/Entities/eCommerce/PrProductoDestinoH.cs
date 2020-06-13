using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrProductoDestinoH
    {
        public int IdProductoDestino { get; set; }
        public int? IdCompania { get; set; }
        public int? IdPais { get; set; }
        public int? IdProducto1 { get; set; }
        public int? IdProducto2 { get; set; }
        public int? IdProductoUpSell { get; set; }
        public DateTime? VigenciaDesde { get; set; }
        public DateTime? VigenciaHasta { get; set; }
        public string CreadoPor { get; set; }
        public DateTime? FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
    }
}
