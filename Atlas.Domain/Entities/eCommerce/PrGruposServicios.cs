using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrGruposServicios
    {
        public int IdGrupoServicio { get; set; }
        public string CodigoGrupoServicio { get; set; }
        public string DescripcionGrupoServicio { get; set; }
        public int? IdCompania { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
    }
}
