using Atlas.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Assuntos.Commands.DeleteAssunto
{
    public class DeleteAssunto  : IRequest<int>
    {
        public DeleteAssunto(int Id)
        {
            this.Id = Id;
        }

        public int Id { get; }
    }


    public class DeleteAssuntoHandler : IRequestHandler<DeleteAssunto, int>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public DeleteAssuntoHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<int> Handle(DeleteAssunto request, CancellationToken cancellationToken)
        {
            var assunto = await _context.Ouvidoria_Assuntos.FindAsync(request.Id);
            _context.Ouvidoria_Assuntos.Remove(assunto);

            return await _context.SaveChangesAsync(cancellationToken);
        }
    }

}
