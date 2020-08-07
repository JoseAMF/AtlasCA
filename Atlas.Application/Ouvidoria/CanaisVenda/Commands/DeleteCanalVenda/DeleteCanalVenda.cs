using Atlas.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.CanaisVenda.Commands.DeleteCanalVenda
{
    public class DeleteCanalVenda  : IRequest<int>
    {
        public DeleteCanalVenda(int Id)
        {
            this.Id = Id;
        }

        public int Id { get; }
    }


    public class DeleteCanalVendaHandler : IRequestHandler<DeleteCanalVenda, int>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public DeleteCanalVendaHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<int> Handle(DeleteCanalVenda request, CancellationToken cancellationToken)
        {
            var canalVenda = await _context.Ouvidoria_CanaisVenda.FindAsync(request.Id);
            _context.Ouvidoria_CanaisVenda.Remove(canalVenda);

           return await _context.SaveChangesAsync(cancellationToken);
        }
    }

}
