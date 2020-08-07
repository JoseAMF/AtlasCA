using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Statuses.Commands.DeleteStatus
{
    public class DeleteStatus  : IRequest<int>
    {
        public DeleteStatus(int Id)
        {
            this.Id = Id;
        }

        public int Id { get; }
    }

    public class DeleteStatusHandler : IRequestHandler<DeleteStatus, int>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public DeleteStatusHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<int> Handle(DeleteStatus request, CancellationToken cancellationToken)
        {
            var status = new Status();
            _context.Ouvidoria_Status.Remove(status);

            return await _context.SaveChangesAsync(cancellationToken);
        }
    }

}
