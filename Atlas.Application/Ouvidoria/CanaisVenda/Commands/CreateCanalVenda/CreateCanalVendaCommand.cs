using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.CanaisVenda.Commands.CreateCanalVenda
{
    public class CreateCanalVendaCommand  : IRequest<int>
    {
        public CreateCanalVendaCommand(CanalVendaDTO CanalVenda)
        {
            this.CanalVenda = CanalVenda;
        }

        public CanalVendaDTO CanalVenda { get; }
    }


    public class CreateCanalVendaHandler : IRequestHandler<CreateCanalVendaCommand, int>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public CreateCanalVendaHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<int> Handle(CreateCanalVendaCommand request, CancellationToken cancellationToken)
        {
            _context.Ouvidoria_CanaisVenda.Add(_mapper.Map<CanalVenda>(request.CanalVenda));

           return await _context.SaveChangesAsync(cancellationToken);
        }
    }

}
