using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class BsCiudades
    {
        public int IdCiudad { get; set; }
        public int IdPais { get; set; }
        public string Ciudad { get; set; }
        public string UrlMiniguia { get; set; }
    }
}
