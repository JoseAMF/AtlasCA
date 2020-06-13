using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoCanalComercial
    {
        public CoCanalComercial()
        {
            CoSellerIdcanalesVentas = new HashSet<CoSellerIdcanalesVentas>();
        }

        public int IdCanalComercial { get; set; }
        public string CodigoCanalComercial { get; set; }
        public string DescripcionCanalComercial { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual ICollection<CoSellerIdcanalesVentas> CoSellerIdcanalesVentas { get; set; }
    }
}
