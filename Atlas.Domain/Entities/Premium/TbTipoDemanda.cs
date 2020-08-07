using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbTipoDemanda
    {
        public int IdTipoDemanda { get; set; }
        public string DsTipoDemanda { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
