using Atlas.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Statuses.Queries.GetStatus
{
    public class GetStatus  : IRequest<StatusDTO>
    {
        public GetStatus(int Id)
        {
            this.Id = Id;
        }

        public int Id { get; }
    }


    public class GetStatusHandler : IRequestHandler<GetStatus, StatusDTO>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public GetStatusHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<StatusDTO> Handle(GetStatus request, CancellationToken cancellationToken)
        {
            return _mapper.Map<StatusDTO>(await _context.Ouvidoria_Status.FindAsync(request.Id));
        }
    }

}
