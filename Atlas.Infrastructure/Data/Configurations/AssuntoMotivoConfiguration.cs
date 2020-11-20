using Atlas.Domain.Entities.Atlas.Ouvidoria;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Infrastructure.Data.Configurations
{
    public class AssuntoMotivoConfiguration : IEntityTypeConfiguration<AssuntoMotivo>
    {
        public void Configure(EntityTypeBuilder<AssuntoMotivo> builder)
        {
            builder.HasKey(am => new { am.AssuntoId, am.MotivoId });

            builder.ToTable("Ouvidoria_AssuntoMotivo");

            builder.HasOne(am => am.Assunto)
                .WithMany(am => am.AssuntoMotivos)
                .HasForeignKey(am => am.AssuntoId);

            builder.HasOne(am => am.Motivo)
                .WithMany(am => am.AssuntoMotivos)
                .HasForeignKey(am => am.MotivoId);
        }
    }
}
