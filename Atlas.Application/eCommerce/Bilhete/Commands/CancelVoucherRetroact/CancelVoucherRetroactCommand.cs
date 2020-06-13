using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.eCommerce;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.eCommerce.Bilhete.Commands.CancelVoucherRetroact
{
   public class CancelVoucherRetroactCommand : IRequest
    {
       

        public CancelVoucherRetroactCommand(string nrBilhete, string data)
        {
            NrVoucher = nrBilhete;
            Data = data;
        }
        public string NrVoucher { get; }
        public string Data { get; }

    }
        public class CancelVoucherRetroactHandler : IRequestHandler<CancelVoucherRetroactCommand>
    {
        private readonly IeCommerceDbContextService contextService;

        public CancelVoucherRetroactHandler(IeCommerceDbContextService contextService)
        {
            this.contextService = contextService;
        }

        public async Task<Unit> Handle(CancelVoucherRetroactCommand request, CancellationToken cancellationToken)
        {
             var context =contextService.GetContextVoucher(request.NrVoucher);

            var dataCancelamento = DateTime.ParseExact(request.Data, "d-M-yyyy", CultureInfo.InvariantCulture);

            string proposta = request.NrVoucher.Substring(0, request.NrVoucher.Length - 2);
            string passageiro = request.NrVoucher.Substring(request.NrVoucher.Length - 2);

            PoPolizas poliza = await context.PoPolizas.Where(x => x.NumeroPoliza == proposta).FirstOrDefaultAsync(cancellationToken);

            var bilhete = context.PoBeneficiariosPoliza.Where(x => x.IdPoliza == poliza.IdPoliza && x.Secuencia == int.Parse(passageiro)).FirstOrDefault();

            poliza.FechaAnulacion = dataCancelamento;
            context.PoPolizas.Update(poliza);

            bilhete.FechaAnulacion = poliza.FechaDesde;
            context.PoBeneficiariosPoliza.Update(bilhete);

            await context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
