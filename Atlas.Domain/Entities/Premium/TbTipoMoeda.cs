using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbTipoMoeda
    {
        public int IdTipoMoeda { get; set; }
        public string CdTipoMoeda { get; set; }
        public string DsTipoMoeda { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
        public string DsPais { get; set; }
    }
}
