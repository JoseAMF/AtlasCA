using Microsoft.EntityFrameworkCore;
using Atlas.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Atlas.Domain.Entities.ContactCenter;

namespace Atlas.Infrastructure.Data
{
    public partial class ContactCenterDbContext : DbContext, IContactCenterDbContext
    {
        public ContactCenterDbContext()
        {
        }

        public ContactCenterDbContext(DbContextOptions<ContactCenterDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<VwOuvidoria> VwOuvidoria { get; set; }

        //         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //         {
        //             if (!optionsBuilder.IsConfigured)
        //             {
        // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                 optionsBuilder.UseSqlServer("Server=Croacia\\homsql001;Database=ContactCenter;User Id=usrconninf05;Password=#Usr_Cnf_2019;");
        //             }
        //         }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VwOuvidoria>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Ouvidoria");

                entity.Property(e => e.DataAbertura)
                    .HasColumnName("dataAbertura")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataEncerramento)
                    .HasColumnName("dataEncerramento")
                    .HasColumnType("datetime");

                entity.Property(e => e.Entidade)
                    .IsRequired()
                    .HasColumnName("entidade")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdentificacaoReclamante)
                    .HasColumnName("identificacaoReclamante")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdentificacaoResponsavel).HasColumnName("identificacaoResponsavel");

                entity.Property(e => e.Protocolo)
                    .HasColumnName("protocolo")
                    .HasColumnType("decimal(20, 0)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
