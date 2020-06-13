using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PeDomiciliosPersonaFisicaView
    {
        public int IdDomicilioPersona { get; set; }
        public int IdPersona { get; set; }
        public int IdDomicilio { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Piso { get; set; }
        public string DeptoOficina { get; set; }
        public string Ciudad { get; set; }
        public string Cp { get; set; }
        public int? IdProvincia { get; set; }
        public int IdPais { get; set; }
        public int? DiferenciaHoraria { get; set; }
        public string CodigoPais { get; set; }
        public string DenominacionPais { get; set; }
        public int? IdTipoCalle { get; set; }
        public string DescripcionTipoCalle { get; set; }
        public string Barrio { get; set; }
    }
}
