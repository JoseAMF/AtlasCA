using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class CrmControle
    {
        public int Id { get; set; }
        public string NrBilhete { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public string DhUsuario { get; set; }
    }
}
