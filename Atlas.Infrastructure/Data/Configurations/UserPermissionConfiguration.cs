using Atlas.Domain.Entities.Atlas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Infrastructure.Data.Configurations
{
    class UserPermissionConfiguration : IEntityTypeConfiguration<UserPermission>
    {
        public void Configure(EntityTypeBuilder<UserPermission> builder)
        {
            builder.HasKey(up => new { up.UserUsername, up.PermissionId });

            builder
                .HasOne(up => up.User)
                .WithMany(u => u.UserPermissions)
                .HasForeignKey(up => up.UserUsername);

            builder
                .HasOne(up => up.Permission)
                .WithMany(p => p.UserPermissions)
                .HasForeignKey(up => up.PermissionId);
        }
    }
}
