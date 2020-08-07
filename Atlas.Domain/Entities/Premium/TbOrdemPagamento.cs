using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbOrdemPagamento
    {
        public int IdOrdemPagamento { get; set; }
        public string NrOrdemPagamento { get; set; }
        public decimal VlCompra { get; set; }
        public int QtVoucher { get; set; }
        public string DsUsuario { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
