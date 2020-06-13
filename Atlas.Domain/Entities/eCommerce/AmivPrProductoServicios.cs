using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class AmivPrProductoServicios
    {
        public int Idproducto { get; set; }
        public string DenominacionProducto { get; set; }
        public int Idservicio { get; set; }
        public string Descripcionservicio { get; set; }
        public int? Nroorden { get; set; }
        public string Codigomoneda { get; set; }
        public string Tope { get; set; }
        public int? IdProductoServicioCompartido { get; set; }
    }
}
