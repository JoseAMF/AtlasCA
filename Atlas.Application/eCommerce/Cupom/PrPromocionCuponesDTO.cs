using Atlas.Application.Common.Mappings;
using Atlas.Domain.Entities.eCommerce;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Application.eCommerce.Cupom
{
    public class PrPromocionCuponesDTO : IMapFrom<PrPromocionCupones>
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
        public bool? CuponDeAgencia { get; set; }
        public int? CouponTypeId { get; set; }
    }
}
