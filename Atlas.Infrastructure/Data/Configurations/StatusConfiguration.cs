using Atlas.Domain.Entities.Atlas.Ouvidoria;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Atlas.Infrastructure.Data.Configurations
{
    public class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Descricao)
                .HasMaxLength(50);
        }

    }
}
