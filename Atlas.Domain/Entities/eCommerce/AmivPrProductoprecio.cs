using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class AmivPrProductoprecio
    {
        public int Idproducto { get; set; }
        public string Denominacionproducto { get; set; }
        public DateTime Fechadesde { get; set; }
        public DateTime? Fechahasta { get; set; }
        public int? Dias { get; set; }
        public int? Edaddesde { get; set; }
        public int? Edadhasta { get; set; }
        public int Idmoneda { get; set; }
        public double Importe { get; set; }
        public double? Porcentajeadicional { get; set; }
        public int? Idmodalidadproducto { get; set; }
    }
}
