using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Assuntos.Commands.CreateAssunto
{
    public class CreateAssuntoCommand  : IRequest<int>
    {
        public CreateAssuntoCommand(AssuntoDTO assunto)
        {
            Assunto = assunto;
        }

        public AssuntoDTO Assunto { get; }
    }


    public class CreateAssuntoHandler : IRequestHandler<CreateAssuntoCommand, int>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public CreateAssuntoHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<int> Handle(CreateAssuntoCommand request, CancellationToken cancellationToken)
        {
            _context.Ouvidoria_Assuntos.Add(_mapper.Map<Assunto>(request.Assunto));

            return await _context.SaveChangesAsync(cancellationToken);
        }
    }

}
