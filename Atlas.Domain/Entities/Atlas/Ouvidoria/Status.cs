using Atlas.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atlas.Domain.Entities.Atlas.Ouvidoria
{
    public class Status : AuditableEntity
    {
        public int Id { get; set; }
        public int IdStatus { get; set; }
        public string Descricao { get; set; }
    }
}