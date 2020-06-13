using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoPeriodicidadFacturacion
    {
        public CoPeriodicidadFacturacion()
        {
            CoAgenciasIdPeriodicidadFactuEfectivoNavigation = new HashSet<CoAgencias>();
            CoAgenciasIdPeriodicidadFactuTarjetaNavigation = new HashSet<CoAgencias>();
        }

        public int IdPeriodicidadFactu { get; set; }
        public string CodigoPeriodicidadFactu { get; set; }
        public string DescripcionPeriodicidadFactu { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }

        public virtual ICollection<CoAgencias> CoAgenciasIdPeriodicidadFactuEfectivoNavigation { get; set; }
        public virtual ICollection<CoAgencias> CoAgenciasIdPeriodicidadFactuTarjetaNavigation { get; set; }
    }
}
