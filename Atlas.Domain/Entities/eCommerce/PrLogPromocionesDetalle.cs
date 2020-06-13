using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrLogPromocionesDetalle
    {
        public int IdLogPromocionesDetalle { get; set; }
        public int IdLogPromocionesAplicadas { get; set; }
        public int IdBeneficiarioPoliza { get; set; }
        public double? Importe { get; set; }
        public double? PorcentajeBonificado { get; set; }
        public double? TotalNeto { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual PoBeneficiariosPoliza IdBeneficiarioPolizaNavigation { get; set; }
        public virtual PrLogPromocionesAplicadas IdLogPromocionesAplicadasNavigation { get; set; }
    }
}
