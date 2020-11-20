using Atlas.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Motivos.Queries.GetMotivo
{
    public class GetMotivoQueryValidation : AbstractValidator<GetMotivoQuery>
    {
        private readonly IAtlasDbContext context;

        public GetMotivoQueryValidation(IAtlasDbContext context)
        {
            this.context = context;

            RuleFor(m => m.Id)
                .NotEmpty()
                .MustAsync(MotivoExistis).WithMessage("Motivo não encontrado.");
        }

        private async Task<bool> MotivoExistis(int id, CancellationToken cancellationToken)
        {
            return await context.Ouvidoria_Motivos.FindAsync(id) == null ? false : true;
        }
    }
}
