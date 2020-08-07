using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class ProdutosCanaisVendas
    {
        public int Id { get; set; }
        public string CdProduto { get; set; }
        public int? IdCanalVenda { get; set; }
        public DateTime? DhInclusao { get; set; }
    }
}
