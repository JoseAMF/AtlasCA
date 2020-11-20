using Atlas.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Premium.PropostaSegurado.Queries.GetPropostaSegurado
{
    public class GetPropostaValidation  : AbstractValidator<GetPropostaSegurado>
    {
        private readonly IPremiumDbContext context;

        public GetPropostaValidation(IPremiumDbContext context)
        {
            this.context = context;

            RuleFor(p => p.Id)
            .NotEmpty()
            .MustAsync(PropostaSeguradoExist).WithMessage("PropostaSegurado não encontrada.");
        }

        private async Task<bool> PropostaSeguradoExist(string id, CancellationToken cancellationToken)
        {
            return await context.TbPropostaSegurado.FindAsync(id) == null ? false : true;
        }
    }
}
