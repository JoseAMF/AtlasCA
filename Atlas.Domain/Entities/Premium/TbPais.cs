using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbPais
    {
        public string CdPais { get; set; }
        public string DsPais { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
        public int? IdTipoMoeda { get; set; }
    }
}
