using Atlas.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.LGPD.Externos.Queries.GetLGPDExterno
{
    public class GetLGPDExternoQuery  : IRequest<LGPDExternoDTO>
    {
        public GetLGPDExternoQuery(int Id)
        {
            this.Id = Id;
        }

        public int Id { get; }
    }


    public class GetLGPDExternoQueryHandler : IRequestHandler<GetLGPDExternoQuery, LGPDExternoDTO>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public GetLGPDExternoQueryHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<LGPDExternoDTO> Handle(GetLGPDExternoQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<LGPDExternoDTO>(await _context.LGPDExternos.FindAsync(request.Id));
        }
    }

}
