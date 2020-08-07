using Atlas.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.CanaisVenda.Commands.UpdateCanalVenda
{
    public class UpdateCanalVendaValidation : AbstractValidator<UpdateCanalVenda>
    {
        private readonly IAtlasDbContext context;

        public UpdateCanalVendaValidation(IAtlasDbContext _context)
        {
            context = _context;

            RuleFor(cv => cv.CanalVenda)
                .NotNull();

            RuleFor(cv => cv.CanalVenda.Descricao)
                .NotEmpty();

            RuleFor(cv => cv.CanalVenda.IdCanalVenda)
                .NotEmpty()
                .MustAsync(CanalVendaExistis).WithMessage("Canal de venda não existe.");
        }

        private async Task<bool> CanalVendaExistis(int id, CancellationToken cancellationToken)
        {
            return await context.Ouvidoria_CanaisVenda.FindAsync(id, cancellationToken) == null ? false : true;
        }
    }

}
