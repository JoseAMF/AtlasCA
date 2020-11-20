using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.Premium;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Premium.Proposta.Commands.UpdateProposta
{
    public class UpdateProposta  : IRequest<int>
    {
        public UpdateProposta(TbProposta Proposta)
        {
            this.Proposta = Proposta;
        }

        public TbProposta Proposta { get; }
    }


    public class UpdatePropostaHandler : IRequestHandler<UpdateProposta, int>
    {
        private readonly IPremiumDbContext _context;
        private readonly IMapper _mapper;

        public UpdatePropostaHandler(IPremiumDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<int> Handle(UpdateProposta request, CancellationToken cancellationToken)
        {
            _context.TbProposta.Update(request.Proposta);

            return await _context.SaveChangesAsync(cancellationToken);
        }
    }

}
