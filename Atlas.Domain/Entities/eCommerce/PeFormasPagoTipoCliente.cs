using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PeFormasPagoTipoCliente
    {
        public int IdFormasPagoTipoPersona { get; set; }
        public int IdTipoCliente { get; set; }
        public int IdFormaPagoBs { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual PoFormasPago IdFormaPagoBsNavigation { get; set; }
        public virtual CoTiposCliente IdTipoClienteNavigation { get; set; }
    }
}
