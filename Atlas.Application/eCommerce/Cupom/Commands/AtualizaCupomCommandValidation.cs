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
    public class AtualizaCupomCommandValidation : AbstractValidator<AtualizaCupomCommand>
    {
        private readonly IRuleEngineService ruleEngineService;
        private IeCommerceDbContextService _contextservice { get; }

        private string ErrorMessage = "Error";

        public AtualizaCupomCommandValidation(IeCommerceDbContextService contextservice, IRuleEngineService ruleEngineService)
        {
            _contextservice = contextservice;
            this.ruleEngineService = ruleEngineService;
            RuleFor(c => c.Ambiente)
                .Must(EnviromentValidator.ValidateEnviromentInitials).WithMessage(EnviromentValidator.EnviromentInitialsValidationErrorMessage);

            RuleFor(c => c.Cupom.CodigoCupon)
                .MinimumLength(6);
            
            RuleFor(c => c)
                .MustAsync(ValidateDuplicates).WithMessage("Este cupom já está ativo");

            RuleFor(c => c)
                .MustAsync(ValidateComission).WithMessage(ErrorMessage);
                
        }

        private async Task<bool> ValidateDuplicates(AtualizaCupomCommand cupom, CancellationToken cancellationToken)
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

        private async Task<bool> ValidateComission(AtualizaCupomCommand cupom, CancellationToken cancellationToken)
        {
            var result = await ruleEngineService.ValidateAgencyComission(cupom.CNPJ, cupom.Cupom.Bonificacion.ToString());
            if(!String.IsNullOrEmpty(result) )
            {
                ErrorMessage = result;
                return false;
            }
            return true;
        }

    }
}
