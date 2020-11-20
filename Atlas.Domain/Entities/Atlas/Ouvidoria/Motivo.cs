using Atlas.Domain.Common;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Atlas.Ouvidoria
{
    public class Motivo : AuditableEntity
    {
        public int Id { get; set; }
        public int IdMotivo { get; set; }
        public string Descricao { get; set; }
        public ICollection<AssuntoMotivo> AssuntoMotivos { get; set; }
    }
}