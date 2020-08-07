using Atlas.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Motivos.Commands.DeleteMotivo
{
    public class DeleteMotivoCommandValidation : AbstractValidator<DeleteMotivoCommand>
    {
        private readonly IAtlasDbContext _context;
        public DeleteMotivoCommandValidation(IAtlasDbContext context)
        {
            _context = context;
            
            RuleFor(m => m.Id)
                .NotEmpty()
                .MustAsync(MotivoExistis).WithMessage("Motivo não existel");
        }

        private async Task<bool> MotivoExistis(int id, CancellationToken cancellationToken)
        {
            return await _context.Ouvidoria_Motivos.FindAsync(id, cancellationToken) == null ? false : true;
        }
    }
}
