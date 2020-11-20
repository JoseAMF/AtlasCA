using Atlas.Domain.Entities.Premium;
using Atlas.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace Atlas.Application.Premium.Proposta.Commands.DeleteProposta
{
    public class DeleteProposta : IRequest<int>
    {
        public DeleteProposta(string Id)
        {
            this.Id = Id;
        }

        public string Id { get; }
    }


    public class DeletePropostaHandler : IRequestHandler<DeleteProposta, int>
    {
        private readonly IPremiumDbContext _context;
        private readonly IMapper _mapper;

        public DeletePropostaHandler(IPremiumDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<int> Handle(DeleteProposta request, CancellationToken cancellationToken)
        {
            var proposta = await _context.TbProposta.FindAsync(request.Id);
            _context.TbProposta.Remove(proposta);

            return await _context.SaveChangesAsync(cancellationToken);
        }
    }

}
