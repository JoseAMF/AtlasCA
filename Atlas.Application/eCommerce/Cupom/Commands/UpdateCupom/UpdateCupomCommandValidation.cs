using Atlas.Application.Common.CustomValidators;
using Atlas.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.eCommerce.Cupom.Commands
{
    public class UpdateCupomCommandValidation : AbstractValidator<CreateCupomCommand>
    {
        private readonly IRuleEngineService ruleEngineService;
        private IeCommerceDbContextService _contextservice { get; }

        private string ErrorMessage = "Error";

        public UpdateCupomCommandValidation(IeCommerceDbContextService contextservice, IRuleEngineService ruleEngineService)
        {
            _contextservice = contextservice;
            this.ruleEngineService = ruleEngineService;
            RuleFor(c => c.Ambiente)
                .Must(EnviromentValidator.ValidateEnviromentInitials).WithMessage(EnviromentValidator.EnviromentInitialsValidationErrorMessage);

            RuleFor(c => c.Cupom.CodigoCupon)
                .MinimumLength(6);

            RuleFor(c => c.Cupom.CouponTypeId)
                .NotEmpty();

            RuleFor(c => c.Cupom.Bonificacion)
                .NotEmpty();

            RuleFor(c => c.Cupom.FechaInicioVigencia)
                .NotEmpty();

            RuleFor(c => c)
                .MustAsync(ValidateDuplicates).WithMessage("Este cupom já está ativo");

            RuleFor(c => c)
                .MustAsync(ValidateComission).WithMessage(ErrorMessage);
                
        }

        private async Task<bool> ValidateDuplicates(CreateCupomCommand cupom, CancellationToken cancellationToken)
        {
            var context = _contextservice.GetContextInitials(cupom.Ambiente);

            var cuponsRepetidos =  await context.PrPromocionCupones
                .Where(x => x.CodigoCupon == cupom.Cupom.CodigoCupon 
                && x.IdCuponesPromocion != cupom.Cupom.IdCuponesPromocion).ToListAsync();

            foreach (var cupomRepetido in cuponsRepetidos)
            {
                if (cupom.Cupom.FechaInicioVigencia >= cupomRepetido.FechaInicioVigencia &&
                    cupom.Cupom.FechaInicioVigencia < cupomRepetido.FechaFinVigencia)
                    return false;
            }
            return true;
        }

        private async Task<bool> ValidateComission(CreateCupomCommand cupom, CancellationToken cancellationToken)
        {
            if (cupom.Cupom.CouponTypeId == 2)
            {
                var result = await ruleEngineService.ValidateAgencyComission(cupom.CNPJ, cupom.Cupom.Bonificacion.ToString());
                if (!String.IsNullOrEmpty(result))
                {
                    ErrorMessage = result;
                    return false;
                }
            }
            else
            {
                if (cupom.Cupom.Bonificacion > 60)
                {
                    ErrorMessage = "Desconto em prêmio não pode ser superior a 60% para esta modalidade.";
                    return false;
                }
            }

            return true;
        }

    }
}
