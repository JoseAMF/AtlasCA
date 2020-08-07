using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class CancelamentoControle
    {
        public int Id { get; set; }
        public string NrBilhete { get; set; }
        public DateTime? DataCancelamento { get; set; }
        public string DhUsuario { get; set; }
    }
}
