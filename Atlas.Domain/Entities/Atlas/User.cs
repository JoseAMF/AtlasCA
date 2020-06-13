using Atlas.Domain.Common;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Atlas
{
    public class User : AuditableEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public char Ativo { get; set; }
        public ICollection<UserPermission> UserPermissions { get; set; }
    }
}
