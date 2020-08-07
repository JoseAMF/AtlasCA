using Atlas.Domain.Entities.Premium;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Common.Interfaces
{
    public interface IPremiumDbContext
    {
        DbSet<BkpTbAgencia> BkpTbAgencia { get; set; }
        DbSet<BkpTbBeneficiario> BkpTbBeneficiario { get; set; }
        DbSet<BkpTbCobertura> BkpTbCobertura { get; set; }
        DbSet<BkpTbProduto> BkpTbProduto { get; set; }
        DbSet<BkpTbVoucher> BkpTbVoucher { get; set; }
        DbSet<BkpTbVoucherExterno> BkpTbVoucherExterno { get; set; }
        DbSet<CanaisVendas> CanaisVendas { get; set; }
        DbSet<CanaisVendasCorretores> CanaisVendasCorretores { get; set; }
        DbSet<CanaisVendasOrigem> CanaisVendasOrigem { get; set; }
        DbSet<CancelamentoControle> CancelamentoControle { get; set; }
        DbSet<CrmControle> CrmControle { get; set; }
        DbSet<I4proControle> I4proControle { get; set; }
        DbSet<PrProductoPrecio> PrProductoPrecio { get; set; }
        DbSet<Produtos> Produtos { get; set; }
        DbSet<ProdutosCanaisVendas> ProdutosCanaisVendas { get; set; }
        DbSet<TbAgencia> TbAgencia { get; set; }
        DbSet<TbAgencia2> TbAgencia2 { get; set; }
        DbSet<TbAgenciaContato> TbAgenciaContato { get; set; }
        DbSet<TbAgenciaCorretorPremium> TbAgenciaCorretorPremium { get; set; }
        DbSet<TbAgenciaPremiumCarga> TbAgenciaPremiumCarga { get; set; }
        DbSet<TbAgendamentoRetorno> TbAgendamentoRetorno { get; set; }
        DbSet<TbAlertaVoucher> TbAlertaVoucher { get; set; }
        DbSet<TbArquivoFisico> TbArquivoFisico { get; set; }
        DbSet<TbArqvCargProd> TbArqvCargProd { get; set; }
        DbSet<TbAutorizacaoComplemento> TbAutorizacaoComplemento { get; set; }
        DbSet<TbAuxiliarCargaMovimento> TbAuxiliarCargaMovimento { get; set; }
        DbSet<TbAuxiliarCargaMovimentoBkp210516> TbAuxiliarCargaMovimentoBkp210516 { get; set; }
        DbSet<TbBeneficiario> TbBeneficiario { get; set; }
        DbSet<TbBilheteSeguradoConfirmaEmail> TbBilheteSeguradoConfirmaEmail { get; set; }
        DbSet<TbCanalVendaProduto> TbCanalVendaProduto { get; set; }
        DbSet<TbCancelamentoSegurado> TbCancelamentoSegurado { get; set; }
        DbSet<TbCancelamentoSeguradoBkp> TbCancelamentoSeguradoBkp { get; set; }
        DbSet<TbCaso> TbCaso { get; set; }
        DbSet<TbCasoCheckList> TbCasoCheckList { get; set; }
        DbSet<TbCasoComunicacao> TbCasoComunicacao { get; set; }
        DbSet<TbCasoDocumento> TbCasoDocumento { get; set; }
        DbSet<TbCasoLimite> TbCasoLimite { get; set; }
        DbSet<TbCasoLimiteD> TbCasoLimiteD { get; set; }
        DbSet<TbCasoMedico> TbCasoMedico { get; set; }
        DbSet<TbCasoViagem> TbCasoViagem { get; set; }
        DbSet<TbCheckList> TbCheckList { get; set; }
        DbSet<TbCheckListCobertura> TbCheckListCobertura { get; set; }
        DbSet<TbCobertura> TbCobertura { get; set; }
        DbSet<TbCoberturaLimite> TbCoberturaLimite { get; set; }
        DbSet<TbCoberturaPrestador> TbCoberturaPrestador { get; set; }
        DbSet<TbConferePropostaCorretor> TbConferePropostaCorretor { get; set; }
        DbSet<TbContato> TbContato { get; set; }
        DbSet<TbControleCarga> TbControleCarga { get; set; }
        DbSet<TbErroCarga> TbErroCarga { get; set; }
        DbSet<TbEventoComunicacao> TbEventoComunicacao { get; set; }
        DbSet<TbEventoComunicaoCobertura> TbEventoComunicaoCobertura { get; set; }
        DbSet<TbGruposPaises> TbGruposPaises { get; set; }
        DbSet<TbIdioma> TbIdioma { get; set; }
        DbSet<TbLiquidacao> TbLiquidacao { get; set; }
        DbSet<TbLiquidacaoNegada> TbLiquidacaoNegada { get; set; }
        DbSet<TbMembro> TbMembro { get; set; }
        DbSet<TbMunicipio> TbMunicipio { get; set; }
        DbSet<TbOrdemPagamento> TbOrdemPagamento { get; set; }
        DbSet<TbPais> TbPais { get; set; }
        DbSet<TbPapelComissao> TbPapelComissao { get; set; }
        DbSet<TbParentescoPpe> TbParentescoPpe { get; set; }
        DbSet<TbPessoaCorretor> TbPessoaCorretor { get; set; }
        DbSet<TbPessoaPoliticaExposta> TbPessoaPoliticaExposta { get; set; }
        DbSet<TbPremiumTipoContaReceber> TbPremiumTipoContaReceber { get; set; }
        DbSet<TbPrestador> TbPrestador { get; set; }
        DbSet<TbProduto> TbProduto { get; set; }
        DbSet<TbProduto1> TbProduto1 { get; set; }
        DbSet<TbProdutoGruposPaises> TbProdutoGruposPaises { get; set; }
        DbSet<TbProdutoMovimento> TbProdutoMovimento { get; set; }
        DbSet<TbProdutoPremium> TbProdutoPremium { get; set; }
        DbSet<TbProposta> TbProposta { get; set; }
        DbSet<TbPropostaBeneficiario> TbPropostaBeneficiario { get; set; }
        DbSet<TbPropostaCorretor> TbPropostaCorretor { get; set; }
        DbSet<TbPropostaDeclaracaoSaude> TbPropostaDeclaracaoSaude { get; set; }
        DbSet<TbPropostaRecusadaSegurado> TbPropostaRecusadaSegurado { get; set; }
        DbSet<TbPropostaSegurado> TbPropostaSegurado { get; set; }
        DbSet<TbRecebimentoSegurado> TbRecebimentoSegurado { get; set; }
        DbSet<TbServicoCargaPreco> TbServicoCargaPreco { get; set; }
        DbSet<TbStatusLiquidacao> TbStatusLiquidacao { get; set; }
        DbSet<TbTipoAbrangencia> TbTipoAbrangencia { get; set; }
        DbSet<TbTipoAssistencia> TbTipoAssistencia { get; set; }
        DbSet<TbTipoContatoComunicacao> TbTipoContatoComunicacao { get; set; }
        DbSet<TbTipoDemanda> TbTipoDemanda { get; set; }
        DbSet<TbTipoDocumento> TbTipoDocumento { get; set; }
        DbSet<TbTipoDocumentoCaso> TbTipoDocumentoCaso { get; set; }
        DbSet<TbTipoEventoComunicacao> TbTipoEventoComunicacao { get; set; }
        DbSet<TbTipoLimite> TbTipoLimite { get; set; }
        DbSet<TbTipoMoeda> TbTipoMoeda { get; set; }
        DbSet<TbTipoServico> TbTipoServico { get; set; }
        DbSet<TbTpAlerta> TbTpAlerta { get; set; }
        DbSet<TbTpContato> TbTpContato { get; set; }
        DbSet<TbTpServicoCobertura> TbTpServicoCobertura { get; set; }
        DbSet<TbUf> TbUf { get; set; }
        DbSet<TbValorMoeda> TbValorMoeda { get; set; }
        DbSet<TbVoucher> TbVoucher { get; set; }
        DbSet<TbVoucherErro> TbVoucherErro { get; set; }
        DbSet<TbVoucherExterno> TbVoucherExterno { get; set; }
        DbSet<Teste1> Teste1 { get; set; }
        DbSet<Teste2> Teste2 { get; set; }
        DbSet<VwApoliceCrm> VwApoliceCrm { get; set; }
        DbSet<VwBilhetesEmitidos> VwBilhetesEmitidos { get; set; }
        DbSet<VwCasos> VwCasos { get; set; }
        DbSet<VwPrecificacaoPorCasos> VwPrecificacaoPorCasos { get; set; }
        DbSet<VwPropostaApolice> VwPropostaApolice { get; set; }
        DbSet<VwPropostaApoliceTeste> VwPropostaApoliceTeste { get; set; }
        DbSet<VwValorMoeda> VwValorMoeda { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
