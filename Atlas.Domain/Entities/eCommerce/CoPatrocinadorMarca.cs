using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoPatrocinadorMarca
    {
        public int IdPatrocinadorMarca { get; set; }
        public int IdPatrocinador { get; set; }
        public int IdMarca { get; set; }
        public DateTime FechaAcuerdo { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public string FileDocumento { get; set; }
        public string PatrocinadorAffinity { get; set; }
        public string FileLogo { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public DateTime? FechaBaja { get; set; }

        public virtual PrMarcasProductos IdMarcaNavigation { get; set; }
        public virtual CoPatrocinadores IdPatrocinadorNavigation { get; set; }
    }
}
