using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PeDomiciliosPersonaJuridicaView
    {
        public int IdDomicilioPersonaJuridica { get; set; }
        public int Expr1 { get; set; }
        public int IdPersonaJuridica { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Piso { get; set; }
        public string DeptoOficina { get; set; }
        public string Ciudad { get; set; }
        public string Cp { get; set; }
        public int? IdProvincia { get; set; }
        public int IdPais { get; set; }
        public string CodigoPais { get; set; }
        public string DenominacionPais { get; set; }
        public int? DiferenciaHoraria { get; set; }
    }
}
