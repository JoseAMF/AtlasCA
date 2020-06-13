using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class AmivPoBeneficiariosPoliza
    {
        public string NumeroPoliza { get; set; }
        public int? Secuencia { get; set; }
        public int IdPoliza { get; set; }
        public int IdBeneficiarioPoliza { get; set; }
        public int IdPersona { get; set; }
        public bool MarcaTitular { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string DescripcionTipoDocumento { get; set; }
        public string Numero { get; set; }
        public string Sexo { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int? IdParentesco { get; set; }
        public string DescripcionParentesco { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public int IdTipoDocumento { get; set; }
        public string CodigoProducto { get; set; }
        public string DenominacionProducto { get; set; }
        public int MaximoDias { get; set; }
    }
}
