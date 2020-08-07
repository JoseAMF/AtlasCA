using Atlas.Domain.Entities.Atlas.Ouvidoria;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Infrastructure.Data.Configurations
{
    public class MotivoConfiguration : IEntityTypeConfiguration<Motivo>
    {
        public void Configure(EntityTypeBuilder<Motivo> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Descricao)
                .HasMaxLength(50);
        }
    }
}
