using Atlas.Application.Common.CustomValidators;
using FluentValidation;

namespace Atlas.Application.eCommerce.Cupom.Queries.GetCupom
{
    public class GetCupomQueryValidation : AbstractValidator<GetCupomQuery>
    {
        public GetCupomQueryValidation()
        {
            RuleFor(c => c.Ambiente)
                .Must(EnviromentValidator.ValidateEnviromentInitials).WithMessage(EnviromentValidator.EnviromentInitialsValidationErrorMessage);

            RuleFor(c => c.Id)
                .NotEmpty();
        }
    }
}
