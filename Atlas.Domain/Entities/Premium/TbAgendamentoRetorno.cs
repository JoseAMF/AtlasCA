using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbAgendamentoRetorno
    {
        public int IdAgendamentoRetorno { get; set; }
        public string DsComentario { get; set; }
        public string AtAtivo { get; set; }
        public DateTime DhRetorno { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
        public int? IdCaso { get; set; }
    }
}
