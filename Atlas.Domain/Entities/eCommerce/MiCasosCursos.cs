using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class MiCasosCursos
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
        public double? ImporteAutorizado { get; set; }
        public int? IdEstadoCurso { get; set; }
        public int? NroCurso { get; set; }
        public int? IdMonedaServicio { get; set; }
        public double? ImporteDisponible { get; set; }
        public int? IdMonedaAutorizacion { get; set; }
        public int? IdPrestador { get; set; }
        public double? CostoEstimado { get; set; }
    }
}
