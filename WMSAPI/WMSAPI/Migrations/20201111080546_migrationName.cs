using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WMSAPI.Migrations
{
    public partial class migrationName : Migration
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
                name: "Audits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Auditmoney = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Auditstatus = table.Column<bool>(type: "bit", nullable: false),
                    Auditopinion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Allocationdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audits", x => x.Id);
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
                name: "Itemdetails",
                columns: table => new
                {
                    XID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Approvalnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Turnoverbasket = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itemdetails", x => x.XID);
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
                name: "Productlist",
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
                    table.PrimaryKey("PK_Productlist", x => x.Pid);
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
                name: "Replenishments",
                columns: table => new
                {
                    IDX = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Replenishodd = table.Column<int>(type: "int", nullable: false),
                    ReplenishDate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Replenishments", x => x.IDX);
                });

            migrationBuilder.CreateTable(
                name: "Singlerows",
                columns: table => new
                {
                    IDX = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Requisition = table.Column<int>(type: "int", nullable: false),
                    Tuneout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transferred = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Allocationdate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Allotpeople = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Auditstate = table.Column<int>(type: "int", nullable: false),
                    Allotcondition = table.Column<int>(type: "int", nullable: false),
                    Framnumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Singlerows", x => x.IDX);
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
                name: "Administrators");

            migrationBuilder.DropTable(
                name: "Arrival");

            migrationBuilder.DropTable(
                name: "Audits");

            migrationBuilder.DropTable(
                name: "Goods");

            migrationBuilder.DropTable(
                name: "Inventorylist");

            migrationBuilder.DropTable(
                name: "Itemdetails");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "Mission");

            migrationBuilder.DropTable(
                name: "Privilege");

            migrationBuilder.DropTable(
                name: "Procurement");

            migrationBuilder.DropTable(
                name: "product");

            migrationBuilder.DropTable(
                name: "Productlist");

            migrationBuilder.DropTable(
                name: "Purchasing");

            migrationBuilder.DropTable(
                name: "Replenishments");

            migrationBuilder.DropTable(
                name: "Singlerows");

            migrationBuilder.DropTable(
                name: "Supplies");

            migrationBuilder.DropTable(
                name: "Warehous");

            migrationBuilder.DropTable(
                name: "Workorder");
        }
    }
}
