using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class AmivBsCompanias
    {
        public int Idcompania { get; set; }
        public int? Idpersonajuridica { get; set; }
        public string Razonsocial { get; set; }
        public string Cuit { get; set; }
        public string Requierecondicionaceptacion { get; set; }
    }
}
