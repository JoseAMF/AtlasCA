using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class TbPropostaDeclaracaoSaude
    {
        public int IdDeclaracao { get; set; }
        public string NrVoucher { get; set; }
        public string CdPergunta { get; set; }
        public string IdResposta { get; set; }
        public string NmComplementoResposta { get; set; }
        public string DsUsuaIncl { get; set; }
        public DateTime DhInclusao { get; set; }
        public string DsUsuaAlte { get; set; }
        public DateTime DhAlteracao { get; set; }

        public virtual TbPropostaSegurado NrVoucherNavigation { get; set; }
    }
}
