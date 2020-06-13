using Atlas.Domain.Entities.Enums;

namespace Atlas.Domain.Entities.Atlas
{
    public class UserPermission
    {
        public string UserUsername { get; set; }
        public User User { get; set; }
        public PermissionEnum PermissionId { get; set; }
        public Permission Permission { get; set; }
    }
}