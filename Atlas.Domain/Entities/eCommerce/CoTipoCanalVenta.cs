using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoTipoCanalVenta
    {
        public CoTipoCanalVenta()
        {
            CoSellerIdcanalesVentas = new HashSet<CoSellerIdcanalesVentas>();
        }

        public int IdTipoCanalVenta { get; set; }
        public string CodigoTipoCanalVenta { get; set; }
        public string DescripcionTipoCanalVenta { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual ICollection<CoSellerIdcanalesVentas> CoSellerIdcanalesVentas { get; set; }
    }
}
