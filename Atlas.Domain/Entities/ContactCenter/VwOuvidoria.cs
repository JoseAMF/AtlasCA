using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.ContactCenter
{
    public partial class VwOuvidoria
    {
        public string Entidade { get; set; }
        public int? IdentificacaoResponsavel { get; set; }
        public DateTime? DataAbertura { get; set; }
        public DateTime? DataEncerramento { get; set; }
        public decimal Protocolo { get; set; }
        public string Status { get; set; }
        public string IdentificacaoReclamante { get; set; }
        public string Tipo { get; set; }
    }
}
