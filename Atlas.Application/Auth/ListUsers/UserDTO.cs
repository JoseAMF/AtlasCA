using Atlas.Application.Common.Mappings;
using Atlas.Domain.Entities.Atlas;

namespace Application.Auth.ListUsers
{
    public class UserDTO : IMapFrom<User>
    {
        public string Username { get; set; }
        public string Email { get; set; }

    }
}
