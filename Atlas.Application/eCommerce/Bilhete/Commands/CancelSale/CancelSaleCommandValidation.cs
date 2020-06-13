using Atlas.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.eCommerce.Bilhete.Commands.CancelSale
{
   public class CancelSaleCommandValidation : AbstractValidator<CancelSaleCommand>
    {
        private readonly IeCommerceDbContextService contextService;

        public CancelSaleCommandValidation(IeCommerceDbContextService contextService)
        {
            this.contextService = contextService;
            RuleFor(c =>c.NrVoucher)
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
