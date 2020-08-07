using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbGruposPaises
    {
        public int IdGruposPaises { get; set; }
        public int IdAgencia { get; set; }
        public string CdPais { get; set; }
        public string CdGruposPaises { get; set; }
        public string DsGruposPaises { get; set; }
        public string AtAtivo { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
