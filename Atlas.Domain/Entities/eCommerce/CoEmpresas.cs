using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoEmpresas
    {
        public CoEmpresas()
        {
            CoClientes = new HashSet<CoClientes>();
        }

        public int IdEmpresa { get; set; }
        public int IdPersonaJuridica { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public int? UserId { get; set; }
        public int? IdSupervisor { get; set; }
        public int? IdCompania { get; set; }
        public int? IdGrupoAfinidad { get; set; }

        public virtual PePersonaJuridica IdPersonaJuridicaNavigation { get; set; }
        public virtual ICollection<CoClientes> CoClientes { get; set; }
    }
}
