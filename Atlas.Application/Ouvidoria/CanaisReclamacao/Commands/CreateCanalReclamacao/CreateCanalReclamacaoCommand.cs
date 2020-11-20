using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Assuntos.Commands.CanaisReclamacao.Commands.CreateCanalReclamacao
{
    public class CreateCanalReclamacaoCommand  : IRequest<int>
    {
        public CreateCanalReclamacaoCommand(CanalReclamacaoDTO canalReclamacao)
        {
            CanalReclamacao = canalReclamacao;
        }

        public CanalReclamacaoDTO CanalReclamacao { get; }
    }


    public class CreateCanalReclamacaoHandler : IRequestHandler<CreateCanalReclamacaoCommand, int>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public CreateCanalReclamacaoHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<int> Handle(CreateCanalReclamacaoCommand request, CancellationToken cancellationToken)
        {
            _context.Ouvidoria_CanaisReclamacoes.Add(_mapper.Map<CanalReclamacao>(request.CanalReclamacao));
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }

}
