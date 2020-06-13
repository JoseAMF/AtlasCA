using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoConsumosVentas
    {
        public int IdConsumosVenta { get; set; }
        public int IdDetallesVenta { get; set; }
        public int? IdPersona { get; set; }
        public DateTime? FechaConsumo { get; set; }
        public int TotalDias { get; set; }
        public int ConsumoDias { get; set; }
        public int DiasDisponibles { get; set; }
        public int? IdPoliza { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual CoDetallesVenta IdDetallesVentaNavigation { get; set; }
        public virtual PePersonaFisica IdPersonaNavigation { get; set; }
        public virtual PoPolizas IdPolizaNavigation { get; set; }
    }
}
