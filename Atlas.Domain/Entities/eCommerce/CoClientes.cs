using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.eCommerce
{
    public partial class CoClientes
    {
        public CoClientes()
        {
            CoNominasEmpresas = new HashSet<CoNominasEmpresas>();
            CoVentaPacksOnline = new HashSet<CoVentaPacksOnline>();
            CoVentas = new HashSet<CoVentas>();
        }

        public int IdCliente { get; set; }
        public int IdTipoCliente { get; set; }
        public int? IdPersonaJuridica { get; set; }
        public int? IdPersona { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FecCreaReg { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FecModReg { get; set; }
        public int? IdClienteIndividual { get; set; }
        public int? IdEmpresa { get; set; }

        public virtual CoClientesIndividuales IdClienteIndividualNavigation { get; set; }
        public virtual CoEmpresas IdEmpresaNavigation { get; set; }
        public virtual PePersonaJuridica IdPersonaJuridicaNavigation { get; set; }
        public virtual PePersonaFisica IdPersonaNavigation { get; set; }
        public virtual CoTiposCliente IdTipoClienteNavigation { get; set; }
        public virtual ICollection<CoNominasEmpresas> CoNominasEmpresas { get; set; }
        public virtual ICollection<CoVentaPacksOnline> CoVentaPacksOnline { get; set; }
        public virtual ICollection<CoVentas> CoVentas { get; set; }
    }
}
