using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class MiCorresponsalesView
    {
        public int IdCorresponsal { get; set; }
        public int IdPersonaJuridica { get; set; }
        public string Cuit { get; set; }
        public string RazonSocial { get; set; }
        public int? IdPais { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string CodigoPais { get; set; }
        public string DenominacionPais { get; set; }
        public int? DiferenciaHoraria { get; set; }
    }
}
