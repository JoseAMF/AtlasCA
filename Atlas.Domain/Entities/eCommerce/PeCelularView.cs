using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PeCelularView
    {
        public int IdCanalesPersona { get; set; }
        public int IdPersona { get; set; }
        public int IdTipoCanal { get; set; }
        public string DetalleCanal { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
    }
}
