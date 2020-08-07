using Atlas.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Motivos.Queries.GetMotivo
{
    public class GetMotivoValidation : AbstractValidator<GetMotivo>
    {
        private readonly IAtlasDbContext context;

        public GetMotivoValidation(IAtlasDbContext context)
        {
            this.context = context;

            RuleFor(m => m.Id)
                .NotEmpty()
                .MustAsync(MotivoExistis).WithMessage("Motivo não encontrado.");
        }

        private async Task<bool> MotivoExistis(int id, CancellationToken cancellationToken)
        {
            return await context.Ouvidoria_Motivos.FindAsync(id, cancellationToken) == null ? false : true;
        }
    }
}
