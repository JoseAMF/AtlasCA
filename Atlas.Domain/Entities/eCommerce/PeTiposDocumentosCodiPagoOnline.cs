using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PeTiposDocumentosCodiPagoOnline
    {
        public int IdTipoDocumentoCodiPago { get; set; }
        public int? IdTipoDocumento { get; set; }
        public int? IdCodiDocumentoPagoOnline { get; set; }
        public string Descrip { get; set; }
    }
}
