using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrPromocionDescuentoIndividual
    {
        public int IdDescuentoIndividualPromocion { get; set; }
        public int IdTipoPromocion { get; set; }
        public int IdPromocion { get; set; }
        public int CantidadBonificados { get; set; }
        public double Bonificacion { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual PrPromociones IdPromocionNavigation { get; set; }
        public virtual PrTiposPromocion IdTipoPromocionNavigation { get; set; }
    }
}
