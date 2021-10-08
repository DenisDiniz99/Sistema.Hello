﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema.Hello.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assuntos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TituloAssunto = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assuntos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cidadaos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Rg = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    DataNasc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TelefoneFixo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DataCad = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Endereco_Rua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco_Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco_Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco_Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco_Cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco_Estado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidadaos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Historicos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Setores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TituloSetor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Endereco_Rua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco_Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco_Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco_Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco_Cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco_Estado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TituloCargo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SrtorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SetorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cargos_Setores_SetorId",
                        column: x => x.SetorId,
                        principalTable: "Setores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Calaboradores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCad = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CargoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calaboradores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calaboradores_Cargos_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Atendimentos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoAtendimento = table.Column<int>(type: "int", nullable: false),
                    Protocolo_NumProtocolo = table.Column<int>(type: "int", nullable: true),
                    CidadaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssuntoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssuntoAtendimentoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ColaboradorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusAtendimento = table.Column<int>(type: "int", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HistoricoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HistoricoAtendimentoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atendimentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Atendimentos_Assuntos_AssuntoAtendimentoId",
                        column: x => x.AssuntoAtendimentoId,
                        principalTable: "Assuntos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Atendimentos_Calaboradores_ColaboradorId",
                        column: x => x.ColaboradorId,
                        principalTable: "Calaboradores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Atendimentos_Cidadaos_CidadaoId",
                        column: x => x.CidadaoId,
                        principalTable: "Cidadaos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Atendimentos_Historicos_HistoricoAtendimentoId",
                        column: x => x.HistoricoAtendimentoId,
                        principalTable: "Historicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atendimentos_AssuntoAtendimentoId",
                table: "Atendimentos",
                column: "AssuntoAtendimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimentos_CidadaoId",
                table: "Atendimentos",
                column: "CidadaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimentos_ColaboradorId",
                table: "Atendimentos",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimentos_HistoricoAtendimentoId",
                table: "Atendimentos",
                column: "HistoricoAtendimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Calaboradores_CargoId",
                table: "Calaboradores",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cargos_SetorId",
                table: "Cargos",
                column: "SetorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atendimentos");

            migrationBuilder.DropTable(
                name: "Assuntos");

            migrationBuilder.DropTable(
                name: "Calaboradores");

            migrationBuilder.DropTable(
                name: "Cidadaos");

            migrationBuilder.DropTable(
                name: "Historicos");

            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropTable(
                name: "Setores");
        }
    }
}
