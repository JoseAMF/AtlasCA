using System;
using System.Threading;
using System.Threading.Tasks;
using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.eCommerce;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Atlas.Infrastructure.Data
{
    public partial class eCommerceDbContext : DbContext, IeCommerceDbContext
    {

        private readonly ICurrentUserService _currentUserService;
        public eCommerceDbContext(DbContextOptions<eCommerceDbContext> options, ICurrentUserService currentUserService)
            : base(options)
        {
            _currentUserService = currentUserService;
        }

        public eCommerceDbContext(string connectionString, ICurrentUserService currentUserService)
            : base(new DbContextOptionsBuilder().UseSqlServer(connectionString).Options)
        {
            _currentUserService = currentUserService;
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.Entity.GetType().GetProperty("CreadoPor") != null)
                {
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            entry.Entity.GetType().GetProperty("CreadoPor")?.SetValue(entry.Entity, _currentUserService.Username, null);
                            entry.Entity.GetType().GetProperty("FecCreaReg")?.SetValue(entry, DateTime.Now, null);
                            break;
                        case EntityState.Modified:
                            entry.Entity.GetType().GetProperty("ModificadoPor")?.SetValue(entry.Entity, _currentUserService.Username, null);
                            entry.Entity.GetType().GetProperty("FecModReg")?.SetValue(entry.Entity, DateTime.Now, null);
                            break;
                    }
                }
            }


            return base.SaveChangesAsync(cancellationToken);
        }

        public virtual DbSet<PareportAtlas> PareportAtlas { get; set; }
        public virtual DbSet<AmiPoSugerencias> AmiPoSugerencias { get; set; }
        public virtual DbSet<AmivBsCompanias> AmivBsCompanias { get; set; }
        public virtual DbSet<AmivBsCuitspaises> AmivBsCuitspaises { get; set; }
        public virtual DbSet<AmivCoAgenciaMarkupProducto> AmivCoAgenciaMarkupProducto { get; set; }
        public virtual DbSet<AmivCoAgencias> AmivCoAgencias { get; set; }
        public virtual DbSet<AmivCoAgenciasEcommerce> AmivCoAgenciasEcommerce { get; set; }
        public virtual DbSet<AmivCoClientes> AmivCoClientes { get; set; }
        public virtual DbSet<AmivCoPromotores> AmivCoPromotores { get; set; }
        public virtual DbSet<AmivCoRelacionProductoModalidad> AmivCoRelacionProductoModalidad { get; set; }
        public virtual DbSet<AmivCoRelacionTipoClienteModalidadProducto> AmivCoRelacionTipoClienteModalidadProducto { get; set; }
        public virtual DbSet<AmivCoVendedoresAgencias> AmivCoVendedoresAgencias { get; set; }
        public virtual DbSet<AmivMiCorresponsales> AmivMiCorresponsales { get; set; }
        public virtual DbSet<AmivMiEmpresas> AmivMiEmpresas { get; set; }
        public virtual DbSet<AmivPePersonaFisica> AmivPePersonaFisica { get; set; }
        public virtual DbSet<AmivPePersonasFisicas> AmivPePersonasFisicas { get; set; }
        public virtual DbSet<AmivPePersonasFisicasCompleto> AmivPePersonasFisicasCompleto { get; set; }
        public virtual DbSet<AmivPoBeneficiariosPoliza> AmivPoBeneficiariosPoliza { get; set; }
        public virtual DbSet<AmivPoBilhetesVigentes> AmivPoBilhetesVigentes { get; set; }
        public virtual DbSet<AmivPoConsultaDeVouchers> AmivPoConsultaDeVouchers { get; set; }
        public virtual DbSet<AmivPoPolizas> AmivPoPolizas { get; set; }
        public virtual DbSet<AmivPrProductoDestino> AmivPrProductoDestino { get; set; }
        public virtual DbSet<AmivPrProductoServicios> AmivPrProductoServicios { get; set; }
        public virtual DbSet<AmivPrProductodestino1> AmivPrProductodestino1 { get; set; }
        public virtual DbSet<AmivPrProductoprecio> AmivPrProductoprecio { get; set; }
        public virtual DbSet<AmivPrProductosAdicionales> AmivPrProductosAdicionales { get; set; }
        public virtual DbSet<AmivPrProductosagencias> AmivPrProductosagencias { get; set; }
        public virtual DbSet<AmivVouchersAce> AmivVouchersAce { get; set; }
        public virtual DbSet<BsCiudades> BsCiudades { get; set; }
        public virtual DbSet<BsCodigosDocumentosPagoOnline> BsCodigosDocumentosPagoOnline { get; set; }
        public virtual DbSet<BsCodigosTarjetasPagoOnline> BsCodigosTarjetasPagoOnline { get; set; }
        public virtual DbSet<BsCompanias> BsCompanias { get; set; }
        public virtual DbSet<BsContinentes> BsContinentes { get; set; }
        public virtual DbSet<BsCuitsPaises> BsCuitsPaises { get; set; }
        public virtual DbSet<BsDatosContacto> BsDatosContacto { get; set; }
        public virtual DbSet<BsEntidadesPagoOnline> BsEntidadesPagoOnline { get; set; }
        public virtual DbSet<BsFormasPago> BsFormasPago { get; set; }
        public virtual DbSet<BsLogMails> BsLogMails { get; set; }
        public virtual DbSet<BsLogMailsBody> BsLogMailsBody { get; set; }
        public virtual DbSet<BsMensajes> BsMensajes { get; set; }
        public virtual DbSet<BsMonedas> BsMonedas { get; set; }
        public virtual DbSet<BsMonedasCotizaciones> BsMonedasCotizaciones { get; set; }
        public virtual DbSet<BsMotivoViaje> BsMotivoViaje { get; set; }
        public virtual DbSet<BsNotificacion> BsNotificacion { get; set; }
        public virtual DbSet<BsNotificacionOrigen> BsNotificacionOrigen { get; set; }
        public virtual DbSet<BsPaises> BsPaises { get; set; }
        public virtual DbSet<BsPaisesEmpresa> BsPaisesEmpresa { get; set; }
        public virtual DbSet<BsParametros> BsParametros { get; set; }
        public virtual DbSet<BsProvincias> BsProvincias { get; set; }
        public virtual DbSet<BsRolesPorGrupo> BsRolesPorGrupo { get; set; }
        public virtual DbSet<BsSegmentosAgencias> BsSegmentosAgencias { get; set; }
        public virtual DbSet<BsUsuarios> BsUsuarios { get; set; }
        public virtual DbSet<CoAgenciaCanalDistribucion> CoAgenciaCanalDistribucion { get; set; }
        public virtual DbSet<CoAgenciaMotivoViaje> CoAgenciaMotivoViaje { get; set; }
        public virtual DbSet<CoAgencias> CoAgencias { get; set; }
        public virtual DbSet<CoAgenciasBudget> CoAgenciasBudget { get; set; }
        public virtual DbSet<CoAgenciasCobranza> CoAgenciasCobranza { get; set; }
        public virtual DbSet<CoAgenciasEjecutivo> CoAgenciasEjecutivo { get; set; }
        public virtual DbSet<CoAgenciasEjecutivoResponsable> CoAgenciasEjecutivoResponsable { get; set; }
        public virtual DbSet<CoAgenciasRepresentante> CoAgenciasRepresentante { get; set; }
        public virtual DbSet<CoAnticiposPublicidad> CoAnticiposPublicidad { get; set; }
        public virtual DbSet<CoCanalComercial> CoCanalComercial { get; set; }
        public virtual DbSet<CoCanalDistribucion> CoCanalDistribucion { get; set; }
        public virtual DbSet<CoClientes> CoClientes { get; set; }
        public virtual DbSet<CoClientesIndividuales> CoClientesIndividuales { get; set; }
        public virtual DbSet<CoComisionesAgencias> CoComisionesAgencias { get; set; }
        public virtual DbSet<CoComisionesRepresentante> CoComisionesRepresentante { get; set; }
        public virtual DbSet<CoComisionesTipoClienteModalidadProducto> CoComisionesTipoClienteModalidadProducto { get; set; }
        public virtual DbSet<CoComposicionGrupoClienteIndividual> CoComposicionGrupoClienteIndividual { get; set; }
        public virtual DbSet<CoConsumosVentas> CoConsumosVentas { get; set; }
        public virtual DbSet<CoCotizacionesIndividuosLog> CoCotizacionesIndividuosLog { get; set; }
        public virtual DbSet<CoCotizacionesIndividuosLogHis> CoCotizacionesIndividuosLogHis { get; set; }
        public virtual DbSet<CoDetalleCotizacionesIndividuosLog> CoDetalleCotizacionesIndividuosLog { get; set; }
        public virtual DbSet<CoDetalleCotizacionesIndividuosLogHis> CoDetalleCotizacionesIndividuosLogHis { get; set; }
        public virtual DbSet<CoDetallesVenta> CoDetallesVenta { get; set; }
        public virtual DbSet<CoDetallesVentaPacksOnline> CoDetallesVentaPacksOnline { get; set; }
        public virtual DbSet<CoEjecutivos> CoEjecutivos { get; set; }
        public virtual DbSet<CoEmpresas> CoEmpresas { get; set; }
        public virtual DbSet<CoEmpresasLogHabilitacion> CoEmpresasLogHabilitacion { get; set; }
        public virtual DbSet<CoFormasPagoAgencias> CoFormasPagoAgencias { get; set; }
        public virtual DbSet<CoNominasEmpresas> CoNominasEmpresas { get; set; }
        public virtual DbSet<CoPatrocinadorMarca> CoPatrocinadorMarca { get; set; }
        public virtual DbSet<CoPatrocinadores> CoPatrocinadores { get; set; }
        public virtual DbSet<CoPeriodicidadComision> CoPeriodicidadComision { get; set; }
        public virtual DbSet<CoPeriodicidadFacturacion> CoPeriodicidadFacturacion { get; set; }
        public virtual DbSet<CoProductosAgenciasMarkUp> CoProductosAgenciasMarkUp { get; set; }
        public virtual DbSet<CoProductosAgenciasMarkUpDetalle> CoProductosAgenciasMarkUpDetalle { get; set; }
        public virtual DbSet<CoRelacionTipoClienteModalidadProducto> CoRelacionTipoClienteModalidadProducto { get; set; }
        public virtual DbSet<CoRepresentantes> CoRepresentantes { get; set; }
        public virtual DbSet<CoResponsableIva> CoResponsableIva { get; set; }
        public virtual DbSet<CoSellerIdcanalesVentas> CoSellerIdcanalesVentas { get; set; }
        public virtual DbSet<CoTipoCalculoImporte> CoTipoCalculoImporte { get; set; }
        public virtual DbSet<CoTipoCanalVenta> CoTipoCanalVenta { get; set; }
        public virtual DbSet<CoTipoComision> CoTipoComision { get; set; }
        public virtual DbSet<CoTiposCliente> CoTiposCliente { get; set; }
        public virtual DbSet<CoTiposdeVenta> CoTiposdeVenta { get; set; }
        public virtual DbSet<CoUnidadMetaComision> CoUnidadMetaComision { get; set; }
        public virtual DbSet<CoVendedoresAgencias> CoVendedoresAgencias { get; set; }
        public virtual DbSet<CoVentaPacksOnline> CoVentaPacksOnline { get; set; }
        public virtual DbSet<CoVentas> CoVentas { get; set; }
        public virtual DbSet<CoVentasFormaPago> CoVentasFormaPago { get; set; }
        public virtual DbSet<EmailContactoAgencias> EmailContactoAgencias { get; set; }
        public virtual DbSet<EmailContactoClientes> EmailContactoClientes { get; set; }
        public virtual DbSet<Html> Html { get; set; }
        public virtual DbSet<LpDetalleDocumentos> LpDetalleDocumentos { get; set; }
        public virtual DbSet<LpDocumentosPago> LpDocumentosPago { get; set; }
        public virtual DbSet<LpFormasPagoDocumentos> LpFormasPagoDocumentos { get; set; }
        public virtual DbSet<LpRelacionProveedorFormasPago> LpRelacionProveedorFormasPago { get; set; }
        public virtual DbSet<LpTiposProveedores> LpTiposProveedores { get; set; }
        public virtual DbSet<MiCasos> MiCasos { get; set; }
        public virtual DbSet<MiCasosBup> MiCasosBup { get; set; }
        public virtual DbSet<MiCasosCursos> MiCasosCursos { get; set; }
        public virtual DbSet<MiCasosCursosBup> MiCasosCursosBup { get; set; }
        public virtual DbSet<MiCasosCursosHist> MiCasosCursosHist { get; set; }
        public virtual DbSet<MiCasosHist> MiCasosHist { get; set; }
        public virtual DbSet<MiContactosCorresponsales> MiContactosCorresponsales { get; set; }
        public virtual DbSet<MiContactosPrestadores> MiContactosPrestadores { get; set; }
        public virtual DbSet<MiCorresponsales> MiCorresponsales { get; set; }
        public virtual DbSet<MiCorresponsalesBup> MiCorresponsalesBup { get; set; }
        public virtual DbSet<MiCorresponsalesView> MiCorresponsalesView { get; set; }
        public virtual DbSet<MiCuestionarioQuality> MiCuestionarioQuality { get; set; }
        public virtual DbSet<MiCuestionarioQualityBup> MiCuestionarioQualityBup { get; set; }
        public virtual DbSet<MiCuestionarioQualityTipos> MiCuestionarioQualityTipos { get; set; }
        public virtual DbSet<MiCuestionarioQualityTiposBup> MiCuestionarioQualityTiposBup { get; set; }
        public virtual DbSet<MiEmpresas> MiEmpresas { get; set; }
        public virtual DbSet<MiEmpresasBup> MiEmpresasBup { get; set; }
        public virtual DbSet<MiEmpresasView> MiEmpresasView { get; set; }
        public virtual DbSet<MiEstados> MiEstados { get; set; }
        public virtual DbSet<MiEstadosCurso> MiEstadosCurso { get; set; }
        public virtual DbSet<MiPaisesAtencionCorresponsales> MiPaisesAtencionCorresponsales { get; set; }
        public virtual DbSet<MiPrestadores> MiPrestadores { get; set; }
        public virtual DbSet<MiSociosEnUso> MiSociosEnUso { get; set; }
        public virtual DbSet<MiSociosEnUsoBup> MiSociosEnUsoBup { get; set; }
        public virtual DbSet<NukeFormDocumentsLog> NukeFormDocumentsLog { get; set; }
        public virtual DbSet<PeAlteracaoPessoaFisica> PeAlteracaoPessoaFisica { get; set; }
        public virtual DbSet<PeAutorizacaoAlteracao> PeAutorizacaoAlteracao { get; set; }
        public virtual DbSet<PeCanalesPersona> PeCanalesPersona { get; set; }
        public virtual DbSet<PeCanalesPersonaJuridica> PeCanalesPersonaJuridica { get; set; }
        public virtual DbSet<PeCelularView> PeCelularView { get; set; }
        public virtual DbSet<PeDocumentosPersonaFisica> PeDocumentosPersonaFisica { get; set; }
        public virtual DbSet<PeDocumentosPersonaJuridica> PeDocumentosPersonaJuridica { get; set; }
        public virtual DbSet<PeDomicilioPersonaJuridica> PeDomicilioPersonaJuridica { get; set; }
        public virtual DbSet<PeDomicilios> PeDomicilios { get; set; }
        public virtual DbSet<PeDomiciliosAgenciasCobranza> PeDomiciliosAgenciasCobranza { get; set; }
        public virtual DbSet<PeDomiciliosPersona> PeDomiciliosPersona { get; set; }
        public virtual DbSet<PeDomiciliosPersonaFisicaView> PeDomiciliosPersonaFisicaView { get; set; }
        public virtual DbSet<PeDomiciliosPersonaJuridicaView> PeDomiciliosPersonaJuridicaView { get; set; }
        public virtual DbSet<PeFaxPersonaJuridicaView> PeFaxPersonaJuridicaView { get; set; }
        public virtual DbSet<PeFormasPagoTipoCliente> PeFormasPagoTipoCliente { get; set; }
        public virtual DbSet<PeMailsPersonaJuridicaView> PeMailsPersonaJuridicaView { get; set; }
        public virtual DbSet<PeMailsView> PeMailsView { get; set; }
        public virtual DbSet<PeNukeRolesView> PeNukeRolesView { get; set; }
        public virtual DbSet<PeNukeUserRolesView> PeNukeUserRolesView { get; set; }
        public virtual DbSet<PeNukeUsersView> PeNukeUsersView { get; set; }
        public virtual DbSet<PePersonaFisica> PePersonaFisica { get; set; }
        public virtual DbSet<PePersonaJuridica> PePersonaJuridica { get; set; }
        public virtual DbSet<PePersonasFisicasView> PePersonasFisicasView { get; set; }
        public virtual DbSet<PePersonasJuridicasView> PePersonasJuridicasView { get; set; }
        public virtual DbSet<PeTelComercialView> PeTelComercialView { get; set; }
        public virtual DbSet<PeTelFijoPersonaJuridicaView> PeTelFijoPersonaJuridicaView { get; set; }
        public virtual DbSet<PeTelFijoView> PeTelFijoView { get; set; }
        public virtual DbSet<PeTiposCalle> PeTiposCalle { get; set; }
        public virtual DbSet<PeTiposCanal> PeTiposCanal { get; set; }
        public virtual DbSet<PeTiposDocumentos> PeTiposDocumentos { get; set; }
        public virtual DbSet<PeTiposDocumentosCodiPagoOnline> PeTiposDocumentosCodiPagoOnline { get; set; }
        public virtual DbSet<PoAgenciaView> PoAgenciaView { get; set; }
        public virtual DbSet<PoAutorizacionExtension> PoAutorizacionExtension { get; set; }
        public virtual DbSet<PoBeneficiariosPoliza> PoBeneficiariosPoliza { get; set; }
        public virtual DbSet<PoDetalleFormasPago> PoDetalleFormasPago { get; set; }
        public virtual DbSet<PoExtensionAutorizacion> PoExtensionAutorizacion { get; set; }
        public virtual DbSet<PoFacturacion> PoFacturacion { get; set; }
        public virtual DbSet<PoFormasPago> PoFormasPago { get; set; }
        public virtual DbSet<PoHistoricoVoucher> PoHistoricoVoucher { get; set; }
        public virtual DbSet<PoParentesco> PoParentesco { get; set; }
        public virtual DbSet<PoPolizaView> PoPolizaView { get; set; }
        public virtual DbSet<PoPolizas> PoPolizas { get; set; }
        public virtual DbSet<PoProductosAnualesPolizas> PoProductosAnualesPolizas { get; set; }
        public virtual DbSet<PoRelacionParentescoWs> PoRelacionParentescoWs { get; set; }
        public virtual DbSet<PoSecuencialDocumento> PoSecuencialDocumento { get; set; }
        public virtual DbSet<PoTempComprador> PoTempComprador { get; set; }
        public virtual DbSet<PoTmpBeneficiarios> PoTmpBeneficiarios { get; set; }
        public virtual DbSet<PrAgenciasHabilitadasPromocion> PrAgenciasHabilitadasPromocion { get; set; }
        public virtual DbSet<PrAgenciasPromocion> PrAgenciasPromocion { get; set; }
        public virtual DbSet<PrCanalesPublicacionCupones> PrCanalesPublicacionCupones { get; set; }
        public virtual DbSet<PrCondicionesGenerales> PrCondicionesGenerales { get; set; }
        public virtual DbSet<PrCondicionesGeneralesProducto> PrCondicionesGeneralesProducto { get; set; }
        public virtual DbSet<PrFormaPagoCuotaInteres> PrFormaPagoCuotaInteres { get; set; }
        public virtual DbSet<PrFormasPagoProducto> PrFormasPagoProducto { get; set; }
        public virtual DbSet<PrGruposAfinidad> PrGruposAfinidad { get; set; }
        public virtual DbSet<PrGruposServicios> PrGruposServicios { get; set; }
        public virtual DbSet<PrLineaProducto> PrLineaProducto { get; set; }
        public virtual DbSet<PrLogPromocionesAplicadas> PrLogPromocionesAplicadas { get; set; }
        public virtual DbSet<PrLogPromocionesDetalle> PrLogPromocionesDetalle { get; set; }
        public virtual DbSet<PrMarcasProductos> PrMarcasProductos { get; set; }
        public virtual DbSet<PrModalidadProducto> PrModalidadProducto { get; set; }
        public virtual DbSet<PrPaquetesProductos> PrPaquetesProductos { get; set; }
        public virtual DbSet<PrProducto> PrProducto { get; set; }
        public virtual DbSet<PrProductoAdicional> PrProductoAdicional { get; set; }
        public virtual DbSet<PrProductoAdicionalH> PrProductoAdicionalH { get; set; }
        public virtual DbSet<PrProductoDatosCotizacion> PrProductoDatosCotizacion { get; set; }
        public virtual DbSet<PrProductoDatosCotizacionH> PrProductoDatosCotizacionH { get; set; }
        public virtual DbSet<PrProductoDestino> PrProductoDestino { get; set; }
        public virtual DbSet<PrProductoDestino20150914> PrProductoDestino20150914 { get; set; }
        public virtual DbSet<PrProductoDestinoH> PrProductoDestinoH { get; set; }
        public virtual DbSet<PrProductoH> PrProductoH { get; set; }
        public virtual DbSet<PrProductoMotivoViaje> PrProductoMotivoViaje { get; set; }
        public virtual DbSet<PrProductoPrecio> PrProductoPrecio { get; set; }
        public virtual DbSet<PrProductoPrecioBackSinmodalidad> PrProductoPrecioBackSinmodalidad { get; set; }
        public virtual DbSet<PrProductoPrecioH> PrProductoPrecioH { get; set; }
        public virtual DbSet<PrProductoPrecioImport> PrProductoPrecioImport { get; set; }
        public virtual DbSet<PrProductoServicios> PrProductoServicios { get; set; }
        public virtual DbSet<PrProductoServiciosH> PrProductoServiciosH { get; set; }
        public virtual DbSet<PrProductoServiciosImport> PrProductoServiciosImport { get; set; }
        public virtual DbSet<PrProductoTiposUso> PrProductoTiposUso { get; set; }
        public virtual DbSet<PrProductosAgencias> PrProductosAgencias { get; set; }
        public virtual DbSet<PrProductosAgenciasH> PrProductosAgenciasH { get; set; }
        public virtual DbSet<PrProductosHabilitadosPromocion> PrProductosHabilitadosPromocion { get; set; }
        public virtual DbSet<PrPromocionAgencia> PrPromocionAgencia { get; set; }
        public virtual DbSet<PrPromocionComboEtario> PrPromocionComboEtario { get; set; }
        public virtual DbSet<PrPromocionCombos> PrPromocionCombos { get; set; }
        public virtual DbSet<PrPromocionCuponGeneral> PrPromocionCuponGeneral { get; set; }
        public virtual DbSet<PrPromocionCupones> PrPromocionCupones { get; set; }
        public virtual DbSet<PrPromocionDescuentoIndividual> PrPromocionDescuentoIndividual { get; set; }
        public virtual DbSet<PrPromocionGrupoFamiliar> PrPromocionGrupoFamiliar { get; set; }
        public virtual DbSet<PrPromocionPaisDestino> PrPromocionPaisDestino { get; set; }
        public virtual DbSet<PrPromocionProducto> PrPromocionProducto { get; set; }
        public virtual DbSet<PrPromocionRangosEtarios> PrPromocionRangosEtarios { get; set; }
        public virtual DbSet<PrPromociones> PrPromociones { get; set; }
        public virtual DbSet<PrProveedoresServicios> PrProveedoresServicios { get; set; }
        public virtual DbSet<PrRangosEdadesPrecios> PrRangosEdadesPrecios { get; set; }
        public virtual DbSet<PrRelacionMultiproducto> PrRelacionMultiproducto { get; set; }
        public virtual DbSet<PrRelacionProductoModalidad> PrRelacionProductoModalidad { get; set; }
        public virtual DbSet<PrSellerIdhabilitadosPromocion> PrSellerIdhabilitadosPromocion { get; set; }
        public virtual DbSet<PrServicios> PrServicios { get; set; }
        public virtual DbSet<PrServiciosHomo> PrServiciosHomo { get; set; }
        public virtual DbSet<PrServiciosView> PrServiciosView { get; set; }
        public virtual DbSet<PrSubCobertura> PrSubCobertura { get; set; }
        public virtual DbSet<PrSugerencias> PrSugerencias { get; set; }
        public virtual DbSet<PrTipoAplicacionPromocion> PrTipoAplicacionPromocion { get; set; }
        public virtual DbSet<PrTipoCobertura> PrTipoCobertura { get; set; }
        public virtual DbSet<PrTipoFacturacionProducto> PrTipoFacturacionProducto { get; set; }
        public virtual DbSet<PrTipoInicioCobertura> PrTipoInicioCobertura { get; set; }
        public virtual DbSet<PrTipoProducto> PrTipoProducto { get; set; }
        public virtual DbSet<PrTipoViaje> PrTipoViaje { get; set; }
        public virtual DbSet<PrTiposObjetivosAgencias> PrTiposObjetivosAgencias { get; set; }
        public virtual DbSet<PrTiposPromocion> PrTiposPromocion { get; set; }
        public virtual DbSet<PrUnidadesMedida> PrUnidadesMedida { get; set; }
        public virtual DbSet<PrVigenciaProducto> PrVigenciaProducto { get; set; }
        public virtual DbSet<PrZonasImpresionServicios> PrZonasImpresionServicios { get; set; }
        public virtual DbSet<ProductsAll20130823> ProductsAll20130823 { get; set; }
        public virtual DbSet<ProductsServiceAll20131007> ProductsServiceAll20131007 { get; set; }
        public virtual DbSet<T> T { get; set; }
        public virtual DbSet<TabNascimento> TabNascimento { get; set; }
        public virtual DbSet<TbErroCarga> TbErroCarga { get; set; }
        public virtual DbSet<TbParentescoPpe> TbParentescoPpe { get; set; }
        public virtual DbSet<TbParentescoPpe1> TbParentescoPpe1 { get; set; }
        public virtual DbSet<TbPessoaCorretor> TbPessoaCorretor { get; set; }
        public virtual DbSet<TbPessoaPoliticaExposta> TbPessoaPoliticaExposta { get; set; }
        public virtual DbSet<TbPessoaPoliticaExposta1> TbPessoaPoliticaExposta1 { get; set; }
        public virtual DbSet<TbProduto> TbProduto { get; set; }
        public virtual DbSet<TbProposta> TbProposta { get; set; }
        public virtual DbSet<TbPropostaAux> TbPropostaAux { get; set; }
        public virtual DbSet<TbPropostaBeneficiario> TbPropostaBeneficiario { get; set; }
        public virtual DbSet<TbPropostaCorretor> TbPropostaCorretor { get; set; }
        public virtual DbSet<TbPropostaDeclaracaoSaude> TbPropostaDeclaracaoSaude { get; set; }
        public virtual DbSet<TbPropostaSegurado> TbPropostaSegurado { get; set; }
        public virtual DbSet<TbPropostaSeguradoAux> TbPropostaSeguradoAux { get; set; }
        public virtual DbSet<TmpLogAmiPoPolizaCompletaReporteBr> TmpLogAmiPoPolizaCompletaReporteBr { get; set; }
        public virtual DbSet<VistaPrueba> VistaPrueba { get; set; }
        public virtual DbSet<Vw360AgenteVendaLegadoOs> Vw360AgenteVendaLegadoOs { get; set; }
        public virtual DbSet<Vw360AgenteVendaLegadoOsCarga> Vw360AgenteVendaLegadoOsCarga { get; set; }
        public virtual DbSet<VwAgente> VwAgente { get; set; }
        public virtual DbSet<VwMovimento> VwMovimento { get; set; }
        public virtual DbSet<VwMovimentoCpf> VwMovimentoCpf { get; set; }
        public virtual DbSet<VwProductoPrecio> VwProductoPrecio { get; set; }
        public virtual DbSet<VwServicio> VwServicio { get; set; }
        public virtual DbSet<WcfAdditionalCoverage> WcfAdditionalCoverage { get; set; }
        public virtual DbSet<WcfAdditionalCoverageServices> WcfAdditionalCoverageServices { get; set; }
        public virtual DbSet<WcfBlackList> WcfBlackList { get; set; }
        public virtual DbSet<WcfBsNotification> WcfBsNotification { get; set; }
        public virtual DbSet<WcfBsNotificationSource> WcfBsNotificationSource { get; set; }
        public virtual DbSet<WcfConsultant> WcfConsultant { get; set; }
        public virtual DbSet<WcfConsultantAgency> WcfConsultantAgency { get; set; }
        public virtual DbSet<WcfContactUsBlogger> WcfContactUsBlogger { get; set; }
        public virtual DbSet<WcfCouponType> WcfCouponType { get; set; }
        public virtual DbSet<WcfCoverageByProductToPrint> WcfCoverageByProductToPrint { get; set; }
        public virtual DbSet<WcfDestinyShowCase> WcfDestinyShowCase { get; set; }
        public virtual DbSet<WcfPoVoucherAdditionalCoverage> WcfPoVoucherAdditionalCoverage { get; set; }
        public virtual DbSet<WcfPoVoucherReasonForCancellation> WcfPoVoucherReasonForCancellation { get; set; }
        public virtual DbSet<WcfProductAdditionalCoverage> WcfProductAdditionalCoverage { get; set; }
        public virtual DbSet<WcfProductAdditionalCoveragePrice> WcfProductAdditionalCoveragePrice { get; set; }
        public virtual DbSet<WcfProductShowCase> WcfProductShowCase { get; set; }
        public virtual DbSet<WcfProductType> WcfProductType { get; set; }
        public virtual DbSet<WcfProductTypeCompany> WcfProductTypeCompany { get; set; }
        public virtual DbSet<WcfProfile> WcfProfile { get; set; }
        public virtual DbSet<WcfProfilePermission> WcfProfilePermission { get; set; }
        public virtual DbSet<WcfProfileRoles> WcfProfileRoles { get; set; }
        public virtual DbSet<WcfQtDiasMultiviagem> WcfQtDiasMultiviagem { get; set; }
        public virtual DbSet<WcfReasonForCancellation> WcfReasonForCancellation { get; set; }
        public virtual DbSet<WcfReportGenerator> WcfReportGenerator { get; set; }
        public virtual DbSet<WcfSession> WcfSession { get; set; }
        public virtual DbSet<WcfSmsLog> WcfSmsLog { get; set; }
        public virtual DbSet<WcfSpecialAudiences> WcfSpecialAudiences { get; set; }
        public virtual DbSet<WcfSpecialAudiencesShowCase> WcfSpecialAudiencesShowCase { get; set; }
        public virtual DbSet<WcfToken> WcfToken { get; set; }
        public virtual DbSet<WcfTokenProfile> WcfTokenProfile { get; set; }
        public virtual DbSet<WcfTopic> WcfTopic { get; set; }
        public virtual DbSet<WcfTopicShowCase> WcfTopicShowCase { get; set; }
        public virtual DbSet<WcfWebUserAddress> WcfWebUserAddress { get; set; }
        public virtual DbSet<WcfWebUsers> WcfWebUsers { get; set; }
        public virtual DbSet<WsSesiones> WsSesiones { get; set; }
        public virtual DbSet<WsTokens> WsTokens { get; set; }

        //         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //         {
        //             if (!optionsBuilder.IsConfigured)
        //             {
        // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                 optionsBuilder.UseSqlServer("Server=SRVSEG-PROD, 1434;Database=PRE-OS-AMIBR;User Id=usrSysPremium;Password=USPomint01;");
        //             }
        //         }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PareportAtlas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PareportAtlas");

                entity.Property(e => e.CancelMesmoDia)

                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CdAgencia).HasColumnName("cd_agencia");

                entity.Property(e => e.CdPpe).HasColumnName("cd_ppe");

                entity.Property(e => e.CdProduto)

                    .HasColumnName("cd_produto")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CdVendedor).HasColumnName("cd_vendedor");

                entity.Property(e => e.Cpf)
                    .HasColumnName("CPF")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.DscAgencia)
                    .HasColumnName("dsc_agencia")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DscArquivoPdf)
                    .HasColumnName("dsc_ArquivoPdf")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DscContatoEmergencia)
                    .HasColumnName("dsc_ContatoEmergencia")
                    .HasMaxLength(201)
                    .IsUnicode(false);

                entity.Property(e => e.DscDesconto)
                    .HasColumnName("dsc_desconto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DscEMailContatoEmergencia)
                    .HasColumnName("dsc_eMailContatoEmergencia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DscFile)
                    .HasColumnName("dsc_file")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DscPpe)
                    .HasColumnName("dsc_ppe")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DscProduto)

                    .HasColumnName("dsc_produto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DscSegmento)
                    .HasColumnName("dsc_segmento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DscTelefoneContatoEmergencia)
                    .HasColumnName("dsc_TelefoneContatoEmergencia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DscVendedor)
                    .HasColumnName("dsc_vendedor")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DtCancelamento)
                    .HasColumnName("dt_cancelamento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtEmissao)
                    .HasColumnName("dt_emissao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtEnvioBilhete)
                    .HasColumnName("dt_envio_bilhete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtFimExtensao)
                    .HasColumnName("dt_fim_extensao")
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

                entity.Property(e => e.Flytour)

                    .HasColumnName("FLYTOUR")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FormaPagto)
                    .HasColumnName("forma_pagto")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdDesconto).HasColumnName("id_desconto");

                entity.Property(e => e.Idbase)

                    .HasColumnName("idbase")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Moeda)

                    .HasColumnName("moeda")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NomeCliente)
                    .HasColumnName("Nome_cliente")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NrCertificado)

                    .HasColumnName("nr_certificado")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrParcelas).HasColumnName("nr_parcelas");

                entity.Property(e => e.NrVoucher)
                    .HasColumnName("nr_voucher")
                    .HasMaxLength(33)
                    .IsUnicode(false);

                entity.Property(e => e.PaisDestino)
                    .HasColumnName("pais_destino")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaisOrigem)

                    .HasColumnName("pais_origem")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PerComissao)
                    .HasColumnName("per_comissao")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerDesconto)
                    .HasColumnName("per_desconto")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Sellerid)
                    .HasColumnName("sellerid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)

                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ValorDolar)
                    .HasColumnName("valor_dolar")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ValorExtensao)
                    .HasColumnName("valor_extensao")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ValorProduto)
                    .HasColumnName("valor_produto")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ValorVoucher)
                    .HasColumnName("valor_voucher")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Vigente)

                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AmiPoSugerencias>(entity =>
            {
                entity.HasKey(e => e.IdSugerencia)
                    .HasName("PK__AMI_PO_Sugerenci__25476A76");

                entity.ToTable("AMI_PO_Sugerencias");

                entity.Property(e => e.CodiProductoOrigen)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodiProductoResultante)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VigenciaDesde).HasColumnType("datetime");

                entity.Property(e => e.VigenciaHasta).HasColumnType("datetime");
            });

            modelBuilder.Entity<AmivBsCompanias>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("amiv_bs_companias");

                entity.Property(e => e.Cuit)
                    .HasColumnName("cuit")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Idcompania)
                    .HasColumnName("idcompania")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Idpersonajuridica).HasColumnName("idpersonajuridica");

                entity.Property(e => e.Razonsocial)
                    .IsRequired()
                    .HasColumnName("razonsocial")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Requierecondicionaceptacion)
                    .HasColumnName("requierecondicionaceptacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AmivBsCuitspaises>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("amiv_bs_cuitspaises");

                entity.Property(e => e.Codigopais)
                    .HasColumnName("codigopais")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cuit)
                    .HasColumnName("cuit")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Denominacionpais)
                    .IsRequired()
                    .HasColumnName("denominacionpais")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idcuitpais).HasColumnName("idcuitpais");

                entity.Property(e => e.Idpais).HasColumnName("idpais");
            });

            modelBuilder.Entity<AmivCoAgenciaMarkupProducto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("amiv_co_agencia_markupProducto");

                entity.Property(e => e.Denominacionagencia)
                    .IsRequired()
                    .HasColumnName("DENOMINACIONAGENCIA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Denominacionproducto)
                    .IsRequired()
                    .HasColumnName("DENOMINACIONPRODUCTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fechavigenciadesde)
                    .HasColumnName("FECHAVIGENCIADESDE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fechavigenciahasta)
                    .HasColumnName("FECHAVIGENCIAHASTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idagencia)
                    .HasColumnName("IDAGENCIA")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Idproducto).HasColumnName("IDPRODUCTO");

                entity.Property(e => e.Markup).HasColumnName("MARKUP");
            });

            modelBuilder.Entity<AmivCoAgencias>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AMIV_CO_Agencias");

                entity.Property(e => e.ApellidoNombreEjecutivo)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoSusep)
                    .HasColumnName("CodigoSUSEP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cuit)
                    .HasColumnName("CUIT")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DenominacionAgencia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisponePagoOnline)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoPersonaFisica)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoPersonaJuridica)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmiteVoucherEnEmision)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdEjecutivo).HasColumnName("idEjecutivo");

                entity.Property(e => e.Idresponsableiva).HasColumnName("idresponsableiva");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AmivCoAgenciasEcommerce>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AMIV_CO_Agencias_ECOMMERCE");

                entity.Property(e => e.ApellidoNombreEjecutivo)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.Cuit)
                    .HasColumnName("CUIT")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DenominacionAgencia)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisponePagoOnline)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EmiteVoucherEnEmision)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdEjecutivo).HasColumnName("idEjecutivo");

                entity.Property(e => e.Idresponsableiva).HasColumnName("idresponsableiva");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AmivCoClientes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AMIV_CO_CLIENTES");

                entity.Property(e => e.Apellido)
                    .HasColumnName("apellido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cuit)
                    .HasColumnName("cuit")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Descripciontipocliente)
                    .IsRequired()
                    .HasColumnName("descripciontipocliente")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idcliente)
                    .HasColumnName("idcliente")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Idpersonajuridica).HasColumnName("idpersonajuridica");

                entity.Property(e => e.Idtipocliente).HasColumnName("idtipocliente");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Razonsocial)
                    .HasColumnName("razonsocial")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipocliente)
                    .IsRequired()
                    .HasColumnName("tipocliente")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AmivCoPromotores>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AMIV_CO_Promotores");

                entity.Property(e => e.Apevendedor)
                    .IsRequired()
                    .HasColumnName("apevendedor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Denominacionagencia)
                    .HasColumnName("denominacionagencia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripciontipodocumento)
                    .IsRequired()
                    .HasColumnName("descripciontipodocumento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecnacimiento)
                    .HasColumnName("fecnacimiento")
                    .HasColumnType("datetime");

                entity.Property(e => e.Genero)
                    .IsRequired()
                    .HasColumnName("genero")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Idagencia).HasColumnName("idagencia");

                entity.Property(e => e.Iduser).HasColumnName("iduser");

                entity.Property(e => e.Idvendedor).HasColumnName("idvendedor");

                entity.Property(e => e.Legajo)
                    .HasColumnName("legajo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombrevendedor)
                    .IsRequired()
                    .HasColumnName("nombrevendedor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Numerodocumento)
                    .HasColumnName("numerodocumento")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Supervisor)
                    .IsRequired()
                    .HasColumnName("supervisor")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AmivCoRelacionProductoModalidad>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("amiv_co_RelacionProductoModalidad");

                entity.Property(e => e.Denominacionproducto)
                    .IsRequired()
                    .HasColumnName("denominacionproducto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idrelacion)
                    .HasColumnName("IDRelacion")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AmivCoRelacionTipoClienteModalidadProducto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("amiv_co_relacionTipoClienteModalidadProducto");

                entity.Property(e => e.Codigomodalidad)
                    .IsRequired()
                    .HasColumnName("codigomodalidad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcionmodalidad)
                    .IsRequired()
                    .HasColumnName("descripcionmodalidad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripciontipocliente)
                    .IsRequired()
                    .HasColumnName("descripciontipocliente")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdRelacion)
                    .HasColumnName("idRelacion")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdmodalidadProducto).HasColumnName("idmodalidadProducto");

                entity.Property(e => e.Idtipocliente).HasColumnName("idtipocliente");

                entity.Property(e => e.Tipocliente)
                    .IsRequired()
                    .HasColumnName("tipocliente")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AmivCoVendedoresAgencias>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AMIV_CO_VendedoresAgencias");

                entity.Property(e => e.ApeVendedor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoTipoDocumento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DenominacionAgencia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTipoDocumento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecNacimiento).HasColumnType("datetime");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.Genero)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Legajo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NombreVendedor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumento)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Supervisor)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AmivMiCorresponsales>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AMIV_MI_Corresponsales");

                entity.Property(e => e.Denominacionpais)
                    .IsRequired()
                    .HasColumnName("denominacionpais")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idcorresponsal).HasColumnName("idcorresponsal");

                entity.Property(e => e.Idpais).HasColumnName("idpais");

                entity.Property(e => e.Idpersonajuridica).HasColumnName("idpersonajuridica");

                entity.Property(e => e.Mail)
                    .HasColumnName("mail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .HasColumnName("observacion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Opcion).HasColumnName("opcion");

                entity.Property(e => e.Razonsocial)
                    .IsRequired()
                    .HasColumnName("razonsocial")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AmivMiEmpresas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("amiv_mi_empresas");

                entity.Property(e => e.Codigoempresa)
                    .HasColumnName("codigoempresa")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cuit)
                    .HasColumnName("cuit")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Idempresa)
                    .HasColumnName("idempresa")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Idpersonajuridica).HasColumnName("idpersonajuridica");

                entity.Property(e => e.Idresponsableiva).HasColumnName("idresponsableiva");

                entity.Property(e => e.Razonsocial)
                    .IsRequired()
                    .HasColumnName("razonsocial")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AmivPePersonaFisica>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AMIV_PE_PersonaFisica");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoTipoDocumento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTipoDocumento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AmivPePersonasFisicas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AMIV_PE_PersonasFisicas");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnName("apellido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Codigotipodocumento)
                    .IsRequired()
                    .HasColumnName("codigotipodocumento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripciontipodocumento)
                    .IsRequired()
                    .HasColumnName("descripciontipodocumento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fechanacimiento)
                    .HasColumnName("fechanacimiento")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idpersona).HasColumnName("idpersona");

                entity.Property(e => e.Idtipodocumento).HasColumnName("idtipodocumento");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasColumnName("sexo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AmivPePersonasFisicasCompleto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AMIV_PE_PersonasFisicasCompleto");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Calle).HasMaxLength(50);

                entity.Property(e => e.Ciudad).HasMaxLength(50);

                entity.Property(e => e.CodigoProvincia)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoTipoDocumento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(10);

                entity.Property(e => e.DeptoOficina).HasMaxLength(5);

                entity.Property(e => e.DescripcionTipoDocumento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumento)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDomicilio).HasMaxLength(6);

                entity.Property(e => e.PaisDomicilio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaisResidencia)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Piso).HasMaxLength(3);

                entity.Property(e => e.ProvinciaDomicilio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AmivPoBeneficiariosPoliza>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("amiv_PO_BeneficiariosPoliza");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DenominacionProducto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionParentesco)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTipoDocumento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAnulacion).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroPoliza)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AmivPoBilhetesVigentes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AMIV_PO_BILHETES_VIGENTES");

                entity.Property(e => e.Cpf)
                    .HasColumnName("CPF")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataDeEmissão)
                    .HasColumnName("Data de emissão")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.NúmeroDoBilhete)
                    .HasColumnName("Número do bilhete")
                    .HasMaxLength(52)
                    .IsUnicode(false);

                entity.Property(e => e.VigenciaFinal)
                    .HasColumnName("Vigencia final")
                    .HasColumnType("datetime");

                entity.Property(e => e.VigenciaInicial)
                    .HasColumnName("Vigencia inicial")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<AmivPoConsultaDeVouchers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AMIV_PO_ConsultaDeVouchers");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaDeEmisiónDelVoucher)
                    .HasColumnName("Fecha de emisión del voucher")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaDeFinDeCobertura)
                    .HasColumnName("Fecha de fin de cobertura")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaDeInicioDeCobertura)
                    .HasColumnName("Fecha de inicio de cobertura")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaDeNacimiento)
                    .HasColumnName("Fecha de Nacimiento")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NúmeroDeDocumento)
                    .HasColumnName("Número de Documento")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NúmeroDeVoucher)
                    .IsRequired()
                    .HasColumnName("Número de Voucher")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Parentesco)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDeDocumento)
                    .IsRequired()
                    .HasColumnName("Tipo de Documento")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AmivPoPolizas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AMIV_PO_Polizas");

                entity.Property(e => e.Agencia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgenciaVendedor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApeVendedor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DenominacionAgencia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DenominacionPais)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Diasproductoanual).HasColumnName("diasproductoanual");

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaDesde).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaHasta).HasColumnType("datetime");

                entity.Property(e => e.Fechaanulacion)
                    .HasColumnName("fechaanulacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idformapago).HasColumnName("idformapago");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreVendedor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nrocargo)
                    .HasColumnName("nrocargo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nrodocumento)
                    .HasColumnName("nrodocumento")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroPoliza)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Numerorecibocobranza).HasColumnName("numerorecibocobranza");

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.Tipodoc)
                    .IsRequired()
                    .HasColumnName("tipodoc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Titular)
                    .IsRequired()
                    .HasColumnName("titular")
                    .HasMaxLength(101)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AmivPrProductoDestino>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("amiv_pr_producto_destino");

                entity.Property(e => e.CodigoMotivoViaje)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DenoProducto1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DenoProducto2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DenoUpSell)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DenominacionPais)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoViaje)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AmivPrProductoServicios>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AMIV_Pr_ProductoServicios");

                entity.Property(e => e.Codigomoneda)
                    .HasColumnName("codigomoneda")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DenominacionProducto)
                    .IsRequired()
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcionservicio)
                    .IsRequired()
                    .HasColumnName("descripcionservicio")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Idproducto).HasColumnName("idproducto");

                entity.Property(e => e.Idservicio).HasColumnName("idservicio");

                entity.Property(e => e.Nroorden).HasColumnName("nroorden");

                entity.Property(e => e.Tope)
                    .HasColumnName("tope")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AmivPrProductodestino1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("amiv_pr_productodestino");

                entity.Property(e => e.Continente)
                    .HasColumnName("continente")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Denominacionpais)
                    .IsRequired()
                    .HasColumnName("denominacionpais")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idcompania).HasColumnName("idcompania");

                entity.Property(e => e.Idcontinente).HasColumnName("idcontinente");

                entity.Property(e => e.Idpais).HasColumnName("idpais");

                entity.Property(e => e.Idproducto1).HasColumnName("idproducto1");

                entity.Property(e => e.Idproducto2).HasColumnName("idproducto2");

                entity.Property(e => e.IdproductoUpsell).HasColumnName("idproductoUpsell");

                entity.Property(e => e.Idproductodestino)
                    .HasColumnName("idproductodestino")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Iso3l)
                    .HasColumnName("iso3l")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerSugerencia)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductoUpsell)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SegundaSugerencia)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AmivPrProductoprecio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("amiv_pr_productoprecio");

                entity.Property(e => e.Denominacionproducto)
                    .IsRequired()
                    .HasColumnName("denominacionproducto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dias).HasColumnName("dias");

                entity.Property(e => e.Edaddesde).HasColumnName("edaddesde");

                entity.Property(e => e.Edadhasta).HasColumnName("edadhasta");

                entity.Property(e => e.Fechadesde)
                    .HasColumnName("fechadesde")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fechahasta)
                    .HasColumnName("fechahasta")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idmodalidadproducto).HasColumnName("idmodalidadproducto");

                entity.Property(e => e.Idmoneda).HasColumnName("idmoneda");

                entity.Property(e => e.Idproducto)
                    .HasColumnName("idproducto")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Importe).HasColumnName("importe");

                entity.Property(e => e.Porcentajeadicional).HasColumnName("porcentajeadicional");
            });

            modelBuilder.Entity<AmivPrProductosAdicionales>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("amiv_pr_productos_adicionales");

                entity.Property(e => e.Compraprotegida).HasColumnName("compraprotegida");

                entity.Property(e => e.Golf).HasColumnName("golf");

                entity.Property(e => e.Idproducto).HasColumnName("idproducto");

                entity.Property(e => e.ProductoOriginal)
                    .IsRequired()
                    .HasColumnName("Producto_Original")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductoResultante)
                    .HasColumnName("Producto_Resultante")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AmivPrProductosagencias>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("amiv_pr_productosagencias");

                entity.Property(e => e.Codigoproducto)
                    .IsRequired()
                    .HasColumnName("codigoproducto")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Denominacionproducto)
                    .IsRequired()
                    .HasColumnName("denominacionproducto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idagencia).HasColumnName("idagencia");

                entity.Property(e => e.Idproducto).HasColumnName("idproducto");

                entity.Property(e => e.Razonsocial)
                    .IsRequired()
                    .HasColumnName("razonsocial")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AmivVouchersAce>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AMIV_Vouchers_ACE");

                entity.Property(e => e.Cpf)
                    .HasColumnName("CPF")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataCheckIn)
                    .HasColumnName("DATA CHECK-IN")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataCheckOut)
                    .HasColumnName("DATA CHECK-OUT")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataDeNascimento)
                    .HasColumnName("DATA DE NASCIMENTO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataDoCancelamento)
                    .HasColumnName("DATA DO CANCELAMENTO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataEmissão)
                    .HasColumnName("DATA EMISSÃO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdAgencia).HasColumnName("ID_Agencia");

                entity.Property(e => e.NomeDoAsegurado)
                    .IsRequired()
                    .HasColumnName("NOME DO ASEGURADO")
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.NºDiasViagem).HasColumnName("Nº DIAS VIAGEM");

                entity.Property(e => e.NºSorte)
                    .IsRequired()
                    .HasColumnName("Nº SORTE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Plano)
                    .IsRequired()
                    .HasColumnName("PLANO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Produto)
                    .IsRequired()
                    .HasColumnName("PRODUTO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sequencial)
                    .IsRequired()
                    .HasColumnName("SEQUENCIAL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasColumnName("SEXO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoRegistro)
                    .IsRequired()
                    .HasColumnName("TIPO REGISTRO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Voucher)
                    .IsRequired()
                    .HasColumnName("VOUCHER")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BsCiudades>(entity =>
            {
                entity.HasKey(e => e.IdCiudad);

                entity.ToTable("BS_Ciudades");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UrlMiniguia)
                    .IsRequired()
                    .HasColumnName("URL_Miniguia")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BsCodigosDocumentosPagoOnline>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BS_CodigosDocumentosPagoOnline");

                entity.Property(e => e.Codi)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descrip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCodiDocumentoPagoOnline).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<BsCodigosTarjetasPagoOnline>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BS_CodigosTarjetasPagoOnline");

                entity.Property(e => e.CodiParam)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdCodigoTarjetaPagoOnline).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<BsCompanias>(entity =>
            {
                entity.HasKey(e => e.IdCompania);

                entity.ToTable("BS_Companias");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.Idioma)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.RequiereCondicionAceptacion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdPersonaJuridicaNavigation)
                    .WithMany(p => p.BsCompanias)
                    .HasForeignKey(d => d.IdPersonaJuridica)
                    .HasConstraintName("FK_BS_IdCompania_IdPersonaJuridica");
            });

            modelBuilder.Entity<BsContinentes>(entity =>
            {
                entity.HasKey(e => e.IdContinente)
                    .HasName("PK__BS_Continentes__2F25DA6B")
                    .IsClustered(false);

                entity.ToTable("BS_Continentes");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Continente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BsCuitsPaises>(entity =>
            {
                entity.HasKey(e => e.IdCuitPais);

                entity.ToTable("BS_CuitsPaises");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cuit)
                    .HasColumnName("CUIT")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BsDatosContacto>(entity =>
            {
                entity.HasKey(e => e.IdDatosContacto);

                entity.ToTable("BS_DatosContacto");

                entity.HasIndex(e => e.EmailContacto)
                    .HasName("ix_PRE_OS_AMIBR_dbo_BS_DatosContacto_1");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailContacto)
                    .IsRequired()
                    .HasColumnName("EMailContacto")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NombreContacto)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BsEntidadesPagoOnline>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BS_Entidades_PagoOnline");

                entity.Property(e => e.Codi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descrip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdEntidadPagoOnline).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<BsFormasPago>(entity =>
            {
                entity.HasKey(e => e.IdFormaPagoBs);

                entity.ToTable("BS_FormasPago");

                entity.Property(e => e.IdFormaPagoBs).HasColumnName("IdFormaPagoBS");

                entity.Property(e => e.CodigoFormaPagoBs)
                    .IsRequired()
                    .HasColumnName("CodigoFormaPagoBS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionFormaPagoBs)
                    .IsRequired()
                    .HasColumnName("DescripcionFormaPagoBS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModPor).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BsLogMails>(entity =>
            {
                entity.HasKey(e => e.IdLogMail)
                    .HasName("PK__BS_Log_Mails")
                    .IsClustered(false);

                entity.ToTable("BS_Log_Mails");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.MailAttach)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailBcc)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailBody)
                    .HasMaxLength(6000)
                    .IsUnicode(false);

                entity.Property(e => e.MailBodyType)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MailFrom)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailResult)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.MailSubject)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailTo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BsLogMailsBody>(entity =>
            {
                entity.HasKey(e => e.IdLogMail)
                    .HasName("PK__BS_Log_Mails_Body")
                    .IsClustered(false);

                entity.ToTable("BS_Log_Mails_Body");

                entity.Property(e => e.IdLogMail).ValueGeneratedNever();

                entity.Property(e => e.MailBody).HasColumnType("ntext");

                entity.HasOne(d => d.IdLogMailNavigation)
                    .WithOne(p => p.BsLogMailsBody)
                    .HasForeignKey<BsLogMailsBody>(d => d.IdLogMail)
                    .HasConstraintName("FK__BS_Log_Mails_Body__BS_Log_Mails");
            });

            modelBuilder.Entity<BsMensajes>(entity =>
            {
                entity.HasKey(e => e.IdMensaje);

                entity.ToTable("BS_Mensajes");

                entity.Property(e => e.Idioma)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Mensaje)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BsMonedas>(entity =>
            {
                entity.HasKey(e => e.IdMoneda)
                    .HasName("PK_Monedas");

                entity.ToTable("BS_Monedas");

                entity.HasIndex(e => e.CodigoMoneda)
                    .HasName("IX_BS_Monedas")
                    .IsUnique();

                entity.Property(e => e.CodigoMoneda)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BsMonedasCotizaciones>(entity =>
            {
                entity.HasKey(e => e.IdMonedaCotizacion)
                    .HasName("PK_MonedasCotizaciones");

                entity.ToTable("BS_MonedasCotizaciones");

                entity.HasIndex(e => new { e.IdMoneda, e.FechaCotizacion })
                    .HasName("IX_BS_MonedasCotizaciones")
                    .IsUnique();

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaCotizacion).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMonedaNavigation)
                    .WithMany(p => p.BsMonedasCotizaciones)
                    .HasForeignKey(d => d.IdMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BS_MonedasCotizaciones_BS_Monedas");
            });

            modelBuilder.Entity<BsMotivoViaje>(entity =>
            {
                entity.HasKey(e => e.IdMotivoViaje);

                entity.ToTable("BS_Motivo_Viaje");

                entity.Property(e => e.AdicionalCompraProtegida)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AdicionalGolf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Habilitado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MotivoViaje)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VentaMayores)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VentaMenores)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BsNotificacion>(entity =>
            {
                entity.HasKey(e => e.IdNotificacion);

                entity.ToTable("BS_Notificacion");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ListaDeDestino)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Mensagem)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NomeDoDisparo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoNotificacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UrldoEmail)
                    .HasColumnName("URLDoEmail")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BsNotificacionOrigen>(entity =>
            {
                entity.HasKey(e => e.IdNotificacionOrigen);

                entity.ToTable("BS_Notificacion_Origen");

                entity.Property(e => e.CampoHijo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CampoPadre)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NombreTabla)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Origen)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BsPaises>(entity =>
            {
                entity.HasKey(e => e.IdPais)
                    .HasName("PK_Paises");

                entity.ToTable("BS_Paises");

                entity.Property(e => e.CodigoPais)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContactoIag)
                    .HasColumnName("ContactoIAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DenominacionPais)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.Iso3l)
                    .HasColumnName("ISO3L")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
            });

            modelBuilder.Entity<BsPaisesEmpresa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BS_Paises_Empresa");

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.IdPais)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IdPaisEmpresa).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<BsParametros>(entity =>
            {
                entity.HasKey(e => e.IdParametros);

                entity.ToTable("BS_Parametros");

                entity.HasIndex(e => new { e.NombreParametro, e.IdCompania })
                    .HasName("IX_BS_Parametros")
                    .IsUnique();

                entity.Property(e => e.DescripcionParametro)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NombreParametro)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValorParametro)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BsProvincias>(entity =>
            {
                entity.HasKey(e => e.IdProvincia);

                entity.ToTable("BS_Provincias");

                entity.Property(e => e.CodigoProvincia)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionProvincia)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.BsProvincias)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BS_Provincias_BS_Paises");
            });

            modelBuilder.Entity<BsRolesPorGrupo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BS_RolesPorGrupo");

                entity.Property(e => e.IdRolGrupo).ValueGeneratedOnAdd();

                entity.Property(e => e.Parametro)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.TipoUsuario)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BsSegmentosAgencias>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BS_Segmentos_Agencias");

                entity.Property(e => e.CodigoSegmentoAgencia)
                    .HasColumnName("codigo_segmento_agencia")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionSegmentoAgencia)
                    .HasColumnName("descripcion_segmento_agencia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnviaMensaje).HasColumnName("enviaMensaje");

                entity.Property(e => e.IdSegmentoAgencia)
                    .HasColumnName("id_segmento_agencia")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<BsUsuarios>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BS_Usuarios");

                entity.Property(e => e.IdUsuario).ValueGeneratedOnAdd();

                entity.Property(e => e.Usuario)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });



            modelBuilder.Entity<CoAgenciaCanalDistribucion>(entity =>
            {
                entity.HasKey(e => e.IdAgenciaCanalDistribucion)
                    .HasName("PK__CO_Agencia_Canal__7A280247")
                    .IsClustered(false);

                entity.ToTable("CO_Agencia_CanalDistribucion");

                entity.Property(e => e.SolicitaCondicionesGenerales)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.CoAgenciaCanalDistribucion)
                    .HasForeignKey(d => d.IdAgencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo_CO_Agencia_CanalDistribucion_1");

                entity.HasOne(d => d.IdCanalDistribucionNavigation)
                    .WithMany(p => p.CoAgenciaCanalDistribucion)
                    .HasForeignKey(d => d.IdCanalDistribucion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo_CO_Agencia_CanalDistribucion_2");
            });

            modelBuilder.Entity<CoAgenciaMotivoViaje>(entity =>
            {
                entity.HasKey(e => e.IdAgenciaMotivoViaje);

                entity.ToTable("CO_Agencia_MotivoViaje");
            });

            modelBuilder.Entity<CoAgencias>(entity =>
            {
                entity.HasKey(e => e.IdAgencia);

                entity.ToTable("CO_Agencias");

                entity.HasIndex(e => e.UserId)
                    .HasName("ix_CO_Agencias_1");

                entity.Property(e => e.CobranzaAutomatica)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CobranzaAutomaticaTc)
                    .HasColumnName("CobranzaAutomaticaTC")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoSusep)
                    .HasColumnName("CodigoSUSEP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DispPagoOnline)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DisponePagoOnline)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmiteVoucherEnEmision)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.IdentificarVenda)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Leyenda)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.LeyendaIngles)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.MarcaAgenciaSupervisora)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MarcaCtaCteIndividual)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mayorista)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PathLogo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RequiereAceptacionCondiciones)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RequiereMailTitular)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPersona)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UrlPagoOnline)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasComment("Id del usuario en la base DotNetNukeAMI");

                entity.HasOne(d => d.IdPeriodicidadFactuEfectivoNavigation)
                    .WithMany(p => p.CoAgenciasIdPeriodicidadFactuEfectivoNavigation)
                    .HasForeignKey(d => d.IdPeriodicidadFactuEfectivo)
                    .HasConstraintName("FK_CO_PeriodicidadFacturacionEfectivo");

                entity.HasOne(d => d.IdPeriodicidadFactuTarjetaNavigation)
                    .WithMany(p => p.CoAgenciasIdPeriodicidadFactuTarjetaNavigation)
                    .HasForeignKey(d => d.IdPeriodicidadFactuTarjeta)
                    .HasConstraintName("FK_CO_PeriodicidadFacturacionTarjeta");

                entity.HasOne(d => d.IdPersonaJuridicaNavigation)
                    .WithMany(p => p.CoAgencias)
                    .HasForeignKey(d => d.IdPersonaJuridica)
                    .HasConstraintName("FK_CO_Agencias_PE_PersonaJuridica");
            });

            modelBuilder.Entity<CoAgenciasBudget>(entity =>
            {
                entity.HasKey(e => e.IdAgenciabudget)
                    .HasName("PK_dbo.CO_AgenciasBudget");

                entity.ToTable("CO_AgenciasBudget");

                entity.Property(e => e.IdAgenciabudget).HasColumnName("idAgenciabudget");

                entity.Property(e => e.FechaDesde).HasColumnType("datetime");

                entity.Property(e => e.FechaHasta).HasColumnType("datetime");

                entity.Property(e => e.IdAgencia).HasColumnName("idAgencia");

                entity.Property(e => e.Monto).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.CoAgenciasBudget)
                    .HasForeignKey(d => d.IdAgencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CO_AgenciasBudget_dbo.CO_AgenciasBudget");
            });

            modelBuilder.Entity<CoAgenciasCobranza>(entity =>
            {
                entity.HasKey(e => e.IdAgenciaCobranza);

                entity.ToTable("CO_AgenciasCobranza");

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.CoAgenciasCobranza)
                    .HasForeignKey(d => d.IdAgencia)
                    .HasConstraintName("FK_CO_AgenciasCobranza_CO_Agencias");
            });

            modelBuilder.Entity<CoAgenciasEjecutivo>(entity =>
            {
                entity.HasKey(e => e.IdAgenciaEjecutivo);

                entity.ToTable("CO_AgenciasEjecutivo");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.CoAgenciasEjecutivo)
                    .HasForeignKey(d => d.IdAgencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_AgenciasEjecutivo_CO_Agencias");

                entity.HasOne(d => d.IdEjecutivoNavigation)
                    .WithMany(p => p.CoAgenciasEjecutivo)
                    .HasForeignKey(d => d.IdEjecutivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_AgenciasEjecutivo_CO_Ejecutivos");
            });

            modelBuilder.Entity<CoAgenciasEjecutivoResponsable>(entity =>
            {
                entity.HasKey(e => e.IdAgenciaEjecutivo);

                entity.ToTable("CO_AgenciasEjecutivoResponsable");

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.CoAgenciasEjecutivoResponsable)
                    .HasForeignKey(d => d.IdAgencia)
                    .HasConstraintName("FK_CO_AgenciasEjecutivoResponsable_CO_Agencias");
            });

            modelBuilder.Entity<CoAgenciasRepresentante>(entity =>
            {
                entity.HasKey(e => e.IdAgenciaRepresentante);

                entity.ToTable("CO_AgenciasRepresentante");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.CoAgenciasRepresentante)
                    .HasForeignKey(d => d.IdAgencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_AgenciasRepresentante_CO_Agencias");

                entity.HasOne(d => d.IdRepresentanteNavigation)
                    .WithMany(p => p.CoAgenciasRepresentante)
                    .HasForeignKey(d => d.IdRepresentante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_AgenciasRepresentante_CO_Representantes");
            });

            modelBuilder.Entity<CoAnticiposPublicidad>(entity =>
            {
                entity.HasKey(e => e.IdAnticipoPublicidad);

                entity.ToTable("CO_AnticiposPublicidad");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoCanalComercial>(entity =>
            {
                entity.HasKey(e => e.IdCanalComercial);

                entity.ToTable("CO_CanalComercial");

                entity.Property(e => e.CodigoCanalComercial)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCanalComercial)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoCanalDistribucion>(entity =>
            {
                entity.HasKey(e => e.IdCanalDistribucion);

                entity.ToTable("CO_CanalDistribucion");

                entity.Property(e => e.CodigoCanalDistribucion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCanalDistribucion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoClientes>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.ToTable("CO_Clientes");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteIndividualNavigation)
                    .WithMany(p => p.CoClientes)
                    .HasForeignKey(d => d.IdClienteIndividual)
                    .HasConstraintName("FK_CO_Clientes_CO_ClientesIndividuales");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.CoClientes)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("FK_CO_Clientes_CO_Empresas");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.CoClientes)
                    .HasForeignKey(d => d.IdPersona)
                    .HasConstraintName("FK_CO_Clientes_PE_PersonaFisica");

                entity.HasOne(d => d.IdPersonaJuridicaNavigation)
                    .WithMany(p => p.CoClientes)
                    .HasForeignKey(d => d.IdPersonaJuridica)
                    .HasConstraintName("FK_CO_Clientes_PE_PersonaJuridica");

                entity.HasOne(d => d.IdTipoClienteNavigation)
                    .WithMany(p => p.CoClientes)
                    .HasForeignKey(d => d.IdTipoCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_Clientes_CO_TiposCliente");
            });

            modelBuilder.Entity<CoClientesIndividuales>(entity =>
            {
                entity.HasKey(e => e.IdClienteIndividual);

                entity.ToTable("CO_ClientesIndividuales");

                entity.Property(e => e.CodigoVerificador)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroTarjeta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFormaPagoNavigation)
                    .WithMany(p => p.CoClientesIndividuales)
                    .HasForeignKey(d => d.IdFormaPago)
                    .HasConstraintName("FK_CO_ClientesIndividuales_PO_FormasPago");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.CoClientesIndividuales)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_ClientesIndividuales_PE_PersonaFisica");
            });

            modelBuilder.Entity<CoComisionesAgencias>(entity =>
            {
                entity.HasKey(e => e.IdComisionAgencia);

                entity.ToTable("CO_ComisionesAgencias");

                entity.HasIndex(e => new { e.IdAgencia, e.FechaComision })
                    .HasName("UK_CO_ComisionesAgencias")
                    .IsUnique();

                entity.Property(e => e.Comision).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaComision).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.CoComisionesAgencias)
                    .HasForeignKey(d => d.IdAgencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_ComisionesAgencias_CO_Agencias");
            });

            modelBuilder.Entity<CoComisionesRepresentante>(entity =>
            {
                entity.HasKey(e => e.IdComisionRepresentante);

                entity.ToTable("CO_ComisionesRepresentante");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRepresentanteNavigation)
                    .WithMany(p => p.CoComisionesRepresentante)
                    .HasForeignKey(d => d.IdRepresentante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_ComisionesRepresentante_CO_Representantes");
            });

            modelBuilder.Entity<CoComisionesTipoClienteModalidadProducto>(entity =>
            {
                entity.HasKey(e => e.IdComisionModalidadProducto);

                entity.ToTable("CO_ComisionesTipoClienteModalidadProducto");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaVigencia).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoRelacionClienteProductoNavigation)
                    .WithMany(p => p.CoComisionesTipoClienteModalidadProducto)
                    .HasForeignKey(d => d.IdTipoRelacionClienteProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_ComisionesTipoClienteModalidadProducto_CO_RelacionTipoClienteModalidadProducto");
            });

            modelBuilder.Entity<CoComposicionGrupoClienteIndividual>(entity =>
            {
                entity.HasKey(e => e.IdGrupoFamiliarIndividuo);

                entity.ToTable("CO_ComposicionGrupoClienteIndividual");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteIndividualNavigation)
                    .WithMany(p => p.CoComposicionGrupoClienteIndividual)
                    .HasForeignKey(d => d.IdClienteIndividual)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_ComposicionGrupoClienteIndividual_CO_ClientesIndividuales");

                entity.HasOne(d => d.IdParentescoNavigation)
                    .WithMany(p => p.CoComposicionGrupoClienteIndividual)
                    .HasForeignKey(d => d.IdParentesco)
                    .HasConstraintName("FK_CO_ComposicionGrupoClienteIndividual_PO_Parentesco");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.CoComposicionGrupoClienteIndividual)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_ComposicionGrupoClienteIndividual_PE_PersonaFisica");
            });

            modelBuilder.Entity<CoConsumosVentas>(entity =>
            {
                entity.HasKey(e => e.IdConsumosVenta);

                entity.ToTable("CO_ConsumosVentas");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaConsumo).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDetallesVentaNavigation)
                    .WithMany(p => p.CoConsumosVentas)
                    .HasForeignKey(d => d.IdDetallesVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_ConsumosVentas_CO_DetallesVenta");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.CoConsumosVentas)
                    .HasForeignKey(d => d.IdPersona)
                    .HasConstraintName("FK_CO_ConsumosVentas_PE_PersonaFisica");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.CoConsumosVentas)
                    .HasForeignKey(d => d.IdPoliza)
                    .HasConstraintName("FK_CO_ConsumosVentas_PO_Polizas");
            });

            modelBuilder.Entity<CoCotizacionesIndividuosLog>(entity =>
            {
                entity.HasKey(e => e.IdCotizacionIndividuo);

                entity.ToTable("CO_CotizacionesIndividuosLog");

                entity.HasIndex(e => new { e.IdCotizacionIndividuo, e.IdAgencia, e.IdProducto })
                    .HasName("CO_CotizacionesIndividuosLog_IX01");

                entity.HasIndex(e => new { e.FechaInicVigencia, e.FechaFinVigencia, e.IdProducto, e.FecCreaReg, e.IdAgencia, e.IdPais })
                    .HasName("ix_idPais");

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cupon)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicVigencia).HasColumnType("datetime");

                entity.Property(e => e.IdAgencia).HasColumnName("idAgencia");

                entity.Property(e => e.MarcaDestinoEuropa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.CoCotizacionesIndividuosLog)
                    .HasForeignKey(d => d.IdAgencia)
                    .HasConstraintName("FK_CO_CotizacionesIndividuosLog_CO_Agencias");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.CoCotizacionesIndividuosLog)
                    .HasForeignKey(d => d.IdPais)
                    .HasConstraintName("FK_CO_CotizacionesIndividuosLog_BS_Paises");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.CoCotizacionesIndividuosLog)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("FK_CO_CotizacionesIndividuosLog_PR_Producto");

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.CoCotizacionesIndividuosLog)
                    .HasForeignKey(d => d.IdProvincia)
                    .HasConstraintName("FK_CO_CotizacionesIndividuosLog_BS_Provincias");

                entity.HasOne(d => d.IdTipoProductoNavigation)
                    .WithMany(p => p.CoCotizacionesIndividuosLog)
                    .HasForeignKey(d => d.IdTipoProducto)
                    .HasConstraintName("FK_CO_CotizacionesIndividuosLog_PR_TipoProducto");

                entity.HasOne(d => d.IdTipoPromocionNavigation)
                    .WithMany(p => p.CoCotizacionesIndividuosLog)
                    .HasForeignKey(d => d.IdTipoPromocion)
                    .HasConstraintName("FK_CO_CotizacionesIndividuosLog_PR_TiposPromocion");

                entity.HasOne(d => d.IdTipoViajeNavigation)
                    .WithMany(p => p.CoCotizacionesIndividuosLog)
                    .HasForeignKey(d => d.IdTipoViaje)
                    .HasConstraintName("FK_CO_CotizacionesIndividuosLog_PR_TipoViaje");
            });

            modelBuilder.Entity<CoCotizacionesIndividuosLogHis>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CO_CotizacionesIndividuosLog_His");

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicVigencia).HasColumnType("datetime");

                entity.Property(e => e.IdAgencia).HasColumnName("idAgencia");

                entity.Property(e => e.IdCotizacionIndividuo).ValueGeneratedOnAdd();

                entity.Property(e => e.MarcaDestinoEuropa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoDetalleCotizacionesIndividuosLog>(entity =>
            {
                entity.HasKey(e => e.IdDetalleCotizacionesIndividuos);

                entity.ToTable("CO_DetalleCotizacionesIndividuosLog");

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.HasOne(d => d.IdCotizacionIndividuoNavigation)
                    .WithMany(p => p.CoDetalleCotizacionesIndividuosLog)
                    .HasForeignKey(d => d.IdCotizacionIndividuo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_DetalleCotizacionesIndividuosLog_CO_CotizacionesIndividuosLog");

                entity.HasOne(d => d.IdMonedaNavigation)
                    .WithMany(p => p.CoDetalleCotizacionesIndividuosLog)
                    .HasForeignKey(d => d.IdMoneda)
                    .HasConstraintName("FK_CO_DetalleCotizacionesIndividuosLog_BS_Monedas");
            });

            modelBuilder.Entity<CoDetalleCotizacionesIndividuosLogHis>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CO_DetalleCotizacionesIndividuosLog_His");

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.IdDetalleCotizacionesIndividuos).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CoDetallesVenta>(entity =>
            {
                entity.HasKey(e => e.IdDetallesVenta)
                    .HasName("PK_CO_DetallesVenta_1");

                entity.ToTable("CO_DetallesVenta");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.IdgrupoFamiliarIndividuo).HasColumnName("IDGrupoFamiliarIndividuo");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMonedaNavigation)
                    .WithMany(p => p.CoDetallesVenta)
                    .HasForeignKey(d => d.IdMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_DetallesVenta_BS_Monedas");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.CoDetallesVenta)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_DetallesVenta_PR_Producto");

                entity.HasOne(d => d.IdVentaNavigation)
                    .WithMany(p => p.CoDetallesVenta)
                    .HasForeignKey(d => d.IdVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_DetallesVenta_CO_Ventas");
            });

            modelBuilder.Entity<CoDetallesVentaPacksOnline>(entity =>
            {
                entity.HasKey(e => e.IdDetallesVentaPackOnline)
                    .HasName("PK_CO_DetallesVentaPackOnline");

                entity.ToTable("CO_DetallesVentaPacksOnline");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.HasOne(d => d.IdMonedaNavigation)
                    .WithMany(p => p.CoDetallesVentaPacksOnline)
                    .HasForeignKey(d => d.IdMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_DetallesVentaPacksOnline_BS_Monedas");

                entity.HasOne(d => d.IdPaisDestinoNavigation)
                    .WithMany(p => p.CoDetallesVentaPacksOnline)
                    .HasForeignKey(d => d.IdPaisDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_DetallesVentaPacksOnline_BS_Paises");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.CoDetallesVentaPacksOnline)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_DetallesVentaPacksOnline_PR_Producto");

                entity.HasOne(d => d.IdVentaPackOnlineNavigation)
                    .WithMany(p => p.CoDetallesVentaPacksOnline)
                    .HasForeignKey(d => d.IdVentaPackOnline)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_DetallesVentaPacksOnline_CO_VentaPacksOnline");
            });

            modelBuilder.Entity<CoEjecutivos>(entity =>
            {
                entity.HasKey(e => e.IdEjecutivo);

                entity.ToTable("CO_Ejecutivos");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroLegajo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCompaniaNavigation)
                    .WithMany(p => p.CoEjecutivos)
                    .HasForeignKey(d => d.IdCompania)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_Ejecutivos_BS_Companias");

                entity.HasOne(d => d.IdPersonaFisicaNavigation)
                    .WithMany(p => p.CoEjecutivos)
                    .HasForeignKey(d => d.IdPersonaFisica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_Ejecutivos_PE_PersonaFisica");
            });

            modelBuilder.Entity<CoEmpresas>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.ToTable("CO_Empresas");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.IdPersonaJuridicaNavigation)
                    .WithMany(p => p.CoEmpresas)
                    .HasForeignKey(d => d.IdPersonaJuridica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_Empresas_PE_PersonaJuridica");
            });

            modelBuilder.Entity<CoEmpresasLogHabilitacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CO_Empresas_LogHabilitacion");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoFormasPagoAgencias>(entity =>
            {
                entity.HasKey(e => e.IdFormaPagoAgencia);

                entity.ToTable("CO_FormasPagoAgencias");

                entity.HasIndex(e => new { e.IdAgencia, e.FechaBaja, e.FechaInicio })
                    .HasName("ix_CO_FormasPagoAgencias_1");

                entity.HasIndex(e => new { e.IdAgencia, e.FechaBaja, e.FechaInicio, e.FechaFin })
                    .HasName("ix_CO_FormasPagoAgencias_2");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UrlPagoOnline)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.CoFormasPagoAgencias)
                    .HasForeignKey(d => d.IdAgencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_FormasPagoAgencias_CO_Agencias");

                entity.HasOne(d => d.IdFormaPagoNavigation)
                    .WithMany(p => p.CoFormasPagoAgencias)
                    .HasForeignKey(d => d.IdFormaPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_FormasPagoAgencias_PO_FormasPago");
            });

            modelBuilder.Entity<CoNominasEmpresas>(entity =>
            {
                entity.HasKey(e => e.IdNomina);

                entity.ToTable("CO_NominasEmpresas");

                entity.Property(e => e.VigenciaDesde).HasColumnType("datetime");

                entity.Property(e => e.VigenciaHasta).HasColumnType("datetime");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.CoNominasEmpresas)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_NominasEmpresas_CO_Clientes");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.CoNominasEmpresas)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_NominasEmpresas_PE_PersonaFisica");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.CoNominasEmpresas)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_NominasEmpresas_PR_Producto");
            });

            modelBuilder.Entity<CoPatrocinadorMarca>(entity =>
            {
                entity.HasKey(e => e.IdPatrocinadorMarca);

                entity.ToTable("CO_PatrocinadorMarca");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaAcuerdo).HasColumnType("datetime");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.FileDocumento)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileLogo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatrocinadorAffinity)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdMarcaNavigation)
                    .WithMany(p => p.CoPatrocinadorMarca)
                    .HasForeignKey(d => d.IdMarca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_PatrocinadorMarca_PR_Marcas");

                entity.HasOne(d => d.IdPatrocinadorNavigation)
                    .WithMany(p => p.CoPatrocinadorMarca)
                    .HasForeignKey(d => d.IdPatrocinador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_PatrocinadorMarca_CO_Patrocinadores");
            });

            modelBuilder.Entity<CoPatrocinadores>(entity =>
            {
                entity.HasKey(e => e.IdPatrocinador);

                entity.ToTable("CO_Patrocinadores");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPersonaJuridicaNavigation)
                    .WithMany(p => p.CoPatrocinadores)
                    .HasForeignKey(d => d.IdPersonaJuridica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_Patrocinadores_PE_PersonaJuridica");
            });

            modelBuilder.Entity<CoPeriodicidadComision>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CO_PeriodicidadComision");

                entity.Property(e => e.CodigoPeriodicidadComision)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionPeriodicidadComision)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.IdPeriodicidadComision).ValueGeneratedOnAdd();

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoPeriodicidadFacturacion>(entity =>
            {
                entity.HasKey(e => e.IdPeriodicidadFactu);

                entity.ToTable("CO_PeriodicidadFacturacion");

                entity.HasIndex(e => e.CodigoPeriodicidadFactu)
                    .HasName("UK_CodigoPeriodicidadFactu")
                    .IsUnique();

                entity.HasIndex(e => e.DescripcionPeriodicidadFactu)
                    .HasName("UK_DescripcionPeriodicidadFactu")
                    .IsUnique();

                entity.Property(e => e.CodigoPeriodicidadFactu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionPeriodicidadFactu)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoProductosAgenciasMarkUp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CO_ProductosAgencias_MarkUp");

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.IdProductoAgenciaMarkUp).ValueGeneratedOnAdd();

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoProductosAgenciasMarkUpDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CO_ProductosAgencias_MarkUp_Detalle");

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FechaVigenciaDesde).HasColumnType("datetime");

                entity.Property(e => e.FechaVigenciaHasta).HasColumnType("datetime");

                entity.Property(e => e.IdDetallePam)
                    .HasColumnName("IdDetallePAM")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CoRelacionTipoClienteModalidadProducto>(entity =>
            {
                entity.HasKey(e => e.IdTipoRelacionClienteProducto);

                entity.ToTable("CO_RelacionTipoClienteModalidadProducto");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdModalidadProductoNavigation)
                    .WithMany(p => p.CoRelacionTipoClienteModalidadProducto)
                    .HasForeignKey(d => d.IdModalidadProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_RelacionTipoClienteModalidadProducto_PR_ModalidadProducto");

                entity.HasOne(d => d.IdTipoClienteNavigation)
                    .WithMany(p => p.CoRelacionTipoClienteModalidadProducto)
                    .HasForeignKey(d => d.IdTipoCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_RelacionTipoClienteModalidadProducto_CO_TiposCliente");
            });

            modelBuilder.Entity<CoRepresentantes>(entity =>
            {
                entity.HasKey(e => e.IdRepresentante);

                entity.ToTable("CO_Representantes");

                entity.Property(e => e.Contacto)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaRevision).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.IdCompaniaNavigation)
                    .WithMany(p => p.CoRepresentantes)
                    .HasForeignKey(d => d.IdCompania)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_Representantes_BS_Companias");

                entity.HasOne(d => d.IdPersonaJuridicaNavigation)
                    .WithMany(p => p.CoRepresentantes)
                    .HasForeignKey(d => d.IdPersonaJuridica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_Representantes_PE_PersonaJuridica");
            });

            modelBuilder.Entity<CoResponsableIva>(entity =>
            {
                entity.HasKey(e => e.IdResponsableIva)
                    .HasName("PK_ResponsableIVA");

                entity.ToTable("CO_ResponsableIVA");

                entity.Property(e => e.IdResponsableIva).HasColumnName("IdResponsableIVA");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionResponsableIva)
                    .IsRequired()
                    .HasColumnName("DescripcionResponsableIVA")
                    .HasMaxLength(50);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoSellerIdcanalesVentas>(entity =>
            {
                entity.HasKey(e => e.IdSellerIdcanalesVentas);

                entity.ToTable("CO_SellerIDCanalesVentas");

                entity.Property(e => e.IdSellerIdcanalesVentas).HasColumnName("IdSellerIDCanalesVentas");

                entity.Property(e => e.Attr1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Attr2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.FooterHtml)
                    .HasColumnName("FooterHTML")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderHtml)
                    .HasColumnName("HeaderHTML")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SellerId)
                    .IsRequired()
                    .HasColumnName("SellerID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.CoSellerIdcanalesVentas)
                    .HasForeignKey(d => d.IdAgencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_SellerIDCanalesVentas_CO_Agencias");

                entity.HasOne(d => d.IdCanalComercialNavigation)
                    .WithMany(p => p.CoSellerIdcanalesVentas)
                    .HasForeignKey(d => d.IdCanalComercial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_SellerIDCanalesVentas_CO_CanalComercial");

                entity.HasOne(d => d.IdCanalDistribucionNavigation)
                    .WithMany(p => p.CoSellerIdcanalesVentas)
                    .HasForeignKey(d => d.IdCanalDistribucion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_SellerIDCanalesVentas_CO_CanalDistribucion");

                entity.HasOne(d => d.IdTipoCanalVentaNavigation)
                    .WithMany(p => p.CoSellerIdcanalesVentas)
                    .HasForeignKey(d => d.IdTipoCanalVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_SellerIDCanalesVentas_CO_TipoCanalVenta");
            });

            modelBuilder.Entity<CoTipoCalculoImporte>(entity =>
            {
                entity.HasKey(e => e.IdTipoCalculoImporte)
                    .HasName("CO_TipoCalculoImporte_PK");

                entity.ToTable("CO_TipoCalculoImporte");

                entity.Property(e => e.Codi)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpCalculo)
                    .IsRequired()
                    .HasColumnName("SP_Calculo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpRecalculo)
                    .IsRequired()
                    .HasColumnName("SP_Recalculo")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoTipoCanalVenta>(entity =>
            {
                entity.HasKey(e => e.IdTipoCanalVenta);

                entity.ToTable("CO_TipoCanalVenta");

                entity.Property(e => e.CodigoTipoCanalVenta)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTipoCanalVenta)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoTipoComision>(entity =>
            {
                entity.HasKey(e => e.IdTipoComisionAgencia);

                entity.ToTable("CO_TipoComision");

                entity.Property(e => e.CodigoTipoComisionAgencia)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTipoComisionAgencia)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoTiposCliente>(entity =>
            {
                entity.HasKey(e => e.IdTipoCliente);

                entity.ToTable("CO_TiposCliente");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTipoCliente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCliente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoVentaNavigation)
                    .WithMany(p => p.CoTiposCliente)
                    .HasForeignKey(d => d.IdTipoVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_TiposCliente_CO_TiposdeVenta");
            });

            modelBuilder.Entity<CoTiposdeVenta>(entity =>
            {
                entity.HasKey(e => e.IdTipodeVenta);

                entity.ToTable("CO_TiposdeVenta");

                entity.Property(e => e.CodigoTipoClienteFacturador)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTipoVenta)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoVenta)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoUnidadMetaComision>(entity =>
            {
                entity.HasKey(e => e.IdUnidadMetaComision);

                entity.ToTable("CO_UnidadMetaComision");

                entity.Property(e => e.CodigoUnidadMetaComision)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionUnidadMetaComision)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoVendedoresAgencias>(entity =>
            {
                entity.HasKey(e => e.IdVendedor)
                    .HasName("PK_CO_VendedoresAgencias_1");

                entity.ToTable("CO_VendedoresAgencias");

                entity.HasIndex(e => e.IdUser)
                    .HasName("IX_CO_VendedoresAgencias")
                    .IsUnique();

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.Filial)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HashVendedor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Legajo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreFantasia)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Supervisor)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.CoVendedoresAgencias)
                    .HasForeignKey(d => d.IdAgencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_VendedoresAgencias_CO_Agencias");

                entity.HasOne(d => d.IdPersonaFisicaNavigation)
                    .WithMany(p => p.CoVendedoresAgencias)
                    .HasForeignKey(d => d.IdPersonaFisica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_VendedoresAgencias_PE_PersonaFisica");
            });


            modelBuilder.Entity<CoVentaPacksOnline>(entity =>
            {
                entity.HasKey(e => e.IdVentaPackOnline);

                entity.ToTable("CO_VentaPacksOnline");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FechaAnulacion).HasColumnType("datetime");

                entity.Property(e => e.FechaVenta).HasColumnType("datetime");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.CoVentaPacksOnline)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_VentaPacksOnline_CO_Clientes");

                entity.HasOne(d => d.IdModalidadProductoNavigation)
                    .WithMany(p => p.CoVentaPacksOnline)
                    .HasForeignKey(d => d.IdModalidadProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_VentaPacksOnline_PR_ModalidadProducto");

                entity.HasOne(d => d.IdVendedorNavigation)
                    .WithMany(p => p.CoVentaPacksOnline)
                    .HasForeignKey(d => d.IdVendedor)
                    .HasConstraintName("FK_CO_VentaPacksOnline_CO_VendedoresAgencias");
            });

            modelBuilder.Entity<CoVentas>(entity =>
            {
                entity.HasKey(e => e.IdVenta);

                entity.ToTable("CO_Ventas");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaAnulacion).HasColumnType("datetime");

                entity.Property(e => e.FechaVenta).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodoVigencia).HasColumnType("numeric(6, 0)");

                entity.Property(e => e.RenovacionAutomatica)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.CoVentas)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_Ventas_CO_Clientes");

                entity.HasOne(d => d.IdModalidadProductoNavigation)
                    .WithMany(p => p.CoVentas)
                    .HasForeignKey(d => d.IdModalidadProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_Ventas_PR_ModalidadProducto");

                entity.HasOne(d => d.IdVendedorNavigation)
                    .WithMany(p => p.CoVentas)
                    .HasForeignKey(d => d.IdVendedor)
                    .HasConstraintName("FK_CO_Ventas_CO_VendedoresAgencias");
            });

            modelBuilder.Entity<CoVentasFormaPago>(entity =>
            {
                entity.HasKey(e => e.IdVentaFormaPago);

                entity.ToTable("CO_VentasFormaPago");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.IdFormaPagoBs).HasColumnName("IdFormaPagoBS");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFormaPagoBsNavigation)
                    .WithMany(p => p.CoVentasFormaPago)
                    .HasForeignKey(d => d.IdFormaPagoBs)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_VentasFormaPago_BS_FormasPago");

                entity.HasOne(d => d.IdVentaNavigation)
                    .WithMany(p => p.CoVentasFormaPago)
                    .HasForeignKey(d => d.IdVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CO_VentasFormaPago_CO_Ventas");
            });

            modelBuilder.Entity<EmailContactoAgencias>(entity =>
            {
                entity.HasKey(e => e.IdContacto);

                entity.ToTable("Email_Contacto_Agencias");

                entity.Property(e => e.IdContacto).HasColumnName("Id_contacto");

                entity.Property(e => e.Agencia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Banco)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Barrio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Calle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cargo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cep)
                    .HasColumnName("CEP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cnpj)
                    .HasColumnName("CNPJ")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Complemento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConfEmail)
                    .HasColumnName("Conf_Email")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Cpf)
                    .HasColumnName("CPF")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cuenta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Departamento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("Fecha_Nacimiento")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IncripcionEstatal)
                    .HasColumnName("Incripcion_Estatal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCompleto)
                    .HasColumnName("Nombre_Completo")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NombreFantasia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroFuncionarios)
                    .HasColumnName("Numero_Funcionarios")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasColumnName("Razon_Social")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RecibirInfoCelular)
                    .HasColumnName("Recibir_Info_Celular")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.RecibirInfoEmail)
                    .HasColumnName("Recibir_Info_Email")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmailContactoClientes>(entity =>
            {
                entity.HasKey(e => e.IdContaco);

                entity.ToTable("Email_Contacto_Clientes");

                entity.Property(e => e.IdContaco).HasColumnName("Id_contaco");

                entity.Property(e => e.Asunto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cep)
                    .HasColumnName("CEP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("Fecha_Nacimiento")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NombreCompleto)
                    .HasColumnName("Nombre_Completo")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RecibirInfoCelular)
                    .HasColumnName("Recibir_Info_Celular")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.RecibirInfoEmail)
                    .HasColumnName("Recibir_Info_Email")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Sexo)
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Html>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HTML", "Financeiro");

                entity.Property(e => e.DataAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.DsRelatorio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StrHtml)
                    .IsRequired()
                    .HasColumnName("StrHTML");
            });

            modelBuilder.Entity<LpDetalleDocumentos>(entity =>
            {
                entity.HasKey(e => e.IdDetalleDocumento);

                entity.ToTable("LP_DetalleDocumentos");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaServicio).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDocumentoPagoNavigation)
                    .WithMany(p => p.LpDetalleDocumentos)
                    .HasForeignKey(d => d.IdDocumentoPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LP_DetalleDocumentos_LP_DocumentosPago");
            });

            modelBuilder.Entity<LpDocumentosPago>(entity =>
            {
                entity.HasKey(e => e.IdDocumentoPago);

                entity.ToTable("LP_DocumentosPago");

                entity.Property(e => e.Cbu)
                    .HasColumnName("CBU")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cuil)
                    .HasColumnName("CUIL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DomicilioDePago)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DomicilioProveedor)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Factura)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaRecepcion).HasColumnType("datetime");

                entity.Property(e => e.ImporteApagar).HasColumnName("ImporteAPagar");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumento)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumentoExterior)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacionDocumento)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocialProveedor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdBeneficiarioPolizaNavigation)
                    .WithMany(p => p.LpDocumentosPago)
                    .HasForeignKey(d => d.IdBeneficiarioPoliza)
                    .HasConstraintName("FK_LP_DocumentosPago_PO_BeneficiariosPoliza");

                entity.HasOne(d => d.IdCasoNavigation)
                    .WithMany(p => p.LpDocumentosPago)
                    .HasForeignKey(d => d.IdCaso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LP_DocumentosPago_MI_Casos");

                entity.HasOne(d => d.IdCorresponsalNavigation)
                    .WithMany(p => p.LpDocumentosPago)
                    .HasForeignKey(d => d.IdCorresponsal)
                    .HasConstraintName("FK_LP_DocumentosPago_MI_Corresponsales");

                entity.HasOne(d => d.IdMonedaLiquidacionNavigation)
                    .WithMany(p => p.LpDocumentosPagoIdMonedaLiquidacionNavigation)
                    .HasForeignKey(d => d.IdMonedaLiquidacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LP_DocumentosPago_BS_Monedas");

                entity.HasOne(d => d.IdMonedaPagoNavigation)
                    .WithMany(p => p.LpDocumentosPagoIdMonedaPagoNavigation)
                    .HasForeignKey(d => d.IdMonedaPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LP_DocumentosPago_BS_Monedas1");
            });

            modelBuilder.Entity<LpFormasPagoDocumentos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LP_FormasPagoDocumentos");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionFormaPagoDocumentos)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoFormaPagoDocumento)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LpRelacionProveedorFormasPago>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LP_RelacionProveedorFormasPago");
            });

            modelBuilder.Entity<LpTiposProveedores>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LP_TiposProveedores");

                entity.Property(e => e.CodigoTipoProveedor)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTipoProveedor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MiCasos>(entity =>
            {
                entity.HasKey(e => e.IdCaso)
                    .HasName("PK_MI_Casos_1");

                entity.ToTable("MI_Casos");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoMontoMaximo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Documentos)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Empresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventosProximos)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FecNac).HasColumnType("datetime");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaFinCobertura).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioCobertura).HasColumnType("datetime");

                entity.Property(e => e.FechaRetorno).HasColumnType("datetime");

                entity.Property(e => e.FechaSalida).HasColumnType("datetime");

                entity.Property(e => e.HoraInicio)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ImporteMontoMaximo).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NroCasoExterno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NroDocumento)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NroSocio)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroVoucher)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacionesCaso)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacionesContacto)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacionesMontoMaximo)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Producto)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MiCasosBup>(entity =>
            {
                entity.HasKey(e => e.IdCaso)
                    .HasName("PK_MI_Casos");

                entity.ToTable("MI_Casos_bup");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Edad)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Empresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EventosProximos)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FecNac).HasColumnType("datetime");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.FechaRetorno).HasColumnType("datetime");

                entity.Property(e => e.FechaSalida).HasColumnType("datetime");

                entity.Property(e => e.HoraInicio)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEmpresa).HasColumnName("Id_Empresa");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NroCasoExterno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NroDocumento)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NroSocio)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroVoucher)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasColumnName("observaciones")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MiCasosCursos>(entity =>
            {
                entity.HasKey(e => e.IdCasoCur)
                    .HasName("PK_MI_Casos_Cursos_1");

                entity.ToTable("MI_Casos_Cursos");

                entity.Property(e => e.Curso)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecHora)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Prestador)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActividad)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MiCasosCursosBup>(entity =>
            {
                entity.HasKey(e => e.IdCasoCur)
                    .HasName("PK_MI_Casos_Cursos");

                entity.ToTable("MI_Casos_Cursos_bup");

                entity.Property(e => e.Curso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecHora)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Prestador)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActividad)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCasoNavigation)
                    .WithMany(p => p.MiCasosCursosBup)
                    .HasForeignKey(d => d.IdCaso)
                    .HasConstraintName("FK_MI_Casos_Cursos_MI_Casos");
            });

            modelBuilder.Entity<MiCasosCursosHist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MI_Casos_Cursos_Hist");

                entity.Property(e => e.Curso)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecHora)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdCasoCurHist).ValueGeneratedOnAdd();

                entity.Property(e => e.Prestador)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioActividad)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MiCasosHist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MI_Casos_Hist");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentoMontoMaximo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Documentos)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Empresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventosProximos)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FecNac).HasColumnType("datetime");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.FechaRetorno).HasColumnType("datetime");

                entity.Property(e => e.FechaSalida).HasColumnType("datetime");

                entity.Property(e => e.HoraInicio)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdCasoHist).ValueGeneratedOnAdd();

                entity.Property(e => e.ImporteMontoMaximo).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NroCasoExterno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NroDocumento)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NroSocio)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroVoucher)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacionesCaso)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacionesContacto)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacionesMontoMaximo)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MiContactosCorresponsales>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MI_ContactosCorresponsales");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactoPrincipal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.IdContactoCorresponsal).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MiContactosPrestadores>(entity =>
            {
                entity.HasKey(e => e.IdContactoPrestadores);

                entity.ToTable("MI_ContactosPrestadores");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactoPrincipal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MiCorresponsales>(entity =>
            {
                entity.HasKey(e => e.IdCorresponsal)
                    .HasName("PK_MI_Corresponsales_1");

                entity.ToTable("MI_Corresponsales");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MiCorresponsalesBup>(entity =>
            {
                entity.HasKey(e => e.IdCorresponsal)
                    .HasName("PK_MI_Corresponsales");

                entity.ToTable("MI_Corresponsales_bup");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descrip)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.MiCorresponsalesBup)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MI_Corresponsales_MI_Empresas");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.MiCorresponsalesBup)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MI_Corresponsales_BS_Paises");
            });

            modelBuilder.Entity<MiCorresponsalesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MI_CorresponsalesView");

                entity.Property(e => e.CodigoPais)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cuit)
                    .IsRequired()
                    .HasColumnName("CUIT")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DenominacionPais)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdPersonaJuridica).ValueGeneratedOnAdd();

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MiCuestionarioQuality>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MI_Cuestionario_Quality");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");
            });

            modelBuilder.Entity<MiCuestionarioQualityBup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MI_Cuestionario_Quality_bup");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");
            });

            modelBuilder.Entity<MiCuestionarioQualityTipos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MI_Cuestionario_Quality_Tipos");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MiCuestionarioQualityTiposBup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MI_Cuestionario_Quality_Tipos_bup");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MiEmpresas>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa)
                    .HasName("PK_MI_Empresas_1");

                entity.ToTable("MI_Empresas");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MiEmpresasBup>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa)
                    .HasName("PK_MI_Empresas");

                entity.ToTable("MI_Empresas_bup");

                entity.Property(e => e.IdEmpresa).HasColumnName("Id_Empresa");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Contacto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cuit)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Descrip)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MiEmpresasView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MI_EmpresasView");

                entity.Property(e => e.CodigoPais)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cuit)
                    .IsRequired()
                    .HasColumnName("CUIT")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DenominacionPais)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdPersonaJuridica).ValueGeneratedOnAdd();

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MiEstados>(entity =>
            {
                entity.HasKey(e => e.IdEstado);

                entity.ToTable("MI_Estados");

                entity.Property(e => e.CodigoEstado)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionEstado)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MiEstadosCurso>(entity =>
            {
                entity.HasKey(e => e.IdEstadoCurso);

                entity.ToTable("MI_EstadosCurso");

                entity.Property(e => e.CodigoEstadoCurso)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionEstadoCurso)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MiPaisesAtencionCorresponsales>(entity =>
            {
                entity.HasKey(e => e.IdPaisAtencionCorresponsal);

                entity.ToTable("MI_PaisesAtencionCorresponsales");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCorresponsalNavigation)
                    .WithMany(p => p.MiPaisesAtencionCorresponsales)
                    .HasForeignKey(d => d.IdCorresponsal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MI_PaisesAtencionCorresponsales_MI_Corresponsales");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.MiPaisesAtencionCorresponsales)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MI_PaisesAtencionCorresponsales_BS_Paises");
            });

            modelBuilder.Entity<MiPrestadores>(entity =>
            {
                entity.HasKey(e => e.IdPrestador);

                entity.ToTable("MI_Prestadores");
            });

            modelBuilder.Entity<MiSociosEnUso>(entity =>
            {
                entity.HasKey(e => e.IdLock);

                entity.ToTable("MI_SociosEnUso");

                entity.Property(e => e.FecBaja).HasColumnType("datetime");

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.NBen)
                    .HasColumnName("nBen")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NSoc)
                    .HasColumnName("nSoc")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MiSociosEnUsoBup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MI_SociosEnUso_bup");

                entity.Property(e => e.FecBaja).HasColumnType("datetime");

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.NBen)
                    .HasColumnName("nBen")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NSoc)
                    .HasColumnName("nSoc")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NukeFormDocumentsLog>(entity =>
            {
                entity.HasKey(e => new { e.ModuleId, e.UserId, e.Path });

                entity.ToTable("NukeForm_DocumentsLog");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Path)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.IdLog).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PeAlteracaoPessoaFisica>(entity =>
            {
                entity.HasKey(e => e.IdAlteracao)
                    .HasName("PK__PE_Alter__76DD1CC141648637");

                entity.ToTable("PE_AlteracaoPessoaFisica");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.PeAlteracaoPessoaFisica)
                    .HasForeignKey(d => d.IdAgencia)
                    .HasConstraintName("FK_PE_Alt_IDAgencia");

                entity.HasOne(d => d.IdPessoaNavigation)
                    .WithMany(p => p.PeAlteracaoPessoaFisica)
                    .HasForeignKey(d => d.IdPessoa)
                    .HasConstraintName("FK_PE_Alt_IDPersona");
            });

            modelBuilder.Entity<PeAutorizacaoAlteracao>(entity =>
            {
                entity.HasKey(e => e.IdAutorizacao)
                    .HasName("PK__PE_Autor__BB7FCFA73BABACE1");

                entity.ToTable("PE_AutorizacaoAlteracao");

                entity.Property(e => e.CriadoPor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.DataModificacao).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.PeAutorizacaoAlteracao)
                    .HasForeignKey(d => d.IdAgencia)
                    .HasConstraintName("FK_PE_AUT_IDAgencia");
            });

            modelBuilder.Entity<PeCanalesPersona>(entity =>
            {
                entity.HasKey(e => e.IdCanalesPersona);

                entity.ToTable("PE_CanalesPersona");

                entity.HasIndex(e => new { e.DetalleCanal, e.DetalleCanal2, e.IdPersona, e.IdTipoCanal })
                    .HasName("ix_PREOSAMIBR_dbo_PE_CanalesPersona_01");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleCanal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleCanal2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.PeCanalesPersona)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE_CanalesPersona_PE_CanalesPersona");

                entity.HasOne(d => d.IdTipoCanalNavigation)
                    .WithMany(p => p.PeCanalesPersona)
                    .HasForeignKey(d => d.IdTipoCanal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE_CanalesPersona_PE_PersonaFisica");
            });

            modelBuilder.Entity<PeCanalesPersonaJuridica>(entity =>
            {
                entity.HasKey(e => e.IdCanalesPersonaJuridica);

                entity.ToTable("PE_CanalesPersonaJuridica");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleCanal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPersonaJuridicaNavigation)
                    .WithMany(p => p.PeCanalesPersonaJuridica)
                    .HasForeignKey(d => d.IdPersonaJuridica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE_CanalesPersonaJuridica_PE_PersonaJuridica");

                entity.HasOne(d => d.IdTipoCanalNavigation)
                    .WithMany(p => p.PeCanalesPersonaJuridica)
                    .HasForeignKey(d => d.IdTipoCanal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE_CanalesPersonaJuridica_PE_TiposCanal");
            });

            modelBuilder.Entity<PeCelularView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PE_CelularView");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleCanal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.IdCanalesPersona).ValueGeneratedOnAdd();

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PeDocumentosPersonaFisica>(entity =>
            {
                entity.HasKey(e => e.IdDocumentoPersonaFisica);

                entity.ToTable("PE_DocumentosPersonaFisica");

                entity.HasIndex(e => new { e.IdTipoDocumento, e.Numero })
                    .HasName("IX_PE_DocumentosPersonaFisica");

                entity.HasIndex(e => new { e.IdTipoDocumento, e.Numero, e.IdPersona })
                    .HasName("IX_PE_DocumentosPersonaFisica2");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.PeDocumentosPersonaFisica)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE_DocumentosPersonaFisica_PE_PersonaFisica");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.PeDocumentosPersonaFisica)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE_DocumentosPersonaFisica_PE_DocumentosPersonaFisica");
            });

            modelBuilder.Entity<PeDocumentosPersonaJuridica>(entity =>
            {
                entity.HasKey(e => e.IdDocumentoPersonaJuridica);

                entity.ToTable("PE_DocumentosPersonaJuridica");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.PeDocumentosPersonaJuridica)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE_DocumentosPersonaJuridica_PE_TiposDocumentos");
            });

            modelBuilder.Entity<PeDomicilioPersonaJuridica>(entity =>
            {
                entity.HasKey(e => e.IdDomicilioPersonaJuridica);

                entity.ToTable("PE_DomicilioPersonaJuridica");

                entity.HasIndex(e => new { e.IdDomicilio, e.IdPersonaJuridica })
                    .HasName("ix_PREOSAMIBR_dbo_PE_DomicilioPersonaJuridica_01");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDomicilioNavigation)
                    .WithMany(p => p.PeDomicilioPersonaJuridica)
                    .HasForeignKey(d => d.IdDomicilio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE_DomicilioPersonaJuridica_PE_Domicilios");

                entity.HasOne(d => d.IdPersonaJuridicaNavigation)
                    .WithMany(p => p.PeDomicilioPersonaJuridica)
                    .HasForeignKey(d => d.IdPersonaJuridica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE_DomicilioPersonaJuridica_PE_PersonaJuridica");
            });

            modelBuilder.Entity<PeDomicilios>(entity =>
            {
                entity.HasKey(e => e.IdDomicilio)
                    .HasName("PK_Domicilios");

                entity.ToTable("PE_Domicilios");

                entity.HasIndex(e => e.FecCreaReg)
                    .HasName("ix_PRE_OS_AMIBR_dbo_PE_Domicilios_1");

                entity.Property(e => e.Barrio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Calle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeptoOficina)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Piso)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.PeDomicilios)
                    .HasForeignKey(d => d.IdPais)
                    .HasConstraintName("FK_Domicilios_Paises");

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.PeDomicilios)
                    .HasForeignKey(d => d.IdProvincia)
                    .HasConstraintName("FK_PE_Domicilios_BS_Provincias");

                entity.HasOne(d => d.IdTipoCalleNavigation)
                    .WithMany(p => p.PeDomicilios)
                    .HasForeignKey(d => d.IdTipoCalle)
                    .HasConstraintName("FK_PE_Domicilios_PE_TiposCalle");
            });

            modelBuilder.Entity<PeDomiciliosAgenciasCobranza>(entity =>
            {
                entity.HasKey(e => e.IdAgenciaCobranzaDomicilio);

                entity.ToTable("PE_DomiciliosAgenciasCobranza");

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAgenciaCobranzaNavigation)
                    .WithMany(p => p.PeDomiciliosAgenciasCobranza)
                    .HasForeignKey(d => d.IdAgenciaCobranza)
                    .HasConstraintName("FK_PE_DomiciliosAgenciasCobranza_CO_AgenciasCobranza");

                entity.HasOne(d => d.IdDomicilioNavigation)
                    .WithMany(p => p.PeDomiciliosAgenciasCobranza)
                    .HasForeignKey(d => d.IdDomicilio)
                    .HasConstraintName("FK_PE_DomiciliosAgenciasCobranza_PE_Domicilios");
            });

            modelBuilder.Entity<PeDomiciliosPersona>(entity =>
            {
                entity.HasKey(e => e.IdDomicilioPersona)
                    .HasName("PK_ClienteDomicilios");

                entity.ToTable("PE_DomiciliosPersona");

                entity.HasIndex(e => new { e.IdDomicilio, e.IdPersona })
                    .HasName("ix_PE_DomiciliosPersona_1");

                entity.HasIndex(e => new { e.IdPersona, e.IdDomicilio })
                    .HasName("ix_PRE_OS_AMIBR_dbo_PE_DomiciliosPersona_1");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDomicilioNavigation)
                    .WithMany(p => p.PeDomiciliosPersona)
                    .HasForeignKey(d => d.IdDomicilio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClienteDomicilios_Domicilios");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.PeDomiciliosPersona)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClienteDomicilios_IdPersona");
            });

            modelBuilder.Entity<PeDomiciliosPersonaFisicaView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PE_DomiciliosPersonaFisicaView");

                entity.Property(e => e.Barrio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Calle).HasMaxLength(50);

                entity.Property(e => e.Ciudad).HasMaxLength(50);

                entity.Property(e => e.CodigoPais)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(10);

                entity.Property(e => e.DenominacionPais)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeptoOficina).HasMaxLength(5);

                entity.Property(e => e.DescripcionTipoCalle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Numero).HasMaxLength(6);

                entity.Property(e => e.Piso).HasMaxLength(3);
            });

            modelBuilder.Entity<PeDomiciliosPersonaJuridicaView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PE_DomiciliosPersonaJuridicaView");

                entity.Property(e => e.Calle).HasMaxLength(50);

                entity.Property(e => e.Ciudad).HasMaxLength(50);

                entity.Property(e => e.CodigoPais)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(10);

                entity.Property(e => e.DenominacionPais)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeptoOficina).HasMaxLength(5);

                entity.Property(e => e.Numero).HasMaxLength(6);

                entity.Property(e => e.Piso).HasMaxLength(3);
            });

            modelBuilder.Entity<PeFaxPersonaJuridicaView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PE_FaxPersonaJuridicaView");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleCanal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.IdCanalesPersonaJuridica).ValueGeneratedOnAdd();

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PeFormasPagoTipoCliente>(entity =>
            {
                entity.HasKey(e => e.IdFormasPagoTipoPersona);

                entity.ToTable("PE_FormasPagoTipoCliente");

                entity.HasIndex(e => new { e.IdFormaPagoBs, e.IdTipoCliente })
                    .HasName("IX_PE_FormasPagoTipoCliente")
                    .IsUnique();

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.IdFormaPagoBs).HasColumnName("IdFormaPagoBS");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFormaPagoBsNavigation)
                    .WithMany(p => p.PeFormasPagoTipoCliente)
                    .HasForeignKey(d => d.IdFormaPagoBs)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE_FormasPagoTipoCliente_BS_FormasPago");

                entity.HasOne(d => d.IdTipoClienteNavigation)
                    .WithMany(p => p.PeFormasPagoTipoCliente)
                    .HasForeignKey(d => d.IdTipoCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE_FormasPagoTipoCliente_CO_TiposCliente");
            });

            modelBuilder.Entity<PeMailsPersonaJuridicaView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PE_MailsPersonaJuridicaView");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleCanal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.IdCanalesPersonaJuridica).ValueGeneratedOnAdd();

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PeMailsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PE_MailsView");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleCanal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.IdCanalesPersona).ValueGeneratedOnAdd();

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PeNukeRolesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PE_NukeRolesView");

                entity.Property(e => e.BillingFrequency)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.IconFile).HasMaxLength(100);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.RoleGroupId).HasColumnName("RoleGroupID");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Rsvpcode)
                    .HasColumnName("RSVPCode")
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceFee).HasColumnType("money");

                entity.Property(e => e.TrialFee).HasColumnType("money");

                entity.Property(e => e.TrialFrequency)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PeNukeUserRolesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PE_NukeUserRolesView");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserRoleId)
                    .HasColumnName("UserRoleID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PeNukeUsersView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PE_NukeUsersView");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastIpaddress)
                    .HasColumnName("LastIPAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LowerEmail).HasMaxLength(256);

                entity.Property(e => e.PasswordResetExpiration).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PePersonaFisica>(entity =>
            {
                entity.HasKey(e => e.IdPersona)
                    .HasName("PK_Beneficiarios");

                entity.ToTable("PE_PersonaFisica");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.IdResponsableIva).HasColumnName("IdResponsableIVA");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdPaisResidenciaNavigation)
                    .WithMany(p => p.PePersonaFisica)
                    .HasForeignKey(d => d.IdPaisResidencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE_PersonaFisica_BS_Paises");
            });



            modelBuilder.Entity<PePersonaJuridica>(entity =>
            {
                entity.HasKey(e => e.IdPersonaJuridica);

                entity.ToTable("PE_PersonaJuridica");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cuit)
                    .HasColumnName("CUIT")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.IdResponsableIva).HasColumnName("IdResponsableIVA");

                entity.Property(e => e.Iibb)
                    .HasColumnName("IIBB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreFantasia)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdResponsableIvaNavigation)
                    .WithMany(p => p.PePersonaJuridica)
                    .HasForeignKey(d => d.IdResponsableIva)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE_PersonaJuridica_CO_ResponsableIVA");
            });

            modelBuilder.Entity<PePersonasFisicasView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PE_PersonasFisicasView");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Barrio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Calle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Cp)
                    .IsRequired()
                    .HasColumnName("CP")
                    .HasMaxLength(10);

                entity.Property(e => e.DeptoOficina)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.DescripcionTipoCalle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.IdPersona).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.PaisDomicilio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaisResidencia)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Piso)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.ProvinciaDomicilio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TelefonoComercial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoFijo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PePersonasJuridicasView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PE_PersonasJuridicasView");

                entity.Property(e => e.CodigoPais)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cuit)
                    .HasColumnName("CUIT")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DenominacionPais)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdPersonaJuridica).ValueGeneratedOnAdd();

                entity.Property(e => e.NombreFantasia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PeTelComercialView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PE_TelComercialView");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleCanal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.IdCanalesPersona).ValueGeneratedOnAdd();

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PeTelFijoPersonaJuridicaView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PE_TelFijoPersonaJuridicaView");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleCanal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.IdCanalesPersonaJuridica).ValueGeneratedOnAdd();

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PeTelFijoView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PE_TelFijoView");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleCanal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.IdCanalesPersona).ValueGeneratedOnAdd();

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PeTiposCalle>(entity =>
            {
                entity.HasKey(e => e.IdTipoCalle);

                entity.ToTable("PE_TiposCalle");

                entity.Property(e => e.CodigoTipoCalle)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTipoCalle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCompaniaNavigation)
                    .WithMany(p => p.PeTiposCalle)
                    .HasForeignKey(d => d.IdCompania)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PE_TiposCalle_BS_Companias");
            });

            modelBuilder.Entity<PeTiposCanal>(entity =>
            {
                entity.HasKey(e => e.IdTipoCanal);

                entity.ToTable("PE_TiposCanal");

                entity.HasIndex(e => e.CodigoTipoCanal)
                    .HasName("IX_PE_TiposCanal")
                    .IsUnique();

                entity.Property(e => e.CodigoTipoCanal)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTipoCanal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PeTiposDocumentos>(entity =>
            {
                entity.HasKey(e => e.IdTipoDocumento);

                entity.ToTable("PE_TiposDocumentos");

                entity.HasIndex(e => e.CodigoTipoDocumento)
                    .HasName("IX_PE_TiposDocumentos")
                    .IsUnique();

                entity.Property(e => e.AplicaEmision)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AplicaPersona)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoTipoDocumento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTipoDocumento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PeTiposDocumentosCodiPagoOnline>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PE_TiposDocumentos_CodiPagoOnline");

                entity.Property(e => e.Descrip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoDocumentoCodiPago).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PoAgenciaView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PO_Agencia_View");

                entity.Property(e => e.Cndiva).HasColumnName("CNDIVA");

                entity.Property(e => e.Codpai).HasColumnName("CODPAI");

                entity.Property(e => e.Codpos)
                    .HasColumnName("CODPOS")
                    .HasMaxLength(10);

                entity.Property(e => e.Direcc)
                    .HasColumnName("DIRECC")
                    .HasMaxLength(60);

                entity.Property(e => e.Jurisd).HasColumnName("JURISD");

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nrocta)
                    .HasColumnName("NROCTA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nrodoc)
                    .HasColumnName("NRODOC")
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PoAutorizacionExtension>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PO_AutorizacionExtension");

                entity.Property(e => e.Amount)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.IdAutorizacion)
                    .HasColumnName("idAutorizacion")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TravelerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValidTo).HasColumnType("datetime");

                entity.Property(e => e.VoucherNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PoBeneficiariosPoliza>(entity =>
            {
                entity.HasKey(e => e.IdBeneficiarioPoliza)
                    .HasName("PK_BeneficiariosPoliza");

                entity.ToTable("PO_BeneficiariosPoliza");

                entity.HasIndex(e => new { e.IdPersona, e.IdPoliza, e.Secuencia })
                    .HasName("ix_po_beneficiariosPoliza")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdPoliza, e.Secuencia, e.FechaAnulacion })
                    .HasName("ix_PREOSAMIBR_dbo_PO_BeneficiariosPoliza_01");

                entity.HasIndex(e => new { e.IdPersona, e.IdProducto, e.IdPoliza, e.Viaja })
                    .HasName("ix_PO_BeneficiariosPoliza_02");

                entity.HasIndex(e => new { e.IdPoliza, e.IdPersona, e.IdProducto, e.Viaja })
                    .HasName("ix_PO_BeneficiariosPoliza_01");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EliminadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExtensionFecha).HasColumnType("datetime");

                entity.Property(e => e.ExtensionIdpago).HasColumnName("ExtensionIDPago");

                entity.Property(e => e.ExtensionVigenciaHasta).HasColumnType("datetime");

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecElimReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaAceptacionCondiciones).HasColumnType("datetime");

                entity.Property(e => e.FechaAnulacion).HasColumnType("datetime");

                entity.Property(e => e.HashVoucher)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdPoextensionAutorizacion).HasColumnName("IdPOExtensionAutorizacion");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pdfvoucher)
                    .HasColumnName("PDFVoucher")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdParentescoNavigation)
                    .WithMany(p => p.PoBeneficiariosPoliza)
                    .HasForeignKey(d => d.IdParentesco)
                    .HasConstraintName("FK_BeneficiariosPoliza_Parentescos");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.PoBeneficiariosPoliza)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BeneficiariosPoliza_Beneficiarios");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.PoBeneficiariosPoliza)
                    .HasForeignKey(d => d.IdPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BeneficiariosPoliza_Polizas");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.PoBeneficiariosPoliza)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("FK_PO_BeneficiariosPoliza_PR_Producto");
            });

            modelBuilder.Entity<PoDetalleFormasPago>(entity =>
            {
                entity.HasKey(e => e.IdDetalleFormasPago)
                    .HasName("PK_DetalleFormaDePago");

                entity.ToTable("PO_DetalleFormasPago");

                entity.HasIndex(e => new { e.IdFormaPago, e.PagoOnlineErrorId, e.IdPoliza })
                    .HasName("ix_PO_DetalleFormasPago_01");

                entity.HasIndex(e => new { e.IdDetalleFormasPago, e.IdPoliza, e.IdFormaPago, e.PagoOnlineErrorId, e.FecCreaReg })
                    .HasName("ix_PRE_OS_AMIBR_dbo_PO_DetalleFormasPago_1");

                entity.Property(e => e.BraspagTransactionId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoVersion)
                    .HasColumnName("codigoVersion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EliminadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecElimReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaCobro).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NroCargo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NroLote)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroTarjeta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PagoOnlineErrorDescrip)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RequestId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TitularTarjeta)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VencimientoTarjeta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFormaPagoNavigation)
                    .WithMany(p => p.PoDetalleFormasPago)
                    .HasForeignKey(d => d.IdFormaPago)
                    .HasConstraintName("FK_DetalleFormaDePago_FormasDePago");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.PoDetalleFormasPago)
                    .HasForeignKey(d => d.IdPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetalleFormaDePago_Polizas");
            });

            modelBuilder.Entity<PoExtensionAutorizacion>(entity =>
            {
                entity.HasKey(e => e.IdPoextensionAutorizacion)
                    .HasName("PK__PO_Exten__83DEE48D63649880");

                entity.ToTable("PO_ExtensionAutorizacion");

                entity.Property(e => e.IdPoextensionAutorizacion).HasColumnName("IdPOExtensionAutorizacion");

                entity.Property(e => e.DescripcionError)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHasta).HasColumnType("datetime");

                entity.Property(e => e.NroVoucher)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Resultado)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PoFacturacion>(entity =>
            {
                entity.HasKey(e => e.IdFactura);

                entity.ToTable("PO_Facturacion");

                entity.Property(e => e.FechaCreacion).HasColumnType("date");

                entity.Property(e => e.FechaProcesamiento)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PoFormasPago>(entity =>
            {
                entity.HasKey(e => e.IdFormaPago)
                    .HasName("PK_FormasDePago");

                entity.ToTable("PO_FormasPago");

                entity.Property(e => e.CodigoFormaPago)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoPasarela)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionFormaPago)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ImagenUrl)
                    .HasColumnName("ImagenURL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoFormaPago)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.UrlPagoOnline)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PoHistoricoVoucher>(entity =>
            {
                entity.HasKey(e => e.IdHistoricoVoucher);

                entity.ToTable("PO_HistoricoVoucher");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaDesde).HasColumnType("datetime");

                entity.Property(e => e.FechaHasta).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdVoucherNavigation)
                    .WithMany(p => p.PoHistoricoVoucher)
                    .HasForeignKey(d => d.IdVoucher)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PO_HistoricoVoucher_PO_Polizas");
            });

            modelBuilder.Entity<PoParentesco>(entity =>
            {
                entity.HasKey(e => e.IdParentesco)
                    .HasName("PK_Parentescos");

                entity.ToTable("PO_Parentesco");

                entity.Property(e => e.CodigoParentesco)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionParentesco)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PoPolizaView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PO_Poliza_View");

                entity.Property(e => e.Agencia)
                    .HasColumnName("AGENCIA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Beneftit)
                    .HasColumnName("BENEFTIT")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Fecdesde)
                    .HasColumnName("FECDESDE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fecemision)
                    .HasColumnName("FECEMISION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fechasta)
                    .HasColumnName("FECHASTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idpoliza)
                    .HasColumnName("IDPOLIZA")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Idproducto).HasColumnName("IDPRODUCTO");

                entity.Property(e => e.Imptotal).HasColumnName("IMPTOTAL");

                entity.Property(e => e.Medpago)
                    .IsRequired()
                    .HasColumnName("MEDPAGO")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nropoliza)
                    .HasColumnName("NROPOLIZA")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Porcen)
                    .HasColumnName("PORCEN")
                    .HasColumnType("numeric(3, 2)");
            });

            modelBuilder.Entity<PoPolizas>(entity =>
            {
                entity.HasKey(e => e.IdPoliza)
                    .HasName("PK_Polizas");

                entity.ToTable("PO_Polizas");

                entity.HasIndex(e => e.IdParentVoucher)
                    .HasName("PO_Polizas_IX01");

                entity.HasIndex(e => e.NumeroPoliza)
                    .HasName("PO_Polizas_UK_NumeroPoliza")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdPoliza, e.CreadoPor, e.IdAgencia, e.FechaEmision })
                    .HasName("PO_Polizas_IX02");

                entity.Property(e => e.ApellidoContactoEmergencia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadOrigen)
                    .HasColumnName("ciudadOrigen")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoAreaContactoEmergencia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoCupon)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Comentario)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CouponTypeId).HasColumnName("CouponTypeID");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EMailContactoEmergencia)
                    .HasColumnName("eMailContactoEmergencia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaAnulacion).HasColumnType("datetime");

                entity.Property(e => e.FechaDesde).HasColumnType("datetime");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaHasta).HasColumnType("datetime");

                entity.Property(e => e.IdEnBroker)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdSellerIdcanalesVentas).HasColumnName("IdSellerIDCanalesVentas");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreContactoEmergencia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroPoliza)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");

                entity.Property(e => e.SalesChannelCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesChannelType)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoContactoEmergencia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoVoucher)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.PoPolizas)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PO_Polizas_PR_Producto");

                entity.HasOne(d => d.IdSellerIdcanalesVentasNavigation)
                    .WithMany(p => p.PoPolizas)
                    .HasForeignKey(d => d.IdSellerIdcanalesVentas)
                    .HasConstraintName("FK_PO_Polizas_CO_SellerIDCanalesVentas");

                entity.HasOne(d => d.IdVendedorNavigation)
                    .WithMany(p => p.PoPolizas)
                    .HasForeignKey(d => d.IdVendedor)
                    .HasConstraintName("FK_PO_Polizas_CO_VendedoresAgencias");
            });

            modelBuilder.Entity<PoProductosAnualesPolizas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PO_ProductosAnualesPolizas");

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dni)
                    .HasColumnName("DNI")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.IdProductoAnual).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PoRelacionParentescoWs>(entity =>
            {
                entity.HasKey(e => e.IdParentescoWs);

                entity.ToTable("PO_RelacionParentesco_WS");

                entity.Property(e => e.IdParentescoWs).HasColumnName("IdParentescoWS");

                entity.Property(e => e.CodigoParentescoWs).HasColumnName("CodigoParentescoWS");

                entity.HasOne(d => d.IdParentescoNavigation)
                    .WithMany(p => p.PoRelacionParentescoWs)
                    .HasForeignKey(d => d.IdParentesco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PO_RelacionParentesco_WS_PO_Parentesco");
            });

            modelBuilder.Entity<PoSecuencialDocumento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PO_SecuencialDocumento");
            });

            modelBuilder.Entity<PoTempComprador>(entity =>
            {
                entity.HasKey(e => e.IdTmpComprador);

                entity.ToTable("PO_TEMP_COMPRADOR");

                entity.Property(e => e.IdTmpComprador).HasColumnName("Id_tmp_Comprador");

                entity.Property(e => e.Apellido).HasMaxLength(50);

                entity.Property(e => e.ApellidoEmerg)
                    .HasColumnName("Apellido_emerg")
                    .HasMaxLength(50);

                entity.Property(e => e.Barrio).HasMaxLength(50);

                entity.Property(e => e.Calle).HasMaxLength(50);

                entity.Property(e => e.Cep)
                    .HasColumnName("CEP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad).HasMaxLength(50);

                entity.Property(e => e.Complemento).HasMaxLength(50);

                entity.Property(e => e.DddCelular)
                    .HasColumnName("DDD_Celular")
                    .HasMaxLength(10);

                entity.Property(e => e.DddCelularEmerg)
                    .HasColumnName("DDD_Celular_emerg")
                    .HasMaxLength(10);

                entity.Property(e => e.DddComercial)
                    .HasColumnName("DDD_Comercial")
                    .HasMaxLength(10);

                entity.Property(e => e.DddComercialEmerg)
                    .HasColumnName("DDD_Comercial_emerg")
                    .HasMaxLength(10);

                entity.Property(e => e.DddResidencial)
                    .HasColumnName("DDD_Residencial")
                    .HasMaxLength(10);

                entity.Property(e => e.DddResidencialEmerg)
                    .HasColumnName("DDD_Residencial_emerg")
                    .HasMaxLength(10);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FechaNacimiento).HasColumnType("smalldatetime");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.NombreEmerg)
                    .HasColumnName("Nombre_emerg")
                    .HasMaxLength(20);

                entity.Property(e => e.NumeroDni)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TelCelular)
                    .HasColumnName("Tel_Celular")
                    .HasMaxLength(20);

                entity.Property(e => e.TelCelularEmerg)
                    .HasColumnName("Tel_Celular_emerg")
                    .HasMaxLength(20);

                entity.Property(e => e.TelComercial)
                    .HasColumnName("Tel_Comercial")
                    .HasMaxLength(20);

                entity.Property(e => e.TelComercialEmerg)
                    .HasColumnName("Tel_Comercial_emerg")
                    .HasMaxLength(20);

                entity.Property(e => e.TelResidencial)
                    .HasColumnName("Tel_Residencial")
                    .HasMaxLength(20);

                entity.Property(e => e.TelResidencialEmerg)
                    .HasColumnName("Tel_Residencial_emerg")
                    .HasMaxLength(20);

                entity.Property(e => e.Uf)
                    .HasColumnName("UF")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PoTmpBeneficiarios>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PO_TMP_Beneficiarios");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cuil)
                    .IsRequired()
                    .HasColumnName("CUIL")
                    .HasMaxLength(22)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento).HasColumnType("smalldatetime");

                entity.Property(e => e.IdTmpBeneficiario).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumento)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoCelular)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoFijo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrAgenciasHabilitadasPromocion>(entity =>
            {
                entity.HasKey(e => e.IdAgenciaHabilitadaPromocion);

                entity.ToTable("PR_AgenciasHabilitadasPromocion");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaVigenciaDesde).HasColumnType("datetime");

                entity.Property(e => e.FechaVigenciaHasta).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.PrAgenciasHabilitadasPromocion)
                    .HasForeignKey(d => d.IdAgencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_AgenciasHabilitadasPromocion_CO_Agencias");

                entity.HasOne(d => d.IdPromocionNavigation)
                    .WithMany(p => p.PrAgenciasHabilitadasPromocion)
                    .HasForeignKey(d => d.IdPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_AgenciasHabilitadasPromocion_PR_Promociones");
            });

            modelBuilder.Entity<PrAgenciasPromocion>(entity =>
            {
                entity.HasKey(e => e.IdAgenciaPromocion);

                entity.ToTable("PR_AgenciasPromocion");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.MarcaExclusionBonificaciones)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.PrAgenciasPromocion)
                    .HasForeignKey(d => d.IdAgencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_AgenciasPromocion_CO_Agencias");

                entity.HasOne(d => d.IdTipoObjetivoComisionNavigation)
                    .WithMany(p => p.PrAgenciasPromocion)
                    .HasForeignKey(d => d.IdTipoObjetivoComision)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_AgenciasPromocion_PR_TiposObjetivosAgencias");
            });

            modelBuilder.Entity<PrCanalesPublicacionCupones>(entity =>
            {
                entity.HasKey(e => e.IdCanalPublicacionCupon);

                entity.ToTable("PR_CanalesPublicacionCupones");

                entity.Property(e => e.CodigoCanalPublicacion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DenominacionCanalPublicacion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrCondicionesGenerales>(entity =>
            {
                entity.HasKey(e => e.IdCondicionesGenerales);

                entity.ToTable("PR_CondicionesGenerales");

                entity.Property(e => e.IdCondicionesGenerales).HasColumnName("Id_CondicionesGenerales");

                entity.Property(e => e.CondicionesGenerales).HasColumnType("text");

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("date");

                entity.Property(e => e.FecModReg).HasColumnType("date");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("date");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("date");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrCondicionesGeneralesProducto>(entity =>
            {
                entity.HasKey(e => e.IdCondicionesGeneralesProducto)
                    .HasName("PK_PR_CondicionesGenerales_Producto2");

                entity.ToTable("PR_CondicionesGenerales_Producto");

                entity.Property(e => e.IdCondicionesGeneralesProducto).HasColumnName("Id_CondicionesGeneralesProducto");

                entity.Property(e => e.IdCondicionesGenerales).HasColumnName("Id_CondicionesGenerales");

                entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");
            });

            modelBuilder.Entity<PrFormaPagoCuotaInteres>(entity =>
            {
                entity.HasKey(e => e.IdFormaPagoCuotaInteres)
                    .HasName("pk_pr_formapago_cuotainteres");

                entity.ToTable("PR_FormaPago_Cuota_Interes");

                entity.Property(e => e.Coeficiente).HasColumnType("numeric(5, 4)");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tem)
                    .HasColumnName("TEM")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Tna)
                    .HasColumnName("TNA")
                    .HasColumnType("numeric(5, 2)");

                entity.HasOne(d => d.IdFormaPagoNavigation)
                    .WithMany(p => p.PrFormaPagoCuotaInteres)
                    .HasForeignKey(d => d.IdFormaPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pr_formapago_cuota_interes_PO_FormasPago");
            });

            modelBuilder.Entity<PrFormasPagoProducto>(entity =>
            {
                entity.HasKey(e => e.IdFormasPagoProducto);

                entity.ToTable("PR_FormasPagoProducto");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.Interes).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFormaPagoNavigation)
                    .WithMany(p => p.PrFormasPagoProducto)
                    .HasForeignKey(d => d.IdFormaPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_FormasPagoProducto_PO_FormasPago");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.PrFormasPagoProducto)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_FormasPagoProducto_PR_Producto");
            });

            modelBuilder.Entity<PrGruposAfinidad>(entity =>
            {
                entity.HasKey(e => e.IdGrupoAfinidad);

                entity.ToTable("PR_GruposAfinidad");

                entity.Property(e => e.CodigoGrupoAfinidad)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionGrupoAfinidad)
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

                entity.Property(e => e.ObservacionGrupoAfinidad)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCompaniaNavigation)
                    .WithMany(p => p.PrGruposAfinidad)
                    .HasForeignKey(d => d.IdCompania)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_GruposAfinidad_BS_Companias");
            });

            modelBuilder.Entity<PrGruposServicios>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PR_GruposServicios");

                entity.Property(e => e.CodigoGrupoServicio)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionGrupoServicio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.IdGrupoServicio).ValueGeneratedOnAdd();

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrLineaProducto>(entity =>
            {
                entity.HasKey(e => e.IdLineaProducto);

                entity.ToTable("PR_LineaProducto");

                entity.Property(e => e.CodigoLineaProducto)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionLineaProducto)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCompaniaNavigation)
                    .WithMany(p => p.PrLineaProducto)
                    .HasForeignKey(d => d.IdCompania)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_LineaProducto_BS_Companias");
            });

            modelBuilder.Entity<PrLogPromocionesAplicadas>(entity =>
            {
                entity.HasKey(e => e.IdLogPromocionesAplicadas);

                entity.ToTable("PR_LogPromocionesAplicadas");

                entity.HasIndex(e => e.IdPoliza)
                    .HasName("IX_PR_LogPromocionesAplicadas");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionDetallePromocion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.PrLogPromocionesAplicadas)
                    .HasForeignKey(d => d.IdPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_LogPromocionesAplicadas_PO_Polizas");

                entity.HasOne(d => d.IdPromocionNavigation)
                    .WithMany(p => p.PrLogPromocionesAplicadas)
                    .HasForeignKey(d => d.IdPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_LogPromocionesAplicadas_PR_Promociones");

                entity.HasOne(d => d.IdTipoPromocionNavigation)
                    .WithMany(p => p.PrLogPromocionesAplicadas)
                    .HasForeignKey(d => d.IdTipoPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_LogPromocionesAplicadas_PR_TiposPromocion");
            });

            modelBuilder.Entity<PrLogPromocionesDetalle>(entity =>
            {
                entity.HasKey(e => e.IdLogPromocionesDetalle);

                entity.ToTable("PR_LogPromocionesDetalle");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdBeneficiarioPolizaNavigation)
                    .WithMany(p => p.PrLogPromocionesDetalle)
                    .HasForeignKey(d => d.IdBeneficiarioPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_LogPromocionesDetalle_PO_BeneficiariosPoliza");

                entity.HasOne(d => d.IdLogPromocionesAplicadasNavigation)
                    .WithMany(p => p.PrLogPromocionesDetalle)
                    .HasForeignKey(d => d.IdLogPromocionesAplicadas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_LogPromocionesDetalle_PR_LogPromocionesAplicadas");
            });

            modelBuilder.Entity<PrMarcasProductos>(entity =>
            {
                entity.HasKey(e => e.IdMarca);

                entity.ToTable("PR_MarcasProductos");

                entity.Property(e => e.CodigoMarca)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionMarca)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModPor).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.FileLogo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdLineaProductoNavigation)
                    .WithMany(p => p.PrMarcasProductos)
                    .HasForeignKey(d => d.IdLineaProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_MarcasProductos_PR_LineaProducto");
            });

            modelBuilder.Entity<PrModalidadProducto>(entity =>
            {
                entity.HasKey(e => e.IdModalidadProducto);

                entity.ToTable("PR_ModalidadProducto");

                entity.Property(e => e.CodigoModalidad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionModalidad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequiereCtaCte)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdTipoFacturacionProductoNavigation)
                    .WithMany(p => p.PrModalidadProducto)
                    .HasForeignKey(d => d.IdTipoFacturacionProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_ModalidadProducto_PR_TipoFacturacionProducto");

                entity.HasOne(d => d.IdTipoUsoNavigation)
                    .WithMany(p => p.PrModalidadProducto)
                    .HasForeignKey(d => d.IdTipoUso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_ModalidadProducto_Pr_ProductoTiposUso");
            });

            modelBuilder.Entity<PrPaquetesProductos>(entity =>
            {
                entity.HasKey(e => e.IdPaquetesProductos);

                entity.ToTable("PR_PaquetesProductos");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMonedaNavigation)
                    .WithMany(p => p.PrPaquetesProductos)
                    .HasForeignKey(d => d.IdMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_PaquetesProductos_BS_Monedas");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.PrPaquetesProductos)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_PaquetesProductos_PR_Producto");
            });

            modelBuilder.Entity<PrProducto>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("PK_Productos");

                entity.ToTable("PR_Producto");

                entity.HasIndex(e => e.CodigoProducto)
                    .HasName("UK_CodigoProducto")
                    .IsUnique();

                entity.Property(e => e.CoberturaMaxima).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CondicionesGenerales).HasColumnType("text");

                entity.Property(e => e.CondicionesGenerales2).HasColumnType("text");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DenominacionProducto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.Leyenda)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.LeyendaIngles)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.LeyendaTratadoEuropa)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.LeyendaTratadoEuropaIngles)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.LeyendaValidez)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.LeyendaValidezIngles)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Linkproducto)
                    .IsRequired()
                    .HasColumnName("linkproducto")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MarcaProductoBase)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PdfCondicionesGenerales)
                    .HasColumnName("PDF_CondicionesGenerales")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProductoAgencias)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Restricciones)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Rpt)
                    .HasColumnName("RPT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMarcaNavigation)
                    .WithMany(p => p.PrProducto)
                    .HasForeignKey(d => d.IdMarca)
                    .HasConstraintName("FK_PR_Producto_PR_MarcasProductos");

                entity.HasOne(d => d.IdMonedaNavigation)
                    .WithMany(p => p.PrProducto)
                    .HasForeignKey(d => d.IdMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_Producto_BS_Monedas");

                entity.HasOne(d => d.IdTipoCoberturaNavigation)
                    .WithMany(p => p.PrProducto)
                    .HasForeignKey(d => d.IdTipoCobertura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_Producto_PR_TipoCobertura");

                entity.HasOne(d => d.IdTipoViajeNavigation)
                    .WithMany(p => p.PrProducto)
                    .HasForeignKey(d => d.IdTipoViaje)
                    .HasConstraintName("FK_PR_Producto_PR_TipoViaje");
            });

            modelBuilder.Entity<PrProductoAdicional>(entity =>
            {
                entity.HasKey(e => e.IdProductoAdicional)
                    .HasName("PK__PR_Producto_Adic__310E22DD")
                    .IsClustered(false);

                entity.ToTable("PR_Producto_Adicional");
            });

            modelBuilder.Entity<PrProductoAdicionalH>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PR_Producto_Adicional_H");
            });

            modelBuilder.Entity<PrProductoDatosCotizacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PR_PRODUCTO_DATOS_COTIZACION");

                entity.Property(e => e.DFechaDesde)
                    .HasColumnName("dFechaDesde")
                    .HasColumnType("datetime");

                entity.Property(e => e.DFechaHasta)
                    .HasColumnName("dFechaHasta")
                    .HasColumnType("datetime");

                entity.Property(e => e.NombrePagina)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrProductoDatosCotizacionH>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PR_PRODUCTO_DATOS_COTIZACION_H");

                entity.Property(e => e.DFechaDesde)
                    .HasColumnName("dFechaDesde")
                    .HasColumnType("datetime");

                entity.Property(e => e.DFechaHasta)
                    .HasColumnName("dFechaHasta")
                    .HasColumnType("datetime");

                entity.Property(e => e.NombrePagina)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrProductoDestino>(entity =>
            {
                entity.HasKey(e => e.IdProductoDestino)
                    .HasName("PK__PR_Produ__4B49C9881F2F69C4")
                    .IsClustered(false);

                entity.ToTable("PR_Producto_Destino");

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VigenciaDesde).HasColumnType("datetime");

                entity.Property(e => e.VigenciaHasta).HasColumnType("datetime");
            });

            modelBuilder.Entity<PrProductoDestino20150914>(entity =>
            {
                entity.HasKey(e => e.IdProductoDestino)
                    .HasName("PK__PR_Producto_Dest__04708690")
                    .IsClustered(false);

                entity.ToTable("PR_Producto_Destino_20150914");

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VigenciaDesde).HasColumnType("datetime");

                entity.Property(e => e.VigenciaHasta).HasColumnType("datetime");
            });

            modelBuilder.Entity<PrProductoDestinoH>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PR_Producto_Destino_H");

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VigenciaDesde).HasColumnType("datetime");

                entity.Property(e => e.VigenciaHasta).HasColumnType("datetime");
            });

            modelBuilder.Entity<PrProductoH>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PR_Producto_H");

                entity.Property(e => e.CoberturaMaxima).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CondicionesGenerales).HasColumnType("text");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DenominacionProducto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.Leyenda)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.LeyendaIngles)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.LeyendaTratadoEuropa)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.LeyendaTratadoEuropaIngles)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.LeyendaValidez)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.LeyendaValidezIngles)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Linkproducto)
                    .IsRequired()
                    .HasColumnName("linkproducto")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MarcaProductoBase)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PdfCondicionesGenerales)
                    .HasColumnName("PDF_CondicionesGenerales")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProductoAgencias)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PrProductoMotivoViaje>(entity =>
            {
                entity.HasKey(e => e.IdProductoMotivoViaje);

                entity.ToTable("PR_Producto_Motivo_Viaje");
            });

            modelBuilder.Entity<PrProductoPrecio>(entity =>
            {
                entity.HasKey(e => e.IdProductoPrecio);

                entity.ToTable("PR_ProductoPrecio");

                entity.HasIndex(e => new { e.IdProductoPrecio, e.Importe, e.FechaHasta, e.Dias, e.IdAgencia, e.IdProducto })
                    .HasName("idx_PR_ProductoPrecio_02");

                entity.HasIndex(e => new { e.IdProductoPrecio, e.Dias, e.EdadDesde, e.EdadHasta, e.IdMoneda, e.Importe, e.PorcentajeAdicional, e.IdModalidadProducto, e.IdProducto, e.IdAgencia, e.FechaDesde, e.FechaHasta })
                    .HasName("ix_PREOSAMIBR_dbo_PR_ProductoPrecio_01");

                entity.HasIndex(e => new { e.IdProductoPrecio, e.FechaDesde, e.FechaHasta, e.Dias, e.EdadDesde, e.EdadHasta, e.IdMoneda, e.Importe, e.PorcentajeAdicional, e.IdGrupoAfinidad, e.IdAgencia, e.IdProducto })
                    .HasName("ix_PR_ProductoPrecio_1");

                entity.HasIndex(e => new { e.IdProductoPrecio, e.Dias, e.EdadDesde, e.EdadHasta, e.IdMoneda, e.Importe, e.PorcentajeAdicional, e.IdModalidadProducto, e.IdProducto, e.IdAgencia, e.ProductTypeId, e.FechaDesde, e.FechaHasta })
                    .HasName("idx_PR_ProductoPrecio_01");

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

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.PrProductoPrecio)
                    .HasForeignKey(d => d.IdAgencia)
                    .HasConstraintName("FK_PR_ProductoPrecio_CO_Agencias");

                entity.HasOne(d => d.IdGrupoAfinidadNavigation)
                    .WithMany(p => p.PrProductoPrecio)
                    .HasForeignKey(d => d.IdGrupoAfinidad)
                    .HasConstraintName("FK_PR_ProductoPrecio_PR_GruposAfinidad");

                entity.HasOne(d => d.IdModalidadProductoNavigation)
                    .WithMany(p => p.PrProductoPrecio)
                    .HasForeignKey(d => d.IdModalidadProducto)
                    .HasConstraintName("FK_PR_ProductoPrecio_PR_ModalidadProducto");

                entity.HasOne(d => d.IdMonedaNavigation)
                    .WithMany(p => p.PrProductoPrecio)
                    .HasForeignKey(d => d.IdMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_ProductoPrecio_BS_Monedas");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.PrProductoPrecio)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_ProductoPrecio_PR_Producto");
            });

            modelBuilder.Entity<PrProductoPrecioBackSinmodalidad>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PR_ProductoPrecio_back_sinmodalidad");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaDesde).HasColumnType("datetime");

                entity.Property(e => e.FechaHasta).HasColumnType("datetime");

                entity.Property(e => e.IdProductoPrecio).ValueGeneratedOnAdd();

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrProductoPrecioBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PR_ProductoPrecio_backup");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaDesde).HasColumnType("datetime");

                entity.Property(e => e.FechaHasta).HasColumnType("datetime");

                entity.Property(e => e.IdProductoPrecio).ValueGeneratedOnAdd();

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrProductoPrecioH>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PR_ProductoPrecio_H");

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
            });

            modelBuilder.Entity<PrProductoPrecioImport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PR_ProductoPrecio_import");

                entity.Property(e => e.CodigoMoneda)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dias)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EdadDesde)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EdadHasta)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaDesde)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdAgencia)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdProducto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdProductoAdicional)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Importe)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrProductoServicios>(entity =>
            {
                entity.HasKey(e => e.IdProductoServicio)
                    .HasName("PK_DetalleProducto");

                entity.ToTable("PR_ProductoServicios");

                entity.HasIndex(e => new { e.IdProducto, e.FecBaja, e.FechaInicioVigencia, e.FechaFinVigencia })
                    .HasName("ix_PR_ProductoServicios_1");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Detalle)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleIngles)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FecBaja).HasColumnType("datetime");

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.ImporteSugerido).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.PrProductoServicios)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_ProductoServicios_PR_IdProducto");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.PrProductoServicios)
                    .HasForeignKey(d => d.IdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_ProductoServicios_PR_Servicios");

                entity.HasOne(d => d.IdUnidadmedidaNavigation)
                    .WithMany(p => p.PrProductoServicios)
                    .HasForeignKey(d => d.IdUnidadmedida)
                    .HasConstraintName("FK_PR_ProductoServicios_PR_UnidadesMedida");
            });



            modelBuilder.Entity<PrProductoServiciosH>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PR_ProductoServicios_H");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Detalle)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FecBaja).HasColumnType("datetime");

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.ImporteSugerido).HasColumnType("numeric(15, 2)");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrProductoServiciosImport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PR_ProductoServicios_import");

                entity.Property(e => e.CodigoMoneda)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DenominacionProducto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionServicio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaInicioVigencia)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdProducto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdServicio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdUnidadMedida)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tope)
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrProductoTiposUso>(entity =>
            {
                entity.HasKey(e => e.IdProductoTipoUso)
                    .HasName("PK_Pr_ProductoTiposUso");

                entity.ToTable("PR_ProductoTiposUso");

                entity.Property(e => e.CodigoTipoUso)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTipoUso)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrProductosAgencias>(entity =>
            {
                entity.HasKey(e => e.IdProductoAgencia)
                    .HasName("PK_PR_ProductoAgencias");

                entity.ToTable("PR_ProductosAgencias");

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");
            });

            modelBuilder.Entity<PrProductosAgenciasH>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PR_ProductosAgencias_H");

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");
            });

            modelBuilder.Entity<PrProductosHabilitadosPromocion>(entity =>
            {
                entity.HasKey(e => e.IdProductoHabilitadoPromocion);

                entity.ToTable("PR_ProductosHabilitadosPromocion");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaVigenciaDesde).HasColumnType("datetime");

                entity.Property(e => e.FechaVigenciaHasta).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.PrProductosHabilitadosPromocion)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_ProductosHabilitadosPromocion_PR_Producto");

                entity.HasOne(d => d.IdPromocionNavigation)
                    .WithMany(p => p.PrProductosHabilitadosPromocion)
                    .HasForeignKey(d => d.IdPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_ProductosHabilitadosPromocion_PR_Promociones");
            });

            modelBuilder.Entity<PrPromocionAgencia>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PR_PromocionAgencia");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.IdPromocionAgencia).ValueGeneratedOnAdd();

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrPromocionComboEtario>(entity =>
            {
                entity.HasKey(e => e.IdComboEtarioPromocion);

                entity.ToTable("PR_PromocionComboEtario");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPromocionNavigation)
                    .WithMany(p => p.PrPromocionComboEtario)
                    .HasForeignKey(d => d.IdPromocion)
                    .HasConstraintName("FK_PR_PromocionComboEtario_PR_Promociones");

                entity.HasOne(d => d.IdTipoPromocionNavigation)
                    .WithMany(p => p.PrPromocionComboEtario)
                    .HasForeignKey(d => d.IdTipoPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_PromocionComboEtario_PR_TiposPromocion");
            });

            modelBuilder.Entity<PrPromocionCombos>(entity =>
            {
                entity.HasKey(e => e.IdComboPromocion)
                    .HasName("PK_PR_CombosPromocion");

                entity.ToTable("PR_PromocionCombos");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.MarcaBonifMenorValor)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPromocionNavigation)
                    .WithMany(p => p.PrPromocionCombos)
                    .HasForeignKey(d => d.IdPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_CombosPromocion_PR_Promociones");

                entity.HasOne(d => d.IdTipoPromocionNavigation)
                    .WithMany(p => p.PrPromocionCombos)
                    .HasForeignKey(d => d.IdTipoPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_CombosPromocion_PR_TiposPromocion");
            });

            modelBuilder.Entity<PrPromocionCuponGeneral>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PR_PromocionCuponGeneral");

                entity.Property(e => e.AgenciasIn)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgenciasNotIn)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoCupon)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdPromocionCuponGeneral).ValueGeneratedOnAdd();

                entity.Property(e => e.ProductosIn)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductosNotIn)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VigenciaDesde).HasColumnType("datetime");

                entity.Property(e => e.VigenciaHasta).HasColumnType("datetime");
            });

            modelBuilder.Entity<PrPromocionCupones>(entity =>
            {
                entity.HasKey(e => e.IdCuponesPromocion);

                entity.ToTable("PR_PromocionCupones");

                entity.HasIndex(e => e.CodigoCupon)
                    .HasName("IX_CodigoCupon");

                entity.Property(e => e.CodigoCupon)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CouponTypeId).HasColumnName("CouponTypeID");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCanalPublicacionCuponNavigation)
                    .WithMany(p => p.PrPromocionCupones)
                    .HasForeignKey(d => d.IdCanalPublicacionCupon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_PromocionCupones_PR_CanalesPublicacionCupones");

                entity.HasOne(d => d.IdGrupoAfinidadNavigation)
                    .WithMany(p => p.PrPromocionCupones)
                    .HasForeignKey(d => d.IdGrupoAfinidad)
                    .HasConstraintName("FK_PR_PromocionCupones_PR_GruposAfinidad");

                entity.HasOne(d => d.IdPromocionNavigation)
                    .WithMany(p => p.PrPromocionCupones)
                    .HasForeignKey(d => d.IdPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_PromocionCupones_PR_Promociones");

                entity.HasOne(d => d.IdTipoPromocionNavigation)
                    .WithMany(p => p.PrPromocionCupones)
                    .HasForeignKey(d => d.IdTipoPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_PromocionCupones_PR_TiposPromocion");
            });

            modelBuilder.Entity<PrPromocionDescuentoIndividual>(entity =>
            {
                entity.HasKey(e => e.IdDescuentoIndividualPromocion);

                entity.ToTable("PR_PromocionDescuentoIndividual");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPromocionNavigation)
                    .WithMany(p => p.PrPromocionDescuentoIndividual)
                    .HasForeignKey(d => d.IdPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_PromocionDescuentoIndividual_PR_Promociones");

                entity.HasOne(d => d.IdTipoPromocionNavigation)
                    .WithMany(p => p.PrPromocionDescuentoIndividual)
                    .HasForeignKey(d => d.IdTipoPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_PromocionDescuentoIndividual_PR_TiposPromocion");
            });

            modelBuilder.Entity<PrPromocionGrupoFamiliar>(entity =>
            {
                entity.HasKey(e => e.IdPromocionGrupoFamiliar);

                entity.ToTable("PR_PromocionGrupoFamiliar");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPromocionNavigation)
                    .WithMany(p => p.PrPromocionGrupoFamiliar)
                    .HasForeignKey(d => d.IdPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_PromocionGrupoFamiliar_PR_Promociones");

                entity.HasOne(d => d.IdRangoEtareoNavigation)
                    .WithMany(p => p.PrPromocionGrupoFamiliar)
                    .HasForeignKey(d => d.IdRangoEtareo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_PromocionGrupoFamiliar_PR_RangosEdadesPrecios");

                entity.HasOne(d => d.IdTipoPromocionNavigation)
                    .WithMany(p => p.PrPromocionGrupoFamiliar)
                    .HasForeignKey(d => d.IdTipoPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_PromocionGrupoFamiliar_PR_TiposPromocion");
            });

            modelBuilder.Entity<PrPromocionPaisDestino>(entity =>
            {
                entity.HasKey(e => e.IdPaisDestinoPromocion);

                entity.ToTable("PR_PromocionPaisDestino");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.PrPromocionPaisDestino)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_PromocionPaisDestino_BS_Paises");

                entity.HasOne(d => d.IdPromocionNavigation)
                    .WithMany(p => p.PrPromocionPaisDestino)
                    .HasForeignKey(d => d.IdPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_PromocionPaisDestino_PR_Promociones");

                entity.HasOne(d => d.IdTipoPromocionNavigation)
                    .WithMany(p => p.PrPromocionPaisDestino)
                    .HasForeignKey(d => d.IdTipoPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_PromocionPaisDestino_PR_TiposPromocion");
            });

            modelBuilder.Entity<PrPromocionProducto>(entity =>
            {
                entity.HasKey(e => e.IdProductoPromocion);

                entity.ToTable("PR_PromocionProducto");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.PrPromocionProducto)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_PromocionProducto_PR_Producto");

                entity.HasOne(d => d.IdPromocionNavigation)
                    .WithMany(p => p.PrPromocionProducto)
                    .HasForeignKey(d => d.IdPromocion)
                    .HasConstraintName("FK_PR_PromocionProducto_PR_Promociones");

                entity.HasOne(d => d.IdTipoPromocionNavigation)
                    .WithMany(p => p.PrPromocionProducto)
                    .HasForeignKey(d => d.IdTipoPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_PromocionProducto_PR_TiposPromocion");
            });

            modelBuilder.Entity<PrPromocionRangosEtarios>(entity =>
            {
                entity.HasKey(e => e.IdRangosEtariosPromocion)
                    .HasName("PK_PR_PromocionRangoEtario");

                entity.ToTable("PR_PromocionRangosEtarios");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPromocionNavigation)
                    .WithMany(p => p.PrPromocionRangosEtarios)
                    .HasForeignKey(d => d.IdPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_PromocionRangoEtario_PR_Promociones");

                entity.HasOne(d => d.IdTipoPromocionNavigation)
                    .WithMany(p => p.PrPromocionRangosEtarios)
                    .HasForeignKey(d => d.IdTipoPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_PromocionRangoEtario_PR_TiposPromocion");
            });

            modelBuilder.Entity<PrPromociones>(entity =>
            {
                entity.HasKey(e => e.IdPromocion);

                entity.ToTable("PR_Promociones");

                entity.Property(e => e.CodigoPromocion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionPromocion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaLimiteInicioViaje).HasColumnType("datetime");

                entity.Property(e => e.MarcaTodasAgencias)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MarcaTodosProductos)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MarcaTodosSellersId)
                    .HasColumnName("MarcaTodosSellersID")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Multiplicador).HasColumnType("numeric(5, 5)");

                entity.HasOne(d => d.IdCompaniaNavigation)
                    .WithMany(p => p.PrPromociones)
                    .HasForeignKey(d => d.IdCompania)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_Promociones_BS_Companias");

                entity.HasOne(d => d.IdTipoAplicacionPromocionNavigation)
                    .WithMany(p => p.PrPromociones)
                    .HasForeignKey(d => d.IdTipoAplicacionPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_Promociones_PR_TipoAplicacionPromocion");

                entity.HasOne(d => d.IdTipoProductoNavigation)
                    .WithMany(p => p.PrPromociones)
                    .HasForeignKey(d => d.IdTipoProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_Promociones_PR_TipoProducto");
            });

            modelBuilder.Entity<PrProveedoresServicios>(entity =>
            {
                entity.HasKey(e => e.IdProveedorServicio);

                entity.ToTable("PR_ProveedoresServicios");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPersonaJuridicaNavigation)
                    .WithMany(p => p.PrProveedoresServicios)
                    .HasForeignKey(d => d.IdPersonaJuridica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_ProveedoresServicios_PE_PersonaJuridica");
            });

            modelBuilder.Entity<PrRangosEdadesPrecios>(entity =>
            {
                entity.HasKey(e => e.IdRangoEtareo);

                entity.ToTable("PR_RangosEdadesPrecios");

                entity.Property(e => e.FinVigencia).HasColumnType("datetime");

                entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            });

            modelBuilder.Entity<PrRelacionMultiproducto>(entity =>
            {
                entity.HasKey(e => e.IdRelacionMultiproducto);

                entity.ToTable("PR_RelacionMultiproducto");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProductoHijoNavigation)
                    .WithMany(p => p.PrRelacionMultiproductoIdProductoHijoNavigation)
                    .HasForeignKey(d => d.IdProductoHijo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_RelacionMultiproducto_PR_Producto1");

                entity.HasOne(d => d.IdProductoPadreNavigation)
                    .WithMany(p => p.PrRelacionMultiproductoIdProductoPadreNavigation)
                    .HasForeignKey(d => d.IdProductoPadre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_RelacionMultiproducto_PR_Producto");

                entity.HasOne(d => d.IdRangoEtareoNavigation)
                    .WithMany(p => p.PrRelacionMultiproducto)
                    .HasForeignKey(d => d.IdRangoEtareo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_RelacionMultiproducto_PR_RangosEdadesPrecios");
            });

            modelBuilder.Entity<PrRelacionProductoModalidad>(entity =>
            {
                entity.HasKey(e => e.IdRelacionProductoModalidad);

                entity.ToTable("PR_RelacionProductoModalidad");

                entity.HasIndex(e => new { e.IdProducto, e.IdModalidadProducto })
                    .HasName("IX_PR_RelacionProductoModalidad")
                    .IsUnique();

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModPor).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdModalidadProductoNavigation)
                    .WithMany(p => p.PrRelacionProductoModalidad)
                    .HasForeignKey(d => d.IdModalidadProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_RelacionProductoModalidad_PR_ModalidadProducto");

                entity.HasOne(d => d.IdMonedaNavigation)
                    .WithMany(p => p.PrRelacionProductoModalidad)
                    .HasForeignKey(d => d.IdMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_RelacionProductoModalidad_BS_Monedas");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.PrRelacionProductoModalidad)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_RelacionProductoModalidad_PR_Producto");
            });

            modelBuilder.Entity<PrSellerIdhabilitadosPromocion>(entity =>
            {
                entity.HasKey(e => e.IdSellerIdhabilitadoPromocion)
                    .HasName("PK_PR_SellerIDHabilitadasPromocion");

                entity.ToTable("PR_SellerIDHabilitadosPromocion");

                entity.Property(e => e.IdSellerIdhabilitadoPromocion).HasColumnName("IdSellerIDHabilitadoPromocion");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaVigenciaDesde).HasColumnType("datetime");

                entity.Property(e => e.FechaVigenciaHasta).HasColumnType("datetime");

                entity.Property(e => e.IdSellerIdcanalesVentas).HasColumnName("IdSellerIDCanalesVentas");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPromocionNavigation)
                    .WithMany(p => p.PrSellerIdhabilitadosPromocion)
                    .HasForeignKey(d => d.IdPromocion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_SellerIDHabilitadosPromocion_PR_Promociones");

                entity.HasOne(d => d.IdSellerIdcanalesVentasNavigation)
                    .WithMany(p => p.PrSellerIdhabilitadosPromocion)
                    .HasForeignKey(d => d.IdSellerIdcanalesVentas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_SellerIDHabilitadosPromocion_CO_SellerIDCanalesVentas");
            });

            modelBuilder.Entity<PrServicios>(entity =>
            {
                entity.HasKey(e => e.IdServicio);

                entity.ToTable("PR_Servicios");

                entity.Property(e => e.CargaPreviaCobertura)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionServicio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionServicioIngles)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.MarcaAtencion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NroOrdenPdf).HasColumnName("NroOrdenPDF");

                entity.Property(e => e.TipoServicio)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PrServiciosHomo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PR_Servicios_homo");

                entity.Property(e => e.CargaPreviaCobertura)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionServicio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionServicioIngles)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.MarcaAtencion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoServicio)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PrServiciosView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PR_ServiciosView");

                entity.Property(e => e.DescripcionServicio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrSubCobertura>(entity =>
            {
                entity.HasKey(e => e.IdSubCobertura);

                entity.ToTable("PR_SubCobertura");

                entity.Property(e => e.SubCobertura)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VigenciaDesde).HasColumnType("datetime");

                entity.Property(e => e.VigenciaHasta).HasColumnType("datetime");
            });

            modelBuilder.Entity<PrSugerencias>(entity =>
            {
                entity.HasKey(e => e.IdSugerencia)
                    .HasName("PK__PR_Sugerencias__492FC531");

                entity.ToTable("PR_Sugerencias");

                entity.Property(e => e.CodiProductoOrigen)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodiProductoResultante)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VigenciaDesde).HasColumnType("datetime");

                entity.Property(e => e.VigenciaHasta).HasColumnType("datetime");
            });

            modelBuilder.Entity<PrTipoAplicacionPromocion>(entity =>
            {
                entity.HasKey(e => e.IdTipoAplicacionPromocion);

                entity.ToTable("PR_TipoAplicacionPromocion");

                entity.Property(e => e.CodigoTipoAplicacionPromocion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTipoAplicacionPromocion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrTipoCobertura>(entity =>
            {
                entity.HasKey(e => e.IdTipoCobertura);

                entity.ToTable("PR_TipoCobertura");

                entity.HasIndex(e => e.DescripcionCobertura)
                    .HasName("UK_Descripcion")
                    .IsUnique();

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCobertura)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCobertura)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PrTipoFacturacionProducto>(entity =>
            {
                entity.HasKey(e => e.IdTipoFacturacionProducto);

                entity.ToTable("PR_TipoFacturacionProducto");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTipoFacturacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequiereNomina)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoFacturacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrTipoInicioCobertura>(entity =>
            {
                entity.HasKey(e => e.IdTipoInicioCobertura);

                entity.ToTable("PR_TipoInicioCobertura");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTipoInicioCobertura)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoInicioCobertura)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PrTipoProducto>(entity =>
            {
                entity.HasKey(e => e.IdTipoProducto)
                    .HasName("PK_PRTipoProducto");

                entity.ToTable("PR_TipoProducto");

                entity.HasIndex(e => e.DenominacionTipoProducto)
                    .HasName("UK_DenominacionTipoProducto")
                    .IsUnique();

                entity.HasIndex(e => e.TipoProducto)
                    .HasName("UK_TipoProducto")
                    .IsUnique();

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DenominacionTipoProducto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProducto)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PrTipoViaje>(entity =>
            {
                entity.HasKey(e => e.IdTipoViaje);

                entity.ToTable("PR_TipoViaje");

                entity.Property(e => e.CodigoTipoViaje)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTipoViaje)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrTiposObjetivosAgencias>(entity =>
            {
                entity.HasKey(e => e.IdTipoObjetivoComision);

                entity.ToTable("PR_TiposObjetivosAgencias");

                entity.Property(e => e.CodigoTipoObjetivoComision)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DenominacionTipoObjetivoComision)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCompaniaNavigation)
                    .WithMany(p => p.PrTiposObjetivosAgencias)
                    .HasForeignKey(d => d.IdCompania)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_TiposObjetivosAgencias_BS_Companias");
            });

            modelBuilder.Entity<PrTiposPromocion>(entity =>
            {
                entity.HasKey(e => e.IdTipoPromocion);

                entity.ToTable("PR_TiposPromocion");

                entity.Property(e => e.CodigoTipoPromocion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionBase)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTipoPromocion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sp)
                    .HasColumnName("SP")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TablaDetalle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCompaniaNavigation)
                    .WithMany(p => p.PrTiposPromocion)
                    .HasForeignKey(d => d.IdCompania)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_TiposPromocion_BS_Companias");
            });

            modelBuilder.Entity<PrUnidadesMedida>(entity =>
            {
                entity.HasKey(e => e.IdUnidadMedida);

                entity.ToTable("PR_UnidadesMedida");

                entity.Property(e => e.CodigoUnidad)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionUnidad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionUnidadIngles)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrVigenciaProducto>(entity =>
            {
                entity.HasKey(e => e.IdVigenciaProducto);

                entity.ToTable("PR_VigenciaProducto");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.PrVigenciaProducto)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_VigenciaProducto_PR_Producto");
            });

            modelBuilder.Entity<PrZonasImpresionServicios>(entity =>
            {
                entity.HasKey(e => e.IdZonaImpresion);

                entity.ToTable("PR_ZonasImpresionServicios");

                entity.Property(e => e.CodigoZonaImpresion)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionZonaImpresion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.IdZonaImpresion).ValueGeneratedOnAdd();

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCompaniaNavigation)
                    .WithMany(p => p.PrZonasImpresionServicios)
                    .HasForeignKey(d => d.IdCompania)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PR_ZonasImpresionServicios_BS_Companias");
            });

            modelBuilder.Entity<ProductsAll20130823>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Products_ALL_20130823");

                entity.Property(e => e.CodigoMoneda)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Codigoproducto)
                    .IsRequired()
                    .HasColumnName("codigoproducto")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Dias)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EdadDesde)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EdadHasta)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Fechadesde)
                    .HasColumnName("fechadesde")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdAgencia)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdProductoAdicional)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Idproducto)
                    .HasColumnName("idproducto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Importe)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductsServiceAll20131007>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProductsService_ALL_20131007");

                entity.Property(e => e.CodigoMoneda)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionProducto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionServicio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaInicioVigencia)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Idproducto)
                    .HasColumnName("idproducto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Idservicio)
                    .HasColumnName("idservicio")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tope)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadMedida)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<T>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("_T");

                entity.Property(e => e.Chksum).HasColumnName("chksum");

                entity.Property(e => e.ColumnName)
                    .HasColumnName("COLUMN_NAME")
                    .HasMaxLength(128);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasColumnName("TABLE_NAME")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<TabNascimento>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DtNascimento).HasMaxLength(255);
            });

            modelBuilder.Entity<TbErroCarga>(entity =>
            {
                entity.HasKey(e => e.IdErro)
                    .HasName("PK__tb_ErroC__E4898D607B9127CC");

                entity.ToTable("tb_ErroCarga_____", "OMINT_SEGURADORA");

                entity.Property(e => e.IdErro).HasColumnName("id_erro");

                entity.Property(e => e.DhInclusao)
                    .HasColumnName("dh_inclusao")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdPoliza).HasColumnName("id_poliza");

                entity.Property(e => e.NrErro).HasColumnName("nr_erro");
            });

            modelBuilder.Entity<TbParentescoPpe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_Parentesco_ppe");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RelationshipId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TbParentescoPpe1>(entity =>
            {
                entity.HasKey(e => e.IdParentescoPpe)
                    .HasName("PK__tb_Paren__6BF90E4A528F1239");

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
                entity.HasKey(e => new { e.CdCorretor, e.IdPessoaCorretor })
                    .HasName("PK__tb_Pesso__4144E6944EBE8155");

                entity.ToTable("tb_PessoaCorretor", "OMINT_SEGURADORA");

                entity.Property(e => e.CdCorretor).HasColumnName("cd_corretor");

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

                entity.Property(e => e.NmPessoaCorretor)
                    .IsRequired()
                    .HasColumnName("nm_pessoa_corretor")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NrCnpjcpf)
                    .IsRequired()
                    .HasColumnName("nr_cnpjcpf")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbPessoaPoliticaExposta>(entity =>
            {
                entity.HasKey(e => e.IdPessoaPoliticaExposta);

                entity.ToTable("tb_PessoaPoliticaExposta");
            });

            modelBuilder.Entity<TbPessoaPoliticaExposta1>(entity =>
            {
                entity.HasKey(e => e.IdPpe)
                    .HasName("PK__tb_Pesso__6FC859946D430875");

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

                entity.HasOne(d => d.IdBeneficiarioPolizaNavigation)
                    .WithMany(p => p.TbPessoaPoliticaExposta1)
                    .HasForeignKey(d => d.IdBeneficiarioPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_PessoaPoliticaExposta_PO_BeneficiariosPoliza");

                entity.HasOne(d => d.IdParentescoPpeNavigation)
                    .WithMany(p => p.TbPessoaPoliticaExposta1)
                    .HasForeignKey(d => d.IdParentescoPpe)
                    .HasConstraintName("FK_tb_PessoaPoliticaExposta_tb_Parentesco_ppe");
            });

            modelBuilder.Entity<TbProduto>(entity =>
            {
                entity.HasKey(e => e.IdProduto)
                    .HasName("PK__tb_Produ__BA38A6B869727791");

                entity.ToTable("tb_Produto", "OMINT_SEGURADORA");

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.Property(e => e.CdCorretor).HasColumnName("cd_corretor");

                entity.Property(e => e.CdSusep)
                    .HasColumnName("cd_susep")
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.CdTpPapel).HasColumnName("cd_tp_papel");

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

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.TbProduto)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("FK_id_Producto");
            });

            modelBuilder.Entity<TbProposta>(entity =>
            {
                entity.HasKey(e => e.NrProposta)
                    .HasName("PK__tb_Propo__990536747F61B8B0");

                entity.ToTable("tb_Proposta___", "OMINT_SEGURADORA");

                entity.Property(e => e.NrProposta)
                    .HasColumnName("nr_proposta")
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

                entity.Property(e => e.DtFimViagem)
                    .HasColumnName("dt_fim_viagem")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtInicioViagem)
                    .HasColumnName("dt_inicio_viagem")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtNascimento)
                    .HasColumnName("dt_nascimento")
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
                    .HasMaxLength(30)
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
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NrRuaEndereco)
                    .HasColumnName("nr_rua_endereco")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneCelular)
                    .HasColumnName("nr_telefone_celular")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneComercial)
                    .HasColumnName("nr_telefone_comercial")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneEmergenciaCelular)
                    .HasColumnName("nr_telefone_emergencia_celular")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneEmergenciaComercial)
                    .HasColumnName("nr_telefone_emergencia_comercial")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneEmergenciaResidencial)
                    .HasColumnName("nr_telefone_emergencia_residencial")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneResidencial)
                    .HasColumnName("nr_telefone_residencial")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PeDescontoCupom)
                    .HasColumnName("pe_desconto_cupom")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.QtdeParcelas)
                    .HasColumnName("qtde_parcelas")
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
            });

            modelBuilder.Entity<TbPropostaAux>(entity =>
            {
                entity.HasKey(e => e.NrProposta)
                    .HasName("PK__tb_Propo__990536740BC78F95");

                entity.ToTable("tb_Proposta_Aux", "OMINT_SEGURADORA");

                entity.Property(e => e.NrProposta)
                    .HasColumnName("nr_proposta")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CdBandeiraCartao)
                    .HasColumnName("cd_bandeira_cartao")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CdFormaPagamento)
                    .HasColumnName("cd_forma_pagamento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

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

                entity.Property(e => e.DtFimViagem)
                    .HasColumnName("dt_fim_viagem")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtInicioViagem)
                    .HasColumnName("dt_inicio_viagem")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtNascimento)
                    .HasColumnName("dt_nascimento")
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

                entity.Property(e => e.IdCanalVenda)
                    .HasColumnName("id_canal_venda")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdControle)
                    .HasColumnName("id_controle")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdMotivoViagem)
                    .HasColumnName("id_motivo_viagem")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdPaisDestinoViagem)
                    .HasColumnName("id_pais_destino_viagem")
                    .HasMaxLength(5)
                    .IsUnicode(false);

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
                    .HasMaxLength(30)
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
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NrRuaEndereco)
                    .HasColumnName("nr_rua_endereco")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneCelular)
                    .HasColumnName("nr_telefone_celular")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneComercial)
                    .HasColumnName("nr_telefone_comercial")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneEmergenciaCelular)
                    .HasColumnName("nr_telefone_emergencia_celular")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneEmergenciaComercial)
                    .HasColumnName("nr_telefone_emergencia_comercial")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneEmergenciaResidencial)
                    .HasColumnName("nr_telefone_emergencia_residencial")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneResidencial)
                    .HasColumnName("nr_telefone_residencial")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PeDescontoCupom)
                    .HasColumnName("pe_desconto_cupom")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.QtdeParcelas)
                    .HasColumnName("qtde_parcelas")
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
            });

            modelBuilder.Entity<TbPropostaBeneficiario>(entity =>
            {
                entity.HasKey(e => e.IdBeneficiario)
                    .HasName("PK__tb_Propo__35B9C95C61D155C9");

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

                entity.HasOne(d => d.NrVoucherNavigation)
                    .WithMany(p => p.TbPropostaBeneficiario)
                    .HasForeignKey(d => d.NrVoucher)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_PropostaBeneficiario_tb_PropostaSegurado");
            });

            modelBuilder.Entity<TbPropostaCorretor>(entity =>
            {
                entity.HasKey(e => new { e.IdPessoaCorretor, e.NrProposta })
                    .HasName("PK__tb_Propo__1780BF865E00C4E5");

                entity.ToTable("tb_PropostaCorretor", "OMINT_SEGURADORA");

                entity.Property(e => e.IdPessoaCorretor).HasColumnName("id_pessoa_corretor");

                entity.Property(e => e.NrProposta)
                    .HasColumnName("nr_proposta")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CdTpPapel)
                    .IsRequired()
                    .HasColumnName("cd_tp_papel")
                    .HasMaxLength(20)
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

                entity.Property(e => e.DvCorretorPrincipal)
                    .IsRequired()
                    .HasColumnName("dv_corretor_principal")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PeComissao)
                    .HasColumnName("pe_comissao")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PeParticipacao)
                    .HasColumnName("pe_participacao")
                    .HasColumnType("decimal(16, 2)");

                entity.HasOne(d => d.NrPropostaNavigation)
                    .WithMany(p => p.TbPropostaCorretor)
                    .HasForeignKey(d => d.NrProposta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_PropostaCorretor_tb_Proposta");
            });

            modelBuilder.Entity<TbPropostaDeclaracaoSaude>(entity =>
            {
                entity.HasKey(e => e.IdDeclaracao)
                    .HasName("PK__tb_Propo__1132B26165A1E6AD");

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

                entity.HasOne(d => d.NrVoucherNavigation)
                    .WithMany(p => p.TbPropostaDeclaracaoSaude)
                    .HasForeignKey(d => d.NrVoucher)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_PropostaDeclaracaoSaude_tb_PropostaSegurado");
            });

            modelBuilder.Entity<TbPropostaSegurado>(entity =>
            {
                entity.HasKey(e => e.NrVoucher)
                    .HasName("PK__tb_Propo__A0D869427132C993");

                entity.ToTable("tb_PropostaSegurado_____", "OMINT_SEGURADORA");

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
                    .IsFixedLength();

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

                entity.Property(e => e.DvPpe)
                    .HasColumnName("dv_ppe")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdParentescoPpe)
                    .HasColumnName("id_parentesco_ppe")
                    .HasMaxLength(5)
                    .IsUnicode(false);

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
                    .HasMaxLength(30)
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
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneComercial)
                    .HasColumnName("nr_telefone_comercial")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneResidencial)
                    .HasColumnName("nr_telefone_residencial")
                    .HasMaxLength(30)
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

                entity.HasOne(d => d.NrPropostaNavigation)
                    .WithMany(p => p.TbPropostaSegurado)
                    .HasForeignKey(d => d.NrProposta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tb_PropostaSegurado_tb_Proposta");
            });

            modelBuilder.Entity<TbPropostaSeguradoAux>(entity =>
            {
                entity.HasKey(e => e.NrVoucher);

                entity.ToTable("tb_PropostaSegurado_Aux", "OMINT_SEGURADORA");

                entity.Property(e => e.NrVoucher)
                    .HasColumnName("nr_voucher")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CdProduto)
                    .HasColumnName("cd_produto")
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

                entity.Property(e => e.DvPpe)
                    .HasColumnName("dv_ppe")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdControle)
                    .HasColumnName("id_controle")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdParentescoPpe)
                    .HasColumnName("id_parentesco_ppe")
                    .HasMaxLength(5)
                    .IsUnicode(false);

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
                    .HasMaxLength(30)
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
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneComercial)
                    .HasColumnName("nr_telefone_comercial")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrTelefoneResidencial)
                    .HasColumnName("nr_telefone_residencial")
                    .HasMaxLength(30)
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

            modelBuilder.Entity<TmpLogAmiPoPolizaCompletaReporteBr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TMP_LOG_AMI_PO_PolizaCompleta_Reporte_BR");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Paso)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VistaPrueba>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VistaPrueba");

                entity.Property(e => e.Addd)
                    .IsRequired()
                    .HasColumnName("addd")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("usuario")
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vw360AgenteVendaLegadoOs>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_360_AgenteVenda_Legado_OS");

                entity.Property(e => e.IdContaAgenteVenda).HasColumnName("idContaAgenteVenda");

                entity.Property(e => e.NomeAgenteVenda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrDocumento)
                    .HasColumnName("nr_Documento")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SenhaAgenteVenda)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.TpDocumento)
                    .IsRequired()
                    .HasColumnName("tp_Documento")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAgenteVenda)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vw360AgenteVendaLegadoOsCarga>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_360_AgenteVenda_Legado_OS_carga");

                entity.Property(e => e.DhAlteracaoData)
                    .HasColumnName("dh_AlteracaoData")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhInclusaoOperacao)
                    .HasColumnName("dh_InclusaoOperacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DsContaUsuarioLegado)
                    .HasColumnName("ds_ContaUsuarioLegado")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsEmailContatoAgenteVenda)
                    .HasColumnName("ds_EmailContatoAgenteVenda")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsNomeAgenteVenda)
                    .HasColumnName("ds_NomeAgenteVenda")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DsNomeContatoAgenteVenda)
                    .HasColumnName("ds_NomeContatoAgenteVenda")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DsSenhaUsuarioLegado)
                    .HasColumnName("ds_SenhaUsuarioLegado")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdContaPortalLegado).HasColumnName("id_ContaPortalLegado");

                entity.Property(e => e.NmAlteracaoLogin)
                    .IsRequired()
                    .HasColumnName("nm_AlteracaoLogin")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NrCodigoAgenteVenda).HasColumnName("nr_CodigoAgenteVenda");

                entity.Property(e => e.NrDocumento)
                    .HasColumnName("nr_Documento")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TpDocumento)
                    .IsRequired()
                    .HasColumnName("tp_Documento")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TpLinhaProduto)
                    .IsRequired()
                    .HasColumnName("tp_LinhaProduto")
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwAgente>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAgente", "AreaTecnica");

                entity.Property(e => e.CdAgencia).HasColumnName("cd_agencia");

                entity.Property(e => e.DscAgencia)
                    .HasColumnName("dsc_agencia")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DscBairro)
                    .HasColumnName("dsc_bairro")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DscCep)
                    .HasColumnName("dsc_cep")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DscComplemento)
                    .HasColumnName("dsc_complemento")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DscEndereco)
                    .HasColumnName("dsc_endereco")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DscExecutivoresponsavel)
                    .HasColumnName("dsc_executivoresponsavel")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DscMail)
                    .HasColumnName("dsc_mail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DscNumero)
                    .HasColumnName("dsc_numero")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DscSegmento)
                    .HasColumnName("dsc_segmento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DscTelefone)
                    .HasColumnName("dsc_telefone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DtBaixa)
                    .HasColumnName("dt_baixa")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtCadastro)
                    .HasColumnName("dt_cadastro")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAgencia)
                    .HasColumnName("id_agencia")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Idbase)
                    .IsRequired()
                    .HasColumnName("idbase")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PerComissao)
                    .HasColumnName("per_comissao")
                    .HasColumnType("decimal(5, 2)");
            });

            modelBuilder.Entity<VwMovimento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMovimento", "AreaTecnica");

                entity.Property(e => e.CdAgencia).HasColumnName("cd_agencia");

                entity.Property(e => e.CdPpe).HasColumnName("cd_ppe");

                entity.Property(e => e.CdProduto)
                    .IsRequired()
                    .HasColumnName("cd_produto")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CdVendedor).HasColumnName("cd_vendedor");

                entity.Property(e => e.Cpf)
                    .HasColumnName("CPF")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.DscAgencia)
                    .HasColumnName("dsc_agencia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DscArquivoPdf)
                    .HasColumnName("dsc_ArquivoPdf")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DscContatoEmergencia)
                    .HasColumnName("dsc_ContatoEmergencia")
                    .HasMaxLength(201)
                    .IsUnicode(false);

                entity.Property(e => e.DscDesconto)
                    .HasColumnName("dsc_desconto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DscEMailContatoEmergencia)
                    .HasColumnName("dsc_eMailContatoEmergencia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DscFile)
                    .HasColumnName("dsc_file")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DscPpe)
                    .HasColumnName("dsc_ppe")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DscProduto)
                    .IsRequired()
                    .HasColumnName("dsc_produto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DscSegmento)
                    .HasColumnName("dsc_segmento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DscTelefoneContatoEmergencia)
                    .HasColumnName("dsc_TelefoneContatoEmergencia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DscVendedor)
                    .HasColumnName("dsc_vendedor")
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.DtCancelamento)
                    .HasColumnName("dt_cancelamento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtEmissao)
                    .HasColumnName("dt_emissao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtFimExtensao)
                    .HasColumnName("dt_fim_extensao")
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

                entity.Property(e => e.FormaPagto)
                    .HasColumnName("forma_pagto")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdDesconto).HasColumnName("id_desconto");

                entity.Property(e => e.Idbase)
                    .IsRequired()
                    .HasColumnName("idbase")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Moeda)
                    .IsRequired()
                    .HasColumnName("moeda")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NomeCliente)
                    .HasColumnName("Nome_cliente")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NrCertificado)
                    .IsRequired()
                    .HasColumnName("nr_certificado")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrParcelas).HasColumnName("nr_parcelas");

                entity.Property(e => e.NrVoucher)
                    .HasColumnName("nr_voucher")
                    .HasMaxLength(33)
                    .IsUnicode(false);

                entity.Property(e => e.PaisDestino)
                    .HasColumnName("pais_destino")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaisOrigem)
                    .IsRequired()
                    .HasColumnName("pais_origem")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PerComissao)
                    .HasColumnName("per_comissao")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerDesconto)
                    .HasColumnName("per_desconto")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Sellerid)
                    .HasColumnName("sellerid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ValorDolar)
                    .HasColumnName("valor_dolar")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ValorExtensao)
                    .HasColumnName("valor_extensao")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ValorProduto)
                    .HasColumnName("valor_produto")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ValorVoucher)
                    .HasColumnName("valor_voucher")
                    .HasColumnType("decimal(8, 2)");
            });

            modelBuilder.Entity<VwMovimentoCpf>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwMovimentoCPF", "AreaTecnica");

                entity.Property(e => e.CdAgencia).HasColumnName("cd_agencia");

                entity.Property(e => e.CdProduto)
                    .IsRequired()
                    .HasColumnName("cd_produto")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CdVendedor).HasColumnName("cd_vendedor");

                entity.Property(e => e.CodigoMotivoCancelamento)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cpf)
                    .HasColumnName("CPF")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.DescricaoMotivoCancelamento)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DscAgencia)
                    .HasColumnName("dsc_agencia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DscArquivoPdf)
                    .HasColumnName("dsc_ArquivoPdf")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DscContatoEmergencia)
                    .HasColumnName("dsc_ContatoEmergencia")
                    .HasMaxLength(201)
                    .IsUnicode(false);

                entity.Property(e => e.DscEMailContatoEmergencia)
                    .HasColumnName("dsc_eMailContatoEmergencia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DscFile)
                    .HasColumnName("dsc_file")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DscProduto)
                    .IsRequired()
                    .HasColumnName("dsc_produto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DscSegmento)
                    .HasColumnName("dsc_segmento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DscTelefoneContatoEmergencia)
                    .HasColumnName("dsc_TelefoneContatoEmergencia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DscVendedor)
                    .HasColumnName("dsc_vendedor")
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.DtCancelamento)
                    .HasColumnName("dt_cancelamento")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtEmissao)
                    .HasColumnName("dt_emissao")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtFimExtensao)
                    .HasColumnName("dt_fim_extensao")
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

                entity.Property(e => e.FormaPagto)
                    .HasColumnName("forma_pagto")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Moeda)
                    .IsRequired()
                    .HasColumnName("moeda")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NomeCliente)
                    .HasColumnName("Nome_cliente")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NrCertificado)
                    .IsRequired()
                    .HasColumnName("nr_certificado")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrVoucher)
                    .HasColumnName("nr_voucher")
                    .HasMaxLength(33)
                    .IsUnicode(false);

                entity.Property(e => e.PaisDestino)
                    .HasColumnName("pais_destino")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaisOrigem)
                    .IsRequired()
                    .HasColumnName("pais_origem")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PerComissao)
                    .HasColumnName("per_comissao")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PerDesconto)
                    .HasColumnName("per_desconto")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Sellerid)
                    .IsRequired()
                    .HasColumnName("sellerid")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ValorDolar)
                    .HasColumnName("valor_dolar")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ValorExtensao)
                    .HasColumnName("valor_extensao")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ValorProduto)
                    .HasColumnName("valor_produto")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ValorVoucher)
                    .HasColumnName("valor_voucher")
                    .HasColumnType("decimal(8, 2)");
            });

            modelBuilder.Entity<VwProductoPrecio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwProductoPrecio", "AreaTecnica");

                entity.Property(e => e.CodigoMoneda)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaDesde).HasColumnType("datetime");

                entity.Property(e => e.FechaHasta).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwServicio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwServicio", "AreaTecnica");

                entity.Property(e => e.CodigoMoneda)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodigoProducto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DenominacionProducto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionServicio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Detalle)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFinVigencia).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia).HasColumnType("datetime");

                entity.Property(e => e.IdProductoServicio).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WcfAdditionalCoverage>(entity =>
            {
                entity.HasKey(e => e.IdAdicional);

                entity.ToTable("WCF_AdditionalCoverage");

                entity.Property(e => e.Adicional)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdicionalIngles)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreaReg).HasColumnType("datetime");

                entity.Property(e => e.FecModReg).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WcfAdditionalCoverageServices>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WCF_AdditionalCoverageServices");

                entity.Property(e => e.AdditionalCoverageServiceId)
                    .HasColumnName("AdditionalCoverageServiceID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AdditionalCoveragelId).HasColumnName("AdditionalCoveragelID");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Detail)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishDetail)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.UnitOfMeasureId).HasColumnName("UnitOfMeasureID");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<WcfBlackList>(entity =>
            {
                entity.HasKey(e => e.BlackListId);

                entity.ToTable("WCF_BlackList");

                entity.Property(e => e.BlackListId).HasColumnName("BlackListID");

                entity.Property(e => e.IdentityDocumentNumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdentityDocumentNumberFiltered)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdentityDocumentTypeId).HasColumnName("IdentityDocumentTypeID");
            });

            modelBuilder.Entity<WcfBsNotification>(entity =>
            {
                entity.HasKey(e => e.IdNotification);

                entity.ToTable("WCF_BS_Notification");

                entity.Property(e => e.IdNotification).HasColumnName("idNotification");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Daily).HasColumnName("daily");

                entity.Property(e => e.DayMonth).HasColumnName("dayMonth");

                entity.Property(e => e.DayWeek).HasColumnName("dayWeek");

                entity.Property(e => e.DestinationList)
                    .HasColumnName("destinationList")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NotificationType)
                    .HasColumnName("notificationType")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SMessage)
                    .HasColumnName("sMessage")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingHours).HasColumnName("shippingHours");

                entity.Property(e => e.TriggerName)
                    .HasColumnName("triggerName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UrlofEmail)
                    .HasColumnName("URLofEmail")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WcfBsNotificationSource>(entity =>
            {
                entity.HasKey(e => e.IdNotificationSource);

                entity.ToTable("WCF_BS_Notification_Source");

                entity.Property(e => e.FieldFather)
                    .HasColumnName("fieldFather")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FieldSon)
                    .HasColumnName("fieldSon")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber).HasColumnName("orderNumber");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnName("source")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasColumnName("tableName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WcfConsultant>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WCF_Consultant");

                entity.Property(e => e.ConsultantId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreationBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<WcfConsultantAgency>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WCF_Consultant_Agency");

                entity.Property(e => e.ConsultantAgencyId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreationBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.VadlidTo).HasColumnType("datetime");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");
            });

            modelBuilder.Entity<WcfContactUsBlogger>(entity =>
            {
                entity.HasKey(e => e.ContactUsBloggerId);

                entity.ToTable("WCF_ContactUs_Blogger");

                entity.Property(e => e.Blog)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WcfCouponType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WCF_CouponType");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CouponTypeId)
                    .HasColumnName("CouponTypeID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WcfCoverageByProductToPrint>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WCF_CoverageByProductToPrint");

                entity.Property(e => e.AdditionalCoverageCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CoverageNameEn)
                    .HasColumnName("CoverageNameEN")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CoverageNamePt)
                    .IsRequired()
                    .HasColumnName("CoverageNamePT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CoverageTypeCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Days)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Franchise)
                    .HasMaxLength(59)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredCapitalEn)
                    .HasColumnName("InsuredCapitalEN")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredCapitalPt)
                    .HasColumnName("InsuredCapitalPT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<WcfDestinyShowCase>(entity =>
            {
                entity.HasKey(e => e.DestinyShowCaseId)
                    .HasName("PK__WCF_Dest__6C968A664CA12EB9")
                    .IsClustered(false);

                entity.ToTable("WCF_Destiny_ShowCase");

                entity.Property(e => e.CreatedByUserId)
                    .HasColumnName("CreatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId)
                    .HasColumnName("LastModifiedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidUntil).HasColumnType("datetime");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.WcfDestinyShowCase)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCF_Destiny_ShowCase_CountryId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.WcfDestinyShowCase)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCF_Destiny_ShowCase_ProductId");
            });

            modelBuilder.Entity<WcfPoVoucherAdditionalCoverage>(entity =>
            {
                entity.HasKey(e => e.VoucherAdditionalCoverageId);

                entity.ToTable("WCF_PO_Voucher_AdditionalCoverage");

                entity.HasIndex(e => e.VoucherId)
                    .HasName("ix_PRE_OS_AMIBR_dbo_WCF_PO_Voucher_AdditionalCoverage_1");

                entity.Property(e => e.AdditionalCoverageId).HasColumnName("AdditionalCoverageID");

                entity.Property(e => e.ProductId).HasColumnName("productID");

                entity.Property(e => e.VoucherAdditionalCoverageId)
                    .HasColumnName("VoucherAdditionalCoverageID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.VoucherId).HasColumnName("VoucherID");

                entity.HasOne(d => d.AdditionalCoverage)
                    .WithMany(p => p.WcfPoVoucherAdditionalCoverage)
                    .HasForeignKey(d => d.AdditionalCoverageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCF_PO_Voucher_AdditionalCoverage_WCF_AdditionalCoverage");
            });

            modelBuilder.Entity<WcfPoVoucherReasonForCancellation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WCF_PO_Voucher_ReasonForCancellation");

                entity.Property(e => e.BeneficiaryId).HasColumnName("BeneficiaryID");

                entity.Property(e => e.ReasonForCancellationId).HasColumnName("ReasonForCancellationID");

                entity.Property(e => e.VoucherId).HasColumnName("VoucherID");

                entity.Property(e => e.VoucherReasonForCancellationId)
                    .HasColumnName("VoucherReasonForCancellationID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WcfProductAdditionalCoverage>(entity =>
            {
                entity.HasKey(e => e.ProductAdditionalId);

                entity.ToTable("WCF_Product_AdditionalCoverage");

                entity.Property(e => e.AdditionalCoverageId).HasColumnName("AdditionalCoverageID");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductAdditionalId)
                    .HasColumnName("ProductAdditionalID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");

                entity.HasOne(d => d.AdditionalCoverage)
                    .WithMany(p => p.WcfProductAdditionalCoverage)
                    .HasForeignKey(d => d.AdditionalCoverageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCF_Product_AdditionalCoverage_WCF_AdditionalCoverage");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.WcfProductAdditionalCoverage)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCF_Product_AdditionalCoverage_PR_Producto");
            });

            modelBuilder.Entity<WcfProductAdditionalCoveragePrice>(entity =>
            {
                entity.HasKey(e => e.ProductAdditionalCoveragePriceId);

                entity.ToTable("WCF_Product_AdditionalCoverage_Price");

                entity.HasIndex(e => new { e.AdditionalCoverageId, e.DaysOfCoverage, e.Amount, e.ProductId, e.ValidFrom, e.ValidTo })
                    .HasName("ix_WCF_Product_AdditionalCoverage_Price_2");

                entity.HasIndex(e => new { e.ProductId, e.AdditionalCoverageId, e.Amount, e.DaysOfCoverage, e.ValidFrom, e.ValidTo })
                    .HasName("ix_WCF_Product_AdditionalCoverage_Price_3");

                entity.HasIndex(e => new { e.ProductId, e.AdditionalCoverageId, e.DaysOfCoverage, e.Amount, e.ValidFrom, e.ValidTo })
                    .HasName("ix_WCF_Product_AdditionalCoverage_Price_1");

                entity.Property(e => e.AdditionalCoverageId).HasColumnName("AdditionalCoverageID");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductAdditionalCoveragePriceId)
                    .HasColumnName("ProductAdditionalCoveragePriceID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");

                entity.HasOne(d => d.AdditionalCoverage)
                    .WithMany(p => p.WcfProductAdditionalCoveragePrice)
                    .HasForeignKey(d => d.AdditionalCoverageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCF_Product_AdditionalCoverage_Price_WCF_AdditionalCoverage");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.WcfProductAdditionalCoveragePrice)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCF_Product_AdditionalCoverage_Price_PR_Producto");
            });

            modelBuilder.Entity<WcfProductShowCase>(entity =>
            {
                entity.HasKey(e => e.ProductShowCaseId)
                    .HasName("PK__WCF_Prod__B57B791346E85563")
                    .IsClustered(false);

                entity.ToTable("WCF_Product_ShowCase");

                entity.Property(e => e.CreatedByUserId)
                    .HasColumnName("CreatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId)
                    .HasColumnName("LastModifiedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidUntil).HasColumnType("datetime");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.WcfProductShowCaseProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCF_Product_ShowCase_ProductId");

                entity.HasOne(d => d.RelatedProduct)
                    .WithMany(p => p.WcfProductShowCaseRelatedProduct)
                    .HasForeignKey(d => d.RelatedProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCF_Product_ShowCase_RelatedProductId");
            });


            modelBuilder.Entity<WcfProductType>(entity =>
            {
                entity.HasKey(e => e.ProductTypeId);

                entity.ToTable("WCF_ProductType");

                entity.HasIndex(e => e.ProductTypeCode)
                    .HasName("UK_ProductTypeCode")
                    .IsUnique();

                entity.HasIndex(e => e.ProductTypeDescription)
                    .HasName("UK_ProductTypeDescription")
                    .IsUnique();

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.ProductTypeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProductTypeDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProductTypeId)
                    .HasColumnName("ProductTypeID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ValidTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<WcfProductTypeCompany>(entity =>
            {
                entity.HasKey(e => e.ProductTypeCompanyId);

                entity.ToTable("WCF_ProductType_Company");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ProductTypeCompanyId)
                    .HasColumnName("ProductTypeCompanyID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");
            });

            modelBuilder.Entity<WcfProfile>(entity =>
            {
                entity.HasKey(e => e.ProfileId);

                entity.ToTable("WCF_Profile");

                entity.Property(e => e.Profile)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<WcfProfilePermission>(entity =>
            {
                entity.HasKey(e => e.ProfilePermissionId);

                entity.ToTable("WCF_Profile_Permission");

                entity.Property(e => e.Method)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Service)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WcfProfileRoles>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("WCF_ProfileRoles");

                entity.Property(e => e.DnnroleName)
                    .HasColumnName("DNNRoleName")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UserTypeCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WcfQtDiasMultiviagem>(entity =>
            {
                entity.HasKey(e => e.QtDiasMultiViagemId);

                entity.ToTable("WCF_QtDiasMultiviagem");

                entity.Property(e => e.QtDiasMultiViagemId).HasColumnName("QtDiasMultiViagemID");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");
            });

            modelBuilder.Entity<WcfReasonForCancellation>(entity =>
            {
                entity.HasKey(e => e.ReasonForCancellationId);

                entity.ToTable("WCF_ReasonForCancellation");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonForCancellationId)
                    .HasColumnName("ReasonForCancellationID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ValidTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<WcfReportGenerator>(entity =>
            {
                entity.HasKey(e => e.ReportGeneratorId);

                entity.ToTable("WCF_ReportGenerator");

                entity.Property(e => e.ReportGeneratorId)
                    .HasColumnName("ReportGeneratorID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReportType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WcfSession>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WCF_Session");

                entity.HasIndex(e => e.SessionId)
                    .HasName("ix_PREOSAMIBR_dbo_WCF_Session_01");

                entity.HasIndex(e => new { e.SessionId, e.UserName, e.SalesChannelType, e.SalesChannelCode, e.Country, e.Language, e.EndDate })
                    .HasName("ix_PRE_OS_AMIBR_dbo_WCF_Session_1");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalesChannelCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesChannelType)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasColumnName("SessionID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<WcfSmsLog>(entity =>
            {
                entity.HasKey(e => e.IdSmsLog);

                entity.ToTable("WCF_SMS_Log");

                entity.Property(e => e.IdSmsLog).HasColumnName("IdSMS_Log");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEnvio).HasColumnType("datetime");

                entity.Property(e => e.IdSmsProceso).HasColumnName("IdSMS_Proceso");
            });

            modelBuilder.Entity<WcfSpecialAudiences>(entity =>
            {
                entity.HasKey(e => e.SpecialAudiencesId)
                    .HasName("PK__WCF_Spec__C108CDC632E15CB6")
                    .IsClustered(false);

                entity.ToTable("WCF_SpecialAudiences");

                entity.Property(e => e.SpecialAudiencesId).HasColumnName("SpecialAudiencesID");

                entity.Property(e => e.LandingPage)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialAudienceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialAudienceName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WcfSpecialAudiencesShowCase>(entity =>
            {
                entity.HasKey(e => e.SpecialAudiencesShowCaseId)
                    .HasName("PK__WCF_Spec__D9E4E3274317C47F")
                    .IsClustered(false);

                entity.ToTable("WCF_SpecialAudiences_ShowCase");

                entity.Property(e => e.CreatedByUserId)
                    .HasColumnName("CreatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId)
                    .HasColumnName("LastModifiedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.SpecialAudiencesId).HasColumnName("SpecialAudiencesID");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidUntil).HasColumnType("datetime");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.WcfSpecialAudiencesShowCase)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCF_SpecialAudiences_ShowCase_ProductId");

                entity.HasOne(d => d.SpecialAudiences)
                    .WithMany(p => p.WcfSpecialAudiencesShowCase)
                    .HasForeignKey(d => d.SpecialAudiencesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCF_SpecialAudiences_ShowCase_CountryId");
            });

            modelBuilder.Entity<WcfToken>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WCF_Token");

                entity.HasIndex(e => e.Token)
                    .HasName("ix_WCF_Token_1");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SalesChannelCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesChannelType)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<WcfTokenProfile>(entity =>
            {
                entity.HasKey(e => e.IdTokenProfile);

                entity.ToTable("WCF_Token_Profile");

                entity.HasIndex(e => e.Token)
                    .HasName("ix_WCF_Token_Profile_1");

                entity.Property(e => e.Profile)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<WcfTopic>(entity =>
            {
                entity.HasKey(e => e.TopicId)
                    .HasName("PK__WCF_Topi__022E0F5C21B6D0B4")
                    .IsClustered(false);

                entity.ToTable("WCF_Topic");

                entity.HasIndex(e => e.TopicCode)
                    .HasName("WCF_Topic_UniqueTopicCode")
                    .IsUnique();

                entity.Property(e => e.CreatedByUserId)
                    .HasColumnName("CreatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.DeletedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedByUserId)
                    .HasColumnName("LastModifiedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.TopicCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WcfTopicShowCase>(entity =>
            {
                entity.HasKey(e => e.TopicShowCaseId)
                    .HasName("PK__WCF_Topi__6BB841F43F47339B")
                    .IsClustered(false);

                entity.ToTable("WCF_Topic_ShowCase");

                entity.Property(e => e.CreatedByUserId)
                    .HasColumnName("CreatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId)
                    .HasColumnName("LastModifiedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidUntil).HasColumnType("datetime");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.WcfTopicShowCase)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCF_Topic_ShowCase_ProductId");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.WcfTopicShowCase)
                    .HasForeignKey(d => d.TopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WCF_Topic_ShowCase_CountryId");
            });

            modelBuilder.Entity<WcfWebUserAddress>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WCF_WebUser_Address");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.WebUserAddressId)
                    .HasColumnName("WebUser_AddressID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.WebUserId).HasColumnName("WebUserID");
            });

            modelBuilder.Entity<WcfWebUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WCF_WebUsers");

                entity.Property(e => e.CellularCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CellularNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Document)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAlternative)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FacebookId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GoogleId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebUserId)
                    .HasColumnName("WebUserID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WsSesiones>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WS_Sesiones");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.Idcompania).HasColumnName("IDCompania");

                entity.Property(e => e.Idioma)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Idsesion)
                    .IsRequired()
                    .HasColumnName("IDSesion")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<WsTokens>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WS_Tokens");

                entity.Property(e => e.CodigoCompania)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Idcompania).HasColumnName("IDCompania");

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}