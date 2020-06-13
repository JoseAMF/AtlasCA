using Atlas.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.eCommerce.Bilhete.CancelVoucherRetroactSales
{
    public class CancelVoucherRetroactSalesCommandValidation : AbstractValidator<CancelVoucherRetroactSalesCommand>
    {
        private readonly IeCommerceDbContextService contextService;

        public CancelVoucherRetroactSalesCommandValidation(IeCommerceDbContextService contextService)
        {
            this.contextService = contextService;
             RuleFor(c => c.NrVoucher)
                .MinimumLength(12)
                .NotEmpty()
                .MustAsync(PoPolizaExists).WithMessage("Bilhete não existe");
        }

        private async Task<bool> PoPolizaExists(string NrVoucher, CancellationToken cancellationToken)
        {
            string proposta = NrVoucher.Substring(0, NrVoucher.Length - 2);

            return await contextService.GetContextVoucher(NrVoucher).PoPolizas
                .Where(x => x.NumeroPoliza == proposta).FirstOrDefaultAsync(cancellationToken) == null ? false : true;
        }
    }
}
