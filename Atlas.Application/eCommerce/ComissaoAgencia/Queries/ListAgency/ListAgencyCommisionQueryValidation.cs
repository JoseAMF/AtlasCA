using Atlas.Application.Common.CustomValidators;
using Atlas.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Application.eCommerce.ComissaoAgencia.Queries.ListAgency
{
   public class ListAgencyCommisionQueryValidation : AbstractValidator<ListAgencyComissionQuery>
    {
        private readonly IeCommerceDbContextService contextService;

        public ListAgencyCommisionQueryValidation(IeCommerceDbContextService contextService)
        {
            this.contextService = contextService;
            RuleFor(a => a.Ambiente)
            .NotEmpty()
            .Must(EnviromentValidator.ValidateEnviromentInitials).WithMessage(EnviromentValidator.EnviromentInitialsValidationErrorMessage);
            
            
        }

      
    }
}
