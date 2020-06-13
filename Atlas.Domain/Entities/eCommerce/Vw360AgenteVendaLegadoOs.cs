using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class Vw360AgenteVendaLegadoOs
    {
        public int IdContaAgenteVenda { get; set; }
        public string UsuarioAgenteVenda { get; set; }
        public string SenhaAgenteVenda { get; set; }
        public int CodigoAgenteVenda { get; set; }
        public string NomeAgenteVenda { get; set; }
        public string NrDocumento { get; set; }
        public string TpDocumento { get; set; }
    }
}
