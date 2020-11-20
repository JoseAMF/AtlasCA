using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.eCommerce;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.eCommerce.Bilhete.Commands.CancelVoucher
{
    public class CancelVoucherCommand : IRequest
    {
        public CancelVoucherCommand(string nrBilhete)
        {
            NrBilhete = nrBilhete;
        }

        public string NrBilhete { get; }
    }
    public class CancelVoucherBilheteHandler : IRequestHandler<CancelVoucherCommand>
    {
        private readonly IeCommerceDbContextService contextService;

        public CancelVoucherBilheteHandler(IeCommerceDbContextService contextService)
        {
            this.contextService = contextService;
        }
        public async Task<Unit> Handle(CancelVoucherCommand request, CancellationToken cancellationToken)
        {
            var context = contextService.GetContextVoucher(request.NrBilhete);

            string proposta = request.NrBilhete.Substring(0, request.NrBilhete.Length - 2);
            string passageiro = request.NrBilhete.Substring(request.NrBilhete.Length - 2);

            PoPolizas poliza = context.PoPolizas.Where(x => x.NumeroPoliza == proposta).FirstOrDefault();

            var bilhete = context.PoBeneficiariosPoliza.Where(x => x.IdPoliza == poliza.IdPoliza && x.Secuencia == int.Parse(passageiro)).FirstOrDefault();

            bilhete.FechaAnulacion = poliza.FechaDesde;

            poliza.FechaAnulacion = poliza.FechaDesde;

            await context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }

}
