using Atlas.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.CanaisVenda.Queries.GetCanalVenda
{
    public class GetCanalVendaQueryValidation : AbstractValidator<GetCanalVendaQuery>
    {
        private readonly IAtlasDbContext context;

        public GetCanalVendaQueryValidation(IAtlasDbContext _context)
        {
            context = _context;
            RuleFor(cv => cv.Id)
                .NotEmpty()
                .MustAsync(CanalVendaExistis).WithMessage("Motivo não encontrado.");
        }

        private async Task<bool> CanalVendaExistis(int id, CancellationToken cancellationToken)
        {
            return await context.Ouvidoria_CanaisVenda.FindAsync(id) == null ? false : true;
        }
    }
}
