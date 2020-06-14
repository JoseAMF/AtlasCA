using Atlas.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.eCommerce.ComissaoAgencia.Queries
{
   public class ListAgencyComissionQuery : IRequest<List<AgenciaDTO>>
    {
        public ListAgencyComissionQuery(string ambiente, string id)
        {
            Ambiente = ambiente;
            Id = id;
        }

        public string Ambiente { get; }
        public string Id { get; }
    }
    public class GetAgencyCommisionQueryHandler : IRequestHandler<ListAgencyComissionQuery, List<AgenciaDTO>>
    {
        private readonly IeCommerceDbContextService contextService;

        public GetAgencyCommisionQueryHandler(IeCommerceDbContextService contextService)
        {
            this.contextService = contextService;
        }
        public async Task<List<AgenciaDTO>> Handle(ListAgencyComissionQuery request, CancellationToken cancellationToken)
        {
            var context = contextService.GetContextVoucher(request.Ambiente);
            var isName = false;

            foreach (char c in request.Id)
            {
                if (Char.IsLetter(c))
                {
                    isName = true;
                    break;
                }
            }

            if (isName)
            {
                var pePersonaJuridica = await context.PePersonaJuridica.Where(x => x.RazonSocial.Contains(request.Id) || x.NombreFantasia.Contains(request.Id))
                    .ToListAsync(cancellationToken);

                List<AgenciaDTO> retorno = new List<AgenciaDTO>();

                foreach (var item in pePersonaJuridica)
                {
                    var aux = new AgenciaDTO();

                    aux.NomeFantasia = item.NombreFantasia;
                    aux.RazaoSocial = item.RazonSocial;
                    aux.CNPJ = context.PeDocumentosPersonaJuridica.Where(x => x.IdPersona == item.IdPersonaJuridica && x.IdTipoDocumento == 8)
                               .Select(x => x.Numero).FirstOrDefault();
                    aux.IdAgencia = context.CoAgencias.Where(x => x.IdPersonaJuridica == item.IdPersonaJuridica).Select(x => x.IdAgencia).FirstOrDefault();
                    aux.Comissao = context.CoComisionesAgencias.Where(x => x.IdAgencia == aux.IdAgencia && x.FechaBaja == null).Select(x => x.Comision).FirstOrDefault();
                    retorno.Add(aux);
                }

                return retorno;
            }
            else
            {
                var peDocumentosPersonaJuridica = context.PeDocumentosPersonaJuridica.Where(x => x.IdTipoDocumento == 8 &&
              x.Numero.Replace("/", "").Replace(".", "").Replace("-", "").Replace(" ", "").Equals(request.Id)).FirstOrDefault();

                var pePersonaJuridica = context.PePersonaJuridica.Where(x => x.IdPersonaJuridica == peDocumentosPersonaJuridica.IdPersona).FirstOrDefault();

                var coAgencias = context.CoAgencias.Where(x => x.IdPersonaJuridica == pePersonaJuridica.IdPersonaJuridica).FirstOrDefault();

                var Comissao = context.CoComisionesAgencias.Where(x => x.IdAgencia == coAgencias.IdAgencia && x.FechaBaja == null).FirstOrDefault();

                var retorno = new List<AgenciaDTO>();

                var aux = new AgenciaDTO();
                aux.NomeFantasia = pePersonaJuridica.NombreFantasia;
                aux.RazaoSocial = pePersonaJuridica.RazonSocial;
                aux.CNPJ = context.PeDocumentosPersonaJuridica.Where(x => x.IdPersona == pePersonaJuridica.IdPersonaJuridica && x.IdTipoDocumento == 8)
                                   .Select(x => x.Numero).FirstOrDefault();
                aux.IdAgencia = coAgencias.IdAgencia;
                aux.Comissao = context.CoComisionesAgencias.Where(x => x.IdAgencia == aux.IdAgencia).Select(x => x.Comision).FirstOrDefault();

                retorno.Add(aux);
                return retorno;

            }
        }
    }
}
