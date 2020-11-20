using Atlas.Application.Common.Interfaces;
using Atlas.Application.Ouvidoria.Assuntos.Commands.CanaisReclamacao;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.CanaisReclamacao.Commands.PostCanalReclamacao
{
    public class PostCanalReclamacaoCommand  : IRequest<int>
    {
        public PostCanalReclamacaoCommand(CanalReclamacaoDTO canalReclamacao)
        {
            CanalReclamacao = canalReclamacao;
        }

        public CanalReclamacaoDTO CanalReclamacao { get; }
    }


    public class PostCanalReclamacaoCommandHandler : IRequestHandler<PostCanalReclamacaoCommand, int>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public PostCanalReclamacaoCommandHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<int> Handle(PostCanalReclamacaoCommand request, CancellationToken cancellationToken)
        {
            _context.Ouvidoria_CanaisReclamacoes.Add(_mapper.Map<CanalReclamacao>(request.CanalReclamacao));

            return await _context.SaveChangesAsync(cancellationToken);
        }
    }

}
