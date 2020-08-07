using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.CanaisVenda.Commands.UpdateCanalVenda
{
    public class UpdateCanalVenda  : IRequest<int>
    {
        public UpdateCanalVenda(CanalVendaDTO canalVenda)
        {
            CanalVenda = canalVenda;
        }

        public CanalVendaDTO CanalVenda { get; }
    }


    public class UpdateCanalVendaHandler : IRequestHandler<UpdateCanalVenda, int>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public UpdateCanalVendaHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<int> Handle(UpdateCanalVenda request, CancellationToken cancellationToken)
        {
            var canalVenda = _mapper.Map<CanalVenda>(request.CanalVenda);
            _context.Ouvidoria_CanaisVenda.Update(canalVenda);

            return await _context.SaveChangesAsync(cancellationToken);
        }
    }

}
