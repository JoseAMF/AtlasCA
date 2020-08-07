using Atlas.Application.Common.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Atlas.Application.Ouvidoria.Assuntos.Queries.ListAssunto
{
    public class ListAssunto  : IRequest<List<AssuntoDTO>>
    {
    }


    public class ListAssuntoHandler : IRequestHandler<ListAssunto, List<AssuntoDTO>>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public ListAssuntoHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<List<AssuntoDTO>> Handle(ListAssunto request, CancellationToken cancellationToken)
        {
            return await _context.Ouvidoria_Assuntos
                .ProjectTo<AssuntoDTO>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }

}
