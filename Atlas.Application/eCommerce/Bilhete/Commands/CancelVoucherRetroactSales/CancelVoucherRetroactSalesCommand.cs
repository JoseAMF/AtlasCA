using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.eCommerce;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.eCommerce.Bilhete.CancelVoucherRetroactSales
{
   public class CancelVoucherRetroactSalesCommand :IRequest
    {
        public CancelVoucherRetroactSalesCommand(string bilhete, string data)
        {
            NrVoucher = bilhete;
            Data = data;
        }
        public string NrVoucher { get; }
        public string Data { get; }
    }

    public class CancelVoucherRetroactSalesHandler:IRequestHandler<CancelVoucherRetroactSalesCommand>
    {
        private readonly IeCommerceDbContextService contextService;

        public CancelVoucherRetroactSalesHandler(IeCommerceDbContextService contextService)
        {
            this.contextService = contextService;
        }

        public async Task<Unit> Handle(CancelVoucherRetroactSalesCommand request, CancellationToken cancellationToken)
        {
            var context = contextService.GetContextVoucher(request.NrVoucher);

            var dataCancelamento =DateTime.ParseExact(request.Data, "d-M-yyyy", CultureInfo.InvariantCulture);

            string proposta =request.NrVoucher.Substring(0, request.NrVoucher.Length - 2);
            string passageiro =request.NrVoucher.Substring(request.NrVoucher.Length - 2);

            PoPolizas poliza = await context.PoPolizas.Where(x => x.NumeroPoliza == proposta).FirstOrDefaultAsync(cancellationToken);

            var bilhetes = context.PoBeneficiariosPoliza.Where(x => x.IdPoliza == poliza.IdPoliza);

            foreach(var bilhete in bilhetes)
            {
                bilhete.FechaAnulacion = dataCancelamento;
                context.PoBeneficiariosPoliza.Update(bilhete);
            }

            poliza.FechaAnulacion = dataCancelamento;


            context.PoPolizas.Update(poliza);

            await context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
