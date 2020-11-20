using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Assuntos.Commands.UpdateAssunto
{
    public class UpdateAssuntoCommand  : IRequest<int>
    {
        public UpdateAssuntoCommand(AssuntoDTO assunto)
        {
            Assunto = assunto;
        }

        public AssuntoDTO Assunto { get; }
    }

    public class UpdateAssuntoHandler : IRequestHandler<UpdateAssuntoCommand, int>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public UpdateAssuntoHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<int> Handle(UpdateAssuntoCommand request, CancellationToken cancellationToken)
        {
            var assunto = await _context.Ouvidoria_Assuntos.FindAsync(request.Assunto.Id);

            _mapper.Map<AssuntoDTO, Assunto>(request.Assunto, assunto);

            return await _context.SaveChangesAsync(cancellationToken);
        }
    }

}
