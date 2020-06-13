using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoAnticiposPublicidad
    {
        public int IdAnticipoPublicidad { get; set; }
        public int IdAgencia { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public int IdMoneda { get; set; }
        public double MontoTotalPublicidad { get; set; }
        public double MontoAdelantoCuentaCorriente { get; set; }
        public double PorcentajeTotalComision { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
    }
}
