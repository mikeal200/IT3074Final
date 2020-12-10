using Microsoft.EntityFrameworkCore.Migrations;

namespace IT3047Final.Migrations.Trail
{
    public partial class trailinit : Migration
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

            migrationBuilder.InsertData(
                table: "Trails",
                columns: new[] { "ID", "parkName", "trailName", "trailRating" },
                values: new object[,]
                {
                    { 1, "Daniel Boone National Forest", "Van Hook Falls and Cane Creek Valley", 4 },
                    { 2, "Daniel Boone National Forest", "Gray's Arch Trail Loop", 4 },
                    { 3, "Daniel Boone National Forest", "Sky Bridge Red River Gorge", 5 },
                    { 4, "Daniel Boone National Forest", "Double Arch Trail", 5 },
                    { 5, "Little Miami State Park", "Little Miami Scenic Trail", 4 },
                    { 6, "Keehner Park", "Keehner Park Trail", 3 },
                    { 7, "Pine Hill Park", "Pine Trails", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trails");
        }
    }
}
