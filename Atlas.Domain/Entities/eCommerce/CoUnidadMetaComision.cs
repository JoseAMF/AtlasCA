using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoUnidadMetaComision
    {
        public int IdUnidadMetaComision { get; set; }
        public string CodigoUnidadMetaComision { get; set; }
        public string DescripcionUnidadMetaComision { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
    }
}
