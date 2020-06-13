using System;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrPromocionCupones
    {
        public int IdCuponesPromocion { get; set; }
        public int IdTipoPromocion { get; set; }
        public int IdPromocion { get; set; }
        public string CodigoCupon { get; set; }
        public int IdCanalPublicacionCupon { get; set; }
        public int? IdGrupoAfinidad { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public double Bonificacion { get; set; }
        public int CuponesPorPersona { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public bool? CuponDeAgencia { get; set; }
        public int? CouponTypeId { get; set; }

        public virtual PrCanalesPublicacionCupones IdCanalPublicacionCuponNavigation { get; set; }
        public virtual PrGruposAfinidad IdGrupoAfinidadNavigation { get; set; }
        public virtual PrPromociones IdPromocionNavigation { get; set; }
        public virtual PrTiposPromocion IdTipoPromocionNavigation { get; set; }
      
    }
}
