using Atlas.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Atlas.Domain.Entities.Atlas;

namespace Atlas.Application.Auth.GetUserRoles
{
    public class GetUserRolesQuery  : IRequest<List<PermissionDTO>>
    {
        public GetUserRolesQuery(string Username)
        {
            this.Username = Username.ToUpper();
        }

        public string Username { get; }
    }


    public class GetUserRolesQueryHandler : IRequestHandler<GetUserRolesQuery, List<PermissionDTO>>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;

        public GetUserRolesQueryHandler(IAtlasDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<List<PermissionDTO>> Handle(GetUserRolesQuery request, CancellationToken cancellationToken)
        {
            var roles =await  _context.Usuarios
                .Where(u => u.Username == request.Username)
                .Include(up => up.UserPermissions)
                .ThenInclude(p => p.Permission)
                .Select(p => p.UserPermissions)
                .FirstOrDefaultAsync();

            return _mapper.Map<List<PermissionDTO>>(roles.Select(p => p.Permission));

        }
    }

}
