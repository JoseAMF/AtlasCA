using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoClientesIndividuales
    {
        public CoClientesIndividuales()
        {
            CoClientes = new HashSet<CoClientes>();
            CoComposicionGrupoClienteIndividual = new HashSet<CoComposicionGrupoClienteIndividual>();
        }

        public int IdClienteIndividual { get; set; }
        public int IdPersona { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int? IdFormaPago { get; set; }
        public string NumeroTarjeta { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string CodigoVerificador { get; set; }
        public bool MarcaGrupo { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public int IdCompania { get; set; }

        public virtual PoFormasPago IdFormaPagoNavigation { get; set; }
        public virtual PePersonaFisica IdPersonaNavigation { get; set; }
        public virtual ICollection<CoClientes> CoClientes { get; set; }
        public virtual ICollection<CoComposicionGrupoClienteIndividual> CoComposicionGrupoClienteIndividual { get; set; }
    }
}
