using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PoTempComprador
    {
        public int IdTmpComprador { get; set; }
        public string SessionId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumeroDni { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Cep { get; set; }
        public string Calle { get; set; }
        public int? Numero { get; set; }
        public string Complemento { get; set; }
        public string Uf { get; set; }
        public string Barrio { get; set; }
        public string Ciudad { get; set; }
        public string DddCelular { get; set; }
        public string TelCelular { get; set; }
        public string DddResidencial { get; set; }
        public string TelResidencial { get; set; }
        public string DddComercial { get; set; }
        public string TelComercial { get; set; }
        public string NombreEmerg { get; set; }
        public string ApellidoEmerg { get; set; }
        public string DddCelularEmerg { get; set; }
        public string TelCelularEmerg { get; set; }
        public string DddResidencialEmerg { get; set; }
        public string TelResidencialEmerg { get; set; }
        public string DddComercialEmerg { get; set; }
        public string TelComercialEmerg { get; set; }
        public string Email { get; set; }
    }
}
