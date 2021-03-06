﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Atlas.Infrastructure.Data.Migrations
{
    public partial class Initial_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ouvidoria_Assuntos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    IdAssunto = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ouvidoria_Assuntos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ouvidoria_CanaisReclamacoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    IdCanalReclamacao = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ouvidoria_CanaisReclamacoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ouvidoria_CanaisVenda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    IdCanalVenda = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ouvidoria_CanaisVenda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ouvidoria_Motivos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    IdMotivo = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ouvidoria_Motivos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ouvidoria_Status",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    IdStatus = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ouvidoria_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Password = table.Column<string>(nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Ativo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "Ouvidoria_AssuntoMotivo",
                columns: table => new
                {
                    AssuntoId = table.Column<int>(nullable: false),
                    MotivoId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ouvidoria_AssuntoMotivo", x => new { x.AssuntoId, x.MotivoId });
                    table.ForeignKey(
                        name: "FK_Ouvidoria_AssuntoMotivo_Ouvidoria_Assuntos_AssuntoId",
                        column: x => x.AssuntoId,
                        principalTable: "Ouvidoria_Assuntos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ouvidoria_AssuntoMotivo_Ouvidoria_Motivos_MotivoId",
                        column: x => x.MotivoId,
                        principalTable: "Ouvidoria_Motivos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuariosPermissoes",
                columns: table => new
                {
                    UserUsername = table.Column<string>(nullable: false),
                    PermissionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosPermissoes", x => new { x.UserUsername, x.PermissionId });
                    table.ForeignKey(
                        name: "FK_UsuariosPermissoes_Permissoes_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuariosPermissoes_Usuarios_UserUsername",
                        column: x => x.UserUsername,
                        principalTable: "Usuarios",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Permissoes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 0, "Cotacao_User" },
                    { 24, "COVID" },
                    { 23, "Ouvidoria" },
                    { 22, "Comissao_Admin" },
                    { 21, "Comissao_Escrita" },
                    { 20, "Comissao_Leitura" },
                    { 19, "VendaLote_Admin" },
                    { 18, "Produto_Admin" },
                    { 17, "Produto_Escrita" },
                    { 16, "Produto_Leitura" },
                    { 15, "Atlas_Admin" },
                    { 14, "CadastroPessoa_Admin" },
                    { 25, "LGPD" },
                    { 13, "CadastroPessoa_Escrita" },
                    { 11, "CancelamentoBilhete_Admin" },
                    { 10, "CancelamentoBilhete_Escrita" },
                    { 9, "CancelamentoBilhete_Leitura" },
                    { 8, "Cupom_Admin" },
                    { 7, "Cupom_Escrita" },
                    { 6, "Cupom_Leitura" },
                    { 5, "PREMIUM_Admin" },
                    { 4, "PREMIUM_Moderator" },
                    { 3, "PREMIUM_User" },
                    { 2, "Cotacao_Admin" },
                    { 1, "Cotacao_Cotador" },
                    { 12, "CadastroPessoa_Leitura" },
                    { 26, "Pareport" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ouvidoria_AssuntoMotivo_MotivoId",
                table: "Ouvidoria_AssuntoMotivo",
                column: "MotivoId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosPermissoes_PermissionId",
                table: "UsuariosPermissoes",
                column: "PermissionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ouvidoria_AssuntoMotivo");

            migrationBuilder.DropTable(
                name: "Ouvidoria_CanaisReclamacoes");

            migrationBuilder.DropTable(
                name: "Ouvidoria_CanaisVenda");

            migrationBuilder.DropTable(
                name: "Ouvidoria_Status");

            migrationBuilder.DropTable(
                name: "UsuariosPermissoes");

            migrationBuilder.DropTable(
                name: "Ouvidoria_Assuntos");

            migrationBuilder.DropTable(
                name: "Ouvidoria_Motivos");

            migrationBuilder.DropTable(
                name: "Permissoes");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
