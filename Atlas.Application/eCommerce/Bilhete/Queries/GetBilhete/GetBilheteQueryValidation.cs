using Atlas.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.eCommerce.Bilhete.Queries.GetBilhete
{
    public class GetBilheteQueryValidation : AbstractValidator<GetBilheteQuery>
    {
        private readonly IeCommerceDbContextService contextService;

        public GetBilheteQueryValidation(IeCommerceDbContextService contextService)
        {
            this.contextService = contextService;

            RuleFor(b => b.NrBilhete)
                .MinimumLength(12);

            RuleFor(b => b.NrBilhete)
                .Must(ValidateVoucher).WithMessage("Bilhete inválido.");

            RuleFor(b => b.NrBilhete)
                .MustAsync(VoucherExists).WithMessage("Bilhete não encontrado.");
        }

        private bool ValidateVoucher(string bilhete)
        {
            foreach (var item in bilhete)
            {
                if (!char.IsDigit(item)) return false;
            }

            return true;
        }

        private async Task<bool> VoucherExists(string NrVoucher, CancellationToken cancelationToken)
        {
            return await contextService.GetContextVoucher(NrVoucher)
                .PoPolizas
                .Where(x => x.NumeroPoliza == NrVoucher.Substring(0, NrVoucher.Length - 2))
                .ToListAsync(cancelationToken) == null ? false : true;

        }
    }

    internal class CancelationToken
    {
    }
}
