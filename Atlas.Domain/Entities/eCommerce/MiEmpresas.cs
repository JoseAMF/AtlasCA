using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class MiEmpresas
    {
        public int IdEmpresa { get; set; }
        public int? IdPersonaJuridica { get; set; }
        public string Codigo { get; set; }
        public string CreadoPor { get; set; }
        public DateTime? FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
    }
}
