using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class BsUsuarios
    {
        public int IdUsuario { get; set; }
        public int? IdCompania { get; set; }
        public string Usuario { get; set; }
    }
}
