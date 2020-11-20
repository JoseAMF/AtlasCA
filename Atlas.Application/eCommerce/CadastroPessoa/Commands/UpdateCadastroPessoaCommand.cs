using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.eCommerce;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.eCommerce.CadastroDePessoa.Commands
{
    public class UpdateCadastroPessoaCommand : IRequest
    {
        public string NrVoucher { get; }
        public PePersonaFisicaDTO Person { get; set; }
    }

    public class UpdateCadastroPessoaCommandHandler : IRequestHandler<UpdateCadastroPessoaCommand>
    {
        private readonly IeCommerceDbContextService contextService;
        private readonly IMapper mapper;

        public UpdateCadastroPessoaCommandHandler(IeCommerceDbContextService contextService, IMapper mapper)
        {
            this.contextService = contextService;
            this.mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateCadastroPessoaCommand request, CancellationToken cancellationToken)
        {
            var context = contextService.GetContextVoucher(request.NrVoucher);
            string proposta = request.NrVoucher.Substring(0, request.NrVoucher.Length - 2);

            int IdPoliza = context.PoPolizas.Where(x => x.NumeroPoliza == proposta).Select(x => x.IdPoliza).FirstOrDefault();

            int IdPersona = context.PoBeneficiariosPoliza.Where(x => x.IdPoliza == IdPoliza).Select(x => x.IdPersona).FirstOrDefault();

            //ToDo Massive work 
            if (request.Person.PeDocumentosPersonaFisica.Any())
            {
                var peDocumentosPersonaFisica = await context.PeDocumentosPersonaFisica.Where(p => p.IdPersona == request.Person.IdPersona).FirstOrDefaultAsync();
                    mapper.Map<PeDocumentosPersonaFisica, PeDocumentosPersonaFisica>(request.Person.PeDocumentosPersonaFisica.ToArray()[0], peDocumentosPersonaFisica);
            }
            //if (request.Person.PeDomiciliosPersona.Any())
            //{
            //    var peDocumentosPersonaFisica = await context.PeDocumentosPersonaFisica.Where(p => p.IdPersona == request.Person.IdPersona).FirstOrDefaultAsync();
            //    context.PeDomiciliosPersona.UpdateRange(pePersonaFisica.PeDomiciliosPersona.ToArray());

            //}

            await context.SaveChangesAsync(cancellationToken);

            return Unit.Value;  
        }
    }
}
