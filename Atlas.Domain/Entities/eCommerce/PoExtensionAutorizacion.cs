using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PoExtensionAutorizacion
    {
        public int IdPoextensionAutorizacion { get; set; }
        public string NroVoucher { get; set; }
        public string Resultado { get; set; }
        public string DescripcionError { get; set; }
        public DateTime? FechaHasta { get; set; }
    }
}
