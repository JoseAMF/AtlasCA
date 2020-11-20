using Atlas.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Premium.Proposta.Commands.DeleteProposta
{
    public class DeletePropostaValidation : AbstractValidator<DeleteProposta>
    {
        private readonly IPremiumDbContext context;

        public DeletePropostaValidation(IPremiumDbContext context)
        {
            this.context = context;

            RuleFor(p => p.Id)
                .NotEmpty()
                .MustAsync(PropostaExist).WithMessage("Proposta não encontrada.");
        }

        private async Task<bool> PropostaExist(string id, CancellationToken cancellationToken)
        {
            return await context.TbProposta.FindAsync(id) == null ? false : true;
        }
    }
}
