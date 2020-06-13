using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class WsTokens
    {
        public string CodigoCompania { get; set; }
        public string Pais { get; set; }
        public int Idcompania { get; set; }
        public string Token { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int EsValido { get; set; }
    }
}
