using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class MiContactosCorresponsales
    {
        public int IdContactoCorresponsal { get; set; }
        public int? IdCorresponsal { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Observaciones { get; set; }
        public string ContactoPrincipal { get; set; }
    }
}
