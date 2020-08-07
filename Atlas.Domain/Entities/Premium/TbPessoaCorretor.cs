using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbPessoaCorretor
    {
        public int IdCanalVenda { get; set; }
        public int CdCorretor { get; set; }
        public int IdPessoaCorretor { get; set; }
        public int CdTpPapel { get; set; }
        public string NrCnpjcpf { get; set; }
        public string CdSusep { get; set; }
        public int? IdAgencia { get; set; }
        public int? DvPadrao { get; set; }
        public string DvCorretorPrincipal { get; set; }
        public decimal? PeComissao { get; set; }
        public string DsUsuaIncl { get; set; }
        public DateTime DhInclusao { get; set; }
        public string DsUsuaAlte { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
