using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoAgenciasBudget
    {
        public int IdAgenciabudget { get; set; }
        public int IdAgencia { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public decimal Monto { get; set; }

        public virtual CoAgencias IdAgenciaNavigation { get; set; }
    }
}
