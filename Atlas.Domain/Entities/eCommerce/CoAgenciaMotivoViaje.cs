using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoAgenciaMotivoViaje
    {
        public int IdAgenciaMotivoViaje { get; set; }
        public int IdAgencia { get; set; }
        public int IdMotivoViaje { get; set; }
    }
}
