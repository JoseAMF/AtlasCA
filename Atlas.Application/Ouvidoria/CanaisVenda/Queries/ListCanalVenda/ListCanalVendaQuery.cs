using Atlas.Application.Common.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.CanaisVenda.Queries.ListCanalVenda
{
    public class ListCanalVendaQuery  : IRequest<List<CanalVendaDTO>>
    {
    }


    public class ListCanalVendaQueryHandler : IRequestHandler<ListCanalVendaQuery, List<CanalVendaDTO>>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public ListCanalVendaQueryHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<List<CanalVendaDTO>> Handle(ListCanalVendaQuery request, CancellationToken cancellationToken)
        {
            return await _context.Ouvidoria_CanaisVenda
                .ProjectTo<CanalVendaDTO>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }

}
