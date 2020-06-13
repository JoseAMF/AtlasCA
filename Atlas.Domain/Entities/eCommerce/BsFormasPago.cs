using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class BsFormasPago
    {
        public int IdFormaPagoBs { get; set; }
        public string CodigoFormaPagoBs { get; set; }
        public string DescripcionFormaPagoBs { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModPor { get; set; }
    }
}
