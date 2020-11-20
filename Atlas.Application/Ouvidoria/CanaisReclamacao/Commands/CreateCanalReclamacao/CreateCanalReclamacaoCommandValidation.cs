using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Application.Ouvidoria.Assuntos.Commands.CanaisReclamacao.Commands.CreateCanalReclamacao
{
    public class CreateCanalReclamacaoCommandValidation  : AbstractValidator<CreateCanalReclamacaoCommand>
    {
        public CreateCanalReclamacaoCommandValidation()
        {
            RuleFor(cr => cr.CanalReclamacao)
                .NotNull();

            RuleFor(cr => cr.CanalReclamacao.Descricao)
                .NotEmpty();
        }
    }
}
