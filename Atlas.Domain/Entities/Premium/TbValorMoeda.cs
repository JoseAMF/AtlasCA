using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbValorMoeda
    {
        public DateTime DtBase { get; set; }
        public int IdTipoMoeda { get; set; }
        public double VlMoeda { get; set; }
        public double VlDolar { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
