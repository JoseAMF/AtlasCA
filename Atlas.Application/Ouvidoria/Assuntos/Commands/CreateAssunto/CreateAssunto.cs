using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Assuntos.Commands.CreateAssunto
{
    public class CreateAssunto  : IRequest<int>
    {
        public CreateAssunto(AssuntoDTO assunto)
        {
            Assunto = assunto;
        }

        public AssuntoDTO Assunto { get; }
    }


    public class CreateAssuntoHandler : IRequestHandler<CreateAssunto, int>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public CreateAssuntoHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<int> Handle(CreateAssunto request, CancellationToken cancellationToken)
        {
            _context.Ouvidoria_Assuntos.Add(_mapper.Map<Assunto>(request.Assunto));

            return await _context.SaveChangesAsync(cancellationToken);
        }
    }

}
