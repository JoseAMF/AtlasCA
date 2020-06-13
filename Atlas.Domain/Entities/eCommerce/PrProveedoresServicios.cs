using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrProveedoresServicios
    {
        public int IdProveedorServicio { get; set; }
        public int IdPersonaJuridica { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime FechaFinVigencia { get; set; }
        public int IdCompania { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string CreadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public string ModificadoPor { get; set; }

        public virtual PePersonaJuridica IdPersonaJuridicaNavigation { get; set; }
    }
}
