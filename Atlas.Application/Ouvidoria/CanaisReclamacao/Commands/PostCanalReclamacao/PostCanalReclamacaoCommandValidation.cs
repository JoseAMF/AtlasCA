using Atlas.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.CanaisReclamacao.Commands.PostCanalReclamacao
{
    public class PostCanalReclamacaoCommandValidation  : AbstractValidator<PostCanalReclamacaoCommand>
    {
        private readonly IAtlasDbContext context;

        public PostCanalReclamacaoCommandValidation(IAtlasDbContext context)
        {
            this.context = context;

            RuleFor(cr => cr.CanalReclamacao)
                .NotNull();

            RuleFor(cr => cr.CanalReclamacao.Descricao)
                .NotEmpty();

            RuleFor(cr => cr.CanalReclamacao.Id)
                .Empty();
        }

    }
}
