using Atlas.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Statuses.Queries.GetStatus
{
    public class GetStatusValidation  : AbstractValidator<GetStatus>
    {
        private readonly IAtlasDbContext context;

        public GetStatusValidation(IAtlasDbContext context)
        {
            this.context = context;

            RuleFor(s => s.Id)
                .NotEmpty()
                .MustAsync(StatusExists).WithMessage("Status não existe.");
        }

        private async Task<bool> StatusExists(int id, CancellationToken cancellationToken)
        {
            return await context.Ouvidoria_Status.FindAsync(id) == null ? false : true;
        }
    }
}
