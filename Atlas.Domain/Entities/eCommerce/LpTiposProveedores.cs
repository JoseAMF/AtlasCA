using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class LpTiposProveedores
    {
        public int IdTipoProveedor { get; set; }
        public string CodigoTipoProveedor { get; set; }
        public string DescripcionTipoProveedor { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
    }
}
