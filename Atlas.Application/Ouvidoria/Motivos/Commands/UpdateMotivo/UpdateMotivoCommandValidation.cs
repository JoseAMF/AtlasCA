using Atlas.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Motivos.Commands.UpdateMotivo
{
    public class UpdateMotivoCommandValidation : AbstractValidator<UpdateMotivoCommand>
    {
        private readonly IAtlasDbContext context;

        public UpdateMotivoCommandValidation(IAtlasDbContext context)
        {
            this.context = context;

            RuleFor(m => m.Motivo)
                .NotNull();

            RuleFor(m => m.Motivo.Descricao)
                .NotEmpty();

            RuleFor(m => m.Motivo.IdMotivo)
                .NotEmpty()
                .MustAsync(MotivoExistis).WithMessage("Motivo não encontrado.");
        }

        private async Task<bool> MotivoExistis(int id, CancellationToken cancellationToken)
        {
            return await context.Ouvidoria_Motivos.FindAsync(id, cancellationToken) == null ? false : true;
        }
    }
}
