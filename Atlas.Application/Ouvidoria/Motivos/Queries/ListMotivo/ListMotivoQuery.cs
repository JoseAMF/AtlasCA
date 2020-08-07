using MediatR;
using Atlas.Domain.Entities.Atlas.Ouvidoria;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using Atlas.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;
using AutoMapper;

namespace Atlas.Application.Ouvidoria.Motivos.Queries.ListMotivo
{
    public class ListMotivoQuery : IRequest<List<MotivoDTO>>
    {
    }

    public class ListMotivoQueryHandler : IRequestHandler<ListMotivoQuery, List<MotivoDTO>>
    {
        private readonly IAtlasDbContext context;
        private readonly IMapper mapper;

        public ListMotivoQueryHandler(IAtlasDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public async Task<List<MotivoDTO>> Handle(ListMotivoQuery request, CancellationToken cancellationToken)
        {
            return await context.Ouvidoria_Motivos
                .ProjectTo<MotivoDTO>(mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
