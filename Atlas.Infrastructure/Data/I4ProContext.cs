using System;
using Atlas.Application.Common.Interfaces;
using Atlas.Domain.Entities.I4Pro;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Atlas.Infrastructure.Data
{
   public partial class I4ProContext : DbContext, II4ProDbContext
    {
        public I4ProContext()
        {
        }

        public I4ProContext(DbContextOptions<I4ProContext> options)
            : base(options)
        {
            this.Database.SetCommandTimeout(300);
        }
        public virtual DbSet<VApoliceCorrSegurado> VApoliceCorrSegurado { get; set; }
        public virtual DbSet<VSinistroCovidSusep> VSinistroCovidSusep { get; set; }
        [Obsolete]
        public virtual DbQuery<QProdutosAtivos> QProdutosAtivos { get; set; }
        [Obsolete]
        public virtual DbQuery<QPViagemPrecoCoberturaBasicaImportacao> QPViagemPrecoCoberturaBasicaImportacao { get; set; }
        [Obsolete]
        public virtual DbQuery<QPViagemPrecoCoberturaAdicionalImportacao> QPViagemPrecoCoberturaAdicionalImportacao { get; set; }

//         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//         {
//             if (!optionsBuilder.IsConfigured)
//             {
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                 optionsBuilder.UseSqlServer("Server=SRVOMT303;Database=ominterp_homolog;User Id=usrAtlas;Password=#r4o2o15ZwMB%20");
//             }
//         }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VSinistroCovidSusep>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_sinistro_covid_susep");

                entity.Property(e => e.CodCia)
                    .HasColumnName("COD_CIA")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DataAviso)
                    .HasColumnName("DATA_AVISO")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataFim)
                    .HasColumnName("DATA_FIM")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataOcorr)
                    .HasColumnName("DATA_OCORR")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DtIdentificacao)
                    .HasColumnName("DT_IDENTIFICACAO")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Gruporamo)
                    .HasColumnName("GRUPORAMO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Idade).HasColumnName("IDADE");

                entity.Property(e => e.Mesano)
                    .HasColumnName("MESANO")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Numsin).HasColumnName("NUMSIN");

                entity.Property(e => e.StatusSin)
                    .IsRequired()
                    .HasColumnName("STATUS_SIN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Uf)
                    .IsRequired()
                    .HasColumnName("UF")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ValorSin)
                    .HasColumnName("VALOR_SIN")
                    .HasColumnType("numeric(38, 2)");
            });

            modelBuilder.Entity<VApoliceCorrSegurado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_apolice_corr_segurado");

                entity.Property(e => e.CdApolice)
                    .HasColumnName("cd_apolice")
                    .HasColumnType("numeric(15, 0)");

                entity.Property(e => e.CdCorretor).HasColumnName("cd_corretor");

                entity.Property(e => e.CdProposta).HasColumnName("cd_proposta");

                entity.Property(e => e.CdSusep)
                    .HasColumnName("cd_susep")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CepSegurad)
                    .HasColumnName("cep_segurad")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DtEmissaoApolice)
                    .HasColumnName("dt_emissao_apolice")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DtNascSeg)
                    .HasColumnName("dt_nasc_seg")
                    .HasColumnType("datetime");

                entity.Property(e => e.NmCorretor)
                    .HasColumnName("nm_corretor")
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.NmSegurado)
                    .HasColumnName("nm_segurado")
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.NrBilhete)
                    .HasColumnName("nr_bilhete")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrCertificado).HasColumnName("nr_certificado");

                entity.Property(e => e.NrCnpjCpfCli).HasColumnName("nr_cnpj_cpf_cli");

                entity.Property(e => e.SexoSegurado)
                    .HasColumnName("sexo_segurado")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
