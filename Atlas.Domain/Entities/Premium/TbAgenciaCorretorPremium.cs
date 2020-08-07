using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbAgenciaCorretorPremium
    {
        public int IdAgenciaCorretor { get; set; }
        public int IdCanalVenda { get; set; }
        public int IdPessoaCorretor { get; set; }
        public int CdTpPapel { get; set; }
        public string NrCnpjcpfCorretor { get; set; }
        public string CdSusep { get; set; }
        public decimal PeComissaoCorretor { get; set; }
        public string NrCnpjcpfAgencia { get; set; }
        public decimal PeComissaoAgencia { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
        public string DsUsuaIncl { get; set; }
        public DateTime DhInclusao { get; set; }
        public string DsUsuaAlte { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
