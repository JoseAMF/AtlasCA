using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbProdutoMovimento
    {
        public int IdMovimento { get; set; }
        public int? IdProduto { get; set; }
        public string CdProduto { get; set; }
        public DateTime DtMovimento { get; set; }
        public DateTime DtInicioVigencia { get; set; }
        public DateTime? DtFimVigencia { get; set; }
        public int NrDias { get; set; }
        public int NrIdadeInicial { get; set; }
        public int NrIdadeFinal { get; set; }
        public string CdMoeda { get; set; }
        public decimal VlPremio { get; set; }
        public decimal VlDolar { get; set; }
        public string DvBagagemEspecial { get; set; }
        public string DvCompraProtegida { get; set; }
        public DateTime? DhInclusao { get; set; }
        public string DsUsuaIncl { get; set; }
        public string DvCancelamento { get; set; }
    }
}
