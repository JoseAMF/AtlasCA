using Atlas.Application.Common.CustomValidators;
using FluentValidation;

namespace Atlas.Application.eCommerce.Cupom.Queries.ListCupom
{
    public class ListCupomQueryValidation : AbstractValidator<ListCupomQuery>
    {
        public ListCupomQueryValidation()
        {
            RuleFor( lc => lc.Ambiente)
                .Must(EnviromentValidator.ValidateEnviromentInitials).WithMessage(EnviromentValidator.EnviromentInitialsValidationErrorMessage);
        }
    }
}
