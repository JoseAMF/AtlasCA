using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class AmivPrProductodestino1
    {
        public int Idproductodestino { get; set; }
        public int? Idcompania { get; set; }
        public int? Idpais { get; set; }
        public string Denominacionpais { get; set; }
        public string Iso3l { get; set; }
        public int? Idproducto1 { get; set; }
        public string PrimerSugerencia { get; set; }
        public int? Idproducto2 { get; set; }
        public string SegundaSugerencia { get; set; }
        public int? IdproductoUpsell { get; set; }
        public string ProductoUpsell { get; set; }
        public int? Idcontinente { get; set; }
        public string Continente { get; set; }
    }
}
