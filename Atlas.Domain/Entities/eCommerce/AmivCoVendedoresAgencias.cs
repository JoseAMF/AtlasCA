using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class AmivCoVendedoresAgencias
    {
        public int IdVendedor { get; set; }
        public int IdPersona { get; set; }
        public string ApeVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public string Legajo { get; set; }
        public string Supervisor { get; set; }
        public string DescripcionTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Genero { get; set; }
        public DateTime? FecNacimiento { get; set; }
        public int IdDocumentoPersonaFisica { get; set; }
        public int IdTipoDocumento { get; set; }
        public string CodigoTipoDocumento { get; set; }
        public int IdAgencia { get; set; }
        public string DenominacionAgencia { get; set; }
        public int IdUser { get; set; }
        public DateTime FecCreaReg { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
