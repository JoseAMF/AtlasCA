using Atlas.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.eCommerce.Cupom.Commands.DeleteCupom
{
    public class DeleteCupomCommand : IRequest
    {
        public DeleteCupomCommand(string ambiente, string id)
        {
            Ambiente = ambiente;
            Id = id;
        }

        public string Ambiente { get; }
        public string Id { get; }
    }

    public class DeleteCupoomCommandHandler : IRequestHandler<DeleteCupomCommand>
    {
        private readonly IeCommerceDbContextService contextService;

        public DeleteCupoomCommandHandler(IeCommerceDbContextService contextService)
        {
            this.contextService = contextService;
        }
        public async Task<Unit> Handle(DeleteCupomCommand request, CancellationToken cancellationToken)
        {
            var context = contextService.GetContextInitials(request.Ambiente);
            var prPromocionCupones = await context.PrPromocionCupones.FindAsync(request.Id);

            context.PrPromocionCupones.Remove(prPromocionCupones);
            await context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
