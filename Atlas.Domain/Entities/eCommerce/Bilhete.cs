using System;

namespace Atlas.Domain.Entities.eCommerce
{
    public class Bilhete
    {
        public string NrVoucher { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string sexo { get; set; }
        public DateTime? DtNascimento { get; set; }
        public string ContatoEmergencia { get; set; }
        public string ContatoEmergenciaTelefone { get; set; }
        public string Agencia { get; set; }
        public string Segmento { get; set; }
        public string Produto { get; set; }
        public string Cupom { get; set; }
        public string SellerID { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public DateTime Emissao { get; set; }
        public string Destino { get; set; }
        public double? Valor { get; set; }
        public double? ValorDolar { get; set; }
        public string FormaPgto { get; set; }
        public DateTime? DtCancelamento { get; set; }

    }
}