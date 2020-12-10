using Microsoft.EntityFrameworkCore.Migrations;

namespace IT3047Final.Migrations.Trail
{
    public partial class Trailmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    trailName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    parkName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trailRating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trails", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trails");
        }
    }
}
