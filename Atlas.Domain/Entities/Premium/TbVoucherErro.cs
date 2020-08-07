using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbVoucherErro
    {
        public string NrVoucher { get; set; }
        public DateTime DtErro { get; set; }
        public string DsMensagemErro { get; set; }
        public int IdVoucherErro { get; set; }
    }
}
