using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Assuntos.Commands.CanaisReclamacao.Commands.DeleteCanalReclamacao
{
    public class DeleteCanalReclamacao  : IRequest<int>
    {
        public DeleteCanalReclamacao(int Id)
        {
            this.Id = Id;
        }

        public int Id { get; }
    }


    public class DeleteCanalReclamacaoHandler : IRequestHandler<DeleteCanalReclamacao, int>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public DeleteCanalReclamacaoHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<int> Handle(DeleteCanalReclamacao request, CancellationToken cancellationToken)
        {
            var canalReclamacao = new CanalReclamacao();
            canalReclamacao.IdCanalReclamacao = request.Id;
            _context.Ouvidoria_CanaisReclamacoes.Remove(canalReclamacao);

            return await _context.SaveChangesAsync(cancellationToken);
        }
    }

}
