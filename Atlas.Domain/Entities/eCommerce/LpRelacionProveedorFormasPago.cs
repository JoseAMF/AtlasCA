using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class LpRelacionProveedorFormasPago
    {
        public int IdRelacionProveedorFormaPago { get; set; }
        public int IdTipoProveedor { get; set; }
        public int IdFormaPagoDocumento { get; set; }
    }
}
