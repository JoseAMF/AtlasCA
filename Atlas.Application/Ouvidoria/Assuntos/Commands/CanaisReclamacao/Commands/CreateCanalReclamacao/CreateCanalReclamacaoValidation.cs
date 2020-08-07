using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Application.Ouvidoria.Assuntos.Commands.CanaisReclamacao.Commands.CreateCanalReclamacao
{
    public class CreateCanalReclamacaoValidation  : AbstractValidator<CreateCanalReclamacao>
    {
        public CreateCanalReclamacaoValidation()
        {
            RuleFor(cr => cr.CanalReclamacao)
                .NotNull();

            RuleFor(cr => cr.CanalReclamacao.Descricao)
                .NotEmpty();
        }
    }
}
