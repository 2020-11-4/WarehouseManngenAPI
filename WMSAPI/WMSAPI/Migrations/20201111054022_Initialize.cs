using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WMSAPI.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administrators",
                columns: table => new
                {
                    Aid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarehouseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginPjone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AState = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrators", x => x.Aid);
                });

            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    Gid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Rsesrvoirare = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionGoods = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.Gid);
                });

            migrationBuilder.CreateTable(
                name: "Mission",
                columns: table => new
                {
                    Mid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tasknumber = table.Column<int>(type: "int", nullable: false),
                    MissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sid = table.Column<int>(type: "int", nullable: false),
                    Hid = table.Column<int>(type: "int", nullable: false),
                    Mint = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mission", x => x.Mid);
                });

            migrationBuilder.CreateTable(
                name: "Privilege",
                columns: table => new
                {
                    Pid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KId = table.Column<int>(type: "int", nullable: false),
                    AId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Privilege", x => x.Pid);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Pid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Classes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductStandard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Measure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LnventorySettings = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Pid);
                });

            migrationBuilder.CreateTable(
                name: "Warehous",
                columns: table => new
                {
                    Wid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuperiorWarehouse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arrangr = table.Column<int>(type: "int", nullable: false),
                    WarehuoseAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetailedAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseEntities = table.Column<bool>(type: "bit", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehous", x => x.Wid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrators");

            migrationBuilder.DropTable(
                name: "Goods");

            migrationBuilder.DropTable(
                name: "Mission");

            migrationBuilder.DropTable(
                name: "Privilege");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Warehous");
        }
    }
}
