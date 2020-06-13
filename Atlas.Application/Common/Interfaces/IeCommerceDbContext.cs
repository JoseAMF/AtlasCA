﻿using Atlas.Domain.Entities.eCommerce;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Common.Interfaces
{
    public interface IeCommerceDbContext
    {

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DbSet<PareportAtlas> PareportAtlas { get; set; }
        DbSet<AmiPoSugerencias> AmiPoSugerencias { get; set; }
        DbSet<AmivBsCompanias> AmivBsCompanias { get; set; }
        DbSet<AmivBsCuitspaises> AmivBsCuitspaises { get; set; }
        DbSet<AmivCoAgenciaMarkupProducto> AmivCoAgenciaMarkupProducto { get; set; }
        DbSet<AmivCoAgencias> AmivCoAgencias { get; set; }
        DbSet<AmivCoAgenciasEcommerce> AmivCoAgenciasEcommerce { get; set; }
        DbSet<AmivCoClientes> AmivCoClientes { get; set; }
        DbSet<AmivCoPromotores> AmivCoPromotores { get; set; }
        DbSet<AmivCoRelacionProductoModalidad> AmivCoRelacionProductoModalidad { get; set; }
        DbSet<AmivCoRelacionTipoClienteModalidadProducto> AmivCoRelacionTipoClienteModalidadProducto { get; set; }
        DbSet<AmivCoVendedoresAgencias> AmivCoVendedoresAgencias { get; set; }
        DbSet<AmivMiCorresponsales> AmivMiCorresponsales { get; set; }
        DbSet<AmivMiEmpresas> AmivMiEmpresas { get; set; }
        DbSet<AmivPePersonaFisica> AmivPePersonaFisica { get; set; }
        DbSet<AmivPePersonasFisicas> AmivPePersonasFisicas { get; set; }
        DbSet<AmivPePersonasFisicasCompleto> AmivPePersonasFisicasCompleto { get; set; }
        DbSet<AmivPoBeneficiariosPoliza> AmivPoBeneficiariosPoliza { get; set; }
        DbSet<AmivPoBilhetesVigentes> AmivPoBilhetesVigentes { get; set; }
        DbSet<AmivPoConsultaDeVouchers> AmivPoConsultaDeVouchers { get; set; }
        DbSet<AmivPoPolizas> AmivPoPolizas { get; set; }
        DbSet<AmivPrProductoDestino> AmivPrProductoDestino { get; set; }
        DbSet<AmivPrProductoServicios> AmivPrProductoServicios { get; set; }
        DbSet<AmivPrProductodestino1> AmivPrProductodestino1 { get; set; }
        DbSet<AmivPrProductoprecio> AmivPrProductoprecio { get; set; }
        DbSet<AmivPrProductosAdicionales> AmivPrProductosAdicionales { get; set; }
        DbSet<AmivPrProductosagencias> AmivPrProductosagencias { get; set; }
        DbSet<AmivVouchersAce> AmivVouchersAce { get; set; }
        DbSet<BsCiudades> BsCiudades { get; set; }
        DbSet<BsCodigosDocumentosPagoOnline> BsCodigosDocumentosPagoOnline { get; set; }
        DbSet<BsCodigosTarjetasPagoOnline> BsCodigosTarjetasPagoOnline { get; set; }
        DbSet<BsCompanias> BsCompanias { get; set; }
        DbSet<BsContinentes> BsContinentes { get; set; }
        DbSet<BsCuitsPaises> BsCuitsPaises { get; set; }
        DbSet<BsDatosContacto> BsDatosContacto { get; set; }
        DbSet<BsEntidadesPagoOnline> BsEntidadesPagoOnline { get; set; }
        DbSet<BsFormasPago> BsFormasPago { get; set; }
        DbSet<BsLogMails> BsLogMails { get; set; }
        DbSet<BsLogMailsBody> BsLogMailsBody { get; set; }
        DbSet<BsMensajes> BsMensajes { get; set; }
        DbSet<BsMonedas> BsMonedas { get; set; }
        DbSet<BsMonedasCotizaciones> BsMonedasCotizaciones { get; set; }
        DbSet<BsMotivoViaje> BsMotivoViaje { get; set; }
        DbSet<BsNotificacion> BsNotificacion { get; set; }
        DbSet<BsNotificacionOrigen> BsNotificacionOrigen { get; set; }
        DbSet<BsPaises> BsPaises { get; set; }
        DbSet<BsPaisesEmpresa> BsPaisesEmpresa { get; set; }
        DbSet<BsParametros> BsParametros { get; set; }
        DbSet<BsProvincias> BsProvincias { get; set; }
        DbSet<BsRolesPorGrupo> BsRolesPorGrupo { get; set; }
        DbSet<BsSegmentosAgencias> BsSegmentosAgencias { get; set; }
        DbSet<BsUsuarios> BsUsuarios { get; set; }
        DbSet<CoAgenciaCanalDistribucion> CoAgenciaCanalDistribucion { get; set; }
        DbSet<CoAgenciaMotivoViaje> CoAgenciaMotivoViaje { get; set; }
        DbSet<CoAgencias> CoAgencias { get; set; }
        DbSet<CoAgenciasBudget> CoAgenciasBudget { get; set; }
        DbSet<CoAgenciasCobranza> CoAgenciasCobranza { get; set; }
        DbSet<CoAgenciasEjecutivo> CoAgenciasEjecutivo { get; set; }
        DbSet<CoAgenciasEjecutivoResponsable> CoAgenciasEjecutivoResponsable { get; set; }
        DbSet<CoAgenciasRepresentante> CoAgenciasRepresentante { get; set; }
        DbSet<CoAnticiposPublicidad> CoAnticiposPublicidad { get; set; }
        DbSet<CoCanalComercial> CoCanalComercial { get; set; }
        DbSet<CoCanalDistribucion> CoCanalDistribucion { get; set; }
        DbSet<CoClientes> CoClientes { get; set; }
        DbSet<CoClientesIndividuales> CoClientesIndividuales { get; set; }
        DbSet<CoComisionesAgencias> CoComisionesAgencias { get; set; }
        DbSet<CoComisionesRepresentante> CoComisionesRepresentante { get; set; }
        DbSet<CoComisionesTipoClienteModalidadProducto> CoComisionesTipoClienteModalidadProducto { get; set; }
        DbSet<CoComposicionGrupoClienteIndividual> CoComposicionGrupoClienteIndividual { get; set; }
        DbSet<CoConsumosVentas> CoConsumosVentas { get; set; }
        DbSet<CoCotizacionesIndividuosLog> CoCotizacionesIndividuosLog { get; set; }
        DbSet<CoCotizacionesIndividuosLogHis> CoCotizacionesIndividuosLogHis { get; set; }
        DbSet<CoDetalleCotizacionesIndividuosLog> CoDetalleCotizacionesIndividuosLog { get; set; }
        DbSet<CoDetalleCotizacionesIndividuosLogHis> CoDetalleCotizacionesIndividuosLogHis { get; set; }
        DbSet<CoDetallesVenta> CoDetallesVenta { get; set; }
        DbSet<CoDetallesVentaPacksOnline> CoDetallesVentaPacksOnline { get; set; }
        DbSet<CoEjecutivos> CoEjecutivos { get; set; }
        DbSet<CoEmpresas> CoEmpresas { get; set; }
        DbSet<CoEmpresasLogHabilitacion> CoEmpresasLogHabilitacion { get; set; }
        DbSet<CoFormasPagoAgencias> CoFormasPagoAgencias { get; set; }
        DbSet<CoNominasEmpresas> CoNominasEmpresas { get; set; }
        DbSet<CoPatrocinadorMarca> CoPatrocinadorMarca { get; set; }
        DbSet<CoPatrocinadores> CoPatrocinadores { get; set; }
        DbSet<CoPeriodicidadComision> CoPeriodicidadComision { get; set; }
        DbSet<CoPeriodicidadFacturacion> CoPeriodicidadFacturacion { get; set; }
        DbSet<CoProductosAgenciasMarkUp> CoProductosAgenciasMarkUp { get; set; }
        DbSet<CoProductosAgenciasMarkUpDetalle> CoProductosAgenciasMarkUpDetalle { get; set; }
        DbSet<CoRelacionTipoClienteModalidadProducto> CoRelacionTipoClienteModalidadProducto { get; set; }
        DbSet<CoRepresentantes> CoRepresentantes { get; set; }
        DbSet<CoResponsableIva> CoResponsableIva { get; set; }
        DbSet<CoSellerIdcanalesVentas> CoSellerIdcanalesVentas { get; set; }
        DbSet<CoTipoCalculoImporte> CoTipoCalculoImporte { get; set; }
        DbSet<CoTipoCanalVenta> CoTipoCanalVenta { get; set; }
        DbSet<CoTipoComision> CoTipoComision { get; set; }
        DbSet<CoTiposCliente> CoTiposCliente { get; set; }
        DbSet<CoTiposdeVenta> CoTiposdeVenta { get; set; }
        DbSet<CoUnidadMetaComision> CoUnidadMetaComision { get; set; }
        DbSet<CoVendedoresAgencias> CoVendedoresAgencias { get; set; }
        DbSet<CoVentaPacksOnline> CoVentaPacksOnline { get; set; }
        DbSet<CoVentas> CoVentas { get; set; }
        DbSet<CoVentasFormaPago> CoVentasFormaPago { get; set; }
        DbSet<EmailContactoAgencias> EmailContactoAgencias { get; set; }
        DbSet<EmailContactoClientes> EmailContactoClientes { get; set; }
        DbSet<Html> Html { get; set; }
        DbSet<LpDetalleDocumentos> LpDetalleDocumentos { get; set; }
        DbSet<LpDocumentosPago> LpDocumentosPago { get; set; }
        DbSet<LpFormasPagoDocumentos> LpFormasPagoDocumentos { get; set; }
        DbSet<LpRelacionProveedorFormasPago> LpRelacionProveedorFormasPago { get; set; }
        DbSet<LpTiposProveedores> LpTiposProveedores { get; set; }
        DbSet<MiCasos> MiCasos { get; set; }
        DbSet<MiCasosBup> MiCasosBup { get; set; }
        DbSet<MiCasosCursos> MiCasosCursos { get; set; }
        DbSet<MiCasosCursosBup> MiCasosCursosBup { get; set; }
        DbSet<MiCasosCursosHist> MiCasosCursosHist { get; set; }
        DbSet<MiCasosHist> MiCasosHist { get; set; }
        DbSet<MiContactosCorresponsales> MiContactosCorresponsales { get; set; }
        DbSet<MiContactosPrestadores> MiContactosPrestadores { get; set; }
        DbSet<MiCorresponsales> MiCorresponsales { get; set; }
        DbSet<MiCorresponsalesBup> MiCorresponsalesBup { get; set; }
        DbSet<MiCorresponsalesView> MiCorresponsalesView { get; set; }
        DbSet<MiCuestionarioQuality> MiCuestionarioQuality { get; set; }
        DbSet<MiCuestionarioQualityBup> MiCuestionarioQualityBup { get; set; }
        DbSet<MiCuestionarioQualityTipos> MiCuestionarioQualityTipos { get; set; }
        DbSet<MiCuestionarioQualityTiposBup> MiCuestionarioQualityTiposBup { get; set; }
        DbSet<MiEmpresas> MiEmpresas { get; set; }
        DbSet<MiEmpresasBup> MiEmpresasBup { get; set; }
        DbSet<MiEmpresasView> MiEmpresasView { get; set; }
        DbSet<MiEstados> MiEstados { get; set; }
        DbSet<MiEstadosCurso> MiEstadosCurso { get; set; }
        DbSet<MiPaisesAtencionCorresponsales> MiPaisesAtencionCorresponsales { get; set; }
        DbSet<MiPrestadores> MiPrestadores { get; set; }
        DbSet<MiSociosEnUso> MiSociosEnUso { get; set; }
        DbSet<MiSociosEnUsoBup> MiSociosEnUsoBup { get; set; }
        DbSet<NukeFormDocumentsLog> NukeFormDocumentsLog { get; set; }
        DbSet<PeAlteracaoPessoaFisica> PeAlteracaoPessoaFisica { get; set; }
        DbSet<PeAutorizacaoAlteracao> PeAutorizacaoAlteracao { get; set; }
        DbSet<PeCanalesPersona> PeCanalesPersona { get; set; }
        DbSet<PeCanalesPersonaJuridica> PeCanalesPersonaJuridica { get; set; }
        DbSet<PeCelularView> PeCelularView { get; set; }
        DbSet<PeDocumentosPersonaFisica> PeDocumentosPersonaFisica { get; set; }
        DbSet<PeDocumentosPersonaJuridica> PeDocumentosPersonaJuridica { get; set; }
        DbSet<PeDomicilioPersonaJuridica> PeDomicilioPersonaJuridica { get; set; }
        DbSet<PeDomicilios> PeDomicilios { get; set; }
        DbSet<PeDomiciliosAgenciasCobranza> PeDomiciliosAgenciasCobranza { get; set; }
        DbSet<PeDomiciliosPersona> PeDomiciliosPersona { get; set; }
        DbSet<PeDomiciliosPersonaFisicaView> PeDomiciliosPersonaFisicaView { get; set; }
        DbSet<PeDomiciliosPersonaJuridicaView> PeDomiciliosPersonaJuridicaView { get; set; }
        DbSet<PeFaxPersonaJuridicaView> PeFaxPersonaJuridicaView { get; set; }
        DbSet<PeFormasPagoTipoCliente> PeFormasPagoTipoCliente { get; set; }
        DbSet<PeMailsPersonaJuridicaView> PeMailsPersonaJuridicaView { get; set; }
        DbSet<PeMailsView> PeMailsView { get; set; }
        DbSet<PeNukeRolesView> PeNukeRolesView { get; set; }
        DbSet<PeNukeUserRolesView> PeNukeUserRolesView { get; set; }
        DbSet<PeNukeUsersView> PeNukeUsersView { get; set; }
        DbSet<PePersonaFisica> PePersonaFisica { get; set; }
        DbSet<PePersonaJuridica> PePersonaJuridica { get; set; }
        DbSet<PePersonasFisicasView> PePersonasFisicasView { get; set; }
        DbSet<PePersonasJuridicasView> PePersonasJuridicasView { get; set; }
        DbSet<PeTelComercialView> PeTelComercialView { get; set; }
        DbSet<PeTelFijoPersonaJuridicaView> PeTelFijoPersonaJuridicaView { get; set; }
        DbSet<PeTelFijoView> PeTelFijoView { get; set; }
        DbSet<PeTiposCalle> PeTiposCalle { get; set; }
        DbSet<PeTiposCanal> PeTiposCanal { get; set; }
        DbSet<PeTiposDocumentos> PeTiposDocumentos { get; set; }
        DbSet<PeTiposDocumentosCodiPagoOnline> PeTiposDocumentosCodiPagoOnline { get; set; }
        DbSet<PoAgenciaView> PoAgenciaView { get; set; }
        DbSet<PoAutorizacionExtension> PoAutorizacionExtension { get; set; }
        DbSet<PoBeneficiariosPoliza> PoBeneficiariosPoliza { get; set; }
        DbSet<PoDetalleFormasPago> PoDetalleFormasPago { get; set; }
        DbSet<PoExtensionAutorizacion> PoExtensionAutorizacion { get; set; }
        DbSet<PoFacturacion> PoFacturacion { get; set; }
        DbSet<PoFormasPago> PoFormasPago { get; set; }
        DbSet<PoHistoricoVoucher> PoHistoricoVoucher { get; set; }
        DbSet<PoParentesco> PoParentesco { get; set; }
        DbSet<PoPolizaView> PoPolizaView { get; set; }
        DbSet<PoPolizas> PoPolizas { get; set; }
        DbSet<PoProductosAnualesPolizas> PoProductosAnualesPolizas { get; set; }
        DbSet<PoRelacionParentescoWs> PoRelacionParentescoWs { get; set; }
        DbSet<PoSecuencialDocumento> PoSecuencialDocumento { get; set; }
        DbSet<PoTempComprador> PoTempComprador { get; set; }
        DbSet<PoTmpBeneficiarios> PoTmpBeneficiarios { get; set; }
        DbSet<PrAgenciasHabilitadasPromocion> PrAgenciasHabilitadasPromocion { get; set; }
        DbSet<PrAgenciasPromocion> PrAgenciasPromocion { get; set; }
        DbSet<PrCanalesPublicacionCupones> PrCanalesPublicacionCupones { get; set; }
        DbSet<PrCondicionesGenerales> PrCondicionesGenerales { get; set; }
        DbSet<PrCondicionesGeneralesProducto> PrCondicionesGeneralesProducto { get; set; }
        DbSet<PrFormaPagoCuotaInteres> PrFormaPagoCuotaInteres { get; set; }
        DbSet<PrFormasPagoProducto> PrFormasPagoProducto { get; set; }
        DbSet<PrGruposAfinidad> PrGruposAfinidad { get; set; }
        DbSet<PrGruposServicios> PrGruposServicios { get; set; }
        DbSet<PrLineaProducto> PrLineaProducto { get; set; }
        DbSet<PrLogPromocionesAplicadas> PrLogPromocionesAplicadas { get; set; }
        DbSet<PrLogPromocionesDetalle> PrLogPromocionesDetalle { get; set; }
        DbSet<PrMarcasProductos> PrMarcasProductos { get; set; }
        DbSet<PrModalidadProducto> PrModalidadProducto { get; set; }
        DbSet<PrPaquetesProductos> PrPaquetesProductos { get; set; }
        DbSet<PrProducto> PrProducto { get; set; }
        DbSet<PrProductoAdicional> PrProductoAdicional { get; set; }
        DbSet<PrProductoAdicionalH> PrProductoAdicionalH { get; set; }
        DbSet<PrProductoDatosCotizacion> PrProductoDatosCotizacion { get; set; }
        DbSet<PrProductoDatosCotizacionH> PrProductoDatosCotizacionH { get; set; }
        DbSet<PrProductoDestino> PrProductoDestino { get; set; }
        DbSet<PrProductoDestino20150914> PrProductoDestino20150914 { get; set; }
        DbSet<PrProductoDestinoH> PrProductoDestinoH { get; set; }
        DbSet<PrProductoH> PrProductoH { get; set; }
        DbSet<PrProductoMotivoViaje> PrProductoMotivoViaje { get; set; }
        DbSet<PrProductoPrecio> PrProductoPrecio { get; set; }
        DbSet<PrProductoPrecioBackSinmodalidad> PrProductoPrecioBackSinmodalidad { get; set; }
        DbSet<PrProductoPrecioH> PrProductoPrecioH { get; set; }
        DbSet<PrProductoPrecioImport> PrProductoPrecioImport { get; set; }
        DbSet<PrProductoServicios> PrProductoServicios { get; set; }
        DbSet<PrProductoServiciosH> PrProductoServiciosH { get; set; }
        DbSet<PrProductoServiciosImport> PrProductoServiciosImport { get; set; }
        DbSet<PrProductoTiposUso> PrProductoTiposUso { get; set; }
        DbSet<PrProductosAgencias> PrProductosAgencias { get; set; }
        DbSet<PrProductosAgenciasH> PrProductosAgenciasH { get; set; }
        DbSet<PrProductosHabilitadosPromocion> PrProductosHabilitadosPromocion { get; set; }
        DbSet<PrPromocionAgencia> PrPromocionAgencia { get; set; }
        DbSet<PrPromocionComboEtario> PrPromocionComboEtario { get; set; }
        DbSet<PrPromocionCombos> PrPromocionCombos { get; set; }
        DbSet<PrPromocionCuponGeneral> PrPromocionCuponGeneral { get; set; }
        DbSet<PrPromocionCupones> PrPromocionCupones { get; set; }
        DbSet<PrPromocionDescuentoIndividual> PrPromocionDescuentoIndividual { get; set; }
        DbSet<PrPromocionGrupoFamiliar> PrPromocionGrupoFamiliar { get; set; }
        DbSet<PrPromocionPaisDestino> PrPromocionPaisDestino { get; set; }
        DbSet<PrPromocionProducto> PrPromocionProducto { get; set; }
        DbSet<PrPromocionRangosEtarios> PrPromocionRangosEtarios { get; set; }
        DbSet<PrPromociones> PrPromociones { get; set; }
        DbSet<PrProveedoresServicios> PrProveedoresServicios { get; set; }
        DbSet<PrRangosEdadesPrecios> PrRangosEdadesPrecios { get; set; }
        DbSet<PrRelacionMultiproducto> PrRelacionMultiproducto { get; set; }
        DbSet<PrRelacionProductoModalidad> PrRelacionProductoModalidad { get; set; }
        DbSet<PrSellerIdhabilitadosPromocion> PrSellerIdhabilitadosPromocion { get; set; }
        DbSet<PrServicios> PrServicios { get; set; }
        DbSet<PrServiciosHomo> PrServiciosHomo { get; set; }
        DbSet<PrServiciosView> PrServiciosView { get; set; }
        DbSet<PrSubCobertura> PrSubCobertura { get; set; }
        DbSet<PrSugerencias> PrSugerencias { get; set; }
        DbSet<PrTipoAplicacionPromocion> PrTipoAplicacionPromocion { get; set; }
        DbSet<PrTipoCobertura> PrTipoCobertura { get; set; }
        DbSet<PrTipoFacturacionProducto> PrTipoFacturacionProducto { get; set; }
        DbSet<PrTipoInicioCobertura> PrTipoInicioCobertura { get; set; }
        DbSet<PrTipoProducto> PrTipoProducto { get; set; }
        DbSet<PrTipoViaje> PrTipoViaje { get; set; }
        DbSet<PrTiposObjetivosAgencias> PrTiposObjetivosAgencias { get; set; }
        DbSet<PrTiposPromocion> PrTiposPromocion { get; set; }
        DbSet<PrUnidadesMedida> PrUnidadesMedida { get; set; }
        DbSet<PrVigenciaProducto> PrVigenciaProducto { get; set; }
        DbSet<PrZonasImpresionServicios> PrZonasImpresionServicios { get; set; }
        DbSet<ProductsAll20130823> ProductsAll20130823 { get; set; }
        DbSet<ProductsServiceAll20131007> ProductsServiceAll20131007 { get; set; }
        DbSet<T> T { get; set; }
        DbSet<TabNascimento> TabNascimento { get; set; }
        DbSet<TbErroCarga> TbErroCarga { get; set; }
        DbSet<TbParentescoPpe> TbParentescoPpe { get; set; }
        DbSet<TbParentescoPpe1> TbParentescoPpe1 { get; set; }
        DbSet<TbPessoaCorretor> TbPessoaCorretor { get; set; }
        DbSet<TbPessoaPoliticaExposta> TbPessoaPoliticaExposta { get; set; }
        DbSet<TbPessoaPoliticaExposta1> TbPessoaPoliticaExposta1 { get; set; }
        DbSet<TbProduto> TbProduto { get; set; }
        DbSet<TbProposta> TbProposta { get; set; }
        DbSet<TbPropostaAux> TbPropostaAux { get; set; }
        DbSet<TbPropostaBeneficiario> TbPropostaBeneficiario { get; set; }
        DbSet<TbPropostaCorretor> TbPropostaCorretor { get; set; }
        DbSet<TbPropostaDeclaracaoSaude> TbPropostaDeclaracaoSaude { get; set; }
        DbSet<TbPropostaSegurado> TbPropostaSegurado { get; set; }
        DbSet<TbPropostaSeguradoAux> TbPropostaSeguradoAux { get; set; }
        DbSet<TmpLogAmiPoPolizaCompletaReporteBr> TmpLogAmiPoPolizaCompletaReporteBr { get; set; }
        DbSet<VistaPrueba> VistaPrueba { get; set; }
        DbSet<Vw360AgenteVendaLegadoOs> Vw360AgenteVendaLegadoOs { get; set; }
        DbSet<Vw360AgenteVendaLegadoOsCarga> Vw360AgenteVendaLegadoOsCarga { get; set; }
        DbSet<VwAgente> VwAgente { get; set; }
        DbSet<VwMovimento> VwMovimento { get; set; }
        DbSet<VwMovimentoCpf> VwMovimentoCpf { get; set; }
        DbSet<VwProductoPrecio> VwProductoPrecio { get; set; }
        DbSet<VwServicio> VwServicio { get; set; }
        DbSet<WcfAdditionalCoverage> WcfAdditionalCoverage { get; set; }
        DbSet<WcfAdditionalCoverageServices> WcfAdditionalCoverageServices { get; set; }
        DbSet<WcfBlackList> WcfBlackList { get; set; }
        DbSet<WcfBsNotification> WcfBsNotification { get; set; }
        DbSet<WcfBsNotificationSource> WcfBsNotificationSource { get; set; }
        DbSet<WcfConsultant> WcfConsultant { get; set; }
        DbSet<WcfConsultantAgency> WcfConsultantAgency { get; set; }
        DbSet<WcfContactUsBlogger> WcfContactUsBlogger { get; set; }
        DbSet<WcfCouponType> WcfCouponType { get; set; }
        DbSet<WcfCoverageByProductToPrint> WcfCoverageByProductToPrint { get; set; }
        DbSet<WcfDestinyShowCase> WcfDestinyShowCase { get; set; }
        DbSet<WcfPoVoucherAdditionalCoverage> WcfPoVoucherAdditionalCoverage { get; set; }
        DbSet<WcfPoVoucherReasonForCancellation> WcfPoVoucherReasonForCancellation { get; set; }
        DbSet<WcfProductAdditionalCoverage> WcfProductAdditionalCoverage { get; set; }
        DbSet<WcfProductAdditionalCoveragePrice> WcfProductAdditionalCoveragePrice { get; set; }
        DbSet<WcfProductShowCase> WcfProductShowCase { get; set; }
        DbSet<WcfProductType> WcfProductType { get; set; }
        DbSet<WcfProductTypeCompany> WcfProductTypeCompany { get; set; }
        DbSet<WcfProfile> WcfProfile { get; set; }
        DbSet<WcfProfilePermission> WcfProfilePermission { get; set; }
        DbSet<WcfProfileRoles> WcfProfileRoles { get; set; }
        DbSet<WcfQtDiasMultiviagem> WcfQtDiasMultiviagem { get; set; }
        DbSet<WcfReasonForCancellation> WcfReasonForCancellation { get; set; }
        DbSet<WcfReportGenerator> WcfReportGenerator { get; set; }
        DbSet<WcfSession> WcfSession { get; set; }
        DbSet<WcfSmsLog> WcfSmsLog { get; set; }
        DbSet<WcfSpecialAudiences> WcfSpecialAudiences { get; set; }
        DbSet<WcfSpecialAudiencesShowCase> WcfSpecialAudiencesShowCase { get; set; }
        DbSet<WcfToken> WcfToken { get; set; }
        DbSet<WcfTokenProfile> WcfTokenProfile { get; set; }
        DbSet<WcfTopic> WcfTopic { get; set; }
        DbSet<WcfTopicShowCase> WcfTopicShowCase { get; set; }
        DbSet<WcfWebUserAddress> WcfWebUserAddress { get; set; }
        DbSet<WcfWebUsers> WcfWebUsers { get; set; }
        DbSet<WsSesiones> WsSesiones { get; set; }
        DbSet<WsTokens> WsTokens { get; set; }
    }
}