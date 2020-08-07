using Atlas.Domain.Entities.Atlas.Ouvidoria;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Infrastructure.Data.Configurations
{
    class AssuntoConfiguration : IEntityTypeConfiguration<Assunto>
    {
        public void Configure(EntityTypeBuilder<Assunto> builder)
        {
            builder.HasKey(a => a.IdAssunto);

            builder.Property(a => a.IdAssunto)
                .ValueGeneratedNever();

            builder.Property(a => a.Descricao)
                .HasMaxLength(50);
        }
    }
}
