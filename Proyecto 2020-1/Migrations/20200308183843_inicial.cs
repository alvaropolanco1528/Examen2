using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_2020_1.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "granjas",
                columns: table => new
                {
                    MadreId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Raza = table.Column<string>(nullable: true),
                    Corral = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_granjas", x => x.MadreId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "granjas");
        }
    }
}
