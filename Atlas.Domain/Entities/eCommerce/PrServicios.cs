using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrServicios
    {
        public PrServicios()
        {
            PrProductoServicios = new HashSet<PrProductoServicios>();
        }

        public int IdServicio { get; set; }
        public string DescripcionServicio { get; set; }
        public string TipoServicio { get; set; }
        public string MarcaAtencion { get; set; }
        public int? NroOrden { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public string CargaPreviaCobertura { get; set; }
        public int? IdZonaImpresionIngles { get; set; }
        public int? IdProveedorServicio { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int? IdCompania { get; set; }
        public string DescripcionServicioIngles { get; set; }
        public int? IdGrupoServicio { get; set; }
        public int? IdZonaImpresion { get; set; }
        public int? IdTipoInicioCobertura { get; set; }
        public int? NroOrdenPdf { get; set; }

        public virtual ICollection<PrProductoServicios> PrProductoServicios { get; set; }
    }
}
