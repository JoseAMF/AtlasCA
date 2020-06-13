using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrMarcasProductos
    {
        public PrMarcasProductos()
        {
            CoPatrocinadorMarca = new HashSet<CoPatrocinadorMarca>();
            PrProducto = new HashSet<PrProducto>();
        }

        public int IdMarca { get; set; }
        public string CodigoMarca { get; set; }
        public string DescripcionMarca { get; set; }
        public int IdLineaProducto { get; set; }
        public string FileLogo { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModPor { get; set; }

        public virtual PrLineaProducto IdLineaProductoNavigation { get; set; }
        public virtual ICollection<CoPatrocinadorMarca> CoPatrocinadorMarca { get; set; }
        public virtual ICollection<PrProducto> PrProducto { get; set; }
    }
}
