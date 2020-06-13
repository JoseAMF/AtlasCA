using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.Atlas;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Auth.ListUsers
{
    public class ListUsersQuery : IRequest<List<UserDTO>>
    {
    }

    public class ListUsersQueryHandler : IRequestHandler<ListUsersQuery, List<UserDTO>>
    {
        private readonly IAtlasDbContext _context;
        private readonly IMapper _mapper;
        public ListUsersQueryHandler(IAtlasDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<UserDTO>> Handle(ListUsersQuery request, CancellationToken cancellationToken)
        {
            return await _context.Usuarios
                .OrderBy(u => u.Username)
                .ProjectTo<UserDTO>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }
}
