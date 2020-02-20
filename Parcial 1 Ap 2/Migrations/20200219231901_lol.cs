using Microsoft.EntityFrameworkCore.Migrations;

namespace Parcial_1_Ap_2.Migrations
{
    public partial class lol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inscripcion",
                columns: table => new
                {
                    InscripcionId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Semestre = table.Column<string>(nullable: false),
                    Limite = table.Column<int>(nullable: false),
                    Tomados = table.Column<int>(nullable: false),
                    Disponibles = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscripcion", x => x.InscripcionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inscripcion");
        }
    }
}
