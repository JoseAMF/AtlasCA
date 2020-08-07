using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Application.Ouvidoria.Statuses.Commands.CreateStatus
{
    public class CreateStatusValidation  : AbstractValidator<CreateStatus>
    {
        public CreateStatusValidation()
        {
            RuleFor(s => s.Status)
                .NotNull();

            RuleFor(s => s.Status.Descricao)
                .NotEmpty();
        }
    }
}
