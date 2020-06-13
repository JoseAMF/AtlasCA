using Atlas.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.eCommerce.CadastroDePessoa.Queries
{
    public class GetCadastroPessoaQuery : IRequest<PePersonaFisicaDTO>
    {
        public GetCadastroPessoaQuery(string nrVoucher)
        {
            NrVoucher = nrVoucher;
        }

        public string NrVoucher { get; }
    }

    public class GetCadastroPessoaQueryHandler : IRequestHandler<GetCadastroPessoaQuery, PePersonaFisicaDTO>
    {
        private readonly IeCommerceDbContextService contextService;
        private readonly IMapper mapper;

        public GetCadastroPessoaQueryHandler(IeCommerceDbContextService contextService, IMapper mapper)
        {
            this.contextService = contextService;
            this.mapper = mapper;
        }
        public async Task<PePersonaFisicaDTO> Handle(GetCadastroPessoaQuery request, CancellationToken cancellationToken)
        {
            var context = contextService.GetContextVoucher(request.NrVoucher);


            string proposta = request.NrVoucher.Substring(0, request.NrVoucher.Length - 2);

            int passageiro = int.Parse(request.NrVoucher.Substring(request.NrVoucher.Length - 2));

            int IdPoliza = await context.PoPolizas.Where(x => x.NumeroPoliza == proposta).Select(x => x.IdPoliza)
                                            .FirstOrDefaultAsync();

            int IdPersona = await context.PoBeneficiariosPoliza.Where(x => x.IdPoliza == IdPoliza && x.Secuencia == passageiro)
                                                         .Select(x => x.IdPersona)
                                                         .FirstOrDefaultAsync();

            var pessoa = await  context.PePersonaFisica.Where(x => x.IdPersona == IdPersona)
            .Include(x => x.PeDomiciliosPersona)
            .ThenInclude(x => x.IdDomicilioNavigation)
            .Include(x => x.PeDocumentosPersonaFisica)
            .FirstOrDefaultAsync();

            return mapper.Map<PePersonaFisicaDTO>(pessoa);
        }
    }
}
