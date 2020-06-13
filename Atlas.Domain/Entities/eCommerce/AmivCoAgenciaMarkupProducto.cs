using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class AmivCoAgenciaMarkupProducto
    {
        public int Idagencia { get; set; }
        public string Denominacionagencia { get; set; }
        public int? Idproducto { get; set; }
        public string Denominacionproducto { get; set; }
        public double? Markup { get; set; }
        public DateTime? Fechavigenciadesde { get; set; }
        public DateTime? Fechavigenciahasta { get; set; }
    }
}
