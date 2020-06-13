using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class BsNotificacionOrigen
    {
        public int IdNotificacionOrigen { get; set; }
        public int IdNotificacion { get; set; }
        public string Origen { get; set; }
        public string NombreTabla { get; set; }
        public string CampoPadre { get; set; }
        public string CampoHijo { get; set; }
        public int Orden { get; set; }
    }
}
