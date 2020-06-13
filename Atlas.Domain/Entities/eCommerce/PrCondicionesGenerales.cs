using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrCondicionesGenerales
    {
        public int IdCondicionesGenerales { get; set; }
        public string Titulo { get; set; }
        public string CondicionesGenerales { get; set; }
        public string CreadoPor { get; set; }
        public DateTime? FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public DateTime? FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
    }
}
