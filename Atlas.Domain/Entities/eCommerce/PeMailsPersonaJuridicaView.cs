using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class PeMailsPersonaJuridicaView
    {
        public int IdCanalesPersonaJuridica { get; set; }
        public int IdPersonaJuridica { get; set; }
        public int IdTipoCanal { get; set; }
        public string DetalleCanal { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
    }
}
