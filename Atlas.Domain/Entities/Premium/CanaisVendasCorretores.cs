using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class CanaisVendasCorretores
    {
        public int Id { get; set; }
        public int? IdCanalVenda { get; set; }
        public int? CdTpPapel { get; set; }
        public int? IdPessoaCorretor { get; set; }
        public int? CdCorretor { get; set; }
        public string CdSusep { get; set; }
        public string NrCnpjCpf { get; set; }
        public int? CdTipoPessoa { get; set; }
        public string NmCorretor { get; set; }
        public int? DvPadrao { get; set; }
        public decimal? PeComissao { get; set; }
        public DateTime? DhInclusao { get; set; }
    }
}
