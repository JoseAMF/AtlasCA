
using Atlas.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Auth.ListRoles
{
    public class ListRolesQuery : IRequest<List<string>>
    {
    }

    public class ListRolesQueryHandler : IRequestHandler<ListRolesQuery, List<string>>
    {
        private readonly IAtlasDbContext _context;

        public ListRolesQueryHandler(IAtlasDbContext context)
        {
            _context = context;
        }
        public async Task<List<string>> Handle(ListRolesQuery request, CancellationToken cancellationToken)
        {
            return await _context.Permissoes.Select(x => x.Name).ToListAsync(cancellationToken);
        }
    }
}
