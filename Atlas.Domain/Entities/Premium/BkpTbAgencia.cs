using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class BkpTbAgencia
    {
        public int IdAgencia { get; set; }
        public string DsAgencia { get; set; }
        public string AtAtivo { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
