using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PoHistoricoVoucher
    {
        public int IdHistoricoVoucher { get; set; }
        public int IdVoucher { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime FecModReg { get; set; }

        public virtual PoPolizas IdVoucherNavigation { get; set; }
    }
}
