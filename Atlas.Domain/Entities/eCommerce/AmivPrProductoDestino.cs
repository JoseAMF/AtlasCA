using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class AmivPrProductoDestino
    {
        public int? IdMotivoViaje { get; set; }
        public string CodigoMotivoViaje { get; set; }
        public string MotivoViaje { get; set; }
        public int? IdPais { get; set; }
        public string DenominacionPais { get; set; }
        public int? IdProducto1 { get; set; }
        public string DenoProducto1 { get; set; }
        public int? IdProducto2 { get; set; }
        public string DenoProducto2 { get; set; }
        public int? IdProductoUpSell { get; set; }
        public string DenoUpSell { get; set; }
    }
}
