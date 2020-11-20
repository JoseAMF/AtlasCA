using Atlas.Domain.Entities.Premium;
using Atlas.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Atlas.Application.Premium.Proposta.Queries.GetProposta;
using System.Linq;

namespace Atlas.Application.Premium.PropostaSegurado.Queries.GetPropostaSegurado
{
    public class GetPropostaSegurado  : IRequest<TbPropostaSegurado>
    {
        public GetPropostaSegurado(string Id)
        {
            this.Id = Id;
        }

        public string Id { get; }
    }


    public class GetPropostaSeguradoHandler : IRequestHandler<GetPropostaSegurado, TbPropostaSegurado>
    {
        private readonly IPremiumDbContext _context;
        private readonly IMapper _mapper;

        public GetPropostaSeguradoHandler(IPremiumDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<TbPropostaSegurado> Handle(GetPropostaSegurado request, CancellationToken cancellationToken)
        {
            var tbPropostaSegurado = await _context.TbPropostaSegurado.FindAsync(request.Id);


            tbPropostaSegurado.IntegradoI4Pro = _context.I4proControle.Where(x => x.NrVoucher == tbPropostaSegurado.NrVoucher).Any();
            tbPropostaSegurado.IntegradoCancelamento = _context.CancelamentoControle.Where(x => x.NrBilhete == tbPropostaSegurado.NrVoucher).Any();

            return tbPropostaSegurado;
        }
    }

}
