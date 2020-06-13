using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoFormasPagoAgencias
    {
        public int IdFormaPagoAgencia { get; set; }
        public int IdAgencia { get; set; }
        public int IdFormaPago { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public string UrlPagoOnline { get; set; }
        public int? CantidadCuotas { get; set; }
        public double? MontoMinimoCuotas { get; set; }

        public virtual CoAgencias IdAgenciaNavigation { get; set; }
        public virtual PoFormasPago IdFormaPagoNavigation { get; set; }
    }
}
