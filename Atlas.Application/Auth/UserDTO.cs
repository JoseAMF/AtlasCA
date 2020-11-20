using Atlas.Application.Common.Mappings;
using Atlas.Domain.Entities.Atlas;
using System.Collections;
using System.Collections.Generic;

namespace Application.Auth.ListUsers
{
    public class UserDTO : IMapFrom<User>
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public ICollection<Permission> Roles { get; set; }

    }
}
