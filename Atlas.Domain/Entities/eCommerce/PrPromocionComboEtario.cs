using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrPromocionComboEtario
    {
        public int IdComboEtarioPromocion { get; set; }
        public int IdTipoPromocion { get; set; }
        public int? IdPromocion { get; set; }
        public int PaxPagan { get; set; }
        public int PaxBonificados { get; set; }
        public int EdadDesdePagan { get; set; }
        public int? EdadHastaPagan { get; set; }
        public int EdadDesdeBonificados { get; set; }
        public int? EdadHastaBonificados { get; set; }
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
