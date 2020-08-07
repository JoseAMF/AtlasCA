using Atlas.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.CanaisVenda.Queries.GetCanalVenda
{
    public class GetCanalVenda  : IRequest<CanalVendaDTO>
    {
        public GetCanalVenda(int Id)
        {
            this.Id = Id;
        }

        public int Id { get; }
    }

    public class GetCanalVendaHandler : IRequestHandler<GetCanalVenda, CanalVendaDTO>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public GetCanalVendaHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<CanalVendaDTO> Handle(GetCanalVenda request, CancellationToken cancellationToken)
        {
            return _mapper.Map<CanalVendaDTO>(await _context.Ouvidoria_CanaisVenda.FindAsync(request.Id));
        }
    }


}
