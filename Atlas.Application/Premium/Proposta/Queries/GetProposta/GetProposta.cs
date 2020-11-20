using Atlas.Domain.Entities.Premium;
using Atlas.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace Atlas.Application.Premium.Proposta.Queries.GetProposta
{
    public class GetProposta  : IRequest<TbProposta>
    {
        public GetProposta(string Id)
        {
            this.Id = Id;
        }

        public string Id { get; }
    }


    public class GetPropostaHandler : IRequestHandler<GetProposta, TbProposta>
    {
        private readonly IPremiumDbContext _context;
        private readonly IMapper _mapper;

        public GetPropostaHandler(IPremiumDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<TbProposta> Handle(GetProposta request, CancellationToken cancellationToken)
        {
            var tbProposta = await _context.TbProposta.FindAsync(request.Id);

            tbProposta.Passageiros = _context.TbPropostaSegurado
                                      .Where(x => x.NrProposta == request.Id).ToList();

            foreach(var item in tbProposta.Passageiros)
            {
                item.IntegradoI4Pro = _context.I4proControle.Where(x => x.NrVoucher == item.NrVoucher).Any();
                item.IntegradoCancelamento = _context.CancelamentoControle.Where(x => x.NrBilhete == item.NrVoucher).Any();
            }

            return tbProposta;
        }
    }

}
