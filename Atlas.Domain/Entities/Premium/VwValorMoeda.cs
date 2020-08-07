using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Premium
{
    public partial class VwValorMoeda
    {
        public string CdTipoMoeda { get; set; }
        public string DsTipoMoeda { get; set; }
        public DateTime DtBase { get; set; }
        public double? VlMoeda { get; set; }
        public string TpMoeda { get; set; }
    }
}
