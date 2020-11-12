using Microsoft.EntityFrameworkCore.Migrations;

namespace WMSAPI.Migrations
{
    public partial class LImstt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Sid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Snumber = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    SName = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Sid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
