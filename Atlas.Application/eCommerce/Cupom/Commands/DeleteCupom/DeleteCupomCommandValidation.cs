using Atlas.Application.Common.CustomValidators;
using Atlas.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.eCommerce.Cupom.Commands.DeleteCupom
{
    class DeleteCupomCommandValidation : AbstractValidator<DeleteCupomCommand>
    {
        private readonly IeCommerceDbContextService contextService;

        public DeleteCupomCommandValidation(IeCommerceDbContextService contextService)
        {
            this.contextService = contextService;

            RuleFor(c => c.Ambiente)
                .Must(EnviromentValidator.ValidateEnviromentInitials).WithMessage(EnviromentValidator.EnviromentInitialsValidationErrorMessage);

            RuleFor(c => c)
                .MustAsync(CupomExists).WithMessage("Cupom não existe");
        }

        public async Task<bool> CupomExists (DeleteCupomCommand request, CancellationToken cancellationToken)
        {
            var context = contextService.GetContextInitials(request.Ambiente);
            var prPromocionCupones = await context.PrPromocionCupones.FindAsync(request.Id);

            if (prPromocionCupones == null)
            {
                return false;
            }

            return true;
        }
    }
}
