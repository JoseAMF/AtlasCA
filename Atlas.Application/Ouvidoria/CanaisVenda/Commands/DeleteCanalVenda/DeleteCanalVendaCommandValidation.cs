using Atlas.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.CanaisVenda.Commands.DeleteCanalVenda
{
    public class DeleteCanalVendaCommandValidation : AbstractValidator<DeleteCanalVendaCommand>
    {
        private readonly IAtlasDbContext context;

        public DeleteCanalVendaCommandValidation(IAtlasDbContext _context)
        {
            context = _context;

            RuleFor(cv => cv.Id)
                .NotEmpty()
                .MustAsync(CanalVendaExistis).WithMessage("Canal de venda não encontrado");
        }

        private async Task<bool> CanalVendaExistis(int id, CancellationToken cancellationToken)
        {
            return await context.Ouvidoria_CanaisVenda.FindAsync(id) == null ? false : true;
        }
    }
}
