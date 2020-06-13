using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class LpFormasPagoDocumentos
    {
        public int IdFormaPagoDocumento { get; set; }
        public string TipoFormaPagoDocumento { get; set; }
        public string DescripcionFormaPagoDocumentos { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
    }
}
