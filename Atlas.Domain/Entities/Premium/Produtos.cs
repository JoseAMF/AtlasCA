using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class Produtos
    {
        public int Id { get; set; }
        public string CdProduto { get; set; }
        public string NmProduto { get; set; }
        public string NrDiaMinimo { get; set; }
        public string NrDiaMaximo { get; set; }
        public int? NrIdadeMaxima { get; set; }
        public int? IdTipoCobertura { get; set; }
        public string CdMoeda { get; set; }
        public decimal? VlMaximoCapital { get; set; }
        public int? DvProdutoAgencia { get; set; }
        public string CdUsuario { get; set; }
        public int? IdTipoProduto { get; set; }
        public int? IdMarca { get; set; }
        public string IdTipoViagem { get; set; }
        public string NmCondicoesGerais { get; set; }
        public int? DvBilhete { get; set; }
        public DateTime? DhInclusao { get; set; }
    }
}
