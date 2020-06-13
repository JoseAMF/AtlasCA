using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class AmivPoPolizas
    {
        public int IdPoliza { get; set; }
        public string NumeroPoliza { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public int? DiasCobertura { get; set; }
        public int IdProducto { get; set; }
        public string Producto { get; set; }
        public int? Diasproductoanual { get; set; }
        public double? ImporteTotal { get; set; }
        public string AgenciaVendedor { get; set; }
        public string Agencia { get; set; }
        public int? IdVendedor { get; set; }
        public string ApeVendedor { get; set; }
        public string NombreVendedor { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public int? IdAgencia { get; set; }
        public string DenominacionAgencia { get; set; }
        public string Titular { get; set; }
        public string Tipodoc { get; set; }
        public string Nrodocumento { get; set; }
        public DateTime? Fechaanulacion { get; set; }
        public string Nrocargo { get; set; }
        public int? Numerorecibocobranza { get; set; }
        public int? Idformapago { get; set; }
        public string DenominacionPais { get; set; }
    }
}
