using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Assuntos.Commands.CanaisReclamacao.Commands.DeleteCanalReclamacao
{
    public class DeleteCanalReclamacaoCommand  : IRequest
    {
        public DeleteCanalReclamacaoCommand(int Id)
        {
            this.Id = Id;
        }

        public int Id { get; }
    }


    public class DeleteCanalReclamacaoHandler : IRequestHandler<DeleteCanalReclamacaoCommand>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public DeleteCanalReclamacaoHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteCanalReclamacaoCommand request, CancellationToken cancellationToken)
        {
            var canalReclamacao = await _context.Ouvidoria_CanaisReclamacoes.FindAsync(request.Id);
            _context.Ouvidoria_CanaisReclamacoes.Remove(canalReclamacao);

            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }

}
