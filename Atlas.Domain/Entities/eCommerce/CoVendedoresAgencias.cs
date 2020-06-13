using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoVendedoresAgencias
    {
        public CoVendedoresAgencias()
        {
            CoVentaPacksOnline = new HashSet<CoVentaPacksOnline>();
            CoVentas = new HashSet<CoVentas>();
            PoPolizas = new HashSet<PoPolizas>();
        }

        public int IdVendedor { get; set; }
        public int IdAgencia { get; set; }
        public int IdPersonaFisica { get; set; }
        public string Legajo { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int IdUser { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public string Supervisor { get; set; }
        public string Email { get; set; }
        public string NombreFantasia { get; set; }
        public string Filial { get; set; }
        public string HashVendedor { get; set; }

        public virtual CoAgencias IdAgenciaNavigation { get; set; }
        public virtual PePersonaFisica IdPersonaFisicaNavigation { get; set; }
         public virtual ICollection<CoVentaPacksOnline> CoVentaPacksOnline { get; set; }
        public virtual ICollection<CoVentas> CoVentas { get; set; }
        public virtual ICollection<PoPolizas> PoPolizas { get; set; }
    }
}
