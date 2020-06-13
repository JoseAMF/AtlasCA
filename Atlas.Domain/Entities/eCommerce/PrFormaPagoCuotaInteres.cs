using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrFormaPagoCuotaInteres
    {
        public int IdFormaPagoCuotaInteres { get; set; }
        public int IdFormaPago { get; set; }
        public int IdTipoInteres { get; set; }
        public int PlanCuotas { get; set; }
        public decimal? Tna { get; set; }
        public decimal? Tem { get; set; }
        public decimal Coeficiente { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual PoFormasPago IdFormaPagoNavigation { get; set; }
    }
}
