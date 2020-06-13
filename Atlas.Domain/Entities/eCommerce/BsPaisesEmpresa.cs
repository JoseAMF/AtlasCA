using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class BsPaisesEmpresa
    {
        public int IdPaisEmpresa { get; set; }
        public int? IdEmpresa { get; set; }
        public string IdPais { get; set; }
        public DateTime? FecCreaReg { get; set; }
    }
}
