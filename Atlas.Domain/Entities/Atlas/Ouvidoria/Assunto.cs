using Atlas.Domain.Common;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Atlas.Ouvidoria
{
    public class Assunto : AuditableEntity
    {
        public int IdAssunto { get; set; }
        public string Descricao { get; set; }
        public ICollection<AssuntoMotivo> AssuntoMotivos { get; set; }
    }
}