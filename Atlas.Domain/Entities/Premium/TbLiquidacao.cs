using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class TbLiquidacao
    {
        public int IdCaso { get; set; }
        public int NrGop { get; set; }
        public string NrNotaFiscal { get; set; }
        public DateTime DtVencimento { get; set; }
        public DateTime? DtPagamento { get; set; }
        public int IdMoeda { get; set; }
        public decimal VlNotaFiscal { get; set; }
        public decimal? VlPagamento { get; set; }
        public int AtStatus { get; set; }
        public DateTime DhInsercao { get; set; }
        public DateTime? DhLiberacao { get; set; }
        public DateTime? DhPagamento { get; set; }
        public string DsUsuario { get; set; }
        public DateTime DhAlteracao { get; set; }
        public string AtQuitacao { get; set; }
        public decimal? VlTaxa { get; set; }
        public string DsUsuarioLiberacao { get; set; }
        public string DsUsuarioPagamento { get; set; }
        public DateTime? DtCadastro { get; set; }
        public decimal? VlTotalDolar { get; set; }
    }
}
