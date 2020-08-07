using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class BkpTbCobertura
    {
        public string IdCobertura { get; set; }
        public string IdProduto { get; set; }
        public string DsCobertura { get; set; }
        public decimal VlLimite { get; set; }
        public string TpLimite { get; set; }
        public string AtAtivo { get; set; }
        public string DsObservacao { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
        public int IdTipoMoeda { get; set; }
        public string AtTipoAssistencia { get; set; }
        public string AtEmail { get; set; }
        public DateTime? DtInicioVigencia { get; set; }
        public DateTime? DtFimVigencia { get; set; }
        public string AtBloqueio { get; set; }
    }
}
