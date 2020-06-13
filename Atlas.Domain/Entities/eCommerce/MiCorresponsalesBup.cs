using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class MiCorresponsalesBup
    {
        public int IdCorresponsal { get; set; }
        public string Codigo { get; set; }
        public string Descrip { get; set; }
        public int IdEmpresa { get; set; }
        public int IdPais { get; set; }
        public int DiferenciaHoraria { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public int? IdPersonaJuridica { get; set; }

        public virtual MiEmpresasBup IdEmpresaNavigation { get; set; }
        public virtual BsPaises IdPaisNavigation { get; set; }
    }
}
