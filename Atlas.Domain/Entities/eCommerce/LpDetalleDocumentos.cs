using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class LpDetalleDocumentos
    {
        public int IdDetalleDocumento { get; set; }
        public int IdDocumentoPago { get; set; }
        public DateTime FechaServicio { get; set; }
        public int IdServicio { get; set; }
        public double ImporteServicio { get; set; }
        public double ImporteAutorizado { get; set; }
        public double ImportePagarServicio { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual LpDocumentosPago IdDocumentoPagoNavigation { get; set; }
    }
}
