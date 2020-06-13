using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class BsRolesPorGrupo
    {
        public int IdRolGrupo { get; set; }
        public int? IdCompania { get; set; }
        public string TipoUsuario { get; set; }
        public string Parametro { get; set; }
        public int? RoleId { get; set; }
    }
}
