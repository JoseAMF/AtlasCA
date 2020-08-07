using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbAutorizacaoComplemento
    {
        public int IdAutorizacaoComplemento { get; set; }
        public int IdUsuario { get; set; }
        public string DsUsuario { get; set; }
        public int IdCaso { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
        public string TpJustificativa { get; set; }
        public string DsJustificativa { get; set; }
    }
}
