using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class BsCodigosTarjetasPagoOnline
    {
        public int IdCodigoTarjetaPagoOnline { get; set; }
        public int? IdEntidadPagoOnline { get; set; }
        public int? IdFormaPago { get; set; }
        public string CodiParam { get; set; }
    }
}
