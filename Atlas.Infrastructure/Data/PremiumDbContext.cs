using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.Premium;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Infrastructure.Data
{
    public partial class PremiumDbContext : DbContext, IPremiumDbContext
    {
        public PremiumDbContext()
        {
        }

        public PremiumDbContext(DbContextOptions<PremiumDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BkpTbAgencia> BkpTbAgencia { get; set; }
        public virtual DbSet<BkpTbBeneficiario> BkpTbBeneficiario { get; set; }
        public virtual DbSet<BkpTbCobertura> BkpTbCobertura { get; set; }
        public virtual DbSet<BkpTbProduto> BkpTbProduto { get; set; }
        public virtual DbSet<BkpTbVoucher> BkpTbVoucher { get; set; }
        public virtual DbSet<BkpTbVoucherExterno> BkpTbVoucherExterno { get; set; }
        public virtual DbSet<CanaisVendas> CanaisVendas { get; set; }
        public virtual DbSet<CanaisVendasCorretores> CanaisVendasCorretores { get; set; }
        public virtual DbSet<CanaisVendasOrigem> CanaisVendasOrigem { get; set; }
        public virtual DbSet<CancelamentoControle> CancelamentoControle { get; set; }
        public virtual DbSet<CrmControle> CrmControle { get; set; }
        public virtual DbSet<I4proControle> I4proControle { get; set; }
        public virtual DbSet<PrProductoPrecio> PrProductoPrecio { get; set; }
        public virtual DbSet<Produtos> Produtos { get; set; }
        public virtual DbSet<ProdutosCanaisVendas> ProdutosCanaisVendas { get; set; }
        public virtual DbSet<TbAgencia> TbAgencia { get; set; }
        public virtual DbSet<TbAgencia2> TbAgencia2 { get; set; }
        public virtual DbSet<TbAgenciaContato> TbAgenciaContato { get; set; }
        public virtual DbSet<TbAgenciaCorretorPremium> TbAgenciaCorretorPremium { get; set; }
        public virtual DbSet<TbAgenciaPremiumCarga> TbAgenciaPremiumCarga { get; set; }
        public virtual DbSet<TbAgendamentoRetorno> TbAgendamentoRetorno { get; set; }
        public virtual DbSet<TbAlertaVoucher> TbAlertaVoucher { get; set; }
        public virtual DbSet<TbArquivoFisico> TbArquivoFisico { get; set; }
        public virtual DbSet<TbArqvCargProd> TbArqvCargProd { get; set; }
        public virtual DbSet<TbAutorizacaoComplemento> TbAutorizacaoComplemento { get; set; }
        public virtual DbSet<TbAuxiliarCargaMovimento> TbAuxiliarCargaMovimento { get; set; }
        public virtual DbSet<TbAuxiliarCargaMovimentoBkp210516> TbAuxiliarCargaMovimentoBkp210516 { get; set; }
        public virtual DbSet<TbBeneficiario> TbBeneficiario { get; set; }
        public virtual DbSet<TbBilheteSeguradoConfirmaEmail> TbBilheteSeguradoConfirmaEmail { get; set; }
        public virtual DbSet<TbCanalVendaProduto> TbCanalVendaProduto { get; set; }
        public virtual DbSet<TbCancelamentoSegurado> TbCancelamentoSegurado { get; set; }
        public virtual DbSet<TbCancelamentoSeguradoBkp> TbCancelamentoSeguradoBkp { get; set; }
        public virtual DbSet<TbCaso> TbCaso { get; set; }
        public virtual DbSet<TbCasoCheckList> TbCasoCheckList { get; set; }
        public virtual DbSet<TbCasoComunicacao> TbCasoComunicacao { get; set; }
        public virtual DbSet<TbCasoDocumento> TbCasoDocumento { get; set; }
        public virtual DbSet<TbCasoLimite> TbCasoLimite { get; set; }
        public virtual DbSet<TbCasoLimiteD> TbCasoLimiteD { get; set; }
        public virtual DbSet<TbCasoMedico> TbCasoMedico { get; set; }
        public virtual DbSet<TbCasoViagem> TbCasoViagem { get; set; }
        public virtual DbSet<TbCheckList> TbCheckList { get; set; }
        public virtual DbSet<TbCheckListCobertura> TbCheckListCobertura { get; set; }
        public virtual DbSet<TbCobertura> TbCobertura { get; set; }
        public virtual DbSet<TbCoberturaLimite> TbCoberturaLimite { get; set; }
        public virtual DbSet<TbCoberturaPrestador> TbCoberturaPrestador { get; set; }
        public virtual DbSet<TbConferePropostaCorretor> TbConferePropostaCorretor { get; set; }
        public virtual DbSet<TbContato> TbContato { get; set; }
        public virtual DbSet<TbControleCarga> TbControleCarga { get; set; }
        public virtual DbSet<TbErroCarga> TbErroCarga { get; set; }
        public virtual DbSet<TbEventoComunicacao> TbEventoComunicacao { get; set; }
        public virtual DbSet<TbEventoComunicaoCobertura> TbEventoComunicaoCobertura { get; set; }
        public virtual DbSet<TbGruposPaises> TbGruposPaises { get; set; }
        public virtual DbSet<TbIdioma> TbIdioma { get; set; }
        public virtual DbSet<TbLiquidacao> TbLiquidacao { get; set; }
        public virtual DbSet<TbLiquidacaoNegada> TbLiquidacaoNegada { get; set; }
        public virtual DbSet<TbMembro> TbMembro { get; set; }
        public virtual DbSet<TbMunicipio> TbMunicipio { get; set; }
        public virtual DbSet<TbOrdemPagamento> TbOrdemPagamento { get; set; }
        public virtual DbSet<TbPais> TbPais { get; set; }
        public virtual DbSet<TbPapelComissao> TbPapelComissao { get; set; }
        public virtual DbSet<TbParentescoPpe> TbParentescoPpe { get; set; }
        public virtual DbSet<TbPessoaCorretor> TbPessoaCorretor { get; set; }
        public virtual DbSet<TbPessoaPoliticaExposta> TbPessoaPoliticaExposta { get; set; }
        public virtual DbSet<TbPremiumTipoContaReceber> TbPremiumTipoContaReceber { get; set; }
        public virtual DbSet<TbPrestador> TbPrestador { get; set; }
        public virtual DbSet<TbProduto> TbProduto { get; set; }
        public virtual DbSet<TbProduto1> TbProduto1 { get; set; }
        public virtual DbSet<TbProdutoGruposPaises> TbProdutoGruposPaises { get; set; }
        public virtual DbSet<TbProdutoMovimento> TbProdutoMovimento { get; set; }
        public virtual DbSet<TbProdutoPremium> TbProdutoPremium { get; set; }
        public virtual DbSet<TbProposta> TbProposta { get; set; }
        public virtual DbSet<TbPropostaBeneficiario> TbPropostaBeneficiario { get; set; }
        public virtual DbSet<TbPropostaCorretor> TbPropostaCorretor { get; set; }
        public virtual DbSet<TbPropostaDeclaracaoSaude> TbPropostaDeclaracaoSaude { get; set; }
        public virtual DbSet<TbPropostaRecusadaSegurado> TbPropostaRecusadaSegurado { get; set; }
        public virtual DbSet<TbPropostaSegurado> TbPropostaSegurado { get; set; }
        public virtual DbSet<TbRecebimentoSegurado> TbRecebimentoSegurado { get; set; }
        public virtual DbSet<TbServicoCargaPreco> TbServicoCargaPreco { get; set; }
        public virtual DbSet<TbStatusLiquidacao> TbStatusLiquidacao { get; set; }
        public virtual DbSet<TbTipoAbrangencia> TbTipoAbrangencia { get; set; }
        public virtual DbSet<TbTipoAssistencia> TbTipoAssistencia { get; set; }
        public virtual DbSet<TbTipoContatoComunicacao> TbTipoContatoComunicacao { get; set; }
        public virtual DbSet<TbTipoDemanda> TbTipoDemanda { get; set; }
        public virtual DbSet<TbTipoDocumento> TbTipoDocumento { get; set; }
        public virtual DbSet<TbTipoDocumentoCaso> TbTipoDocumentoCaso { get; set; }
        public virtual DbSet<TbTipoEventoComunicacao> TbTipoEventoComunicacao { get; set; }
        public virtual DbSet<TbTipoLimite> TbTipoLimite { get; set; }
        public virtual DbSet<TbTipoMoeda> TbTipoMoeda { get; set; }
        public virtual DbSet<TbTipoServico> TbTipoServico { get; set; }
        public virtual DbSet<TbTpAlerta> TbTpAlerta { get; set; }
        public virtual DbSet<TbTpContato> TbTpContato { get; set; }
        public virtual DbSet<TbTpServicoCobertura> TbTpServicoCobertura { get; set; }
        public virtual DbSet<TbUf> TbUf { get; set; }
        public virtual DbSet<TbValorMoeda> TbValorMoeda { get; set; }
        public virtual DbSet<TbVoucher> TbVoucher { get; set; }
        public virtual DbSet<TbVoucherErro> TbVoucherErro { get; set; }
        public virtual DbSet<TbVoucherExterno> TbVoucherExterno { get; set; }
        public virtual DbSet<Teste1> Teste1 { get; set; }
        public virtual DbSet<Teste2> Teste2 { get; set; }
        public virtual DbSet<VwApoliceCrm> VwApoliceCrm { get; set; }
        public virtual DbSet<VwBilhetesEmitidos> VwBilhetesEmitidos { get; set; }
        public virtual DbSet<VwCasos> VwCasos { get; set; }
        public virtual DbSet<VwPrecificacaoPorCasos> VwPrecificacaoPorCasos { get; set; }
        public virtual DbSet<VwPropostaApolice> VwPropostaApolice { get; set; }
        public virtual DbSet<VwPropostaApoliceTeste> VwPropostaApoliceTeste { get; set; }
        public virtual DbSet<VwValorMoeda> VwValorMoeda { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BkpTbAgencia>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bkp_tb_Agencia");

                entity.Property(e => e.AtAtivo)
                    .IsRequired()
                    .HasColumnName("at_Ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsAgencia)
                    .HasColumnName("ds_Agencia")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdAgencia)
                    .HasColumnName("id_Agencia")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<BkpTbBeneficiario>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bkp_tb_Beneficiario");

                entity.Property(e => e.CdIdioma)
                    .HasColumnName("cd_Idioma")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CdLinhaProduto)
                    .HasColumnName("cd_LinhaProduto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CdPais)
                    .HasColumnName("cd_Pais")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CdSexo)
                    .HasColumnName("cd_Sexo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_Inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsNome)
                    .IsRequired()
                    .HasColumnName("ds_Nome")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsSobrenome)
                    .HasColumnName("ds_Sobrenome")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaInclusao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaInclusao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DtNascimento)
                    .HasColumnName("dt_Nascimento")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdApolicePremium)
                    .HasColumnName("id_ApolicePremium")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdBeneficiario)
                    .HasColumnName("id_Beneficiario")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdBeneplano).HasColumnName("id_beneplano");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("id_TipoDocumento");

                entity.Property(e => e.NrDocumento)
                    .HasColumnName("nr_Documento")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BkpTbCobertura>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bkp_tb_Cobertura");

                entity.Property(e => e.AtAtivo)
                    .IsRequired()
                    .HasColumnName("at_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AtBloqueio)
                    .HasColumnName("at_Bloqueio")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AtEmail)
                    .HasColumnName("at_Email")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AtTipoAssistencia)
                    .HasColumnName("at_TipoAssistencia")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsCobertura)
                    .IsRequired()
                    .HasColumnName("ds_Cobertura")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsObservacao)
                    .HasColumnName("ds_Observacao")
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DtFimVigencia)
                    .HasColumnName("dt_FimVigencia")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtInicioVigencia)
                    .HasColumnName("dt_InicioVigencia")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCobertura)
                    .IsRequired()
                    .HasColumnName("id_Cobertura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdProduto)
                    .IsRequired()
                    .HasColumnName("id_Produto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoMoeda).HasColumnName("id_TipoMoeda");

                entity.Property(e => e.TpLimite)
                    .IsRequired()
                    .HasColumnName("tp_Limite")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VlLimite)
                    .HasColumnName("vl_Limite")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<BkpTbProduto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bkp_tb_Produto");

                entity.Property(e => e.AtAbrangencia)
                    .IsRequired()
                    .HasColumnName("at_abrangencia")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AtAtivo)
                    .IsRequired()
                    .HasColumnName("at_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsObservacao)
                    .HasColumnName("ds_Observacao")
                    .IsUnicode(false);

                entity.Property(e => e.DsProduto)
                    .IsRequired()
                    .HasColumnName("ds_Produto")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DtVigencia)
                    .HasColumnName("dt_Vigencia")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAgencia).HasColumnName("id_Agencia");

                entity.Property(e => e.IdProduto)
                    .IsRequired()
                    .HasColumnName("id_Produto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoMoeda).HasColumnName("id_TipoMoeda");
            });

            modelBuilder.Entity<BkpTbVoucher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bkp_tb_voucher");

                entity.Property(e => e.AtAtivo)
                    .IsRequired()
                    .HasColumnName("at_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsCliente)
                    .IsRequired()
                    .HasColumnName("ds_Cliente")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsComplemento)
                    .IsRequired()
                    .HasColumnName("ds_Complemento")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsEndereco)
                    .IsRequired()
                    .HasColumnName("ds_Endereco")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuario)
                    .IsRequired()
                    .HasColumnName("ds_usuario")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DtCancelamento)
                    .HasColumnName("dt_cancelamento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtContratacao)
                    .HasColumnName("dt_Contratacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtInicioVigencia)
                    .HasColumnName("dt_InicioVigencia")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtValidade)
                    .HasColumnName("dt_Validade")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdMunicipio).HasColumnName("id_Municipio");

                entity.Property(e => e.IdOrdemPagamento)
                    .HasColumnName("id_OrdemPagamento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdProduto)
                    .IsRequired()
                    .HasColumnName("id_Produto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdTpDocumento).HasColumnName("id_TpDocumento");

                entity.Property(e => e.NrDocumento)
                    .HasColumnName("nr_Documento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrVoucher)
                    .IsRequired()
                    .HasColumnName("nr_Voucher")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VlVoucher)
                    .HasColumnName("vl_Voucher")
                    .HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<BkpTbVoucherExterno>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bkp_tb_VoucherExterno");

                entity.Property(e => e.DsInformativoRetorno)
                    .IsRequired()
                    .HasColumnName("ds_InformativoRetorno")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.NrVoucherExterno)
                    .IsRequired()
                    .HasColumnName("nr_VoucherExterno")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CanaisVendas>(entity =>
            {
                entity.HasKey(e => e.IdCanalVenda)
                    .HasName("PK_Canais_Vendas_1");

                entity.ToTable("Canais_Vendas", "OMINT_SEGURADORA");

                entity.Property(e => e.IdCanalVenda)
                    .HasColumnName("id_canal_venda")
                    .ValueGeneratedNever();

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.NmCanalVenda)
                    .HasColumnName("nm_canal_venda")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CanaisVendasCorretores>(entity =>
            {
                entity.ToTable("Canais_Vendas_Corretores", "OMINT_SEGURADORA");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CdCorretor).HasColumnName("cd_corretor");

                entity.Property(e => e.CdSusep)
                    .HasColumnName("cd_susep")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CdTipoPessoa).HasColumnName("cd_tipo_pessoa");

                entity.Property(e => e.CdTpPapel).HasColumnName("cd_tp_papel");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DvPadrao).HasColumnName("dv_padrao");

                entity.Property(e => e.IdCanalVenda).HasColumnName("id_canal_venda");

                entity.Property(e => e.IdPessoaCorretor).HasColumnName("id_pessoa_corretor");

                entity.Property(e => e.NmCorretor)
                    .HasColumnName("nm_corretor")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NrCnpjCpf)
                    .HasColumnName("nr_cnpj_cpf")
                    .HasMaxLength(50);

                entity.Property(e => e.PeComissao)
                    .HasColumnName("pe_comissao")
                    .HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<CanaisVendasOrigem>(entity =>
            {
                entity.HasKey(e => new { e.IdCanalVenda, e.IdCanalVendaOrigem })
                    .HasName("PK_Canais_Vendas_11");

                entity.ToTable("Canais_Vendas_Origem", "OMINT_SEGURADORA");

                entity.Property(e => e.IdCanalVenda).HasColumnName("id_canal_venda");

                entity.Property(e => e.IdCanalVendaOrigem)
                    .HasColumnName("id_canal_venda_origem")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.NmCanalVenda)
                    .IsRequired()
                    .HasColumnName("nm_canal_venda")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CancelamentoControle>(entity =>
            {
                entity.ToTable("Cancelamento_Controle", "OMINT_SEGURADORA");

                entity.Property(e => e.DataCancelamento).HasColumnType("datetime");

                entity.Property(e => e.DhUsuario)
                    .HasColumnName("dh_usuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrBilhete)
                    .IsRequired()
                    .HasColumnName("nr_bilhete")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CrmControle>(entity =>
            {
                entity.ToTable("CRM_Controle", "OMINT_SEGURADORA");

                entity.Property(e => e.DataAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.DhUsuario)
                    .HasColumnName("dh_usuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrBilhete)
                    .IsRequired()
                    .HasColumnName("Nr_bilhete")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<I4proControle>(entity =>
            {
                entity.ToTable("I4PRO_Controle", "OMINT_SEGURADORA");

                entity.Property(e => e.DataAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.DhUsuario)
                    .HasColumnName("dh_usuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrVoucher)
                    .IsRequired()
                    .HasColumnName("Nr_voucher")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrProductoPrecio>(entity =>
            {
                entity.HasKey(e => e.IdProductoPrecio);

                entity.ToTable("PR_ProductoPrecio", "OMINT_SEGURADORA");

                entity.Property(e => e.CdProduto)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaDesde).HasColumnType("datetime");

                entity.Property(e => e.FechaHasta).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
            });

            modelBuilder.Entity<Produtos>(entity =>
            {
                entity.ToTable("Produtos", "OMINT_SEGURADORA");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CdMoeda)
                    .HasColumnName("cd_moeda")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CdProduto)
                    .HasColumnName("cd_produto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CdUsuario)
                    .HasColumnName("cd_usuario")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DvBilhete).HasColumnName("dv_bilhete");

                entity.Property(e => e.DvProdutoAgencia).HasColumnName("dv_produto_agencia");

                entity.Property(e => e.IdMarca).HasColumnName("id_marca");

                entity.Property(e => e.IdTipoCobertura).HasColumnName("id_tipo_cobertura");

                entity.Property(e => e.IdTipoProduto).HasColumnName("id_tipo_produto");

                entity.Property(e => e.IdTipoViagem)
                    .HasColumnName("id_tipo_viagem")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NmCondicoesGerais)
                    .HasColumnName("nm_condicoes_gerais")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NmProduto)
                    .HasColumnName("nm_produto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrDiaMaximo)
                    .HasColumnName("nr_dia_maximo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrDiaMinimo)
                    .HasColumnName("nr_dia_minimo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrIdadeMaxima).HasColumnName("nr_idade_maxima");

                entity.Property(e => e.VlMaximoCapital)
                    .HasColumnName("vl_maximo_capital")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<ProdutosCanaisVendas>(entity =>
            {
                entity.ToTable("Produtos_Canais_Vendas", "OMINT_SEGURADORA");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CdProduto)
                    .IsRequired()
                    .HasColumnName("cd_produto")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCanalVenda).HasColumnName("id_canal_venda");
            });

            modelBuilder.Entity<TbAgencia>(entity =>
            {
                entity.HasKey(e => e.IdAgencia)
                    .HasName("PK__tb_Agenc__B6C0E6F47E57BA87");

                entity.ToTable("tb_Agencia", "PREMIUM");

                entity.Property(e => e.IdAgencia).HasColumnName("id_Agencia");

                entity.Property(e => e.AtAtivo)
                    .IsRequired()
                    .HasColumnName("at_Ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DsAgencia)
                    .HasColumnName("ds_Agencia")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbAgencia2>(entity =>
            {
                entity.HasKey(e => e.IdAgencia)
                    .HasName("PK__tb_Agenc__B6C0E6F41FEDB87C");

                entity.ToTable("tb_Agencia2", "PREMIUM");

                entity.Property(e => e.IdAgencia).HasColumnName("id_Agencia");

                entity.Property(e => e.AtAtivo)
                    .IsRequired()
                    .HasColumnName("at_Ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsAgencia)
                    .HasColumnName("ds_Agencia")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbAgenciaContato>(entity =>
            {
                entity.HasKey(e => e.IdAgenciaContato)
                    .HasName("PK__tb_Agenc__AC538BE323BE4960");

                entity.ToTable("tb_AgenciaContato", "PREMIUM");

                entity.Property(e => e.IdAgenciaContato).HasColumnName("id_AgenciaContato");

                entity.Property(e => e.AtAtivo)
                    .IsRequired()
                    .HasColumnName("at_Ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsAgenciaContato)
                    .HasColumnName("ds_AgenciaContato")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsEmail)
                    .HasColumnName("ds_Email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdAgencia).HasColumnName("id_Agencia");

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.TbAgenciaContato)
                    .HasForeignKey(d => d.IdAgencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_AgenciaContato_tb_Agencia");
            });

            modelBuilder.Entity<TbAgenciaCorretorPremium>(entity =>
            {
                entity.HasKey(e => e.IdAgenciaCorretor)
                    .HasName("PK__tb_Agenc__94F1D6E8118A8A8C");

                entity.ToTable("tb_AgenciaCorretorPremium", "OMINT_SEGURADORA");

                entity.Property(e => e.IdAgenciaCorretor).HasColumnName("id_AgenciaCorretor");

                entity.Property(e => e.CdSusep)
                    .IsRequired()
                    .HasColumnName("cd_susep")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CdTpPapel).HasColumnName("cd_tp_papel");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuaAlte)
                    .IsRequired()
                    .HasColumnName("ds_usua_alte")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaIncl)
                    .IsRequired()
                    .HasColumnName("ds_usua_incl")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DtFim)
                    .HasColumnName("dt_fim")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtInicio)
                    .HasColumnName("dt_inicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCanalVenda).HasColumnName("id_canal_venda");

                entity.Property(e => e.IdPessoaCorretor).HasColumnName("id_pessoa_corretor");

                entity.Property(e => e.NrCnpjcpfAgencia)
                    .IsRequired()
                    .HasColumnName("nr_cnpjcpf_agencia")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrCnpjcpfCorretor)
                    .IsRequired()
                    .HasColumnName("nr_cnpjcpf_corretor")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PeComissaoAgencia)
                    .HasColumnName("pe_comissao_agencia")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PeComissaoCorretor)
                    .HasColumnName("pe_comissao_corretor")
                    .HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<TbAgenciaPremiumCarga>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_AgenciaPremiumCarga");

                entity.Property(e => e.CdAgencia)
                    .HasColumnName("cd_agencia")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NrCnpjcpfAgencia)
                    .HasColumnName("nr_cnpjcpf_agencia")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PeComissaoAencia).HasColumnName("pe_comissao_aencia");
            });

            modelBuilder.Entity<TbAgendamentoRetorno>(entity =>
            {
                entity.HasKey(e => e.IdAgendamentoRetorno)
                    .HasName("PK__tb_Agend__128C4F056497E884");

                entity.ToTable("tb_AgendamentoRetorno", "PREMIUM");

                entity.Property(e => e.IdAgendamentoRetorno).HasColumnName("id_AgendamentoRetorno");

                entity.Property(e => e.AtAtivo)
                    .IsRequired()
                    .HasColumnName("at_Ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhRetorno)
                    .HasColumnName("dh_Retorno")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsComentario)
                    .HasColumnName("ds_Comentario")
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdCaso).HasColumnName("id_Caso");
            });

            modelBuilder.Entity<TbAlertaVoucher>(entity =>
            {
                entity.HasKey(e => e.IdAlertaVoucher)
                    .HasName("PK_id_AlertaVoucher");

                entity.ToTable("tb_AlertaVoucher", "PREMIUM");

                entity.Property(e => e.IdAlertaVoucher).HasColumnName("id_AlertaVoucher");

                entity.Property(e => e.AtAtivo)
                    .IsRequired()
                    .HasColumnName("at_Ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsAlerta)
                    .IsRequired()
                    .HasColumnName("ds_Alerta")
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuario)
                    .IsRequired()
                    .HasColumnName("ds_Usuario")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdTpAlerta)
                    .IsRequired()
                    .HasColumnName("id_TpAlerta")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NrVoucher)
                    .IsRequired()
                    .HasColumnName("nr_Voucher")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbArquivoFisico>(entity =>
            {
                entity.HasKey(e => new { e.NrVoucher, e.DtArquivo });

                entity.ToTable("tb_Arquivo_Fisico", "OMINT_SEGURADORA");

                entity.Property(e => e.NrVoucher)
                    .HasColumnName("nr_voucher")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DtArquivo)
                    .HasColumnName("dt_arquivo")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuaIncl)
                    .IsRequired()
                    .HasColumnName("ds_usua_incl")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbArqvCargProd>(entity =>
            {
                entity.HasKey(e => e.IdArqv)
                    .HasName("PK__tb_arqv___8A8CA3832121D3D7");

                entity.ToTable("tb_arqv_carg_prod", "OMINT_SEGURADORA");

                entity.Property(e => e.IdArqv).HasColumnName("id_arqv");

                entity.Property(e => e.DhIncl)
                    .HasColumnName("dh_incl")
                    .HasColumnType("datetime");

                entity.Property(e => e.NmArqv)
                    .IsRequired()
                    .HasColumnName("nm_arqv")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbAutorizacaoComplemento>(entity =>
            {
                entity.HasKey(e => e.IdAutorizacaoComplemento);

                entity.ToTable("tb_AutorizacaoComplemento", "PREMIUM");

                entity.Property(e => e.IdAutorizacaoComplemento).HasColumnName("id_AutorizacaoComplemento");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsJustificativa)
                    .HasColumnName("DS_JUSTIFICATIVA")
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuario)
                    .IsRequired()
                    .HasColumnName("ds_Usuario")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdCaso).HasColumnName("id_Caso");

                entity.Property(e => e.IdUsuario).HasColumnName("id_Usuario");

                entity.Property(e => e.TpJustificativa)
                    .HasColumnName("TP_JUSTIFICATIVA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbAuxiliarCargaMovimento>(entity =>
            {
                entity.ToTable("tb_AuxiliarCargaMovimento", "OMINT_SEGURADORA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DvBagagemEspecial)
                    .HasColumnName("dv_bagagem_especial")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DvCancelamento)
                    .IsRequired()
                    .HasColumnName("dv_cancelamento")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DvCompraProtegida)
                    .HasColumnName("dv_compra_protegida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaDesde).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TbAuxiliarCargaMovimentoBkp210516>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_AuxiliarCargaMovimento_bkp_210516", "OMINT_SEGURADORA");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DvBagagemEspecial)
                    .HasColumnName("dv_bagagem_especial")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DvCompraProtegida)
                    .HasColumnName("dv_compra_protegida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaDesde).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TbBeneficiario>(entity =>
            {
                entity.HasKey(e => e.IdBeneficiario)
                    .HasName("PK_tb_IAG_beneficiario");

                entity.ToTable("tb_Beneficiario", "PREMIUM");

                entity.Property(e => e.IdBeneficiario).HasColumnName("id_Beneficiario");

                entity.Property(e => e.CdIdioma)
                    .HasColumnName("cd_Idioma")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CdLinhaProduto)
                    .HasColumnName("cd_LinhaProduto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CdPais)
                    .HasColumnName("cd_Pais")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CdSexo)
                    .HasColumnName("cd_Sexo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_Inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsNome)
                    .IsRequired()
                    .HasColumnName("ds_Nome")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsSobrenome)
                    .HasColumnName("ds_Sobrenome")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaInclusao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaInclusao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DtNascimento)
                    .HasColumnName("dt_Nascimento")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdApolicePremium)
                    .HasColumnName("id_ApolicePremium")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdBeneplano).HasColumnName("id_beneplano");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("id_TipoDocumento");

                entity.Property(e => e.NrDocumento)
                    .HasColumnName("nr_Documento")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.CdIdiomaNavigation)
                    .WithMany(p => p.TbBeneficiario)
                    .HasForeignKey(d => d.CdIdioma)
                    .HasConstraintName("FK_tb_IAG_Beneficiario_tb_IAG_Idioma");
            });

            modelBuilder.Entity<TbBilheteSeguradoConfirmaEmail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_BilheteSeguradoConfirmaEmail", "OMINT_SEGURADORA");

                entity.Property(e => e.DhAgenda)
                    .HasColumnName("dh_agenda")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhEnvio)
                    .HasColumnName("dh_envio")
                    .HasColumnType("datetime");

                entity.Property(e => e.NrBilhete)
                    .IsRequired()
                    .HasColumnName("nr_bilhete")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCanalVendaProduto>(entity =>
            {
                entity.HasKey(e => new { e.IdCanalVenda, e.CdProduto })
                    .HasName("PK__tb_Canal__07E894691837881B");

                entity.ToTable("tb_CanalVendaProduto", "OMINT_SEGURADORA");

                entity.Property(e => e.IdCanalVenda).HasColumnName("id_canal_venda");

                entity.Property(e => e.CdProduto)
                    .HasColumnName("cd_produto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsCanalVenda)
                    .IsRequired()
                    .HasColumnName("ds_canal_venda")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlte)
                    .IsRequired()
                    .HasColumnName("ds_usua_alte")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaIncl)
                    .IsRequired()
                    .HasColumnName("ds_usua_incl")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCancelamentoSegurado>(entity =>
            {
                entity.HasKey(e => e.NrBilhete)
                    .HasName("PK_tb_CancelamentoSegurado_1");

                entity.ToTable("tb_CancelamentoSegurado", "OMINT_SEGURADORA");

                entity.Property(e => e.NrBilhete)
                    .HasColumnName("nr_bilhete")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CancelaAgrupada)
                    .IsRequired()
                    .HasColumnName("cancela_agrupada")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CdApolice)
                    .HasColumnName("cd_apolice")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CdMotivo).HasColumnName("cd_motivo");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuaAlte)
                    .IsRequired()
                    .HasColumnName("ds_usua_alte")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaIncl)
                    .IsRequired()
                    .HasColumnName("ds_usua_incl")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DtCancelamento)
                    .HasColumnName("dt_cancelamento")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCancelamentoSegurado)
                    .HasColumnName("id_CancelamentoSegurado")
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdMeioPagamento).HasColumnName("id_meio_pagamento");

                entity.Property(e => e.NrAgencia)
                    .HasColumnName("nr_agencia")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NrBanco)
                    .HasColumnName("nr_banco")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NrContaCorrente)
                    .HasColumnName("nr_conta_corrente")
                    .HasMaxLength(23)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NrDacAgencia)
                    .HasColumnName("nr_dac_agencia")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NrDacContaCorrente)
                    .HasColumnName("nr_dac_conta_corrente")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbCancelamentoSeguradoBkp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_CancelamentoSegurado_bkp", "OMINT_SEGURADORA");

                entity.Property(e => e.CancelaAgrupada)
                    .IsRequired()
                    .HasColumnName("cancela_agrupada")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CdApolice)
                    .HasColumnName("cd_apolice")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CdMotivo).HasColumnName("cd_motivo");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuaAlte)
                    .IsRequired()
                    .HasColumnName("ds_usua_alte")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaIncl)
                    .IsRequired()
                    .HasColumnName("ds_usua_incl")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DtCancelamento)
                    .HasColumnName("dt_cancelamento")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCancelamentoSegurado)
                    .HasColumnName("id_CancelamentoSegurado")
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdMeioPagamento).HasColumnName("id_meio_pagamento");

                entity.Property(e => e.NrAgencia)
                    .HasColumnName("nr_agencia")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NrBanco)
                    .HasColumnName("nr_banco")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NrBilhete)
                    .IsRequired()
                    .HasColumnName("nr_bilhete")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrContaCorrente)
                    .HasColumnName("nr_conta_corrente")
                    .HasMaxLength(23)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NrDacAgencia)
                    .HasColumnName("nr_dac_agencia")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NrDacContaCorrente)
                    .HasColumnName("nr_dac_conta_corrente")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbCaso>(entity =>
            {
                entity.HasKey(e => e.IdCaso)
                    .HasName("PK_tb_IAG_caso");

                entity.ToTable("tb_Caso", "PREMIUM");

                entity.Property(e => e.IdCaso).HasColumnName("id_Caso");

                entity.Property(e => e.AtAcionamentoPrevio)
                    .HasColumnName("at_AcionamentoPrevio")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AtAutorizado)
                    .IsRequired()
                    .HasColumnName("at_Autorizado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CdIdioma)
                    .HasColumnName("cd_Idioma")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CdPais)
                    .HasColumnName("cd_pais")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CdStatus)
                    .IsRequired()
                    .HasColumnName("cd_Status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.DhAbertura)
                    .HasColumnName("dh_Abertura")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhEncerramento)
                    .HasColumnName("dh_Encerramento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_Inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsCaracteristica)
                    .HasColumnName("ds_Caracteristica")
                    .IsUnicode(false);

                entity.Property(e => e.DsContato)
                    .HasColumnName("ds_Contato")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsEmail)
                    .HasColumnName("ds_Email")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaEncerramento)
                    .HasColumnName("ds_UsuaEncerramento")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaInclusao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaInclusao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DtViagem)
                    .HasColumnName("dt_viagem")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdBeneficiario).HasColumnName("id_Beneficiario");

                entity.Property(e => e.IdCasoRef).HasColumnName("id_CasoRef");

                entity.Property(e => e.IdCobertura)
                    .HasColumnName("id_Cobertura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdContato).HasColumnName("id_Contato");

                entity.Property(e => e.IdMunicipio).HasColumnName("id_Municipio");

                entity.Property(e => e.IdRefContato)
                    .HasColumnName("id_RefContato")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdTpContato).HasColumnName("id_TpContato");

                entity.Property(e => e.NrDddFax)
                    .HasColumnName("nr_DddFax")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NrDddTelefone)
                    .HasColumnName("nr_DddTelefone")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NrDdiFax)
                    .HasColumnName("nr_DdiFax")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NrDdiTelefone)
                    .HasColumnName("nr_DdiTelefone")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NrPrefixoFax)
                    .HasColumnName("nr_PrefixoFax")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NrPrefixoTelefone)
                    .HasColumnName("nr_PrefixoTelefone")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NrSufixoFax)
                    .HasColumnName("nr_SufixoFax")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NrSufixoTelefone)
                    .HasColumnName("nr_SufixoTelefone")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NrVoucher)
                    .HasColumnName("nr_Voucher")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TpCaso)
                    .IsRequired()
                    .HasColumnName("tp_Caso")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TpGop)
                    .HasColumnName("tp_GOP")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdBeneficiarioNavigation)
                    .WithMany(p => p.TbCaso)
                    .HasForeignKey(d => d.IdBeneficiario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_IAG_Caso_tb_IAG_Beneficiario");
            });

            modelBuilder.Entity<TbCasoCheckList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_CasoCheckList", "PREMIUM");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhPrazo)
                    .HasColumnName("dh_Prazo")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhResolucao)
                    .HasColumnName("dh_Resolucao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdCaso).HasColumnName("id_Caso");

                entity.Property(e => e.IdCheckList).HasColumnName("id_CheckList");
            });

            modelBuilder.Entity<TbCasoComunicacao>(entity =>
            {
                entity.HasKey(e => e.IdCasoComunicacao)
                    .HasName("PK_tb_IAG_CasoComunicacao");

                entity.ToTable("tb_CasoComunicacao", "PREMIUM");

                entity.Property(e => e.IdCasoComunicacao).HasColumnName("id_CasoComunicacao");

                entity.Property(e => e.AtEstorno)
                    .HasColumnName("at_Estorno")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.AtFormaContato)
                    .HasColumnName("at_FormaContato")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CdTipoModo).HasColumnName("cd_TipoModo");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_Inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsCasoComunicacao)
                    .HasColumnName("ds_CasoComunicacao")
                    .IsUnicode(false);

                entity.Property(e => e.DsContato)
                    .HasColumnName("ds_Contato")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsLocalizacaoPrestador)
                    .HasColumnName("ds_LocalizacaoPrestador")
                    .IsUnicode(false);

                entity.Property(e => e.DsPrestador)
                    .HasColumnName("ds_Prestador")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaInclusao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaInclusao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdCaso).HasColumnName("id_Caso");

                entity.Property(e => e.IdContatoComunicacao).HasColumnName("id_ContatoComunicacao");

                entity.Property(e => e.IdEventoComunicacao).HasColumnName("id_EventoComunicacao");

                entity.Property(e => e.IdTipoDemanda).HasColumnName("id_TipoDemanda");

                entity.Property(e => e.IdTipoMoeda).HasColumnName("id_TipoMoeda");

                entity.Property(e => e.NrDocumentoPrestador)
                    .HasColumnName("nr_DocumentoPrestador")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VlAutorizado).HasColumnName("vl_Autorizado");

                entity.Property(e => e.VlContratado).HasColumnName("vl_Contratado");

                entity.Property(e => e.VlOrcamento).HasColumnName("vl_Orcamento");

                entity.HasOne(d => d.IdCasoNavigation)
                    .WithMany(p => p.TbCasoComunicacao)
                    .HasForeignKey(d => d.IdCaso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_IAG_CasoComunicacao_tb_IAG_Caso");

                entity.HasOne(d => d.IdContatoComunicacaoNavigation)
                    .WithMany(p => p.TbCasoComunicacao)
                    .HasForeignKey(d => d.IdContatoComunicacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_IAG_CasoComunicacao_tb_IAG_ContatoComunicacao");
            });

            modelBuilder.Entity<TbCasoDocumento>(entity =>
            {
                entity.HasKey(e => e.IdCasoDocumento)
                    .HasName("PK_tb_IAG_CasoDocumento");

                entity.ToTable("tb_CasoDocumento", "PREMIUM");

                entity.Property(e => e.IdCasoDocumento).HasColumnName("id_CasoDocumento");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_Inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsComentario)
                    .HasColumnName("ds_Comentario")
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaInclusao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaInclusao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdCasoComunicacao).HasColumnName("id_CasoComunicacao");

                entity.Property(e => e.IdImagem).HasColumnName("id_Imagem");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("id_TipoDocumento");

                entity.HasOne(d => d.IdCasoComunicacaoNavigation)
                    .WithMany(p => p.TbCasoDocumento)
                    .HasForeignKey(d => d.IdCasoComunicacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_IAG_CasoDocumento_tb_IAG_CasoComunicacao");
            });

            modelBuilder.Entity<TbCasoLimite>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_CasoLimite", "PREMIUM");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_Inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaInclusao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaInclusao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdCaso).HasColumnName("id_Caso");

                entity.Property(e => e.IdTipoLimite).HasColumnName("id_TipoLimite");

                entity.Property(e => e.QtLimite).HasColumnName("qt_Limite");

                entity.Property(e => e.QtLimiteComplementar).HasColumnName("qt_LimiteComplementar");

                entity.Property(e => e.VlAutorizado).HasColumnName("vl_Autorizado");

                entity.Property(e => e.VlDisponivel).HasColumnName("vl_Disponivel");

                entity.Property(e => e.VlLimite).HasColumnName("vl_Limite");

                entity.Property(e => e.VlLimiteComplemetar).HasColumnName("vl_LimiteComplemetar");
            });

            modelBuilder.Entity<TbCasoLimiteD>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_CasoLimite_D", "PREMIUM");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_Inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaInclusao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaInclusao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdCaso).HasColumnName("id_Caso");

                entity.Property(e => e.IdTipoLimite).HasColumnName("id_TipoLimite");

                entity.Property(e => e.QtLimite).HasColumnName("qt_Limite");

                entity.Property(e => e.QtLimiteComplementar).HasColumnName("qt_LimiteComplementar");

                entity.Property(e => e.VlAutorizado).HasColumnName("vl_Autorizado");

                entity.Property(e => e.VlDisponivel).HasColumnName("vl_Disponivel");

                entity.Property(e => e.VlLimite).HasColumnName("vl_Limite");

                entity.Property(e => e.VlLimiteComplemetar).HasColumnName("vl_LimiteComplemetar");
            });

            modelBuilder.Entity<TbCasoMedico>(entity =>
            {
                entity.HasKey(e => e.IdCasoMedico)
                    .HasName("PK_tb_IAG_CasoMedico");

                entity.ToTable("tb_CasoMedico", "PREMIUM");

                entity.Property(e => e.IdCasoMedico).HasColumnName("id_CasoMedico");

                entity.Property(e => e.AtCredenciado)
                    .HasColumnName("at_Credenciado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AtLimite)
                    .HasColumnName("at_Limite")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CdTipoPrestador)
                    .HasColumnName("cd_TipoPrestador")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_Inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsAssistenciaRequerida)
                    .HasColumnName("ds_AssistenciaRequerida")
                    .IsUnicode(false);

                entity.Property(e => e.DsCid)
                    .HasColumnName("ds_Cid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsLocalizacaoBeneficiario)
                    .HasColumnName("ds_LocalizacaoBeneficiario")
                    .IsUnicode(false);

                entity.Property(e => e.DsLocalizacaoPrestador)
                    .HasColumnName("ds_LocalizacaoPrestador")
                    .IsUnicode(false);

                entity.Property(e => e.DsNomeAcompanhante)
                    .HasColumnName("ds_NomeAcompanhante")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsPrestador)
                    .HasColumnName("ds_Prestador")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsRelatorioMedico)
                    .HasColumnName("ds_RelatorioMedico")
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaInclusao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaInclusao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DtAlta)
                    .HasColumnName("dt_Alta")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtInternacao)
                    .HasColumnName("dt_Internacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtLimite)
                    .HasColumnName("dt_Limite")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCaso).HasColumnName("id_Caso");

                entity.Property(e => e.IdTipoAssistencia).HasColumnName("id_TipoAssistencia");

                entity.Property(e => e.IdTipoMoeda).HasColumnName("id_TipoMoeda");

                entity.Property(e => e.NrAutorizacaoOmint).HasColumnName("nr_AutorizacaoOmint");

                entity.Property(e => e.NrDocumentoPrestador)
                    .HasColumnName("nr_DocumentoPrestador")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneAcompanhante)
                    .HasColumnName("nr_TelefoneAcompanhante")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VlLimiteCobertura).HasColumnName("vl_LimiteCobertura");

                entity.HasOne(d => d.IdCasoNavigation)
                    .WithMany(p => p.TbCasoMedico)
                    .HasForeignKey(d => d.IdCaso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_IAG_CasoMedico_tb_IAG_Caso");
            });

            modelBuilder.Entity<TbCasoViagem>(entity =>
            {
                entity.HasKey(e => e.IdCasoViagem)
                    .HasName("PK_tb_IAG_CasoViagem");

                entity.ToTable("tb_CasoViagem", "PREMIUM");

                entity.Property(e => e.IdCasoViagem).HasColumnName("id_CasoViagem");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_Inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsComentario)
                    .HasColumnName("ds_Comentario")
                    .IsUnicode(false);

                entity.Property(e => e.DsDetalheSolicitacao)
                    .HasColumnName("ds_DetalheSolicitacao")
                    .IsUnicode(false);

                entity.Property(e => e.DsLocalizacaoBeneficiario)
                    .HasColumnName("ds_LocalizacaoBeneficiario")
                    .IsUnicode(false);

                entity.Property(e => e.DsLocalizacaoPrestador)
                    .HasColumnName("ds_LocalizacaoPrestador")
                    .IsUnicode(false);

                entity.Property(e => e.DsPrestador)
                    .HasColumnName("ds_Prestador")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaInclusao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaInclusao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdCaso).HasColumnName("id_Caso");

                entity.Property(e => e.IdTipoAssistencia).HasColumnName("id_TipoAssistencia");

                entity.Property(e => e.IdTipoMoeda).HasColumnName("id_TipoMoeda");

                entity.Property(e => e.NrDocumentoPrestador)
                    .HasColumnName("nr_DocumentoPrestador")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VlContratado).HasColumnName("vl_Contratado");

                entity.Property(e => e.VlLimiteCobertura).HasColumnName("vl_LimiteCobertura");

                entity.Property(e => e.VlOrcamento).HasColumnName("vl_Orcamento");

                entity.HasOne(d => d.IdCasoNavigation)
                    .WithMany(p => p.TbCasoViagem)
                    .HasForeignKey(d => d.IdCaso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_IAG_CasoViagem_tb_IAG_Caso");
            });

            modelBuilder.Entity<TbCheckList>(entity =>
            {
                entity.HasKey(e => e.IdCheckList)
                    .HasName("PK_tb_PREMIUM_CheckList");

                entity.ToTable("tb_CheckList", "PREMIUM");

                entity.Property(e => e.IdCheckList).HasColumnName("id_CheckList");

                entity.Property(e => e.AtMedidorTempo)
                    .IsRequired()
                    .HasColumnName("at_MedidorTempo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('D')");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsCheckList)
                    .IsRequired()
                    .HasColumnName("ds_CheckList")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NrTempo)
                    .HasColumnName("nr_Tempo")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TbCheckListCobertura>(entity =>
            {
                entity.HasKey(e => new { e.IdCheckList, e.IdCobertura });

                entity.ToTable("tb_CheckListCobertura", "PREMIUM");

                entity.Property(e => e.IdCheckList).HasColumnName("id_CheckList");

                entity.Property(e => e.IdCobertura)
                    .HasColumnName("id_Cobertura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCobertura>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_Cobertura", "PREMIUM");

                entity.Property(e => e.AtAtivo)
                    .IsRequired()
                    .HasColumnName("at_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AtBloqueio)
                    .HasColumnName("at_bloqueio")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.AtEmail)
                    .HasColumnName("at_Email")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AtTipoAssistencia)
                    .HasColumnName("at_TipoAssistencia")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsCobertura)
                    .IsRequired()
                    .HasColumnName("ds_Cobertura")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsObservacao)
                    .HasColumnName("ds_Observacao")
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DtFimVigencia)
                    .HasColumnName("dt_FimVigencia")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtInicioVigencia)
                    .HasColumnName("dt_InicioVigencia")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCobertura)
                    .IsRequired()
                    .HasColumnName("id_Cobertura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdProduto)
                    .IsRequired()
                    .HasColumnName("id_Produto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoMoeda).HasColumnName("id_TipoMoeda");

                entity.Property(e => e.TpLimite)
                    .IsRequired()
                    .HasColumnName("tp_Limite")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VlLimite)
                    .HasColumnName("vl_Limite")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TbCoberturaLimite>(entity =>
            {
                entity.HasKey(e => new { e.NrVoucher, e.IdCobertura, e.DhAutorizado });

                entity.ToTable("tb_CoberturaLimite", "PREMIUM");

                entity.Property(e => e.NrVoucher)
                    .HasColumnName("nr_Voucher")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCobertura)
                    .HasColumnName("id_Cobertura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DhAutorizado)
                    .HasColumnName("dh_Autorizado")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhUtilizado)
                    .HasColumnName("dh_Utilizado")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdCaso).HasColumnName("id_Caso");

                entity.Property(e => e.IdCasoComunicacao).HasColumnName("id_CasoComunicacao");

                entity.Property(e => e.IdTipoMoeda).HasColumnName("id_TipoMoeda");

                entity.Property(e => e.TpLimite)
                    .IsRequired()
                    .HasColumnName("tp_Limite")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('V')");

                entity.Property(e => e.VlAutorizado)
                    .HasColumnName("vl_Autorizado")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VlUtilizado)
                    .HasColumnName("vl_Utilizado")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TbCoberturaPrestador>(entity =>
            {
                entity.HasKey(e => new { e.IdPrestador, e.IdCobertura });

                entity.ToTable("tb_CoberturaPrestador", "PREMIUM");

                entity.Property(e => e.IdPrestador).HasColumnName("id_Prestador");

                entity.Property(e => e.IdCobertura)
                    .HasColumnName("id_Cobertura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbConferePropostaCorretor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TB_Confere_Proposta_Corretor", "OMINT_SEGURADORA");

                entity.Property(e => e.NrProposta)
                    .HasColumnName("nr_proposta")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbContato>(entity =>
            {
                entity.HasKey(e => e.IdContato)
                    .HasName("PK_tb_IAG_Contato_1");

                entity.ToTable("tb_Contato", "PREMIUM");

                entity.Property(e => e.IdContato).HasColumnName("id_Contato");

                entity.Property(e => e.CdPais)
                    .IsRequired()
                    .HasColumnName("cd_Pais")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_Inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsCaracteristica)
                    .HasColumnName("ds_Caracteristica")
                    .IsUnicode(false);

                entity.Property(e => e.DsContato)
                    .HasColumnName("ds_Contato")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsEmail)
                    .HasColumnName("ds_Email")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaInclusao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaInclusao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdTpContato).HasColumnName("id_TpContato");

                entity.Property(e => e.NrDddFax)
                    .HasColumnName("nr_DddFax")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NrDddTelefone)
                    .HasColumnName("nr_DddTelefone")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NrDdiFax)
                    .HasColumnName("nr_DdiFax")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NrDdiTelefone)
                    .HasColumnName("nr_DdiTelefone")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NrPrefixoFax)
                    .HasColumnName("nr_PrefixoFax")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NrPrefixoTelefone)
                    .HasColumnName("nr_PrefixoTelefone")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NrSufixoFax)
                    .HasColumnName("nr_SufixoFax")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NrSufixoTelefone)
                    .HasColumnName("nr_SufixoTelefone")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbControleCarga>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_Controle_Carga", "OMINT_SEGURADORA");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuaAlter)
                    .HasColumnName("ds_usua_alter")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaInclu)
                    .IsRequired()
                    .HasColumnName("ds_usua_inclu")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DtMovimento)
                    .HasColumnName("dt_movimento")
                    .HasColumnType("date");

                entity.Property(e => e.StCarga)
                    .IsRequired()
                    .HasColumnName("st_carga")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbErroCarga>(entity =>
            {
                entity.HasKey(e => e.IdErro)
                    .HasName("PK__tb_ErroC__E4898D6020CCCE1C");

                entity.ToTable("tb_ErroCarga", "OMINT_SEGURADORA");

                entity.Property(e => e.IdErro).HasColumnName("id_erro");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdPoliza).HasColumnName("id_poliza");

                entity.Property(e => e.NrErro).HasColumnName("nr_erro");
            });

            modelBuilder.Entity<TbEventoComunicacao>(entity =>
            {
                entity.HasKey(e => e.IdEventoComunicacao)
                    .HasName("PK_tb_PREMIUM_EventoComunicacao");

                entity.ToTable("tb_EventoComunicacao", "PREMIUM");

                entity.Property(e => e.IdEventoComunicacao).HasColumnName("id_EventoComunicacao");

                entity.Property(e => e.AtComplemento)
                    .IsRequired()
                    .HasColumnName("at_Complemento")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.AtLimite)
                    .IsRequired()
                    .HasColumnName("at_Limite")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.AtTipoAssistencia)
                    .IsRequired()
                    .HasColumnName("at_TipoAssistencia")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsEventoComunicacao)
                    .IsRequired()
                    .HasColumnName("ds_EventoComunicacao")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbEventoComunicaoCobertura>(entity =>
            {
                entity.HasKey(e => new { e.IdEventoComunicacao, e.IdCobertura, e.IdProduto });

                entity.ToTable("tb_EventoComunicaoCobertura", "PREMIUM");

                entity.Property(e => e.IdEventoComunicacao).HasColumnName("id_EventoComunicacao");

                entity.Property(e => e.IdCobertura)
                    .HasColumnName("id_Cobertura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdProduto)
                    .HasColumnName("id_Produto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbGruposPaises>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_GruposPaises", "PREMIUM");

                entity.Property(e => e.AtAtivo)
                    .IsRequired()
                    .HasColumnName("at_Ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CdGruposPaises)
                    .HasColumnName("cd_GruposPaises")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CdPais)
                    .IsRequired()
                    .HasColumnName("cd_Pais")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsGruposPaises)
                    .HasColumnName("ds_GruposPaises")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdAgencia).HasColumnName("id_Agencia");

                entity.Property(e => e.IdGruposPaises).HasColumnName("id_GruposPaises");
            });

            modelBuilder.Entity<TbIdioma>(entity =>
            {
                entity.HasKey(e => e.CdIdioma)
                    .HasName("PK_tb_IAG_Idioma");

                entity.ToTable("tb_Idioma", "PREMIUM");

                entity.Property(e => e.CdIdioma)
                    .HasColumnName("cd_Idioma")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsIdioma)
                    .IsRequired()
                    .HasColumnName("ds_Idioma")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbLiquidacao>(entity =>
            {
                entity.HasKey(e => new { e.IdCaso, e.NrGop, e.NrNotaFiscal });

                entity.ToTable("tb_Liquidacao", "PREMIUM");

                entity.Property(e => e.IdCaso).HasColumnName("id_Caso");

                entity.Property(e => e.NrGop).HasColumnName("nr_Gop");

                entity.Property(e => e.NrNotaFiscal)
                    .HasColumnName("nr_NotaFiscal")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AtQuitacao)
                    .IsRequired()
                    .HasColumnName("at_Quitacao")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.AtStatus)
                    .HasColumnName("at_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DhInsercao)
                    .HasColumnName("dh_Insercao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhLiberacao)
                    .HasColumnName("dh_Liberacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhPagamento)
                    .HasColumnName("dh_Pagamento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuario)
                    .IsRequired()
                    .HasColumnName("ds_Usuario")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_name())");

                entity.Property(e => e.DsUsuarioLiberacao)
                    .HasColumnName("ds_UsuarioLiberacao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuarioPagamento)
                    .HasColumnName("ds_UsuarioPagamento")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_Cadastro")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtPagamento)
                    .HasColumnName("dt_Pagamento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtVencimento)
                    .HasColumnName("dt_Vencimento")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdMoeda).HasColumnName("id_Moeda");

                entity.Property(e => e.VlNotaFiscal)
                    .HasColumnName("vl_NotaFiscal")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VlPagamento)
                    .HasColumnName("vl_Pagamento")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VlTaxa)
                    .HasColumnName("vl_Taxa")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VlTotalDolar)
                    .HasColumnName("vl_TotalDolar")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TbLiquidacaoNegada>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_LiquidacaoNegada", "PREMIUM");

                entity.Property(e => e.AtQuitacao)
                    .IsRequired()
                    .HasColumnName("at_Quitacao")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AtStatus).HasColumnName("at_Status");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInsercao)
                    .HasColumnName("dh_Insercao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhLiberacao)
                    .HasColumnName("dh_Liberacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhPagamento)
                    .HasColumnName("dh_Pagamento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuario)
                    .IsRequired()
                    .HasColumnName("ds_Usuario")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuarioLiberacao)
                    .HasColumnName("ds_UsuarioLiberacao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuarioPagamento)
                    .HasColumnName("ds_UsuarioPagamento")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_Cadastro")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtPagamento)
                    .HasColumnName("dt_Pagamento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtVencimento)
                    .HasColumnName("dt_Vencimento")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCaso).HasColumnName("id_Caso");

                entity.Property(e => e.IdMoeda).HasColumnName("id_Moeda");

                entity.Property(e => e.NrGop).HasColumnName("nr_Gop");

                entity.Property(e => e.NrNotaFiscal)
                    .IsRequired()
                    .HasColumnName("nr_NotaFiscal")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VlNotaFiscal)
                    .HasColumnName("vl_NotaFiscal")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VlPagamento)
                    .HasColumnName("vl_Pagamento")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VlTaxa)
                    .HasColumnName("vl_Taxa")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VlTotalDolar)
                    .HasColumnName("vl_TotalDolar")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TbMembro>(entity =>
            {
                entity.HasKey(e => e.IdMembro)
                    .HasName("PK_tb_PREMIUM_Membro_1");

                entity.ToTable("tb_Membro", "PREMIUM");

                entity.Property(e => e.IdMembro).HasColumnName("id_Membro");

                entity.Property(e => e.AtAtivo)
                    .HasColumnName("at_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.CdPais)
                    .IsRequired()
                    .HasColumnName("cd_Pais")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_Inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsCaracteristica)
                    .HasColumnName("ds_Caracteristica")
                    .IsUnicode(false);

                entity.Property(e => e.DsContato)
                    .HasColumnName("ds_Contato")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsEmail)
                    .HasColumnName("ds_Email")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DsMembro)
                    .IsRequired()
                    .HasColumnName("ds_Membro")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaInclusao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaInclusao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NrDddFax)
                    .HasColumnName("nr_DddFax")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NrDddTelefone)
                    .HasColumnName("nr_DddTelefone")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NrDdiFax)
                    .HasColumnName("nr_DdiFax")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NrDdiTelefone)
                    .HasColumnName("nr_DdiTelefone")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NrPrefixoFax)
                    .HasColumnName("nr_PrefixoFax")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NrPrefixoTelefone)
                    .HasColumnName("nr_PrefixoTelefone")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NrSufixoFax)
                    .HasColumnName("nr_SufixoFax")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NrSufixoTelefone)
                    .HasColumnName("nr_SufixoTelefone")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbMunicipio>(entity =>
            {
                entity.HasKey(e => e.IdMunicipio);

                entity.ToTable("tb_Municipio", "PREMIUM");

                entity.Property(e => e.IdMunicipio).HasColumnName("id_Municipio");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsMunicipio)
                    .HasColumnName("ds_Municipio")
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdUf).HasColumnName("id_UF");
            });

            modelBuilder.Entity<TbOrdemPagamento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_OrdemPagamento", "PREMIUM");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuario)
                    .IsRequired()
                    .HasColumnName("ds_usuario")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdOrdemPagamento)
                    .HasColumnName("id_OrdemPagamento")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NrOrdemPagamento)
                    .HasColumnName("nr_OrdemPagamento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QtVoucher).HasColumnName("qt_Voucher");

                entity.Property(e => e.VlCompra)
                    .HasColumnName("vl_Compra")
                    .HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<TbPais>(entity =>
            {
                entity.HasKey(e => e.CdPais);

                entity.ToTable("tb_Pais", "PREMIUM");

                entity.Property(e => e.CdPais)
                    .HasColumnName("cd_Pais")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsPais)
                    .IsRequired()
                    .HasColumnName("ds_Pais")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoMoeda).HasColumnName("id_TipoMoeda");
            });

            modelBuilder.Entity<TbPapelComissao>(entity =>
            {
                entity.HasKey(e => e.CdTpPapel)
                    .HasName("PK__tb_Papel__3C8F0BF9249D5F00");

                entity.ToTable("tb_PapelComissao", "OMINT_SEGURADORA");

                entity.Property(e => e.CdTpPapel)
                    .HasColumnName("cd_tp_papel")
                    .ValueGeneratedNever();

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsTpPapel)
                    .IsRequired()
                    .HasColumnName("ds_tp_papel")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlte)
                    .IsRequired()
                    .HasColumnName("ds_usua_alte")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaIncl)
                    .IsRequired()
                    .HasColumnName("ds_usua_incl")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbParentescoPpe>(entity =>
            {
                entity.HasKey(e => e.IdParentescoPpe)
                    .HasName("PK__tb_Paren__6BF90E4A286DEFE4");

                entity.ToTable("tb_Parentesco_ppe", "OMINT_SEGURADORA");

                entity.Property(e => e.IdParentescoPpe)
                    .HasColumnName("id_parentesco_ppe")
                    .ValueGeneratedNever();

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuaAlte)
                    .IsRequired()
                    .HasColumnName("ds_usua_alte")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaIncl)
                    .IsRequired()
                    .HasColumnName("ds_usua_incl")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NmParentescoPpe)
                    .IsRequired()
                    .HasColumnName("nm_parentesco_ppe")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbPessoaCorretor>(entity =>
            {
                entity.HasKey(e => new { e.IdCanalVenda, e.CdCorretor, e.IdPessoaCorretor })
                    .HasName("PK__tb_Pesso__7629709F2C3E80C8");

                entity.ToTable("tb_PessoaCorretor", "OMINT_SEGURADORA");

                entity.Property(e => e.IdCanalVenda).HasColumnName("id_canal_venda");

                entity.Property(e => e.CdCorretor).HasColumnName("cd_corretor");

                entity.Property(e => e.IdPessoaCorretor).HasColumnName("id_pessoa_corretor");

                entity.Property(e => e.CdSusep)
                    .HasColumnName("cd_susep")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CdTpPapel).HasColumnName("cd_tp_papel");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuaAlte)
                    .IsRequired()
                    .HasColumnName("ds_usua_alte")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaIncl)
                    .IsRequired()
                    .HasColumnName("ds_usua_incl")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DvCorretorPrincipal)
                    .HasColumnName("dv_corretor_principal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DvPadrao).HasColumnName("dv_padrao");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.NrCnpjcpf)
                    .IsRequired()
                    .HasColumnName("nr_cnpjcpf")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PeComissao)
                    .HasColumnName("pe_comissao")
                    .HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<TbPessoaPoliticaExposta>(entity =>
            {
                entity.HasKey(e => e.IdPpe)
                    .HasName("PK__tb_Pesso__6FC85994300F11AC");

                entity.ToTable("tb_PessoaPoliticaExposta", "OMINT_SEGURADORA");

                entity.Property(e => e.IdPpe).HasColumnName("id_ppe");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuaAlte)
                    .IsRequired()
                    .HasColumnName("ds_usua_alte")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaIncl)
                    .IsRequired()
                    .HasColumnName("ds_usua_incl")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DvPpe)
                    .IsRequired()
                    .HasColumnName("dv_ppe")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdParentescoPpe).HasColumnName("id_parentesco_ppe");
            });

            modelBuilder.Entity<TbPremiumTipoContaReceber>(entity =>
            {
                entity.HasKey(e => e.IdContaReceber)
                    .HasName("PK_tb_PremiumTipoContaReceber_1");

                entity.ToTable("tb_PremiumTipoContaReceber", "PREMIUM");

                entity.Property(e => e.IdContaReceber).HasColumnName("id_ContaReceber");

                entity.Property(e => e.CdTipoPessoa)
                    .IsRequired()
                    .HasColumnName("cd_TipoPessoa")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_Inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsTipoContaReceber)
                    .IsRequired()
                    .HasColumnName("ds_TipoContaReceber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsTipoMovimento)
                    .IsRequired()
                    .HasColumnName("ds_TipoMovimento")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaInclusao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaInclusao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoContaReceber).HasColumnName("id_TipoContaReceber");

                entity.Property(e => e.IdTipoMovimento).HasColumnName("id_TipoMovimento");
            });

            modelBuilder.Entity<TbPrestador>(entity =>
            {
                entity.HasKey(e => e.IdPrestador);

                entity.ToTable("tb_Prestador", "PREMIUM");

                entity.Property(e => e.IdPrestador).HasColumnName("id_Prestador");

                entity.Property(e => e.AtAtivo)
                    .IsRequired()
                    .HasColumnName("at_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsBairro)
                    .IsRequired()
                    .HasColumnName("ds_Bairro")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsComplemento)
                    .IsRequired()
                    .HasColumnName("ds_Complemento")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsContato)
                    .IsRequired()
                    .HasColumnName("ds_Contato")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsEmail)
                    .IsRequired()
                    .HasColumnName("ds_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsEndereco)
                    .IsRequired()
                    .HasColumnName("ds_Endereco")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsObservacao)
                    .HasColumnName("ds_Observacao")
                    .IsUnicode(false);

                entity.Property(e => e.DsPrestador)
                    .IsRequired()
                    .HasColumnName("ds_Prestador")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuario)
                    .IsRequired()
                    .HasColumnName("ds_usuario")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdMunicipio).HasColumnName("id_Municipio");

                entity.Property(e => e.IdTpDocumento).HasColumnName("id_TpDocumento");

                entity.Property(e => e.NrCep)
                    .IsRequired()
                    .HasColumnName("nr_Cep")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NrDocumento)
                    .IsRequired()
                    .HasColumnName("nr_Documento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrFax)
                    .IsRequired()
                    .HasColumnName("nr_Fax")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefone)
                    .IsRequired()
                    .HasColumnName("nr_Telefone")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbProduto>(entity =>
            {
                entity.HasKey(e => e.IdProduto)
                    .HasName("PK__tb_Produ__BA38A6B833DFA290");

                entity.ToTable("tb_Produto", "OMINT_SEGURADORA");

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.Property(e => e.CdCorretor).HasColumnName("cd_corretor");

                entity.Property(e => e.CdSusep)
                    .HasColumnName("cd_susep")
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.CdTpPapel).HasColumnName("cd_tp_papel");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DvPadrao)
                    .HasColumnName("dv_padrao")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdCanalVenda).HasColumnName("id_canal_venda");

                entity.Property(e => e.IdPergunta).HasColumnName("id_pergunta");

                entity.Property(e => e.IdPessoaCorretor).HasColumnName("id_pessoa_corretor");

                entity.Property(e => e.IdProducto).HasColumnName("id_producto");

                entity.Property(e => e.IdQuestionario).HasColumnName("id_questionario");

                entity.Property(e => e.IdResposta).HasColumnName("id_resposta");
            });

            modelBuilder.Entity<TbProduto1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_Produto", "PREMIUM");

                entity.Property(e => e.AtAbrangencia)
                    .IsRequired()
                    .HasColumnName("at_abrangencia")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AtAtivo)
                    .IsRequired()
                    .HasColumnName("at_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsObservacao)
                    .HasColumnName("ds_Observacao")
                    .IsUnicode(false);

                entity.Property(e => e.DsProduto)
                    .IsRequired()
                    .HasColumnName("ds_Produto")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DtVigencia)
                    .HasColumnName("dt_Vigencia")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAgencia).HasColumnName("id_Agencia");

                entity.Property(e => e.IdProduto)
                    .IsRequired()
                    .HasColumnName("id_Produto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoMoeda).HasColumnName("id_TipoMoeda");
            });

            modelBuilder.Entity<TbProdutoGruposPaises>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_Produto_GruposPaises", "PREMIUM");

                entity.Property(e => e.AtAtivo)
                    .IsRequired()
                    .HasColumnName("at_Ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.CdGruposPaises)
                    .HasColumnName("cd_GruposPaises")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdProduto)
                    .IsRequired()
                    .HasColumnName("id_Produto")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbProdutoMovimento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_Produto_Movimento", "OMINT_SEGURADORA");

                entity.Property(e => e.CdMoeda)
                    .IsRequired()
                    .HasColumnName("cd_moeda")
                    .HasMaxLength(5);

                entity.Property(e => e.CdProduto)
                    .IsRequired()
                    .HasColumnName("cd_produto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuaIncl)
                    .HasColumnName("ds_usua_incl")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DtFimVigencia)
                    .HasColumnName("dt_fim_vigencia")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtInicioVigencia)
                    .HasColumnName("dt_inicio_vigencia")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtMovimento)
                    .HasColumnName("dt_movimento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DvBagagemEspecial)
                    .HasColumnName("dv_bagagem_especial")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DvCancelamento)
                    .HasColumnName("dv_cancelamento")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DvCompraProtegida)
                    .HasColumnName("dv_compra_protegida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdMovimento)
                    .HasColumnName("id_movimento")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.Property(e => e.NrDias).HasColumnName("nr_dias");

                entity.Property(e => e.NrIdadeFinal).HasColumnName("nr_idade_final");

                entity.Property(e => e.NrIdadeInicial).HasColumnName("nr_idade_inicial");

                entity.Property(e => e.VlDolar)
                    .HasColumnName("vl_dolar")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.VlPremio)
                    .HasColumnName("vl_premio")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TbProdutoPremium>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_ProdutoPremium", "OMINT_SEGURADORA");

                entity.Property(e => e.CdProduto)
                    .IsRequired()
                    .HasColumnName("cd_produto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CdProdutoEc)
                    .HasColumnName("cd_produto_ec")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DsUsuaIncl)
                    .IsRequired()
                    .HasColumnName("ds_usua_incl")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DvBagagemEspecial)
                    .IsRequired()
                    .HasColumnName("dv_bagagem_especial")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DvCancelamento)
                    .IsRequired()
                    .HasColumnName("dv_cancelamento")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DvCompraProtegida)
                    .IsRequired()
                    .HasColumnName("dv_compra_protegida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdProduto).HasColumnName("idProduto");

                entity.Property(e => e.NrIdadeFinal).HasColumnName("nr_idade_final");

                entity.Property(e => e.NrIdadeInicial).HasColumnName("nr_idade_inicial");
            });

            modelBuilder.Entity<TbProposta>(entity =>
            {
                entity.HasKey(e => e.NrProposta)
                    .HasName("PK__tb_Propo__9905367422FFFAA8");

                entity.ToTable("tb_Proposta", "OMINT_SEGURADORA");

                entity.HasIndex(e => new { e.NrProposta, e.IdCanalVenda })
                    .HasName("ix_tb_proposta_01");

                entity.Property(e => e.NrProposta)
                    .HasColumnName("nr_proposta")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Agencia)
                    .HasColumnName("agencia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BraspagTransactionId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Canal1)
                    .HasColumnName("canal1")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Canal2)
                    .HasColumnName("canal2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CdBandeira).HasColumnName("cd_bandeira");

                entity.Property(e => e.CdBandeiraCartao)
                    .HasColumnName("cd_bandeira_cartao")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CdFormaPagamento)
                    .HasColumnName("cd_forma_pagamento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CdSexo)
                    .HasColumnName("cd_sexo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CdTpCupom)
                    .HasColumnName("cd_tp_cupom")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CdTpMovimento)
                    .HasColumnName("cd_tp_movimento")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CdUfOrigemViagem)
                    .HasColumnName("cd_uf_origem_viagem")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Comentario)
                    .HasColumnName("comentario")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuaAlte)
                    .IsRequired()
                    .HasColumnName("ds_usua_alte")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaIncl)
                    .IsRequired()
                    .HasColumnName("ds_usua_incl")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DtAssinaturaDps)
                    .HasColumnName("dt_assinatura_dps")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtCotacao)
                    .HasColumnName("dt_cotacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtFimViagem)
                    .HasColumnName("dt_fim_viagem")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtInicioViagem)
                    .HasColumnName("dt_inicio_viagem")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtNascimento)
                    .HasColumnName("dt_nascimento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtRegresso)
                    .HasColumnName("dt_regresso")
                    .HasColumnType("datetime");

                entity.Property(e => e.DvBagagemEspecial)
                    .HasColumnName("dv_bagagem_especial")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DvCompraProtegida)
                    .HasColumnName("dv_compra_protegida")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DvPossuiDps)
                    .HasColumnName("dv_possui_dps")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DvRegresso).HasColumnName("dv_regresso");

                entity.Property(e => e.IdCanalVenda)
                    .HasColumnName("id_canal_venda")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdMotivoViagem)
                    .HasColumnName("id_motivo_viagem")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdPaisDestinoViagem)
                    .HasColumnName("id_pais_destino_viagem")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Idbase)
                    .HasColumnName("idbase")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Idpoliza).HasColumnName("idpoliza");

                entity.Property(e => e.NmBairro)
                    .HasColumnName("nm_bairro")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NmCep)
                    .HasColumnName("nm_cep")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NmCidade)
                    .HasColumnName("nm_cidade")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NmComplemento)
                    .HasColumnName("nm_complemento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NmContatoEmergencia)
                    .HasColumnName("nm_contato_emergencia")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NmEmail)
                    .HasColumnName("nm_email")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NmEndereco)
                    .HasColumnName("nm_endereco")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NmPagador)
                    .HasColumnName("nm_pagador")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NmUf)
                    .HasColumnName("nm_uf")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrCpf)
                    .HasColumnName("nr_cpf")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrCupom)
                    .HasColumnName("nr_cupom")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrIdentificadorPagamento)
                    .HasColumnName("nr_identificador_pagamento")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NrRuaEndereco)
                    .HasColumnName("nr_rua_endereco")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneCelular)
                    .HasColumnName("nr_telefone_celular")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneComercial)
                    .HasColumnName("nr_telefone_comercial")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneEmergenciaCelular)
                    .HasColumnName("nr_telefone_emergencia_celular")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneEmergenciaComercial)
                    .HasColumnName("nr_telefone_emergencia_comercial")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneEmergenciaResidencial)
                    .HasColumnName("nr_telefone_emergencia_residencial")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneResidencial)
                    .HasColumnName("nr_telefone_residencial")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PeDescontoCupom)
                    .HasColumnName("pe_desconto_cupom")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.QtdeDiasViagem).HasColumnName("qtde_dias_viagem");

                entity.Property(e => e.QtdeParcelas)
                    .HasColumnName("qtde_parcelas")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VlCotacao)
                    .HasColumnName("vl_cotacao")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.VlPago)
                    .HasColumnName("vl_pago")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.VlPremio)
                    .HasColumnName("vl_premio")
                    .HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<TbPropostaBeneficiario>(entity =>
            {
                entity.HasKey(e => e.IdBeneficiario)
                    .HasName("PK__tb_Propo__35B9C95C3C74E891");

                entity.ToTable("tb_PropostaBeneficiario", "OMINT_SEGURADORA");

                entity.Property(e => e.IdBeneficiario).HasColumnName("id_beneficiario");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuaAlte)
                    .IsRequired()
                    .HasColumnName("ds_usua_alte")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaIncl)
                    .IsRequired()
                    .HasColumnName("ds_usua_incl")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DtNascimento)
                    .HasColumnName("dt_nascimento")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdParentesco)
                    .IsRequired()
                    .HasColumnName("id_parentesco")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NmBeneficiario)
                    .IsRequired()
                    .HasColumnName("nm_beneficiario")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NrCpf)
                    .IsRequired()
                    .HasColumnName("nr_cpf")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrVoucher)
                    .IsRequired()
                    .HasColumnName("nr_voucher")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeParticipacao)
                    .HasColumnName("pe_participacao")
                    .HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<TbPropostaCorretor>(entity =>
            {
                entity.HasKey(e => new { e.NrProposta, e.IdPessoaCorretor })
                    .HasName("PK__tb_Propo__9DE438BA40457975");

                entity.ToTable("tb_PropostaCorretor", "OMINT_SEGURADORA");

                entity.Property(e => e.NrProposta)
                    .HasColumnName("nr_proposta")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdPessoaCorretor).HasColumnName("id_pessoa_corretor");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuaAlte)
                    .IsRequired()
                    .HasColumnName("ds_usua_alte")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaIncl)
                    .IsRequired()
                    .HasColumnName("ds_usua_incl")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DvCorretorPrincipal)
                    .IsRequired()
                    .HasColumnName("dv_corretor_principal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbPropostaDeclaracaoSaude>(entity =>
            {
                entity.HasKey(e => e.IdDeclaracao)
                    .HasName("PK__tb_Propo__1132B26144160A59");

                entity.ToTable("tb_PropostaDeclaracaoSaude", "OMINT_SEGURADORA");

                entity.Property(e => e.IdDeclaracao).HasColumnName("id_declaracao");

                entity.Property(e => e.CdPergunta)
                    .IsRequired()
                    .HasColumnName("cd_pergunta")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuaAlte)
                    .IsRequired()
                    .HasColumnName("ds_usua_alte")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaIncl)
                    .IsRequired()
                    .HasColumnName("ds_usua_incl")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdResposta)
                    .IsRequired()
                    .HasColumnName("id_resposta")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NmComplementoResposta)
                    .HasColumnName("nm_complemento_resposta")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NrVoucher)
                    .IsRequired()
                    .HasColumnName("nr_voucher")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbPropostaRecusadaSegurado>(entity =>
            {
                entity.HasKey(e => e.IdRecusa)
                    .HasName("PK__tb_Propo__0A3ADA9347E69B3D");

                entity.ToTable("tb_PropostaRecusadaSegurado", "OMINT_SEGURADORA");

                entity.Property(e => e.IdRecusa).HasColumnName("id_recusa");

                entity.Property(e => e.DhEnvio)
                    .HasColumnName("dh_envio")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuaIncl)
                    .HasColumnName("ds_usua_incl")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NmOcorrencia)
                    .HasColumnName("nm_ocorrencia")
                    .HasColumnType("text");

                entity.Property(e => e.NrProposta)
                    .HasColumnName("nr_proposta")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrVoucher)
                    .HasColumnName("nr_voucher")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbPropostaSegurado>(entity =>
            {
                entity.HasKey(e => e.NrVoucher)
                    .HasName("PK__tb_Propo__A0D869427132C993");

                entity.ToTable("tb_PropostaSegurado", "OMINT_SEGURADORA");

                entity.HasIndex(e => new { e.NrVoucher, e.NrProposta, e.CdProduto, e.IdAgencia })
                    .HasName("ix_tb_PropostaSegurado_01");

                entity.Property(e => e.NrVoucher)
                    .HasColumnName("nr_voucher")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CdProduto)
                    .HasColumnName("cd_produto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CdSexo)
                    .HasColumnName("cd_sexo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.CpfCnpjAgencia)
                    .HasColumnName("cpf_cnpj_agencia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CpfCnpjVendedor)
                    .HasColumnName("cpf_cnpj_vendedor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhCancelamento)
                    .HasColumnName("dh_cancelamento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInicioExtensao)
                    .HasColumnName("dh_inicio_extensao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhRetornoApolice)
                    .HasColumnName("dh_retorno_apolice")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhTerminoExtensao)
                    .HasColumnName("dh_termino_extensao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsFile)
                    .HasColumnName("ds_file")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DsPaisDestinoViagem)
                    .HasColumnName("ds_pais_destino_viagem")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsPathArquivoPdf)
                    .HasColumnName("ds_PathArquivoPDF")
                    .IsUnicode(false);

                entity.Property(e => e.DsProduto)
                    .HasColumnName("ds_produto")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlte)
                    .IsRequired()
                    .HasColumnName("ds_usua_alte")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaIncl)
                    .IsRequired()
                    .HasColumnName("ds_usua_incl")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DtNascimento)
                    .HasColumnName("dt_nascimento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DvBagagemEspecial)
                    .HasColumnName("dv_bagagem_especial")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DvCancelamento)
                    .IsRequired()
                    .HasColumnName("dv_cancelamento")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DvCompraProtegida)
                    .HasColumnName("dv_compra_protegida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DvPpe)
                    .HasColumnName("dv_ppe")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.IdPaisDestinoViagem)
                    .HasColumnName("id_pais_destino_viagem")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdParentescoPpe)
                    .HasColumnName("id_parentesco_ppe")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdVendedor).HasColumnName("id_vendedor");

                entity.Property(e => e.NmBairro)
                    .HasColumnName("nm_bairro")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NmCep)
                    .HasColumnName("nm_cep")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NmCidade)
                    .HasColumnName("nm_cidade")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NmComplemento)
                    .HasColumnName("nm_complemento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NmEmail)
                    .HasColumnName("nm_email")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NmEndereco)
                    .HasColumnName("nm_endereco")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NmSegurado)
                    .HasColumnName("nm_segurado")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NmUf)
                    .HasColumnName("nm_uf")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrApolice)
                    .HasColumnName("nr_apolice")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NrCpf)
                    .HasColumnName("nr_cpf")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrIdadeFinal).HasColumnName("nr_idade_final");

                entity.Property(e => e.NrIdadeInicial).HasColumnName("nr_idade_inicial");

                entity.Property(e => e.NrProposta)
                    .IsRequired()
                    .HasColumnName("nr_proposta")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrRuaEndereco)
                    .HasColumnName("nr_rua_endereco")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneCelular)
                    .HasColumnName("nr_telefone_celular")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneComercial)
                    .HasColumnName("nr_telefone_comercial")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneResidencial)
                    .HasColumnName("nr_telefone_residencial")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.VlExtensao)
                    .HasColumnName("vl_extensao")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.VlPremioBruto)
                    .HasColumnName("vl_premio_bruto")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.VlPremioLiquido)
                    .HasColumnName("vl_premio_liquido")
                    .HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<TbRecebimentoSegurado>(entity =>
            {
                entity.HasKey(e => new { e.NrVoucher, e.NrParcela })
                    .HasName("PK__tb_Receb__88D0FD2843ABF605");

                entity.ToTable("tb_RecebimentoSegurado", "OMINT_SEGURADORA");

                entity.Property(e => e.NrVoucher)
                    .HasColumnName("nr_voucher")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrParcela).HasColumnName("nr_parcela");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuaAlte)
                    .HasColumnName("ds_usua_alte")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaIncl)
                    .HasColumnName("ds_usua_incl")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DtRecebimento)
                    .HasColumnName("dt_recebimento")
                    .HasColumnType("datetime");

                entity.Property(e => e.VlPago)
                    .HasColumnName("vl_pago")
                    .HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<TbServicoCargaPreco>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_Servico_Carga_Preco", "OMINT_SEGURADORA");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuaIncl)
                    .IsRequired()
                    .HasColumnName("ds_usua_incl")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DtControle)
                    .HasColumnName("dt_controle")
                    .HasColumnType("datetime");

                entity.Property(e => e.StControle)
                    .IsRequired()
                    .HasColumnName("st_controle")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbStatusLiquidacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_StatusLiquidacao", "PREMIUM");

                entity.Property(e => e.DsStatus)
                    .IsRequired()
                    .HasColumnName("ds_Status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdStatus).HasColumnName("id_Status");
            });

            modelBuilder.Entity<TbTipoAbrangencia>(entity =>
            {
                entity.HasKey(e => e.IdTipoAbrangencia);

                entity.ToTable("tb_TipoAbrangencia", "PREMIUM");

                entity.Property(e => e.IdTipoAbrangencia).HasColumnName("id_TipoAbrangencia");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsTipoAbrangencia)
                    .IsRequired()
                    .HasColumnName("ds_TipoAbrangencia")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbTipoAssistencia>(entity =>
            {
                entity.HasKey(e => e.IdTipoAssistencia);

                entity.ToTable("tb_TipoAssistencia", "PREMIUM");

                entity.Property(e => e.IdTipoAssistencia).HasColumnName("id_TipoAssistencia");

                entity.Property(e => e.AtLimite)
                    .IsRequired()
                    .HasColumnName("at_Limite")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AtStatus)
                    .IsRequired()
                    .HasColumnName("at_Status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AtTipoAssistencia)
                    .IsRequired()
                    .HasColumnName("at_TipoAssistencia")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsTipoAssistencia)
                    .IsRequired()
                    .HasColumnName("ds_TipoAssistencia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsTipoAssistenciaEn)
                    .HasColumnName("ds_TipoAssistenciaEn")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbTipoContatoComunicacao>(entity =>
            {
                entity.HasKey(e => e.IdContatoComunicacao)
                    .HasName("PK_tb_IAG_ContatoComunicacao");

                entity.ToTable("tb_TipoContatoComunicacao", "PREMIUM");

                entity.Property(e => e.IdContatoComunicacao).HasColumnName("id_ContatoComunicacao");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsContatoComunicacao)
                    .IsRequired()
                    .HasColumnName("ds_ContatoComunicacao")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbTipoDemanda>(entity =>
            {
                entity.HasKey(e => e.IdTipoDemanda);

                entity.ToTable("tb_TipoDemanda", "PREMIUM");

                entity.Property(e => e.IdTipoDemanda).HasColumnName("id_TipoDemanda");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsTipoDemanda)
                    .IsRequired()
                    .HasColumnName("ds_TipoDemanda")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbTipoDocumento>(entity =>
            {
                entity.HasKey(e => e.IdTipoDocumento);

                entity.ToTable("tb_TipoDocumento", "PREMIUM");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("id_TipoDocumento");

                entity.Property(e => e.CdTipoDocumento)
                    .IsRequired()
                    .HasColumnName("cd_TipoDocumento")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsTipoDocumento)
                    .IsRequired()
                    .HasColumnName("ds_TipoDocumento")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbTipoDocumentoCaso>(entity =>
            {
                entity.HasKey(e => e.IdTipoDocumento);

                entity.ToTable("tb_TipoDocumentoCaso", "PREMIUM");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("id_TipoDocumento");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsTipoDocumento)
                    .IsRequired()
                    .HasColumnName("ds_TipoDocumento")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbTipoEventoComunicacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_TipoEventoComunicacao", "PREMIUM");

                entity.Property(e => e.AtComplemento)
                    .IsRequired()
                    .HasColumnName("at_Complemento")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AtLimite)
                    .IsRequired()
                    .HasColumnName("at_Limite")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AtTipoAssistencia)
                    .IsRequired()
                    .HasColumnName("at_TipoAssistencia")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsEventoComunicacao)
                    .IsRequired()
                    .HasColumnName("ds_EventoComunicacao")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEventoComunicacao).HasColumnName("id_EventoComunicacao");
            });

            modelBuilder.Entity<TbTipoLimite>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_TipoLimite", "PREMIUM");

                entity.Property(e => e.CdLinhaProduto)
                    .IsRequired()
                    .HasColumnName("cd_LinhaProduto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CdTipoProduto)
                    .IsRequired()
                    .HasColumnName("cd_TipoProduto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsTipoLimite)
                    .IsRequired()
                    .HasColumnName("ds_TipoLimite")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DtFim)
                    .HasColumnName("dt_fim")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtInicio)
                    .HasColumnName("dt_Inicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdTipoAbrangencia).HasColumnName("id_TipoAbrangencia");

                entity.Property(e => e.IdTipoLimite).HasColumnName("id_TipoLimite");

                entity.Property(e => e.IdTipoMoeda).HasColumnName("id_TipoMoeda");

                entity.Property(e => e.QtLimite).HasColumnName("qt_Limite");

                entity.Property(e => e.VlLimite).HasColumnName("vl_Limite");
            });

            modelBuilder.Entity<TbTipoMoeda>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_TipoMoeda", "PREMIUM");

                entity.Property(e => e.CdTipoMoeda)
                    .HasColumnName("cd_TipoMoeda")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsPais)
                    .IsRequired()
                    .HasColumnName("ds_Pais")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsTipoMoeda)
                    .IsRequired()
                    .HasColumnName("ds_TipoMoeda")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoMoeda).HasColumnName("id_TipoMoeda");
            });

            modelBuilder.Entity<TbTipoServico>(entity =>
            {
                entity.HasKey(e => e.IdTpServico);

                entity.ToTable("tb_TipoServico", "PREMIUM");

                entity.Property(e => e.IdTpServico).HasColumnName("id_TpServico");

                entity.Property(e => e.AtAtivo)
                    .IsRequired()
                    .HasColumnName("at_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsTpServico)
                    .IsRequired()
                    .HasColumnName("ds_TpServico")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuario)
                    .IsRequired()
                    .HasColumnName("ds_usuario")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdCobertura)
                    .IsRequired()
                    .HasColumnName("id_Cobertura")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbTpAlerta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_TpAlerta", "PREMIUM");

                entity.Property(e => e.AtAvisoRecorrente)
                    .IsRequired()
                    .HasColumnName("at_AvisoRecorrente")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DsTpAlerta)
                    .IsRequired()
                    .HasColumnName("ds_TpAlerta")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdTpAlerta)
                    .IsRequired()
                    .HasColumnName("id_TpAlerta")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TbTpContato>(entity =>
            {
                entity.HasKey(e => e.IdTpContato);

                entity.ToTable("tb_TpContato", "PREMIUM");

                entity.Property(e => e.IdTpContato).HasColumnName("id_TpContato");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsTpContato)
                    .IsRequired()
                    .HasColumnName("ds_TpContato")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbTpServicoCobertura>(entity =>
            {
                entity.HasKey(e => new { e.IdTpServico, e.IdCobertura });

                entity.ToTable("tb_TpServicoCobertura", "PREMIUM");

                entity.Property(e => e.IdTpServico).HasColumnName("id_TpServico");

                entity.Property(e => e.IdCobertura)
                    .HasColumnName("id_Cobertura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbUf>(entity =>
            {
                entity.HasKey(e => e.IdUf);

                entity.ToTable("tb_UF", "PREMIUM");

                entity.Property(e => e.IdUf).HasColumnName("id_Uf");

                entity.Property(e => e.CdPais)
                    .IsRequired()
                    .HasColumnName("cd_Pais")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUf)
                    .IsRequired()
                    .HasColumnName("ds_UF")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbValorMoeda>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_ValorMoeda", "PREMIUM");

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_Alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsUsuaAlteracao)
                    .IsRequired()
                    .HasColumnName("ds_UsuaAlteracao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DtBase)
                    .HasColumnName("dt_Base")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdTipoMoeda).HasColumnName("id_TipoMoeda");

                entity.Property(e => e.VlDolar).HasColumnName("vl_Dolar");

                entity.Property(e => e.VlMoeda).HasColumnName("vl_Moeda");
            });

            modelBuilder.Entity<TbVoucher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_Voucher", "PREMIUM");

                entity.Property(e => e.AtAtivo)
                    .IsRequired()
                    .HasColumnName("at_ativo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DhAlteracao)
                    .HasColumnName("dh_alteracao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsCliente)
                    .IsRequired()
                    .HasColumnName("ds_Cliente")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsComplemento)
                    .IsRequired()
                    .HasColumnName("ds_Complemento")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsContatoEmergencia)
                    .HasColumnName("ds_ContatoEmergencia")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsEmailCliente)
                    .HasColumnName("ds_EmailCliente")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsEndereco)
                    .IsRequired()
                    .HasColumnName("ds_Endereco")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsInativacao)
                    .HasColumnName("ds_Inativacao")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DsPathArquivoPdf)
                    .HasColumnName("ds_PathArquivoPDF")
                    .IsUnicode(false);

                entity.Property(e => e.DsUsuario)
                    .IsRequired()
                    .HasColumnName("ds_usuario")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DtCancelamento)
                    .HasColumnName("dt_Cancelamento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtContratacao)
                    .HasColumnName("dt_Contratacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtInativacao)
                    .HasColumnName("dt_Inativacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtInicioVigencia)
                    .HasColumnName("dt_InicioVigencia")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtValidade)
                    .HasColumnName("dt_Validade")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdMunicipio).HasColumnName("id_Municipio");

                entity.Property(e => e.IdOrdemPagamento)
                    .HasColumnName("id_OrdemPagamento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdProduto)
                    .IsRequired()
                    .HasColumnName("id_Produto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdTpDocumento).HasColumnName("id_TpDocumento");

                entity.Property(e => e.NrDocumento)
                    .HasColumnName("nr_Documento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneEmergencia)
                    .HasColumnName("nr_TelefoneEmergencia")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NrVoucher)
                    .IsRequired()
                    .HasColumnName("nr_Voucher")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VlVoucher)
                    .HasColumnName("vl_Voucher")
                    .HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<TbVoucherErro>(entity =>
            {
                entity.HasKey(e => e.IdVoucherErro)
                    .HasName("PK__tb_Vouch__B78AA32C0D64F3ED");

                entity.ToTable("tb_VoucherErro", "PREMIUM");

                entity.Property(e => e.IdVoucherErro).HasColumnName("id_VoucherErro");

                entity.Property(e => e.DsMensagemErro)
                    .HasColumnName("ds_MensagemErro")
                    .IsUnicode(false);

                entity.Property(e => e.DtErro)
                    .HasColumnName("dt_Erro")
                    .HasColumnType("datetime");

                entity.Property(e => e.NrVoucher)
                    .IsRequired()
                    .HasColumnName("nr_Voucher")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbVoucherExterno>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_VoucherExterno", "PREMIUM");

                entity.Property(e => e.DsInformativoRetorno)
                    .HasColumnName("ds_InformativoRetorno")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.NrVoucherExterno)
                    .IsRequired()
                    .HasColumnName("nr_VoucherExterno")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Teste1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("teste1");

                entity.Property(e => e.Coluna1)
                    .HasColumnName("coluna1")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Teste2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("teste2");

                entity.Property(e => e.Coluna1)
                    .HasColumnName("coluna1")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwApoliceCrm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ApoliceCRM", "OMINT_SEGURADORA");

                entity.Property(e => e.CdCorretor).HasColumnName("cd_corretor");

                entity.Property(e => e.CdRepresentante).HasColumnName("cd_representante");

                entity.Property(e => e.CdVendedor).HasColumnName("cd_vendedor");

                entity.Property(e => e.CpfCnpjCorretor)
                    .HasColumnName("cpf_cnpj_corretor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CpfCnpjRepresentante)
                    .HasColumnName("cpf_cnpj_representante")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CpfCnpjVendedor)
                    .HasColumnName("cpf_cnpj_vendedor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsFile)
                    .HasColumnName("ds_file")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DsPaisDestinoViagem)
                    .HasColumnName("ds_pais_destino_viagem")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsProduto)
                    .HasColumnName("ds_produto")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DtEmissao)
                    .HasColumnName("dt_emissao")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DtFimViagem)
                    .HasColumnName("dt_fim_viagem")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DtInicioViagem)
                    .HasColumnName("dt_inicio_viagem")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NmSegurado)
                    .HasColumnName("nm_segurado")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NrApolice).HasColumnName("nr_apolice");

                entity.Property(e => e.NrBilhete)
                    .HasColumnName("nr_bilhete")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NrCpf)
                    .HasColumnName("nr_cpf")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PeDesconto)
                    .HasColumnName("pe_desconto")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.VlCotacao)
                    .HasColumnName("vl_cotacao")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.VlPremio)
                    .HasColumnName("vl_premio")
                    .HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<VwBilhetesEmitidos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_bilhetes_emitidos");

                entity.Property(e => e.CdProduto)
                    .HasColumnName("cd_produto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.DtArquivo)
                    .HasColumnName("dt_arquivo")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtCancelamento)
                    .HasColumnName("dt_cancelamento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtCotacao)
                    .HasColumnName("dt_cotacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtFimViagem)
                    .HasColumnName("dt_fim_viagem")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtInicioViagem)
                    .HasColumnName("dt_inicio_viagem")
                    .HasColumnType("datetime");

                entity.Property(e => e.NmCorretor)
                    .HasColumnName("nm_corretor")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NmSegurado)
                    .HasColumnName("nm_segurado")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NrCpf)
                    .HasColumnName("nr_cpf")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrVoucher)
                    .IsRequired()
                    .HasColumnName("nr_voucher")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Operacao)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Tgi).HasColumnName("TGI");

                entity.Property(e => e.Tgp).HasColumnName("TGP");

                entity.Property(e => e.VlPremioLiquido)
                    .HasColumnName("vl_premio_liquido")
                    .HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<VwCasos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Casos");

                entity.Property(e => e.Cobertura)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DataDeAbertura)
                    .HasColumnName("Data de Abertura")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataDeContratação)
                    .HasColumnName("Data de Contratação")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataDeEncerramento)
                    .HasColumnName("Data de Encerramento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataDeNascimento)
                    .HasColumnName("Data de Nascimento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataFinalDaVigência)
                    .HasColumnName("Data Final da Vigência")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInicialDaVigência)
                    .HasColumnName("Data Inicial da Vigência")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsAssistenciaRequerida)
                    .HasColumnName("ds_AssistenciaRequerida")
                    .IsUnicode(false);

                entity.Property(e => e.DsNaturezaProblema)
                    .HasColumnName("ds_NaturezaProblema")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsPrestador)
                    .HasColumnName("ds_Prestador")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DtPagamento)
                    .HasColumnName("dt_Pagamento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtRegistro)
                    .HasColumnName("dt_Registro")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtVencimento)
                    .HasColumnName("dt_Vencimento")
                    .HasColumnType("datetime");

                entity.Property(e => e.EstadoDeDestino)
                    .HasColumnName("Estado de Destino")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IdBeneficiario)
                    .HasColumnName("id_Beneficiario")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.LimiteDaCobertura)
                    .HasColumnName("Limite da Cobertura")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Moeda)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomeDoBeneficiário)
                    .IsRequired()
                    .HasColumnName("Nome do Beneficiário")
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.NrGop).HasColumnName("nr_Gop");

                entity.Property(e => e.NrNotaFiscal)
                    .HasColumnName("nr_NotaFiscal")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumerodoVoucher)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaisDoBeneficiário)
                    .HasColumnName("Pais do Beneficiário")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PaísDeDestino)
                    .HasColumnName("País de Destino")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ProdutoContratado)
                    .IsRequired()
                    .HasColumnName("Produto Contratado")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDeCaso)
                    .IsRequired()
                    .HasColumnName("Tipo de Caso")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAutorizado).HasColumnName("Total Autorizado");

                entity.Property(e => e.TotalUtilizado).HasColumnName("Total Utilizado");

                entity.Property(e => e.VlDespesas)
                    .HasColumnName("vl_Despesas")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VlPago)
                    .HasColumnName("vl_Pago")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VlTaxa)
                    .HasColumnName("vl_Taxa")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VwPrecificacaoPorCasos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PrecificacaoPorCasos");

                entity.Property(e => e.Cobertura)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DataDeAbertura)
                    .HasColumnName("Data de Abertura")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataDeContratação)
                    .HasColumnName("Data de Contratação")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataDeEncerramento)
                    .HasColumnName("Data de Encerramento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataDeNascimento)
                    .HasColumnName("Data de Nascimento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataFinalDaVigência)
                    .HasColumnName("Data Final da Vigência")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataInicialDaVigência)
                    .HasColumnName("Data Inicial da Vigência")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsAssistenciaRequerida)
                    .HasColumnName("ds_AssistenciaRequerida")
                    .IsUnicode(false);

                entity.Property(e => e.DsNaturezaProblema)
                    .HasColumnName("ds_NaturezaProblema")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DsPrestador)
                    .HasColumnName("ds_Prestador")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DtPagamento)
                    .HasColumnName("dt_Pagamento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtRegistro)
                    .HasColumnName("dt_Registro")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtVencimento)
                    .HasColumnName("dt_Vencimento")
                    .HasColumnType("datetime");

                entity.Property(e => e.EstadoDeDestino)
                    .IsRequired()
                    .HasColumnName("Estado de Destino")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdBeneficiario)
                    .HasColumnName("id_Beneficiario")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.LimiteDaCobertura)
                    .HasColumnName("Limite da Cobertura")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Moeda)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MunicípioDeDestino)
                    .HasColumnName("Município de Destino")
                    .IsUnicode(false);

                entity.Property(e => e.NomeDoBeneficiário)
                    .IsRequired()
                    .HasColumnName("Nome do Beneficiário")
                    .HasMaxLength(251)
                    .IsUnicode(false);

                entity.Property(e => e.NrGop).HasColumnName("nr_Gop");

                entity.Property(e => e.NrNotaFiscal)
                    .HasColumnName("nr_NotaFiscal")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumerodoVoucher)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaisDoBeneficiário)
                    .HasColumnName("Pais do Beneficiário")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PaísDeDestino)
                    .IsRequired()
                    .HasColumnName("País de Destino")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ProdutoContratado)
                    .IsRequired()
                    .HasColumnName("Produto Contratado")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDeCaso)
                    .IsRequired()
                    .HasColumnName("Tipo de Caso")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAutorizado).HasColumnName("Total Autorizado");

                entity.Property(e => e.TotalUtilizado).HasColumnName("Total Utilizado");

                entity.Property(e => e.VlDespesas)
                    .HasColumnName("vl_Despesas")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VlPago)
                    .HasColumnName("vl_Pago")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VlTaxa)
                    .HasColumnName("vl_Taxa")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VwPropostaApolice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PropostaApolice", "OMINT_SEGURADORA");

                entity.Property(e => e.CdBandeira).HasColumnName("cd_bandeira");

                entity.Property(e => e.CdFormaPagamento)
                    .HasColumnName("cd_forma_pagamento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CdPergunta)
                    .HasColumnName("cd_pergunta")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CdProduto)
                    .HasColumnName("cd_produto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CdSexoPagador)
                    .IsRequired()
                    .HasColumnName("cd_sexo_pagador")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CdSexoSegurado)
                    .IsRequired()
                    .HasColumnName("cd_sexo_segurado")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CdTpCupom)
                    .HasColumnName("cd_tp_cupom")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CdTpMovimento)
                    .IsRequired()
                    .HasColumnName("cd_tp_movimento")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CdTpPapel).HasColumnName("cd_tp_papel");

                entity.Property(e => e.CdUfOrigemViagem)
                    .HasColumnName("cd_uf_origem_viagem")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Comentario)
                    .HasColumnName("comentario")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DhRetornoApolice)
                    .HasColumnName("dh_retorno_apolice")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsPatharquivopdf)
                    .HasColumnName("ds_patharquivopdf")
                    .IsUnicode(false);

                entity.Property(e => e.DtAssinaturaDps)
                    .HasColumnName("dt_assinatura_dps")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtCotacao)
                    .HasColumnName("dt_cotacao")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DtFimViagem)
                    .HasColumnName("dt_fim_viagem")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DtInicioViagem)
                    .HasColumnName("dt_inicio_viagem")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DtNascimento)
                    .HasColumnName("dt_nascimento")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DtNascimentoPagador)
                    .HasColumnName("dt_nascimento_pagador")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DtNascimentoSegurado)
                    .HasColumnName("dt_nascimento_segurado")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DtRegresso)
                    .HasColumnName("dt_regresso")
                    .HasColumnType("datetime");

                entity.Property(e => e.DvBagagemEspecial)
                    .IsRequired()
                    .HasColumnName("dv_bagagem_especial")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DvCancelamento)
                    .IsRequired()
                    .HasColumnName("dv_cancelamento")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DvCompraProtegida)
                    .IsRequired()
                    .HasColumnName("dv_compra_protegida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DvCorretorPrincipal)
                    .IsRequired()
                    .HasColumnName("dv_corretor_principal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DvPossuiDps)
                    .HasColumnName("dv_possui_dps")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DvPpe)
                    .HasColumnName("dv_ppe")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DvRegresso).HasColumnName("dv_regresso");

                entity.Property(e => e.IdCanalVenda).HasColumnName("id_canal_venda");

                entity.Property(e => e.IdMotivoViagem)
                    .HasColumnName("id_motivo_viagem")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdPaisDestinoViagem)
                    .HasColumnName("id_pais_destino_viagem")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdParentesco)
                    .HasColumnName("id_parentesco")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdParentescoPpe)
                    .HasColumnName("id_parentesco_ppe")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdPessoaCorretor).HasColumnName("id_pessoa_corretor");

                entity.Property(e => e.IdResposta)
                    .HasColumnName("id_resposta")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NmAgencia)
                    .HasColumnName("nm_agencia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NmBairro)
                    .HasColumnName("nm_bairro")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NmBeneficiario)
                    .HasColumnName("nm_beneficiario")
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.NmCanalVendas2)
                    .HasColumnName("nm_canal_vendas2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NmCep)
                    .HasColumnName("nm_cep")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NmCidade)
                    .HasColumnName("nm_cidade")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NmComplemento)
                    .HasColumnName("nm_complemento")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NmComplementoResposta)
                    .HasColumnName("nm_complemento_resposta")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.NmContatoEmergencia)
                    .HasColumnName("nm_contato_emergencia")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NmEmail)
                    .HasColumnName("nm_email")
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.NmEndereco)
                    .HasColumnName("nm_endereco")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NmPagador)
                    .HasColumnName("nm_pagador")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NmSegurado)
                    .HasColumnName("nm_segurado")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NmUf)
                    .HasColumnName("nm_uf")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NmUsuario)
                    .HasColumnName("nm_usuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrApolice)
                    .HasColumnName("nr_apolice")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NrCobranca)
                    .HasColumnName("nr_cobranca")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrCpf)
                    .HasColumnName("nr_cpf")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NrCpfPagador)
                    .HasColumnName("nr_cpf_pagador")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NrCpfSegurado)
                    .HasColumnName("nr_cpf_segurado")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NrCupom)
                    .HasColumnName("nr_cupom")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrIdentificadorPagamento)
                    .HasColumnName("nr_identificador_pagamento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrPedido)
                    .IsRequired()
                    .HasColumnName("nr_pedido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrProposta)
                    .IsRequired()
                    .HasColumnName("nr_proposta")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrRuaEndereco)
                    .HasColumnName("nr_rua_endereco")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneCelular)
                    .HasColumnName("nr_telefone_celular")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneCelularPagador)
                    .HasColumnName("nr_telefone_celular_pagador")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneComercial)
                    .HasColumnName("nr_telefone_comercial")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneEmergenciaCelular)
                    .HasColumnName("nr_telefone_emergencia_celular")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneEmergenciaComercial)
                    .HasColumnName("nr_telefone_emergencia_comercial")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneEmergenciaResidencial)
                    .HasColumnName("nr_telefone_emergencia_residencial")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneResidencial)
                    .HasColumnName("nr_telefone_residencial")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneResidencialPagador)
                    .HasColumnName("nr_telefone_residencial_pagador")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.PeComissao)
                    .HasColumnName("pe_comissao")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.PeDescontoCupom)
                    .HasColumnName("pe_desconto_cupom")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PeParticipacaoBeneficiario)
                    .HasColumnName("pe_participacao_beneficiario")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PeParticipacaoCorretor)
                    .IsRequired()
                    .HasColumnName("pe_participacao_corretor")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.QtdeDiasViagem).HasColumnName("qtde_dias_viagem");

                entity.Property(e => e.QtdeParcelas)
                    .HasColumnName("qtde_parcelas")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TpOperacao)
                    .HasColumnName("tp_operacao")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VlCotacao)
                    .HasColumnName("vl_cotacao")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.VlPago)
                    .HasColumnName("vl_pago")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.VlPremio)
                    .HasColumnName("vl_premio")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.VlPremioBruto)
                    .HasColumnName("vl_premio_bruto")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.VlPremioLiquido)
                    .HasColumnName("vl_premio_liquido")
                    .HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<VwPropostaApoliceTeste>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PropostaApolice_teste", "OMINT_SEGURADORA");

                entity.Property(e => e.CdBandeira).HasColumnName("cd_bandeira");

                entity.Property(e => e.CdFormaPagamento)
                    .HasColumnName("cd_forma_pagamento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CdPergunta)
                    .HasColumnName("cd_pergunta")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CdProduto)
                    .HasColumnName("cd_produto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CdSexoPagador)
                    .IsRequired()
                    .HasColumnName("cd_sexo_pagador")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CdSexoSegurado)
                    .IsRequired()
                    .HasColumnName("cd_sexo_segurado")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CdTpCupom)
                    .HasColumnName("cd_tp_cupom")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CdTpMovimento)
                    .IsRequired()
                    .HasColumnName("cd_tp_movimento")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CdTpPapel).HasColumnName("cd_tp_papel");

                entity.Property(e => e.CdUfOrigemViagem)
                    .HasColumnName("cd_uf_origem_viagem")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DhRetornoApolice)
                    .HasColumnName("dh_retorno_apolice")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsPatharquivopdf)
                    .HasColumnName("ds_patharquivopdf")
                    .IsUnicode(false);

                entity.Property(e => e.DtAssinaturaDps)
                    .HasColumnName("dt_assinatura_dps")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtCotacao)
                    .HasColumnName("dt_cotacao")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DtFimViagem)
                    .HasColumnName("dt_fim_viagem")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DtInicioViagem)
                    .HasColumnName("dt_inicio_viagem")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DtNascimento)
                    .HasColumnName("dt_nascimento")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DtNascimentoPagador)
                    .HasColumnName("dt_nascimento_pagador")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DtNascimentoSegurado)
                    .HasColumnName("dt_nascimento_segurado")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DvBagagemEspecial)
                    .IsRequired()
                    .HasColumnName("dv_bagagem_especial")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DvCancelamento)
                    .IsRequired()
                    .HasColumnName("dv_cancelamento")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DvCompraProtegida)
                    .IsRequired()
                    .HasColumnName("dv_compra_protegida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DvCorretorPrincipal)
                    .IsRequired()
                    .HasColumnName("dv_corretor_principal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DvPossuiDps)
                    .HasColumnName("dv_possui_dps")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DvPpe)
                    .HasColumnName("dv_ppe")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCanalVenda).HasColumnName("id_canal_venda");

                entity.Property(e => e.IdMotivoViagem)
                    .HasColumnName("id_motivo_viagem")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdPaisDestinoViagem)
                    .HasColumnName("id_pais_destino_viagem")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdParentesco)
                    .HasColumnName("id_parentesco")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdParentescoPpe)
                    .HasColumnName("id_parentesco_ppe")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdPessoaCorretor).HasColumnName("id_pessoa_corretor");

                entity.Property(e => e.IdResposta)
                    .HasColumnName("id_resposta")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NmBairro)
                    .HasColumnName("nm_bairro")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NmBeneficiario)
                    .HasColumnName("nm_beneficiario")
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.NmCidade)
                    .HasColumnName("nm_cidade")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NmComplemento)
                    .HasColumnName("nm_complemento")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NmComplementoResposta)
                    .HasColumnName("nm_complemento_resposta")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.NmContatoEmergencia)
                    .HasColumnName("nm_contato_emergencia")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NmEmail)
                    .HasColumnName("nm_email")
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.NmEndereco)
                    .HasColumnName("nm_endereco")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NmPagador)
                    .HasColumnName("nm_pagador")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NmSegurado)
                    .HasColumnName("nm_segurado")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NmUf)
                    .HasColumnName("nm_uf")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NrApolice)
                    .HasColumnName("nr_apolice")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NrCobranca)
                    .HasColumnName("nr_cobranca")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrCpf)
                    .HasColumnName("nr_cpf")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NrCpfPagador)
                    .HasColumnName("nr_cpf_pagador")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NrCpfSegurado)
                    .HasColumnName("nr_cpf_segurado")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NrCupom)
                    .HasColumnName("nr_cupom")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrIdentificadorPagamento)
                    .HasColumnName("nr_identificador_pagamento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrPedido)
                    .IsRequired()
                    .HasColumnName("nr_pedido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrProposta)
                    .IsRequired()
                    .HasColumnName("nr_proposta")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrRuaEndereco)
                    .HasColumnName("nr_rua_endereco")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneCelular)
                    .HasColumnName("nr_telefone_celular")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneCelularPagador)
                    .HasColumnName("nr_telefone_celular_pagador")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneComercial)
                    .HasColumnName("nr_telefone_comercial")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneEmergenciaCelular)
                    .HasColumnName("nr_telefone_emergencia_celular")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneEmergenciaComercial)
                    .HasColumnName("nr_telefone_emergencia_comercial")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneEmergenciaResidencial)
                    .HasColumnName("nr_telefone_emergencia_residencial")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneResidencial)
                    .HasColumnName("nr_telefone_residencial")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneResidencialPagador)
                    .HasColumnName("nr_telefone_residencial_pagador")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.PeComissao)
                    .HasColumnName("pe_comissao")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.PeDescontoCupom)
                    .HasColumnName("pe_desconto_cupom")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PeParticipacaoBeneficiario)
                    .HasColumnName("pe_participacao_beneficiario")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PeParticipacaoCorretor)
                    .IsRequired()
                    .HasColumnName("pe_participacao_corretor")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.QtdeDiasViagem).HasColumnName("qtde_dias_viagem");

                entity.Property(e => e.QtdeParcelas)
                    .HasColumnName("qtde_parcelas")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TpOperacao)
                    .HasColumnName("tp_operacao")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VlCotacao)
                    .HasColumnName("vl_cotacao")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.VlPago)
                    .HasColumnName("vl_pago")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.VlPremio)
                    .HasColumnName("vl_premio")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.VlPremioBruto)
                    .HasColumnName("vl_premio_bruto")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.VlPremioLiquido)
                    .HasColumnName("vl_premio_liquido")
                    .HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<VwValorMoeda>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ValorMoeda");

                entity.Property(e => e.CdTipoMoeda)
                    .HasColumnName("cd_TipoMoeda")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DsTipoMoeda)
                    .IsRequired()
                    .HasColumnName("ds_TipoMoeda")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DtBase)
                    .HasColumnName("dt_Base")
                    .HasColumnType("datetime");

                entity.Property(e => e.TpMoeda)
                    .HasColumnName("tp_Moeda")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VlMoeda).HasColumnName("vl_Moeda");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
