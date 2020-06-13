using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class BsMotivoViaje
    {
        public int IdMotivoViaje { get; set; }
        public string Codigo { get; set; }
        public string MotivoViaje { get; set; }
        public string Habilitado { get; set; }
        public string AdicionalGolf { get; set; }
        public string AdicionalCompraProtegida { get; set; }
        public string VentaMayores { get; set; }
        public string VentaMenores { get; set; }
        public int? EdadHastaMenores { get; set; }
        public int? MaxQuantityOfDays { get; set; }
    }
}
