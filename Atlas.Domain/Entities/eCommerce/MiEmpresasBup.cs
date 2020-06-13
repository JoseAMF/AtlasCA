using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class MiEmpresasBup
    {
        public MiEmpresasBup()
        {
            MiCorresponsalesBup = new HashSet<MiCorresponsalesBup>();
        }

        public int IdEmpresa { get; set; }
        public string Codigo { get; set; }
        public string Descrip { get; set; }
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string Cuit { get; set; }
        public int Orden { get; set; }

        public virtual ICollection<MiCorresponsalesBup> MiCorresponsalesBup { get; set; }
    }
}
