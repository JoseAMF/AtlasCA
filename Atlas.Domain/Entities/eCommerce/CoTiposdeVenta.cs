using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoTiposdeVenta
    {
        public CoTiposdeVenta()
        {
            CoTiposCliente = new HashSet<CoTiposCliente>();
        }

        public int IdTipodeVenta { get; set; }
        public string TipoVenta { get; set; }
        public string DescripcionTipoVenta { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public string CodigoTipoClienteFacturador { get; set; }

        public virtual ICollection<CoTiposCliente> CoTiposCliente { get; set; }
    }
}
