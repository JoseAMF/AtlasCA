using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Statuses.Commands.UpdateStatus
{
    public class UpdateStatusCommand  : IRequest
    {
        public UpdateStatusCommand(StatusDTO status)
        {
            Status = status;
        }

        public StatusDTO Status { get; }
    }


    public class UpdateStatusCommandHandler : IRequestHandler<UpdateStatusCommand>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public UpdateStatusCommandHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateStatusCommand request, CancellationToken cancellationToken)
        {
            var status = await _context.Ouvidoria_Status.FindAsync(request.Status.Id);

            _mapper.Map<StatusDTO, Status>(request.Status, status);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }

}
