using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbTipoLimite
    {
        public int IdTipoLimite { get; set; }
        public string DsTipoLimite { get; set; }
        public string CdLinhaProduto { get; set; }
        public string CdTipoProduto { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
        public double VlLimite { get; set; }
        public int QtLimite { get; set; }
        public int IdTipoAbrangencia { get; set; }
        public int IdTipoMoeda { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
