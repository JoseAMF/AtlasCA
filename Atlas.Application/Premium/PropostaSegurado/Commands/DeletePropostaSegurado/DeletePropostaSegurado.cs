using Atlas.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
namespace Atlas.Application.Premium.PropostaSegurado.Commands.DeletePropostaSegurado
{
    public class DeletePropostaSegurado  : IRequest<int>
    {
        public DeletePropostaSegurado(string Id)
        {
            this.Id = Id;
        }

        public string Id { get; }
    }


    public class DeletePropostaSeguradoHandler : IRequestHandler<DeletePropostaSegurado, int>
    {
        private readonly IPremiumDbContext _context;
        private readonly IMapper _mapper;

        public DeletePropostaSeguradoHandler(IPremiumDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<int> Handle(DeletePropostaSegurado request, CancellationToken cancellationToken)
        {
            var tbPropostaSegurado = await _context.TbPropostaSegurado.FindAsync(request.Id);
            _context.TbPropostaSegurado.Remove(tbPropostaSegurado);

            return await _context.SaveChangesAsync(cancellationToken);
        }
    }

}
