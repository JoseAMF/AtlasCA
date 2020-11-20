using Atlas.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Assuntos.Commands.CanaisReclamacao.Commands.DeleteCanalReclamacao
{
    public class DeleteCanalReclamacaoCommandValidation  : AbstractValidator<DeleteCanalReclamacaoCommand>
    {
        private readonly IAtlasDbContext context;

        public DeleteCanalReclamacaoCommandValidation(IAtlasDbContext context)
        {
            this.context = context;

            RuleFor(cr => cr.Id)
                .NotEmpty();

            RuleFor(cr => cr.Id)
                .NotEmpty()
                .MustAsync(CanalReclamacaoExist).WithMessage("Canal de reclamação não existe");
        }

        private async Task<bool> CanalReclamacaoExist(int id, CancellationToken cancellationToken)
        {
            return await context.Ouvidoria_CanaisReclamacoes.FindAsync(id) == null ? false : true;
        }
    }
}
