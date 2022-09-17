using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ovejas.App.persistencia.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cuidadoOvinos",
                columns: table => new
                {
                    cuidadoOvinoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cuidadoOvinos", x => x.cuidadoOvinoId);
                });

            migrationBuilder.CreateTable(
                name: "historiasClinicas",
                columns: table => new
                {
                    historiaClinicaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaAperturaHistoría = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreDueño = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreMedico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historiasClinicas", x => x.historiaClinicaId);
                });

            migrationBuilder.CreateTable(
                name: "medicosVeterinarios",
                columns: table => new
                {
                    medicoVeterinarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarjetaProfesional = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicosVeterinarios", x => x.medicoVeterinarioId);
                });

            migrationBuilder.CreateTable(
                name: "ovejas",
                columns: table => new
                {
                    ovejasId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Raza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreMedicoVeterinario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ovejas", x => x.ovejasId);
                });

            migrationBuilder.CreateTable(
                name: "visitasDomiciliarias",
                columns: table => new
                {
                    visitasDomiciliariasId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Temperatura = table.Column<float>(type: "real", nullable: false),
                    Peso = table.Column<float>(type: "real", nullable: false),
                    FrecuenciaRespiratoria = table.Column<float>(type: "real", nullable: false),
                    FrecuenciaCardiaca = table.Column<float>(type: "real", nullable: false),
                    EstadoAnimo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaVisita = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentoVeterinario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicinasFormuladas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    medicoVeterinarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visitasDomiciliarias", x => x.visitasDomiciliariasId);
                    table.ForeignKey(
                        name: "FK_visitasDomiciliarias_medicosVeterinarios_medicoVeterinarioId",
                        column: x => x.medicoVeterinarioId,
                        principalTable: "medicosVeterinarios",
                        principalColumn: "medicoVeterinarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dueñoOveja",
                columns: table => new
                {
                    dueñoOvejaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ovejasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dueñoOveja", x => x.dueñoOvejaId);
                    table.ForeignKey(
                        name: "FK_dueñoOveja_ovejas_ovejasId",
                        column: x => x.ovejasId,
                        principalTable: "ovejas",
                        principalColumn: "ovejasId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dueñoOveja_ovejasId",
                table: "dueñoOveja",
                column: "ovejasId");

            migrationBuilder.CreateIndex(
                name: "IX_visitasDomiciliarias_medicoVeterinarioId",
                table: "visitasDomiciliarias",
                column: "medicoVeterinarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cuidadoOvinos");

            migrationBuilder.DropTable(
                name: "dueñoOveja");

            migrationBuilder.DropTable(
                name: "historiasClinicas");

            migrationBuilder.DropTable(
                name: "visitasDomiciliarias");

            migrationBuilder.DropTable(
                name: "ovejas");

            migrationBuilder.DropTable(
                name: "medicosVeterinarios");
        }
    }
}
