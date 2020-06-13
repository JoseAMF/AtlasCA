using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class MiCorresponsales
    {
        public MiCorresponsales()
        {
            LpDocumentosPago = new HashSet<LpDocumentosPago>();
            MiPaisesAtencionCorresponsales = new HashSet<MiPaisesAtencionCorresponsales>();
        }

        public int IdCorresponsal { get; set; }
        public int? IdPersonaJuridica { get; set; }
        public int? Opcion { get; set; }
        public string Observacion { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual ICollection<LpDocumentosPago> LpDocumentosPago { get; set; }
        public virtual ICollection<MiPaisesAtencionCorresponsales> MiPaisesAtencionCorresponsales { get; set; }
    }
}
