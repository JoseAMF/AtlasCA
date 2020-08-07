using Atlas.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Assuntos.Queries.GetAssunto
{
    public class GetAssunto  : IRequest<AssuntoDTO>
    {
        public GetAssunto(int Id)
        {
            this.Id = Id;
        }

        public int Id { get; }
    }


    public class GetAssuntoHandler : IRequestHandler<GetAssunto, AssuntoDTO>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public GetAssuntoHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<AssuntoDTO> Handle(GetAssunto request, CancellationToken cancellationToken)
        {
            return _mapper.Map<AssuntoDTO>(await _context.Ouvidoria_Assuntos.FindAsync(request.Id));
        }
    }

}
