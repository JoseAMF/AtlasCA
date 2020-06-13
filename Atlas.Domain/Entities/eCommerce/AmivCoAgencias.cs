using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class AmivCoAgencias
    {
        public int IdAgencia { get; set; }
        public int? IdPersonaJuridica { get; set; }
        public string DenominacionAgencia { get; set; }
        public string Cuit { get; set; }
        public int? Idresponsableiva { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string DisponePagoOnline { get; set; }
        public string EmiteVoucherEnEmision { get; set; }
        public int? IdEjecutivo { get; set; }
        public string ApellidoNombreEjecutivo { get; set; }
        public string DocumentoPersonaFisica { get; set; }
        public string DocumentoPersonaJuridica { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string CodigoSusep { get; set; }
    }
}
