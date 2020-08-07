using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class I4proControle
    {
        public int Id { get; set; }
        public string NrVoucher { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public string DhUsuario { get; set; }
    }
}
