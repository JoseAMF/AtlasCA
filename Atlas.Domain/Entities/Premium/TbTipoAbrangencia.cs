using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbTipoAbrangencia
    {
        public int IdTipoAbrangencia { get; set; }
        public string DsTipoAbrangencia { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
