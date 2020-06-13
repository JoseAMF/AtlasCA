using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrProductoH
    {
        public int IdProducto { get; set; }
        public string CodigoProducto { get; set; }
        public string DenominacionProducto { get; set; }
        public int MinimoDias { get; set; }
        public int MaximoDias { get; set; }
        public int EdadMaxima { get; set; }
        public string Leyenda { get; set; }
        public int IdTipoCobertura { get; set; }
        public string Linkproducto { get; set; }
        public int IdMoneda { get; set; }
        public decimal CoberturaMaxima { get; set; }
        public string ProductoAgencias { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public int? IdTipoProducto { get; set; }
        public int? IdMarca { get; set; }
        public int? IdTipoViaje { get; set; }
        public string CondicionesGenerales { get; set; }
        public string MarcaProductoBase { get; set; }
        public string PdfCondicionesGenerales { get; set; }
        public string LeyendaValidez { get; set; }
        public string LeyendaTratadoEuropa { get; set; }
        public string LeyendaValidezIngles { get; set; }
        public string LeyendaTratadoEuropaIngles { get; set; }
        public string LeyendaIngles { get; set; }
        public int? Orden { get; set; }
        public bool? MuestraIngles { get; set; }
        public int? IdGrupoRangosEdad { get; set; }
    }
}
