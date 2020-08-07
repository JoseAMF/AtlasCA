using System.Collections.Generic;
using Atlas.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace Atlas.Application.Ouvidoria.Statuses.Queries.ListStatus
{
    public class ListStatus : IRequest<List<StatusDTO>>
    {
    }


    public class ListStatusHandler : IRequestHandler<ListStatus, List<StatusDTO>>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public ListStatusHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public Task<List<StatusDTO>> Handle(ListStatus request, CancellationToken cancellationToken)
        {
           return _context.Ouvidoria_Status
                .ProjectTo<StatusDTO>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }

}
