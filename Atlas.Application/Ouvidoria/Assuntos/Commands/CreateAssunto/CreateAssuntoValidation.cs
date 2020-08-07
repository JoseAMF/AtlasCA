﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Application.Ouvidoria.Assuntos.Commands.CreateAssunto
{
    public class CreateAssuntoValidation  : AbstractValidator<CreateAssunto>
    {
        public CreateAssuntoValidation()
        {
            RuleFor(a => a.Assunto)
                .NotNull();
            RuleFor(a => a.Assunto.Descricao)
                .NotEmpty();
        }
    }
}
