using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class Vw360AgenteVendaLegadoOsCarga
    {
        public int NrCodigoAgenteVenda { get; set; }
        public string DsNomeAgenteVenda { get; set; }
        public string NrDocumento { get; set; }
        public string TpDocumento { get; set; }
        public string DsNomeContatoAgenteVenda { get; set; }
        public string DsEmailContatoAgenteVenda { get; set; }
        public string TpLinhaProduto { get; set; }
        public int IdContaPortalLegado { get; set; }
        public string DsContaUsuarioLegado { get; set; }
        public string DsSenhaUsuarioLegado { get; set; }
        public DateTime DhInclusaoOperacao { get; set; }
        public string NmAlteracaoLogin { get; set; }
        public DateTime DhAlteracaoData { get; set; }
    }
}
