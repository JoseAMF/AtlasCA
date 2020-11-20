using Atlas.Application.Common.Interfaces;
using Atlas.Application.Ouvidoria.Motivos.Commands.DeleteMotivo;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Motivos.Commands.DeleteMotivo
{
    public class DeleteMotivoCommand  : IRequest
    {
        public DeleteMotivoCommand(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}


public class DeleteMotivoCommandHandler : IRequestHandler<DeleteMotivoCommand>
{
    private readonly IAtlasDbContext _context;
    private readonly IMapper _mapper;

    public DeleteMotivoCommandHandler(IAtlasDbContext context, IMapper mapper)
    {
        this._context = context;
        this._mapper = mapper;
    }

    public async Task<Unit> Handle(DeleteMotivoCommand request, CancellationToken cancellationToken)
    {
        var motivo = await _context.Ouvidoria_Motivos.FindAsync(request.Id);
        _context.Ouvidoria_Motivos.Remove(motivo);

        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}

