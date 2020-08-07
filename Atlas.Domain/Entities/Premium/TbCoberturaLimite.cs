using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbCoberturaLimite
    {
        public string NrVoucher { get; set; }
        public string IdCobertura { get; set; }
        public decimal VlAutorizado { get; set; }
        public decimal VlUtilizado { get; set; }
        public DateTime DhAutorizado { get; set; }
        public DateTime DhUtilizado { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
        public int? IdTipoMoeda { get; set; }
        public string TpLimite { get; set; }
        public int? IdCasoComunicacao { get; set; }
        public int? IdCaso { get; set; }
    }
}
