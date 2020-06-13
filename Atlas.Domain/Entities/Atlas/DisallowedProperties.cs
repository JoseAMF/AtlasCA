using Atlas.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atlas.Domain.Entities.Atlas
{
    public class DisallowedColumnsForUpdate : AuditableEntity
    {
        public int Id { get; set; }
        public string Coluna { get; set; }
        public Tabelas TabelaId { get; set; }
        public virtual Table Tabela { get; set; }

    }
}