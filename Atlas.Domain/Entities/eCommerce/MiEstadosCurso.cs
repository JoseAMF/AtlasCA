using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class MiEstadosCurso
    {
        public int IdEstadoCurso { get; set; }
        public string CodigoEstadoCurso { get; set; }
        public string DescripcionEstadoCurso { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
    }
}
