using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbProdutoGruposPaises
    {
        public string IdProduto { get; set; }
        public string CdGruposPaises { get; set; }
        public string AtAtivo { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
