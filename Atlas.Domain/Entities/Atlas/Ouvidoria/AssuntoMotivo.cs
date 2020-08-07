using Atlas.Domain.Common;

namespace Atlas.Domain.Entities.Atlas.Ouvidoria
{
    public class AssuntoMotivo : AuditableEntity
    {
        public int AssuntoId { get; set; }
        public Assunto Assunto { get; set; }

        public int MotivoId { get; set; }
        public Motivo Motivo { get; set; }
    }
}