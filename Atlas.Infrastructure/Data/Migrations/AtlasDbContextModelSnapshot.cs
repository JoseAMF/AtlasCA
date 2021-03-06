﻿// <auto-generated />
using System;
using Atlas.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Atlas.Infrastructure.Data.Migrations
{
    [DbContext(typeof(AtlasDbContext))]
    partial class AtlasDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Atlas.Domain.Entities.Atlas.Ouvidoria.Assunto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("IdAssunto")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ouvidoria_Assuntos");
                });

            modelBuilder.Entity("Atlas.Domain.Entities.Atlas.Ouvidoria.AssuntoMotivo", b =>
                {
                    b.Property<int>("AssuntoId")
                        .HasColumnType("int");

                    b.Property<int>("MotivoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AssuntoId", "MotivoId");

                    b.HasIndex("MotivoId");

                    b.ToTable("Ouvidoria_AssuntoMotivo");
                });

            modelBuilder.Entity("Atlas.Domain.Entities.Atlas.Ouvidoria.CanalReclamacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("IdCanalReclamacao")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ouvidoria_CanaisReclamacoes");
                });

            modelBuilder.Entity("Atlas.Domain.Entities.Atlas.Ouvidoria.CanalVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("IdCanalVenda")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ouvidoria_CanaisVenda");
                });

            modelBuilder.Entity("Atlas.Domain.Entities.Atlas.Ouvidoria.Motivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("IdMotivo")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ouvidoria_Motivos");
                });

            modelBuilder.Entity("Atlas.Domain.Entities.Atlas.Ouvidoria.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("IdStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ouvidoria_Status");
                });

            modelBuilder.Entity("Atlas.Domain.Entities.Atlas.Permission", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Permissoes");

                    b.HasData(
                        new
                        {
                            Id = 0,
                            Name = "Cotacao_User"
                        },
                        new
                        {
                            Id = 1,
                            Name = "Cotacao_Cotador"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cotacao_Admin"
                        },
                        new
                        {
                            Id = 3,
                            Name = "PREMIUM_User"
                        },
                        new
                        {
                            Id = 4,
                            Name = "PREMIUM_Moderator"
                        },
                        new
                        {
                            Id = 5,
                            Name = "PREMIUM_Admin"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Cupom_Leitura"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Cupom_Escrita"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Cupom_Admin"
                        },
                        new
                        {
                            Id = 9,
                            Name = "CancelamentoBilhete_Leitura"
                        },
                        new
                        {
                            Id = 10,
                            Name = "CancelamentoBilhete_Escrita"
                        },
                        new
                        {
                            Id = 11,
                            Name = "CancelamentoBilhete_Admin"
                        },
                        new
                        {
                            Id = 12,
                            Name = "CadastroPessoa_Leitura"
                        },
                        new
                        {
                            Id = 13,
                            Name = "CadastroPessoa_Escrita"
                        },
                        new
                        {
                            Id = 14,
                            Name = "CadastroPessoa_Admin"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Atlas_Admin"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Produto_Leitura"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Produto_Escrita"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Produto_Admin"
                        },
                        new
                        {
                            Id = 19,
                            Name = "VendaLote_Admin"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Comissao_Leitura"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Comissao_Escrita"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Comissao_Admin"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Ouvidoria"
                        },
                        new
                        {
                            Id = 24,
                            Name = "COVID"
                        },
                        new
                        {
                            Id = 25,
                            Name = "LGPD"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Pareport"
                        });
                });

            modelBuilder.Entity("Atlas.Domain.Entities.Atlas.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Ativo")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Username");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Atlas.Domain.Entities.Atlas.UserPermission", b =>
                {
                    b.Property<string>("UserUsername")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.HasKey("UserUsername", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("UsuariosPermissoes");
                });

            modelBuilder.Entity("Atlas.Domain.Entities.Atlas.Ouvidoria.AssuntoMotivo", b =>
                {
                    b.HasOne("Atlas.Domain.Entities.Atlas.Ouvidoria.Assunto", "Assunto")
                        .WithMany("AssuntoMotivos")
                        .HasForeignKey("AssuntoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Atlas.Domain.Entities.Atlas.Ouvidoria.Motivo", "Motivo")
                        .WithMany("AssuntoMotivos")
                        .HasForeignKey("MotivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Atlas.Domain.Entities.Atlas.UserPermission", b =>
                {
                    b.HasOne("Atlas.Domain.Entities.Atlas.Permission", "Permission")
                        .WithMany("UserPermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Atlas.Domain.Entities.Atlas.User", "User")
                        .WithMany("UserPermissions")
                        .HasForeignKey("UserUsername")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
