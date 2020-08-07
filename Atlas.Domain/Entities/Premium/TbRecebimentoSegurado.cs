using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbRecebimentoSegurado
    {
        public string NrVoucher { get; set; }
        public int NrParcela { get; set; }
        public DateTime DtRecebimento { get; set; }
        public decimal VlPago { get; set; }
        public string DsUsuaIncl { get; set; }
        public DateTime? DhInclusao { get; set; }
        public string DsUsuaAlte { get; set; }
        public DateTime? DhAlteracao { get; set; }
    }
}
