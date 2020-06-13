using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoTipoComision
    {
        public int IdTipoComisionAgencia { get; set; }
        public string CodigoTipoComisionAgencia { get; set; }
        public string DescripcionTipoComisionAgencia { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
    }
}
