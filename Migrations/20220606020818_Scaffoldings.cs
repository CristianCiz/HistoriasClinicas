using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestHistoriasClinicas.Migrations
{
    public partial class Scaffoldings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "Usuarios");

            migrationBuilder.AddColumn<string>(
                name: "Legajo",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EspecialidadId",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Matricula",
                table: "Persona",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Persona",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Diagnosticos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true),
                    Recomendacion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosticos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoriasClinicas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriasClinicas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Episodios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Motivo = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    FechaYHoraInicio = table.Column<DateTime>(nullable: false),
                    FechaYHoraAlta = table.Column<DateTime>(nullable: true),
                    FechaYHoraCierre = table.Column<DateTime>(nullable: true),
                    EstadoAbierto = table.Column<bool>(nullable: false),
                    HistoriaClinicaId = table.Column<int>(nullable: false),
                    EmpleadoRegistraId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Episodios_Persona_EmpleadoRegistraId",
                        column: x => x.EmpleadoRegistraId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Episodios_HistoriasClinicas_HistoriaClinicaId",
                        column: x => x.HistoriaClinicaId,
                        principalTable: "HistoriasClinicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Dni = table.Column<int>(nullable: false),
                    Telefono = table.Column<int>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    FechaAlta = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    ObraSocial = table.Column<string>(nullable: true),
                    HistoriaClinicaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacientes_HistoriasClinicas_HistoriaClinicaId",
                        column: x => x.HistoriaClinicaId,
                        principalTable: "HistoriasClinicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Epicrisis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EpisodioId = table.Column<int>(nullable: false),
                    MedicoId = table.Column<int>(nullable: false),
                    FechaYHora = table.Column<DateTime>(nullable: false),
                    DiagnosticoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Epicrisis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Epicrisis_Diagnosticos_DiagnosticoId",
                        column: x => x.DiagnosticoId,
                        principalTable: "Diagnosticos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Epicrisis_Episodios_EpisodioId",
                        column: x => x.EpisodioId,
                        principalTable: "Episodios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Epicrisis_Persona_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evoluciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaYHoraInicio = table.Column<DateTime>(nullable: false),
                    FechaYHoraAlta = table.Column<DateTime>(nullable: false),
                    FechaYHoraCierre = table.Column<DateTime>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    EstadoAbierto = table.Column<bool>(nullable: false),
                    MedicoId = table.Column<int>(nullable: true),
                    EpisodioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evoluciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evoluciones_Episodios_EpisodioId",
                        column: x => x.EpisodioId,
                        principalTable: "Episodios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evoluciones_Persona_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EvolucionId = table.Column<int>(nullable: false),
                    Mensaje = table.Column<string>(nullable: true),
                    FechaYHora = table.Column<DateTime>(nullable: false),
                    PersonaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notas_Evoluciones_EvolucionId",
                        column: x => x.EvolucionId,
                        principalTable: "Evoluciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notas_Persona_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persona_EspecialidadId",
                table: "Persona",
                column: "EspecialidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Epicrisis_DiagnosticoId",
                table: "Epicrisis",
                column: "DiagnosticoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Epicrisis_EpisodioId",
                table: "Epicrisis",
                column: "EpisodioId");

            migrationBuilder.CreateIndex(
                name: "IX_Epicrisis_MedicoId",
                table: "Epicrisis",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Episodios_EmpleadoRegistraId",
                table: "Episodios",
                column: "EmpleadoRegistraId");

            migrationBuilder.CreateIndex(
                name: "IX_Episodios_HistoriaClinicaId",
                table: "Episodios",
                column: "HistoriaClinicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Evoluciones_EpisodioId",
                table: "Evoluciones",
                column: "EpisodioId");

            migrationBuilder.CreateIndex(
                name: "IX_Evoluciones_MedicoId",
                table: "Evoluciones",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_EvolucionId",
                table: "Notas",
                column: "EvolucionId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_PersonaId",
                table: "Notas",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_HistoriaClinicaId",
                table: "Pacientes",
                column: "HistoriaClinicaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Especialidades_EspecialidadId",
                table: "Persona",
                column: "EspecialidadId",
                principalTable: "Especialidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Especialidades_EspecialidadId",
                table: "Persona");

            migrationBuilder.DropTable(
                name: "Epicrisis");

            migrationBuilder.DropTable(
                name: "Notas");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Diagnosticos");

            migrationBuilder.DropTable(
                name: "Evoluciones");

            migrationBuilder.DropTable(
                name: "Episodios");

            migrationBuilder.DropTable(
                name: "HistoriasClinicas");

            migrationBuilder.DropIndex(
                name: "IX_Persona_EspecialidadId",
                table: "Persona");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Legajo",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "EspecialidadId",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Matricula",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Persona");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Usuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "Id");
        }
    }
}
