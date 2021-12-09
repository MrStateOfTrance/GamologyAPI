using Microsoft.EntityFrameworkCore.Migrations;

namespace GamologyAPI.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Genero = table.Column<string>(nullable: false),
                    Desarrollador = table.Column<string>(nullable: false),
                    Distribuidor = table.Column<string>(nullable: false),
                    Fechalanzamiento = table.Column<string>(nullable: false),
                    Plataforma = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
