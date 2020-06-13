using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class BsMensajes
    {
        public int IdMensaje { get; set; }
        public int CodigoMensaje { get; set; }
        public string Idioma { get; set; }
        public string Mensaje { get; set; }
    }
}
