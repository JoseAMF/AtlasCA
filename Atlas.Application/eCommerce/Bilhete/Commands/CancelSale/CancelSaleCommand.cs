using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.eCommerce;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Atlas.Application.eCommerce.Bilhete.Commands.CancelSale
{
  public class CancelSaleCommand : IRequest
    {
        public CancelSaleCommand(string bilhete)
        {
            NrVoucher = bilhete;
        }

        public string NrVoucher { get; }
    }
    public class CancelSaleHandler : IRequestHandler<CancelSaleCommand>
    {
        private readonly IeCommerceDbContextService contextService;

        public CancelSaleHandler(IeCommerceDbContextService contextService)
        {
            this.contextService = contextService;
        }

        public async Task<Unit> Handle(CancelSaleCommand request, CancellationToken cancellationToken)
        {
            var context =contextService.GetContextVoucher(request.NrVoucher);

            string proposta = request.NrVoucher.Substring(0, request.NrVoucher.Length - 2);
            string passageiro = request.NrVoucher.Substring(request.NrVoucher.Length - 2);

            PoPolizas poliza =await context.PoPolizas.Where(x => x.NumeroPoliza == proposta).FirstOrDefaultAsync(cancellationToken);

            var bilhetes = context.PoBeneficiariosPoliza.Where(x => x.IdPoliza == poliza.IdPoliza);

            foreach(var bilhete in bilhetes)
            {
                bilhete.FechaAnulacion = poliza.FechaDesde;
                context.PoBeneficiariosPoliza.Update(bilhete);

            }


            poliza.FechaAnulacion = poliza.FechaDesde;

            context.PoPolizas.Update(poliza);

            await context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
