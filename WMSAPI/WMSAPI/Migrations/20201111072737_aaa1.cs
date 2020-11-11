using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WMSAPI.Migrations
{
    public partial class aaa1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arrival",
                columns: table => new
                {
                    Arrival_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Arrivalregistration = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Anumbers = table.Column<int>(type: "int", nullable: false),
                    Asupplier = table.Column<int>(type: "int", nullable: false),
                    Acategory = table.Column<int>(type: "int", nullable: false),
                    Atype = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Adelivery = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arrival", x => x.Arrival_Id);
                });

            migrationBuilder.CreateTable(
                name: "Inventorylist",
                columns: table => new
                {
                    Inventorylist_NId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iwarehouse = table.Column<int>(type: "int", nullable: false),
                    Icategory = table.Column<int>(type: "int", nullable: false),
                    Icoding = table.Column<int>(type: "int", nullable: false),
                    Ibatch = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Iarticle = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Iunload = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Iunit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Istoreroom = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventorylist", x => x.Inventorylist_NId);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    Material_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mcoding = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Mwarm = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Mspecification = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mquantity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mstorage = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.Material_Id);
                });

            migrationBuilder.CreateTable(
                name: "Procurement",
                columns: table => new
                {
                    Procurement_PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PAOG = table.Column<int>(type: "int", nullable: false),
                    Purchase = table.Column<int>(type: "int", nullable: false),
                    Storagecontent = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Inventorystatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procurement", x => x.Procurement_PId);
                });

            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    Product_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCategory = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Pcoding = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Pspecification = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Punit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Pamount = table.Column<int>(type: "int", nullable: false),
                    Pgoods = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product", x => x.Product_Id);
                });

            migrationBuilder.CreateTable(
                name: "Purchasing",
                columns: table => new
                {
                    Purchasing_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ordernumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Supplier = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Purchasedate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Agent = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    State = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchasing", x => x.Purchasing_Id);
                });

            migrationBuilder.CreateTable(
                name: "Supplies",
                columns: table => new
                {
                    Supplies_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Materialcode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    GS1 = table.Column<int>(type: "int", nullable: false),
                    MaName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MAttribute = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Mspecification = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MUnit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MQuantity = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Mlasttoy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Munitprice = table.Column<int>(type: "int", nullable: false),
                    Mdateproduced = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mrequiredtime = table.Column<int>(type: "int", nullable: false),
                    Mremark = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplies", x => x.Supplies_Id);
                });

            migrationBuilder.CreateTable(
                name: "Workorder",
                columns: table => new
                {
                    workorder_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Wodd = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    warm = table.Column<int>(type: "int", nullable: false),
                    Wcount = table.Column<int>(type: "int", nullable: false),
                    Wtype = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    WName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Wtime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Wcommodity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workorder", x => x.workorder_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arrival");

            migrationBuilder.DropTable(
                name: "Inventorylist");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "Procurement");

            migrationBuilder.DropTable(
                name: "product");

            migrationBuilder.DropTable(
                name: "Purchasing");

            migrationBuilder.DropTable(
                name: "Supplies");

            migrationBuilder.DropTable(
                name: "Workorder");
        }
    }
}
