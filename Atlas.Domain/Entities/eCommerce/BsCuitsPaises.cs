using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class BsCuitsPaises
    {
        public int IdCuitPais { get; set; }
        public int IdPais { get; set; }
        public int IdTipoPersona { get; set; }
        public string Cuit { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
    }
}
