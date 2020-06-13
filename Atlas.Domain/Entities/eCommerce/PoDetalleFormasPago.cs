using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PoDetalleFormasPago
    {
        public int IdDetalleFormasPago { get; set; }
        public int IdPoliza { get; set; }
        public int? IdFormaPago { get; set; }
        public double? Importe { get; set; }
        public string NroCargo { get; set; }
        public string NroLote { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public DateTime? FecElimReg { get; set; }
        public string EliminadoPor { get; set; }
        public int? PagoOnlineErrorId { get; set; }
        public string PagoOnlineErrorDescrip { get; set; }
        public int? NumeroReciboCobranza { get; set; }
        public DateTime? FechaCobro { get; set; }
        public double? Cuotas { get; set; }
        public double? ImporteGrilla { get; set; }
        public double? ImporteConPromocion { get; set; }
        public double? MarkUp { get; set; }
        public double? ImporteConMarkUp { get; set; }
        public double? Interes { get; set; }
        public double? ImporteConInteres { get; set; }
        public string NumeroTarjeta { get; set; }
        public string VencimientoTarjeta { get; set; }
        public string TitularTarjeta { get; set; }
        public string BraspagTransactionId { get; set; }
        public string RequestId { get; set; }
        public string CodigoVersion { get; set; }

        public virtual PoFormasPago IdFormaPagoNavigation { get; set; }
        public virtual PoPolizas IdPolizaNavigation { get; set; }
    }
}
