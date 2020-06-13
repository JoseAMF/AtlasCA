using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrProductoServicios
    {
        public int IdProductoServicio { get; set; }
        public int IdProducto { get; set; }
        public int IdServicio { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public int? IdUnidadmedida { get; set; }
        public int? IdMoneda { get; set; }
        public double? Tope { get; set; }
        public int? IdProductoServicioCompartido { get; set; }
        public string Detalle { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public decimal? ImporteSugerido { get; set; }
        public DateTime? FecBaja { get; set; }
        public string DetalleIngles { get; set; }
        public int? CaracteristicaPrincipal { get; set; }

        public virtual PrProducto IdProductoNavigation { get; set; }
        public virtual PrServicios IdServicioNavigation { get; set; }
        public virtual PrUnidadesMedida IdUnidadmedidaNavigation { get; set; }
    }
}
