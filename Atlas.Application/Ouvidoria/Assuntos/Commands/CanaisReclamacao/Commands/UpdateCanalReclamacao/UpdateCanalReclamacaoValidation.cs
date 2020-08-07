using Atlas.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Assuntos.Commands.CanaisReclamacao.Commands.UpdateCanalReclamacao
{
    public class UpdateCanalReclamacaoValidation  : AbstractValidator<UpdateCanalReclamacao>
    {
        private readonly IAtlasDbContext context;

        public UpdateCanalReclamacaoValidation(IAtlasDbContext context)
        {
            this.context = context;

            RuleFor(cr => cr.CanalReclamacao)
                .NotNull();

            RuleFor(cr => cr.CanalReclamacao.Descricao)
                .NotEmpty();

            RuleFor(cr => cr.CanalReclamacao.IdCanalReclamacao)
                .NotEmpty()
                .MustAsync(CanalReclamacaoExist).WithMessage("Canal de reclamação não existe");
        }

        private async Task<bool> CanalReclamacaoExist(int id, CancellationToken cancellationToken)
        {
            return await context.Ouvidoria_CanaisReclamacoes.FindAsync(id, cancellationToken) == null ? false : true;
        }
    }
}
