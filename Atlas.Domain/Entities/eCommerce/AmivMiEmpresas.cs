using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class AmivMiEmpresas
    {
        public int Idempresa { get; set; }
        public int? Idpersonajuridica { get; set; }
        public string Codigoempresa { get; set; }
        public string Cuit { get; set; }
        public string Razonsocial { get; set; }
        public int Idresponsableiva { get; set; }
    }
}
