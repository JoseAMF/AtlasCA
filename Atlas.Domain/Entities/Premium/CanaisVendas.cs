using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class CanaisVendas
    {
        public int IdCanalVenda { get; set; }
        public string NmCanalVenda { get; set; }
        public DateTime? DhInclusao { get; set; }
    }
}
