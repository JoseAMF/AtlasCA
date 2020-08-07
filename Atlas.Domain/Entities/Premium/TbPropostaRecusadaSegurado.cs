using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbPropostaRecusadaSegurado
    {
        public int IdRecusa { get; set; }
        public string NrVoucher { get; set; }
        public string NrProposta { get; set; }
        public string NmOcorrencia { get; set; }
        public DateTime? DhEnvio { get; set; }
        public DateTime? DhInclusao { get; set; }
        public string DsUsuaIncl { get; set; }
    }
}
