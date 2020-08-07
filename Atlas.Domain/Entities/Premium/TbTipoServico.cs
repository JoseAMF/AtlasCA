using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbTipoServico
    {
        public int IdTpServico { get; set; }
        public string IdCobertura { get; set; }
        public string DsTpServico { get; set; }
        public string AtAtivo { get; set; }
        public string DsUsuario { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
