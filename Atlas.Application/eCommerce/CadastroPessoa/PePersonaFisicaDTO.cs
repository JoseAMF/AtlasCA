using Atlas.Domain.Entities.eCommerce;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Application.eCommerce.CadastroDePessoa
{
    public class PePersonaFisicaDTO
    {
        public PePersonaFisicaDTO()
        {
            CoClientes = new HashSet<CoClientes>();
            CoClientesIndividuales = new HashSet<CoClientesIndividuales>();
            CoComposicionGrupoClienteIndividual = new HashSet<CoComposicionGrupoClienteIndividual>();
            CoConsumosVentas = new HashSet<CoConsumosVentas>();
            CoEjecutivos = new HashSet<CoEjecutivos>();
            CoNominasEmpresas = new HashSet<CoNominasEmpresas>();
            CoVendedoresAgencias = new HashSet<CoVendedoresAgencias>();
            PeAlteracaoPessoaFisica = new HashSet<PeAlteracaoPessoaFisica>();
            PeCanalesPersona = new HashSet<PeCanalesPersona>();
            PeDocumentosPersonaFisica = new HashSet<PeDocumentosPersonaFisica>();
            PeDomiciliosPersona = new HashSet<PeDomiciliosPersona>();
            PoBeneficiariosPoliza = new HashSet<PoBeneficiariosPoliza>();
        }

        public int IdPersona { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int IdPaisResidencia { get; set; }
        public string Sexo { get; set; }
        public int? IdResponsableIva { get; set; }

        public virtual BsPaises IdPaisResidenciaNavigation { get; set; }
        public virtual ICollection<CoClientes> CoClientes { get; set; }
        public virtual ICollection<CoClientesIndividuales> CoClientesIndividuales { get; set; }
        public virtual ICollection<CoComposicionGrupoClienteIndividual> CoComposicionGrupoClienteIndividual { get; set; }
        public virtual ICollection<CoConsumosVentas> CoConsumosVentas { get; set; }
        public virtual ICollection<CoEjecutivos> CoEjecutivos { get; set; }
        public virtual ICollection<CoNominasEmpresas> CoNominasEmpresas { get; set; }
        public virtual ICollection<CoVendedoresAgencias> CoVendedoresAgencias { get; set; }
        public virtual ICollection<PeAlteracaoPessoaFisica> PeAlteracaoPessoaFisica { get; set; }
        public virtual ICollection<PeCanalesPersona> PeCanalesPersona { get; set; }
        public virtual ICollection<PeDocumentosPersonaFisica> PeDocumentosPersonaFisica { get; set; }
        public virtual ICollection<PeDomiciliosPersona> PeDomiciliosPersona { get; set; }
        public virtual ICollection<PoBeneficiariosPoliza> PoBeneficiariosPoliza { get; set; }
    }
}
