using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class AmivCoClientes
    {
        public int Idcliente { get; set; }
        public int Idtipocliente { get; set; }
        public string Tipocliente { get; set; }
        public string Descripciontipocliente { get; set; }
        public int? Idpersonajuridica { get; set; }
        public string Cuit { get; set; }
        public string Razonsocial { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
    }
}
