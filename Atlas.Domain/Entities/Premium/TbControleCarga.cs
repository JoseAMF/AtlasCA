using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbControleCarga
    {
        public DateTime DtMovimento { get; set; }
        public string StCarga { get; set; }
        public DateTime DhInclusao { get; set; }
        public string DsUsuaInclu { get; set; }
        public DateTime? DhAlteracao { get; set; }
        public string DsUsuaAlter { get; set; }
    }
}
