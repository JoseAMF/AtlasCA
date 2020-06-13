using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WsSesiones
    {
        public int Idcompania { get; set; }
        public string Idioma { get; set; }
        public string Idsesion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
