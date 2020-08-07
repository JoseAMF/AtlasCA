using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbProdutoPremium
    {
        public int IdProduto { get; set; }
        public string CdProduto { get; set; }
        public int NrIdadeInicial { get; set; }
        public int NrIdadeFinal { get; set; }
        public string DvBagagemEspecial { get; set; }
        public string DvCompraProtegida { get; set; }
        public string DsUsuaIncl { get; set; }
        public DateTime DhInclusao { get; set; }
        public string DvCancelamento { get; set; }
        public string CdProdutoEc { get; set; }
    }
}
