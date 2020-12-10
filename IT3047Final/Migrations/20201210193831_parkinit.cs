using Microsoft.EntityFrameworkCore.Migrations;

namespace IT3047Final.Migrations
{
    public partial class parkinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    parkName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    parkAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    parkRating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ID", "parkAddress", "parkName", "parkRating" },
                values: new object[,]
                {
                    { 1, "7411 Barret Rd, West Chester Township, OH 45069", "Keehner Park", 3 },
                    { 2, "1720 King Ave, Kings Mills, OH 45034", "Carter Park", 3 },
                    { 3, "19852 OH-664, Logan, OH 43138", "Hocking Hills State Park", 5 },
                    { 4, "11661 State Park Rd, Athens, OH 45701", "Strouds Run State Park", 5 },
                    { 5, "1700 Bypass Rd, London, KY 40744", "Daniel Boone National Forest", 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
