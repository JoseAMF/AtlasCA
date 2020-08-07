using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbCancelamentoSegurado
    {
        public decimal IdCancelamentoSegurado { get; set; }
        public string NrBilhete { get; set; }
        public string CdApolice { get; set; }
        public string CancelaAgrupada { get; set; }
        public int CdMotivo { get; set; }
        public DateTime DtCancelamento { get; set; }
        public int? IdMeioPagamento { get; set; }
        public string NrBanco { get; set; }
        public string NrAgencia { get; set; }
        public string NrDacAgencia { get; set; }
        public string NrContaCorrente { get; set; }
        public string NrDacContaCorrente { get; set; }
        public string DsUsuaIncl { get; set; }
        public DateTime DhInclusao { get; set; }
        public string DsUsuaAlte { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
