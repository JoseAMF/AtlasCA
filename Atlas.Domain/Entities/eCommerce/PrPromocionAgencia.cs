﻿using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PrPromocionAgencia
    {
        public int IdPromocionAgencia { get; set; }
        public int IdTipoPromocion { get; set; }
        public int IdPromocion { get; set; }
        public int IdAgencia { get; set; }
        public int? IdProducto { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public double Bonificacion { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
    }
}
