using Atlas.Domain.Entities.Enums;
using System;
using System.Collections.Generic;

namespace Atlas.Domain.Entities.Atlas
{
    public class Permission
    {
        public PermissionEnum Id { get; set; }
        public string Name { get; set; }
        public ICollection<UserPermission> UserPermissions { get; set; }

    }
}
