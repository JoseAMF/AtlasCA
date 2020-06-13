using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoTipoCalculoImporte
    {
        public int IdTipoCalculoImporte { get; set; }
        public string Codi { get; set; }
        public string Descripcion { get; set; }
        public string SpCalculo { get; set; }
        public string SpRecalculo { get; set; }
    }
}
