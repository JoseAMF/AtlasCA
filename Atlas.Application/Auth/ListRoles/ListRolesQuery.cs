
using Atlas.Application.Auth;
using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.Atlas;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Auth.ListRoles
{
    public class ListRolesQuery : IRequest<List<PermissionDTO>>
    {
    }

    public class ListRolesQueryHandler : IRequestHandler<ListRolesQuery, List<PermissionDTO>>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public ListRolesQueryHandler(IAtlasDbContext context, IMapper mapper)
        {
            _context = context;
            this._mapper = mapper;
        }
        public async Task<List<PermissionDTO>> Handle(ListRolesQuery request, CancellationToken cancellationToken)
        {
            return await _context.Permissoes.ProjectTo<PermissionDTO>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
        }
    }
}

