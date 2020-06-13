using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class MiCasosCursosBup
    {
        public int IdCasoCur { get; set; }
        public int? IdCaso { get; set; }
        public string Curso { get; set; }
        public DateTime? Fecha { get; set; }
        public string UsuarioActividad { get; set; }
        public DateTime? FecCreaReg { get; set; }
        public string FecHora { get; set; }
        public int? IdServicio { get; set; }
        public string Prestador { get; set; }
        public double? CostoEstimado { get; set; }

        public virtual MiCasosBup IdCasoNavigation { get; set; }
    }
}
