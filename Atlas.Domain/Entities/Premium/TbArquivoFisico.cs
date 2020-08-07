using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbArquivoFisico
    {
        public string NrVoucher { get; set; }
        public DateTime DtArquivo { get; set; }
        public DateTime DhInclusao { get; set; }
        public string DsUsuaIncl { get; set; }
    }
}
