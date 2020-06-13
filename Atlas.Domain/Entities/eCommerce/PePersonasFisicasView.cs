using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PePersonasFisicasView
    {
        public int IdPersona { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string FechaNacimiento { get; set; }
        public string PaisResidencia { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string TelefonoFijo { get; set; }
        public string TelefonoComercial { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Piso { get; set; }
        public string DeptoOficina { get; set; }
        public string Ciudad { get; set; }
        public string Cp { get; set; }
        public int IdProvincia { get; set; }
        public int IdPais { get; set; }
        public string ProvinciaDomicilio { get; set; }
        public string PaisDomicilio { get; set; }
        public int? IdDomicilio { get; set; }
        public string Sexo { get; set; }
        public int? IdTipoCalle { get; set; }
        public string DescripcionTipoCalle { get; set; }
        public string Barrio { get; set; }
    }
}
