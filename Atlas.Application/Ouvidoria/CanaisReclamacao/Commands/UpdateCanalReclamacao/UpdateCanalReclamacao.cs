using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Assuntos.Commands.CanaisReclamacao.Commands.UpdateCanalReclamacao
{
    public class UpdateCanalReclamacao  : IRequest<int>
    {
        public UpdateCanalReclamacao(CanalReclamacaoDTO canalReclamacao)
        {
            CanalReclamacao = canalReclamacao;
        }

        public CanalReclamacaoDTO CanalReclamacao { get; }
    }


    public class UpdateCanalReclamacaoHandler : IRequestHandler<UpdateCanalReclamacao, int>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public UpdateCanalReclamacaoHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<int> Handle(UpdateCanalReclamacao request, CancellationToken cancellationToken)
        {
            _context.Ouvidoria_CanaisReclamacoes.Update(_mapper.Map<CanalReclamacao>(request.CanalReclamacao));
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }

}
