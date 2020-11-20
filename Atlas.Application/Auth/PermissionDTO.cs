using Atlas.Application.Common.Mappings;
using Atlas.Domain.Entities.Atlas;
using Atlas.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Application.Auth
{
    public class PermissionDTO : IMapFrom<Permission>
    {
        public PermissionEnum Id { get; set; }
        public string Name { get; set; }
    }
}
