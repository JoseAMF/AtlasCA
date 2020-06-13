using Atlas.Application.Common.CustomValidators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Application.eCommerce.CadastroDePessoa.Queries
{
    class GetCadastroPessoaQueryValidation : AbstractValidator<GetCadastroPessoaQuery>
    {
        public GetCadastroPessoaQueryValidation()
        {
            RuleFor(c => c.NrVoucher)
                .MinimumLength(12)
                .NotEmpty()
                .Must(EnviromentValidator.ValidateVoucherNumber).WithMessage(EnviromentValidator.VoucherNumberValidationErrorMessage);
        }
    }
}
