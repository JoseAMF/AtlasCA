using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.eCommerce;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.eCommerce.Cupom.Commands.CreateCupom
{
    public class CreateCupomCommand : IRequest<int>
    {
        public string Ambiente { get; set; }
        public string CNPJ { get; set; }
        public PrPromocionCuponesDTO Cupom { get; set; }

    }

    public class CreateCupomCommandHandler : IRequestHandler<CreateCupomCommand, int>
    {
        private readonly IeCommerceDbContextService _contextService;
        private readonly IMapper _mapper;

        public CreateCupomCommandHandler(IeCommerceDbContextService context, IMapper mapper)
        {
            _contextService = context;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateCupomCommand request, CancellationToken cancellationToken)
        {
            var context = _contextService.GetContextInitials(request.Ambiente);
            var cupom = _mapper.Map<PrPromocionCupones>(request.Cupom);
            context.PrPromocionCupones.Add(cupom);
            await context.SaveChangesAsync(cancellationToken);

            return cupom.IdCuponesPromocion;
        }
    }
}
