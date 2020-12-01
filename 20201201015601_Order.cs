using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderApplicationPage.Migrations
{
    public partial class Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<int>(type: "int", nullable: false),
                    ShipToFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipToAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipToZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipToCountryCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Number);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
