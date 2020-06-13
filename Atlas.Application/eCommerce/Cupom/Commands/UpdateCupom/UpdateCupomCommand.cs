using Atlas.Application.Common.Interfaces;
using Atlas.Application.Common.Mappings;
using Atlas.Domain.Entities.eCommerce;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.eCommerce.Cupom.Commands
{
    public class CreateCupomCommand : IRequest
    {
        public string Ambiente { get; set; }
        public string CNPJ { get; set; }
        public PrPromocionCuponesDTO Cupom { get; set; }
    }

    public class AtualizaCupomCommandHandler : IRequestHandler<CreateCupomCommand>
    {
        private readonly IeCommerceDbContextService _contextService;
        private readonly IMapper _mapper;

        public AtualizaCupomCommandHandler(IeCommerceDbContextService context, IMapper mapper)
        {
            _contextService = context;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CreateCupomCommand request, CancellationToken cancellationToken)
        {
            var context = _contextService.GetContextInitials(request.Ambiente);

            context.PrPromocionCupones.Update(_mapper.Map<PrPromocionCuponesDTO, PrPromocionCupones>(request.Cupom));
            await context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
