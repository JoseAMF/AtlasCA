using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class AmivPoConsultaDeVouchers
    {
        public string NúmeroDeVoucher { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string TipoDeDocumento { get; set; }
        public string NúmeroDeDocumento { get; set; }
        public string FechaDeNacimiento { get; set; }
        public string FechaDeEmisiónDelVoucher { get; set; }
        public string FechaDeInicioDeCobertura { get; set; }
        public string FechaDeFinDeCobertura { get; set; }
        public string Parentesco { get; set; }
    }
}
