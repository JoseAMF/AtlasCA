using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class AmivMiCorresponsales
    {
        public int Idcorresponsal { get; set; }
        public int? Idpersonajuridica { get; set; }
        public string Razonsocial { get; set; }
        public int Idpais { get; set; }
        public string Denominacionpais { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public int? Opcion { get; set; }
        public string Observacion { get; set; }
    }
}
