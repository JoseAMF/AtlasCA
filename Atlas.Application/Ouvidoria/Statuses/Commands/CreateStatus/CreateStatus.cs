using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Statuses.Commands.CreateStatus
{
    public class CreateStatus : IRequest<int>
    {
        public CreateStatus(StatusDTO status)
        {
            Status = status;
        }

        public StatusDTO Status { get; }
    }


    public class CreateStatusHandler : IRequestHandler<CreateStatus, int>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public CreateStatusHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<int> Handle(CreateStatus request, CancellationToken cancellationToken)
        {
            _context.Ouvidoria_Status.Add(_mapper.Map<Status>(request.Status));
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }

}
