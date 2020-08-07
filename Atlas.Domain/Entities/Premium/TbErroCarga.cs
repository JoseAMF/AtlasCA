using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbErroCarga
    {
        public int IdErro { get; set; }
        public DateTime? DhInclusao { get; set; }
        public int? IdPoliza { get; set; }
        public int? NrErro { get; set; }
    }
}
