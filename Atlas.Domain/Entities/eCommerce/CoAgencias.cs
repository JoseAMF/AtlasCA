using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoAgencias
    {
        public CoAgencias()
        {
            CoAgenciaCanalDistribucion = new HashSet<CoAgenciaCanalDistribucion>();
            CoAgenciasBudget = new HashSet<CoAgenciasBudget>();
            CoAgenciasCobranza = new HashSet<CoAgenciasCobranza>();
            CoAgenciasEjecutivo = new HashSet<CoAgenciasEjecutivo>();
            CoAgenciasEjecutivoResponsable = new HashSet<CoAgenciasEjecutivoResponsable>();
            CoAgenciasRepresentante = new HashSet<CoAgenciasRepresentante>();
            CoComisionesAgencias = new HashSet<CoComisionesAgencias>();
            CoCotizacionesIndividuosLog = new HashSet<CoCotizacionesIndividuosLog>();
            CoFormasPagoAgencias = new HashSet<CoFormasPagoAgencias>();
            CoSellerIdcanalesVentas = new HashSet<CoSellerIdcanalesVentas>();
            CoVendedoresAgencias = new HashSet<CoVendedoresAgencias>();
            PeAlteracaoPessoaFisica = new HashSet<PeAlteracaoPessoaFisica>();
            PeAutorizacaoAlteracao = new HashSet<PeAutorizacaoAlteracao>();
            PrAgenciasHabilitadasPromocion = new HashSet<PrAgenciasHabilitadasPromocion>();
            PrAgenciasPromocion = new HashSet<PrAgenciasPromocion>();
            PrProductoPrecio = new HashSet<PrProductoPrecio>();
        }

        public int IdAgencia { get; set; }
        public int? IdPersonaJuridica { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public int UserId { get; set; }
        public int? IdSupervisor { get; set; }
        public string EmiteVoucherEnEmision { get; set; }
        public string DispPagoOnline { get; set; }
        public string DisponePagoOnline { get; set; }
        public int? IdPeriodicidadFactuEfectivo { get; set; }
        public int? IdPeriodicidadFactuTarjeta { get; set; }
        public string CobranzaAutomatica { get; set; }
        public int? FacturacionPuntual { get; set; }
        public int? IdCompania { get; set; }
        public string CobranzaAutomaticaTc { get; set; }
        public string UrlPagoOnline { get; set; }
        public string Mayorista { get; set; }
        public string RequiereAceptacionCondiciones { get; set; }
        public string PathLogo { get; set; }
        public byte? MarkUp { get; set; }
        public byte? ModificaMarkUp { get; set; }
        public double? MinimoMarkUp { get; set; }
        public string MarcaCtaCteIndividual { get; set; }
        public bool? ShowLogoOmint { get; set; }
        public string MarcaAgenciaSupervisora { get; set; }
        public string RequiereMailTitular { get; set; }
        public bool? MuestraCondicionesGenerales { get; set; }
        public double? MaximoMarkUp { get; set; }
        public bool? MuestraLogoAgencia { get; set; }
        public int? IdPersonaFisica { get; set; }
        public string TipoPersona { get; set; }
        public int? IdTipoCalculoImporte { get; set; }
        public int? IdSegmentosAgencias { get; set; }
        public string Leyenda { get; set; }
        public string LeyendaIngles { get; set; }
        public string CodigoSusep { get; set; }
        public string IdentificarVenda { get; set; }
        public bool? EnviaMensaje { get; set; }

        public virtual CoPeriodicidadFacturacion IdPeriodicidadFactuEfectivoNavigation { get; set; }
        public virtual CoPeriodicidadFacturacion IdPeriodicidadFactuTarjetaNavigation { get; set; }
        public virtual PePersonaJuridica IdPersonaJuridicaNavigation { get; set; }
        public virtual ICollection<CoAgenciaCanalDistribucion> CoAgenciaCanalDistribucion { get; set; }
        public virtual ICollection<CoAgenciasBudget> CoAgenciasBudget { get; set; }
        public virtual ICollection<CoAgenciasCobranza> CoAgenciasCobranza { get; set; }
        public virtual ICollection<CoAgenciasEjecutivo> CoAgenciasEjecutivo { get; set; }
        public virtual ICollection<CoAgenciasEjecutivoResponsable> CoAgenciasEjecutivoResponsable { get; set; }
        public virtual ICollection<CoAgenciasRepresentante> CoAgenciasRepresentante { get; set; }
        public virtual ICollection<CoComisionesAgencias> CoComisionesAgencias { get; set; }
        public virtual ICollection<CoCotizacionesIndividuosLog> CoCotizacionesIndividuosLog { get; set; }
        public virtual ICollection<CoFormasPagoAgencias> CoFormasPagoAgencias { get; set; }
        public virtual ICollection<CoSellerIdcanalesVentas> CoSellerIdcanalesVentas { get; set; }
        public virtual ICollection<CoVendedoresAgencias> CoVendedoresAgencias { get; set; }
        public virtual ICollection<PeAlteracaoPessoaFisica> PeAlteracaoPessoaFisica { get; set; }
        public virtual ICollection<PeAutorizacaoAlteracao> PeAutorizacaoAlteracao { get; set; }
        public virtual ICollection<PrAgenciasHabilitadasPromocion> PrAgenciasHabilitadasPromocion { get; set; }
        public virtual ICollection<PrAgenciasPromocion> PrAgenciasPromocion { get; set; }
        public virtual ICollection<PrProductoPrecio> PrProductoPrecio { get; set; }
    }
}
