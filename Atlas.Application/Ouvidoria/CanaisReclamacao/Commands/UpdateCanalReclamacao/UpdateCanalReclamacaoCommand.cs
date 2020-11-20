using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Assuntos.Commands.CanaisReclamacao.Commands.UpdateCanalReclamacao
{
    public class UpdateCanalReclamacaoCommand  : IRequest<int>
    {
        public UpdateCanalReclamacaoCommand(CanalReclamacaoDTO canalReclamacao)
        {
            CanalReclamacao = canalReclamacao;
        }

        public CanalReclamacaoDTO CanalReclamacao { get; }
    }


    public class UpdateCanalReclamacaoHandler : IRequestHandler<UpdateCanalReclamacaoCommand, int>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public UpdateCanalReclamacaoHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<int> Handle(UpdateCanalReclamacaoCommand request, CancellationToken cancellationToken)
        {
            var canalReclamacao = await _context.Ouvidoria_CanaisReclamacoes.FindAsync(request.CanalReclamacao.Id);

            _mapper.Map<CanalReclamacaoDTO, CanalReclamacao>(request.CanalReclamacao, canalReclamacao);

            return await _context.SaveChangesAsync(cancellationToken);
        }
    }

}
