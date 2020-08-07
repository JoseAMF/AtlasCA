using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class CanaisVendasOrigem
    {
        public int IdCanalVenda { get; set; }
        public string NmCanalVenda { get; set; }
        public string IdCanalVendaOrigem { get; set; }
        public DateTime? DhInclusao { get; set; }
    }
}
