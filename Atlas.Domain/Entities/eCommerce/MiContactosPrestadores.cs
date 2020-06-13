using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class MiContactosPrestadores
    {
        public int IdContactoPrestadores { get; set; }
        public int? IdPrestador { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Observaciones { get; set; }
        public string ContactoPrincipal { get; set; }
    }
}
