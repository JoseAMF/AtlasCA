using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Assuntos.Commands.UpdateAssunto
{
    public class UpdateAssunto  : IRequest<int>
    {
        public UpdateAssunto(AssuntoDTO assunto)
        {
            Assunto = assunto;
        }

        public AssuntoDTO Assunto { get; }
    }

    public class UpdateAssuntoHandler : IRequestHandler<UpdateAssunto, int>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public UpdateAssuntoHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<int> Handle(UpdateAssunto request, CancellationToken cancellationToken)
        {
            _context.Ouvidoria_Assuntos.Update(_mapper.Map<Assunto>(request.Assunto));

            return await _context.SaveChangesAsync(cancellationToken);
        }
    }

}
