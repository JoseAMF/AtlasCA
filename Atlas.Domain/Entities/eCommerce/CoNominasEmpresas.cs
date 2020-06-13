using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoNominasEmpresas
    {
        public int IdNomina { get; set; }
        public int IdCliente { get; set; }
        public DateTime VigenciaDesde { get; set; }
        public DateTime? VigenciaHasta { get; set; }
        public int IdPersona { get; set; }
        public int IdProducto { get; set; }

        public virtual CoClientes IdClienteNavigation { get; set; }
        public virtual PePersonaFisica IdPersonaNavigation { get; set; }
        public virtual PrProducto IdProductoNavigation { get; set; }
    }
}
