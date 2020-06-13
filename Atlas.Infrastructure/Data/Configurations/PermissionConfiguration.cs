using Atlas.Domain.Entities.Atlas;
using Atlas.Domain.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atlas.Infrastructure.Data.Configurations
{
    class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedNever();
            
            builder.Property(p => p.Name)
                .HasMaxLength(50);

            builder.ToTable("Permissoes")
                .HasData(Enum.GetValues(typeof(PermissionEnum))
                .OfType<PermissionEnum>()
                .Select(x => new Permission() { Id = x, Name = x.ToString() })
                .ToArray());
        }
    }
}
