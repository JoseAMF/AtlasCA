using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class AmivPePersonaFisica
    {
        public int IdPersona { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string DescripcionTipoDocumento { get; set; }
        public string Numero { get; set; }
        public string Sexo { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int IdDocumentoPersonaFisica { get; set; }
        public int IdTipoDocumento { get; set; }
        public string CodigoTipoDocumento { get; set; }
    }
}
