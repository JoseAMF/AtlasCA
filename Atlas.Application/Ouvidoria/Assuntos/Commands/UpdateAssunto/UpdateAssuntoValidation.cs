using Atlas.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Assuntos.Commands.UpdateAssunto
{
    public class UpdateAssuntoValidation  : AbstractValidator<UpdateAssunto>
    {
        private readonly IAtlasDbContext context;

        public UpdateAssuntoValidation(IAtlasDbContext context)
        {
            this.context = context;

            RuleFor(a => a.Assunto)
                .NotNull();

            RuleFor(a => a.Assunto.Descricao)
                .NotEmpty();

            RuleFor(a => a.Assunto.IdAssunto)
                .NotEmpty()
                .MustAsync(AssuntoExist).WithMessage("Assunto não existe");
        }

        private async Task<bool> AssuntoExist(int id, CancellationToken cancellationToken)
        {
            return await context.Ouvidoria_Assuntos.FindAsync(id, cancellationToken) == null ? false : true;
        }
    }
}
