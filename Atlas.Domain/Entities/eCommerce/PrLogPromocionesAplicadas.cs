using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrLogPromocionesAplicadas
    {
        public PrLogPromocionesAplicadas()
        {
            PrLogPromocionesDetalle = new HashSet<PrLogPromocionesDetalle>();
        }

        public int IdLogPromocionesAplicadas { get; set; }
        public int IdPromocion { get; set; }
        public int IdPoliza { get; set; }
        public int IdTipoPromocion { get; set; }
        public int IdDetallePromocion { get; set; }
        public double Valor { get; set; }
        public bool PromoUtilizada { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public string DescripcionDetallePromocion { get; set; }

        public virtual PoPolizas IdPolizaNavigation { get; set; }
        public virtual PrPromociones IdPromocionNavigation { get; set; }
        public virtual PrTiposPromocion IdTipoPromocionNavigation { get; set; }
        public virtual ICollection<PrLogPromocionesDetalle> PrLogPromocionesDetalle { get; set; }
    }
}
