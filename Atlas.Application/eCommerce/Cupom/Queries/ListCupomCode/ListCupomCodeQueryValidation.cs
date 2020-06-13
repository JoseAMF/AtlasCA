using Atlas.Application.Common.CustomValidators;
using FluentValidation;

namespace Atlas.Application.eCommerce.Cupom.Queries.GetCupomCode
{
    public class GetCupomQueryValidation : AbstractValidator<ListCupomCodeQuery>
    {
        public GetCupomQueryValidation()
        {
            RuleFor(c => c.Ambiente)
                .Must(EnviromentValidator.ValidateEnviromentInitials).WithMessage(EnviromentValidator.EnviromentInitialsValidationErrorMessage);
        }
    }
}
