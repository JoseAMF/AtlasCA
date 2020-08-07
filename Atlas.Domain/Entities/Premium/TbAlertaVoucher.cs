using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbAlertaVoucher
    {
        public string IdTpAlerta { get; set; }
        public string DsAlerta { get; set; }
        public string NrVoucher { get; set; }
        public string AtAtivo { get; set; }
        public DateTime DhAlteracao { get; set; }
        public string DsUsuario { get; set; }
        public int IdAlertaVoucher { get; set; }
    }
}
