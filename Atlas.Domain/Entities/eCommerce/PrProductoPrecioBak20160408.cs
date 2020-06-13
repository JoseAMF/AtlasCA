using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrProductoPrecioBak20160408
    {
        public int IdProductoPrecio { get; set; }
        public int IdProducto { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public int? Dias { get; set; }
        public int? EdadDesde { get; set; }
        public int? EdadHasta { get; set; }
        public int IdMoneda { get; set; }
        public double Importe { get; set; }
        public double? PorcentajeAdicional { get; set; }
        public int? IdProductoAdicional { get; set; }
        public string CreadoPor { get; set; }
        public DateTime? FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public int? IdGrupoAfinidad { get; set; }
        public int? IdAgencia { get; set; }
        public int? IdModalidadProducto { get; set; }
        public int? CapitasDesde { get; set; }
        public int? CapitasHasta { get; set; }
    }
}
