using Atlas.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Assuntos.Commands.UpdateAssunto
{
    public class UpdateAssuntoCommandValidation  : AbstractValidator<UpdateAssuntoCommand>
    {
        private readonly IAtlasDbContext context;

        public UpdateAssuntoCommandValidation(IAtlasDbContext context)
        {
            this.context = context;

            RuleFor(a => a.Assunto)
                .NotNull();

            RuleFor(a => a.Assunto.Descricao)
                .NotEmpty();

            RuleFor(a => a.Assunto.Id)
                .NotEmpty()
                .MustAsync(AssuntoExist).WithMessage("Assunto não existe");
        }

        private async Task<bool> AssuntoExist(int? id, CancellationToken cancellationToken)
        {
            return await context.Ouvidoria_Assuntos.FindAsync(id) == null ? false : true;
        }
    }
}
