using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class VwPrecificacaoPorCasos
    {
        public int Caso { get; set; }
        public string TipoDeCaso { get; set; }
        public string PaísDeDestino { get; set; }
        public string EstadoDeDestino { get; set; }
        public string MunicípioDeDestino { get; set; }
        public DateTime? DataDeAbertura { get; set; }
        public DateTime? DataDeEncerramento { get; set; }
        public string ProdutoContratado { get; set; }
        public string Cobertura { get; set; }
        public DateTime? DataInicialDaVigência { get; set; }
        public DateTime? DataFinalDaVigência { get; set; }
        public decimal LimiteDaCobertura { get; set; }
        public double? TotalAutorizado { get; set; }
        public double? TotalUtilizado { get; set; }
        public string Moeda { get; set; }
        public string NumerodoVoucher { get; set; }
        public DateTime? DataDeContratação { get; set; }
        public string NomeDoBeneficiário { get; set; }
        public string PaisDoBeneficiário { get; set; }
        public string Sexo { get; set; }
        public DateTime? DataDeNascimento { get; set; }
        public string IdBeneficiario { get; set; }
        public int? NrGop { get; set; }
        public string NrNotaFiscal { get; set; }
        public decimal? VlDespesas { get; set; }
        public decimal? VlTaxa { get; set; }
        public decimal? VlPago { get; set; }
        public DateTime? DtVencimento { get; set; }
        public DateTime? DtRegistro { get; set; }
        public DateTime? DtPagamento { get; set; }
        public string DsPrestador { get; set; }
        public string DsAssistenciaRequerida { get; set; }
        public string DsNaturezaProblema { get; set; }
    }
}
