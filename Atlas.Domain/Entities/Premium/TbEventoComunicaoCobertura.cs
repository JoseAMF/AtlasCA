using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbEventoComunicaoCobertura
    {
        public int IdEventoComunicacao { get; set; }
        public string IdCobertura { get; set; }
        public string IdProduto { get; set; }
        public string DsUsuaAlteracao { get; set; }
        public DateTime DhAlteracao { get; set; }
    }
}
