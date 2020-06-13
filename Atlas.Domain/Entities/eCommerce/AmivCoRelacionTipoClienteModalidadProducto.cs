using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class AmivCoRelacionTipoClienteModalidadProducto
    {
        public int IdRelacion { get; set; }
        public int Idtipocliente { get; set; }
        public string Tipocliente { get; set; }
        public string Descripciontipocliente { get; set; }
        public int IdmodalidadProducto { get; set; }
        public string Codigomodalidad { get; set; }
        public string Descripcionmodalidad { get; set; }
    }
}
