using Atlas.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atlas.Domain.Entities.Enums 
{
        public enum PermissionEnum
    {
        Cotacao_User,
        Cotacao_Cotador,
        Cotacao_Admin,
        PREMIUM_User,
        PREMIUM_Moderator,
        PREMIUM_Admin,
        Cupom_Leitura,
        Cupom_Escrita,
        Cupom_Admin,
        CancelamentoBilhete_Leitura,
        CancelamentoBilhete_Escrita,
        CancelamentoBilhete_Admin,
        CadastroPessoa_Leitura,
        CadastroPessoa_Escrita,
        CadastroPessoa_Admin,
        Atlas_Admin,
        Produto_Leitura,
        Produto_Escrita,
        Produto_Admin,
        VendaLote_Admin,
        Comissao_Leitura,
        Comissao_Escrita,
        Comissao_Admin,
        Ouvidoria,
        COVID,
        LGPD,
        Pareport,
    }
}