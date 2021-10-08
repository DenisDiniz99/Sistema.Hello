using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema.Hello.Data.Migrations
{
    public partial class Migr2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimentos_Assuntos_AssuntoAtendimentoId",
                table: "Atendimentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Atendimentos_Historicos_HistoricoAtendimentoId",
                table: "Atendimentos");

            migrationBuilder.DropTable(
                name: "Historicos");

            migrationBuilder.DropIndex(
                name: "IX_Atendimentos_AssuntoAtendimentoId",
                table: "Atendimentos");

            migrationBuilder.DropIndex(
                name: "IX_Atendimentos_HistoricoAtendimentoId",
                table: "Atendimentos");

            migrationBuilder.DropColumn(
                name: "AssuntoAtendimentoId",
                table: "Atendimentos");

            migrationBuilder.DropColumn(
                name: "AssuntoId",
                table: "Atendimentos");

            migrationBuilder.DropColumn(
                name: "HistoricoAtendimentoId",
                table: "Atendimentos");

            migrationBuilder.DropColumn(
                name: "Observacao",
                table: "Atendimentos");

            migrationBuilder.DropColumn(
                name: "TipoAtendimento",
                table: "Atendimentos");

            migrationBuilder.RenameColumn(
                name: "HistoricoId",
                table: "Atendimentos",
                newName: "AgendamentoId");

            migrationBuilder.AddColumn<Guid>(
                name: "SecretariaId",
                table: "Setores",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAtend",
                table: "Atendimentos",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Atendimentos",
                type: "varchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "HoraAtend",
                table: "Atendimentos",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Agendamentos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataAtend = table.Column<DateTime>(type: "datetime", nullable: false),
                    HoraAtend = table.Column<DateTime>(type: "datetime", nullable: false),
                    TipoAtendimento = table.Column<int>(type: "int", nullable: false),
                    Protocolo_NumProtocolo = table.Column<int>(type: "int", nullable: true),
                    CidadaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssuntoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssuntoAtendimentoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SetorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ColaboradorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agendamentos_Assuntos_AssuntoAtendimentoId",
                        column: x => x.AssuntoAtendimentoId,
                        principalTable: "Assuntos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Agendamentos_Calaboradores_ColaboradorId",
                        column: x => x.ColaboradorId,
                        principalTable: "Calaboradores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agendamentos_Cidadaos_CidadaoId",
                        column: x => x.CidadaoId,
                        principalTable: "Cidadaos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agendamentos_Setores_SetorId",
                        column: x => x.SetorId,
                        principalTable: "Setores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Secretarias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TituloSecretaria = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secretarias", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Setores_SecretariaId",
                table: "Setores",
                column: "SecretariaId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimentos_AgendamentoId",
                table: "Atendimentos",
                column: "AgendamentoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_AssuntoAtendimentoId",
                table: "Agendamentos",
                column: "AssuntoAtendimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_CidadaoId",
                table: "Agendamentos",
                column: "CidadaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_ColaboradorId",
                table: "Agendamentos",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_SetorId",
                table: "Agendamentos",
                column: "SetorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimentos_Agendamentos_AgendamentoId",
                table: "Atendimentos",
                column: "AgendamentoId",
                principalTable: "Agendamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Setores_Secretarias_SecretariaId",
                table: "Setores",
                column: "SecretariaId",
                principalTable: "Secretarias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimentos_Agendamentos_AgendamentoId",
                table: "Atendimentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Setores_Secretarias_SecretariaId",
                table: "Setores");

            migrationBuilder.DropTable(
                name: "Agendamentos");

            migrationBuilder.DropTable(
                name: "Secretarias");

            migrationBuilder.DropIndex(
                name: "IX_Setores_SecretariaId",
                table: "Setores");

            migrationBuilder.DropIndex(
                name: "IX_Atendimentos_AgendamentoId",
                table: "Atendimentos");

            migrationBuilder.DropColumn(
                name: "SecretariaId",
                table: "Setores");

            migrationBuilder.DropColumn(
                name: "DataAtend",
                table: "Atendimentos");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Atendimentos");

            migrationBuilder.DropColumn(
                name: "HoraAtend",
                table: "Atendimentos");

            migrationBuilder.RenameColumn(
                name: "AgendamentoId",
                table: "Atendimentos",
                newName: "HistoricoId");

            migrationBuilder.AddColumn<Guid>(
                name: "AssuntoAtendimentoId",
                table: "Atendimentos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AssuntoId",
                table: "Atendimentos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "HistoricoAtendimentoId",
                table: "Atendimentos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Observacao",
                table: "Atendimentos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoAtendimento",
                table: "Atendimentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Atendimentos_AssuntoAtendimentoId",
                table: "Atendimentos",
                column: "AssuntoAtendimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimentos_HistoricoAtendimentoId",
                table: "Atendimentos",
                column: "HistoricoAtendimentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimentos_Assuntos_AssuntoAtendimentoId",
                table: "Atendimentos",
                column: "AssuntoAtendimentoId",
                principalTable: "Assuntos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimentos_Historicos_HistoricoAtendimentoId",
                table: "Atendimentos",
                column: "HistoricoAtendimentoId",
                principalTable: "Historicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
