using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbCheckList
    {
        public int IdCheckList { get; set; }
        public string DsCheckList { get; set; }
        public decimal NrTempo { get; set; }
        public string AtMedidorTempo { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
