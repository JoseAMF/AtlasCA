using Atlas.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.CanaisVenda.Commands.UpdateCanalVenda
{
    public class UpdateCanalVendaCommandValidation : AbstractValidator<UpdateCanalVendaCommand>
    {
        private readonly IAtlasDbContext context;

        public UpdateCanalVendaCommandValidation(IAtlasDbContext _context)
        {
            context = _context;

            RuleFor(cv => cv.CanalVenda)
                .NotNull();

            RuleFor(cv => cv.CanalVenda.Descricao)
                .NotEmpty();

            RuleFor(cv => cv.CanalVenda.Id)
                .NotEmpty()
                .MustAsync(CanalVendaExistis).WithMessage("Canal de venda não existe.");
        }

        private async Task<bool> CanalVendaExistis(int? id, CancellationToken cancellationToken)
        {
            if (!id.HasValue) return false;
            return await context.Ouvidoria_CanaisVenda.FindAsync(id) == null ? false : true;
        }
    }

}
