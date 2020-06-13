using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoCanalDistribucion
    {
        public CoCanalDistribucion()
        {
            CoAgenciaCanalDistribucion = new HashSet<CoAgenciaCanalDistribucion>();
            CoSellerIdcanalesVentas = new HashSet<CoSellerIdcanalesVentas>();
        }

        public int IdCanalDistribucion { get; set; }
        public string CodigoCanalDistribucion { get; set; }
        public string DescripcionCanalDistribucion { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual ICollection<CoAgenciaCanalDistribucion> CoAgenciaCanalDistribucion { get; set; }
        public virtual ICollection<CoSellerIdcanalesVentas> CoSellerIdcanalesVentas { get; set; }
    }
}
