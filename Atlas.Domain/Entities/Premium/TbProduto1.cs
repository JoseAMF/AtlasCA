using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbProduto1
    {
        public string IdProduto { get; set; }
        public string DsProduto { get; set; }
        public int IdTipoMoeda { get; set; }
        public string AtAbrangencia { get; set; }
        public DateTime DtVigencia { get; set; }
        public string AtAtivo { get; set; }
        public string DsObservacao { get; set; }
        public int? IdAgencia { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
