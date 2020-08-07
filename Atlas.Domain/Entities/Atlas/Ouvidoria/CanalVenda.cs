using Atlas.Domain.Common;

namespace Atlas.Domain.Entities.Atlas.Ouvidoria
{
    public class CanalVenda : AuditableEntity
    {
        public int IdCanalVenda { get; set; }
        public string Descricao { get; set; }
    }
}