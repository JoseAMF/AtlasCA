using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoAgenciasEjecutivoResponsable
    {
        public int IdAgenciaEjecutivo { get; set; }
        public int? IdAgencia { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string CreadoPor { get; set; }
        public DateTime? FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual CoAgencias IdAgenciaNavigation { get; set; }
    }
}
