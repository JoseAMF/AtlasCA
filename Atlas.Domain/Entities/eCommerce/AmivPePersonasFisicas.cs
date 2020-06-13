using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class AmivPePersonasFisicas
    {
        public int Idpersona { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public DateTime? Fechanacimiento { get; set; }
        public int Idtipodocumento { get; set; }
        public string Codigotipodocumento { get; set; }
        public string Descripciontipodocumento { get; set; }
        public string Numero { get; set; }
    }
}
