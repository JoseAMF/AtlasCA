using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class AmivPePersonasFisicasCompleto
    {
        public int IdPersona { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int IdPaisResidencia { get; set; }
        public string PaisResidencia { get; set; }
        public string Sexo { get; set; }
        public int? IdDomicilio { get; set; }
        public string Calle { get; set; }
        public string NumeroDomicilio { get; set; }
        public string Piso { get; set; }
        public string DeptoOficina { get; set; }
        public string Ciudad { get; set; }
        public string Cp { get; set; }
        public int? IdProvincia { get; set; }
        public string ProvinciaDomicilio { get; set; }
        public int? IdPais { get; set; }
        public string PaisDomicilio { get; set; }
        public int IdDocumentoPersonaFisica { get; set; }
        public int IdTipoDocumento { get; set; }
        public string DescripcionTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string CodigoTipoDocumento { get; set; }
        public string CodigoProvincia { get; set; }
    }
}
