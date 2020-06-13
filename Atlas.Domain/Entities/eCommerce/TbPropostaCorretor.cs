using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class TbPropostaCorretor
    {
        public int IdPessoaCorretor { get; set; }
        public string NrProposta { get; set; }
        public string CdTpPapel { get; set; }
        public decimal PeParticipacao { get; set; }
        public decimal PeComissao { get; set; }
        public string DvCorretorPrincipal { get; set; }
        public string DsUsuaIncl { get; set; }
        public DateTime DhInclusao { get; set; }
        public string DsUsuaAlte { get; set; }
        public DateTime DhAlteracao { get; set; }

        public virtual TbProposta NrPropostaNavigation { get; set; }
    }
}
