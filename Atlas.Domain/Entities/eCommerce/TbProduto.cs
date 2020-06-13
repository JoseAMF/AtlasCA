using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class TbProduto
    {
        public int IdProduto { get; set; }
        public int? IdProducto { get; set; }
        public int? IdQuestionario { get; set; }
        public int? IdPergunta { get; set; }
        public int? IdResposta { get; set; }
        public int? CdTpPapel { get; set; }
        public int? IdPessoaCorretor { get; set; }
        public int? CdCorretor { get; set; }
        public string CdSusep { get; set; }
        public string DvPadrao { get; set; }
        public int? IdCanalVenda { get; set; }

        public virtual PrProducto IdProductoNavigation { get; set; }
    }
}
