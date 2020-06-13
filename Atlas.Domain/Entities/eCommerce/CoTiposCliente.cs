using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoTiposCliente
    {
        public CoTiposCliente()
        {
            CoClientes = new HashSet<CoClientes>();
            CoRelacionTipoClienteModalidadProducto = new HashSet<CoRelacionTipoClienteModalidadProducto>();
            PeFormasPagoTipoCliente = new HashSet<PeFormasPagoTipoCliente>();
        }

        public int IdTipoCliente { get; set; }
        public string TipoCliente { get; set; }
        public string DescripcionTipoCliente { get; set; }
        public int IdTipoVenta { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual CoTiposdeVenta IdTipoVentaNavigation { get; set; }
        public virtual ICollection<CoClientes> CoClientes { get; set; }
        public virtual ICollection<CoRelacionTipoClienteModalidadProducto> CoRelacionTipoClienteModalidadProducto { get; set; }
        public virtual ICollection<PeFormasPagoTipoCliente> PeFormasPagoTipoCliente { get; set; }
    }
}
