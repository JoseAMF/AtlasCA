using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.CanaisVenda.Commands.UpdateCanalVenda
{
    public class UpdateCanalVendaCommand  : IRequest<int>
    {
        public UpdateCanalVendaCommand(CanalVendaDTO canalVenda)
        {
            CanalVenda = canalVenda;
        }

        public CanalVendaDTO CanalVenda { get; }
    }


    public class UpdateCanalVendaHandler : IRequestHandler<UpdateCanalVendaCommand, int>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public UpdateCanalVendaHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<int> Handle(UpdateCanalVendaCommand request, CancellationToken cancellationToken)
        {
            var canalVenda = await _context.Ouvidoria_CanaisVenda.FindAsync(request.CanalVenda.Id);

            _mapper.Map<CanalVendaDTO, CanalVenda>(request.CanalVenda, canalVenda);

            return await _context.SaveChangesAsync(cancellationToken);
        }
    }

}
