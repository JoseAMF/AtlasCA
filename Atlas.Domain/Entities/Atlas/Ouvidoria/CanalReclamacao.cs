using Atlas.Domain.Common;

namespace Atlas.Domain.Entities.Atlas.Ouvidoria
{
    public class CanalReclamacao : AuditableEntity
    {
        public int Id { get; set; }
        public int IdCanalReclamacao { get; set; }
        public string Descricao { get; set; }
    }
}