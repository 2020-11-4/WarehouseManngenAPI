using Microsoft.EntityFrameworkCore.Migrations;

namespace WMSAPI.Migrations
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Warehous");

            migrationBuilder.DropColumn(
                name: "WarehouseName",
                table: "Administrators");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Goods",
                newName: "IID");

            migrationBuilder.AddColumn<int>(
                name: "Kid",
                table: "Administrators",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Wid",
                table: "Administrators",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Sid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Snumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
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

            migrationBuilder.DropColumn(
                name: "Kid",
                table: "Administrators");

            migrationBuilder.DropColumn(
                name: "Wid",
                table: "Administrators");

            migrationBuilder.RenameColumn(
                name: "IID",
                table: "Goods",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "WarehouseName",
                table: "Administrators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Warehous",
                columns: table => new
                {
                    Wid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Arrangr = table.Column<int>(type: "int", nullable: false),
                    DetailedAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    SuperiorWarehouse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseEntities = table.Column<bool>(type: "bit", nullable: false),
                    WarehouseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehuoseAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehous", x => x.Wid);
                });
        }
    }
}
