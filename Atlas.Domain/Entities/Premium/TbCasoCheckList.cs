using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbCasoCheckList
    {
        public int IdCheckList { get; set; }
        public int IdCaso { get; set; }
        public DateTime DhPrazo { get; set; }
        public DateTime? DhResolucao { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
