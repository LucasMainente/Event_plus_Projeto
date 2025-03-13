using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Event_.Migrations
{
    /// <inheritdoc />
    public partial class Event : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instituicao",
                columns: table => new
                {
                    IdInstituicao = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CNPJ = table.Column<string>(type: "VARCHAR(50)", maxLength: 14, nullable: false),
                    NomeFantasia = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Endereco = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instituicao", x => x.IdInstituicao);
                });

            migrationBuilder.CreateTable(
                name: "TipoEvento",
                columns: table => new
                {
                    TipoEventoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TituloTipoEvento = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEvento", x => x.TipoEventoID);
                });

            migrationBuilder.CreateTable(
                name: "TiposUsuario",
                columns: table => new
                {
                    TipoUsuarioID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TituloTipoUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposUsuario", x => x.TipoUsuarioID);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Senha = table.Column<string>(type: "VARCHAR(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Evento",
                columns: table => new
                {
                    IdEvento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTipoEvento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdInstituicao = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstituicaoIdInstituicao = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DataEvento = table.Column<DateTime>(type: "DATE", nullable: false),
                    NomeEvento = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Descricao = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    IdTipoUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento", x => x.IdEvento);
                    table.ForeignKey(
                        name: "FK_Evento_Instituicao_InstituicaoIdInstituicao",
                        column: x => x.InstituicaoIdInstituicao,
                        principalTable: "Instituicao",
                        principalColumn: "IdInstituicao");
                    table.ForeignKey(
                        name: "FK_Evento_TipoEvento_IdTipoEvento",
                        column: x => x.IdTipoEvento,
                        principalTable: "TipoEvento",
                        principalColumn: "TipoEventoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evento_TiposUsuario_IdTipoUsuario",
                        column: x => x.IdTipoUsuario,
                        principalTable: "TiposUsuario",
                        principalColumn: "TipoUsuarioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComentarioEventos",
                columns: table => new
                {
                    ComentarioID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Exibir = table.Column<bool>(type: "BIT", nullable: false),
                    UsuarioID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComentarioEventos", x => x.ComentarioID);
                    table.ForeignKey(
                        name: "FK_ComentarioEventos_Evento_EventoID",
                        column: x => x.EventoID,
                        principalTable: "Evento",
                        principalColumn: "IdEvento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComentarioEventos_Usuario_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Presencas",
                columns: table => new
                {
                    PresencaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presencas", x => x.PresencaID);
                    table.ForeignKey(
                        name: "FK_Presencas_Evento_EventoID",
                        column: x => x.EventoID,
                        principalTable: "Evento",
                        principalColumn: "IdEvento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Presencas_Usuario_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComentarioEventos_EventoID",
                table: "ComentarioEventos",
                column: "EventoID");

            migrationBuilder.CreateIndex(
                name: "IX_ComentarioEventos_UsuarioID",
                table: "ComentarioEventos",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_IdTipoEvento",
                table: "Evento",
                column: "IdTipoEvento");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_IdTipoUsuario",
                table: "Evento",
                column: "IdTipoUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_InstituicaoIdInstituicao",
                table: "Evento",
                column: "InstituicaoIdInstituicao");

            migrationBuilder.CreateIndex(
                name: "IX_Instituicao_CNPJ",
                table: "Instituicao",
                column: "CNPJ",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Presencas_EventoID",
                table: "Presencas",
                column: "EventoID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Presencas_UsuarioID",
                table: "Presencas",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Email",
                table: "Usuario",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComentarioEventos");

            migrationBuilder.DropTable(
                name: "Presencas");

            migrationBuilder.DropTable(
                name: "Evento");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Instituicao");

            migrationBuilder.DropTable(
                name: "TipoEvento");

            migrationBuilder.DropTable(
                name: "TiposUsuario");
        }
    }
}
