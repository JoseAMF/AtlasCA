using Atlas.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Assuntos.Queries.GetAssunto
{
    public class GetAssuntoValidation : AbstractValidator<GetAssunto>
    {
        private readonly IAtlasDbContext context;

        public GetAssuntoValidation(IAtlasDbContext context)
        {
            this.context = context;

            RuleFor(a => a.Id)
                .NotEmpty()
                .NotNull()
                .MustAsync(AssuntoExist).WithMessage("Assunto não existe.");

        }

        private async Task<bool> AssuntoExist(int id, CancellationToken cancellationToken)
        {
           return await context.Ouvidoria_Assuntos.FindAsync(id, cancellationToken) == null ? false : true;
        }
    }
}
