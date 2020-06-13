using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PoTmpBeneficiarios
    {
        public int IdTmpBeneficiario { get; set; }
        public string SessionId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IdBeneficiario { get; set; }
        public int IdPersonaFisica { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Sexo { get; set; }
        public string TelefonoFijo { get; set; }
        public string TelefonoCelular { get; set; }
        public string Email { get; set; }
        public string Cuil { get; set; }
        public int? NumeroPasajero { get; set; }
    }
}
