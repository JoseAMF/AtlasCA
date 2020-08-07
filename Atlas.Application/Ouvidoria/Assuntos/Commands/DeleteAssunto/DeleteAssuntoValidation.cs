using Atlas.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Assuntos.Commands.DeleteAssunto
{
    public class DeleteAssuntoValidation  : AbstractValidator<DeleteAssunto>
    {
        private readonly IAtlasDbContext context;

        public DeleteAssuntoValidation(IAtlasDbContext context)
        {
            this.context = context;

            RuleFor(a => a.Id)
                .NotEmpty()
                .MustAsync(AssuntoExist).WithMessage("Assunto não encontrado");
        }

        private async Task<bool> AssuntoExist(int id, CancellationToken cancellationToken)
        {
            return await context.Ouvidoria_Assuntos.FindAsync(id, cancellationToken) == null ? false : true;
        }
    }
}
