using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class BsProvincias
    {
        public BsProvincias()
        {
            CoCotizacionesIndividuosLog = new HashSet<CoCotizacionesIndividuosLog>();
            PeDomicilios = new HashSet<PeDomicilios>();
        }

        public int IdProvincia { get; set; }
        public int IdPais { get; set; }
        public string DescripcionProvincia { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public string CodigoProvincia { get; set; }

        public virtual BsPaises IdPaisNavigation { get; set; }
        public virtual ICollection<CoCotizacionesIndividuosLog> CoCotizacionesIndividuosLog { get; set; }
        public virtual ICollection<PeDomicilios> PeDomicilios { get; set; }
    }
}
