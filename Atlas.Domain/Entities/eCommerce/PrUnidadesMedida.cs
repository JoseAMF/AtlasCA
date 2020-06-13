using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrUnidadesMedida
    {
        public PrUnidadesMedida()
        {
            PrProductoServicios = new HashSet<PrProductoServicios>();
        }

        public int IdUnidadMedida { get; set; }
        public string CodigoUnidad { get; set; }
        public string DescripcionUnidad { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public string DescripcionUnidadIngles { get; set; }

        public virtual ICollection<PrProductoServicios> PrProductoServicios { get; set; }
    }
}
