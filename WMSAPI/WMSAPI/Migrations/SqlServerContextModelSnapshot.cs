﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WMSAPI.Data;

namespace WMSAPI.Migrations
{
    [DbContext(typeof(SqlServerContext))]
    partial class SqlServerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WMSAPI.Model.A_Administrator", b =>
                {
                    b.Property<int>("Aid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("AState")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LoginPjone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarehouseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Aid");

                    b.ToTable("Administrators");
                });

            modelBuilder.Entity("WMSAPI.Model.G_Goods", b =>
                {
                    b.Property<int>("Gid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DescriptionGoods")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Rsesrvoirare")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Gid");

                    b.ToTable("Goods");
                });

            modelBuilder.Entity("WMSAPI.Model.M_Mission", b =>
                {
                    b.Property<int>("Mid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Hid")
                        .HasColumnType("int");

                    b.Property<int>("Mint")
                        .HasColumnType("int");

                    b.Property<DateTime>("MissionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Sid")
                        .HasColumnType("int");

                    b.Property<int>("Tasknumber")
                        .HasColumnType("int");

                    b.HasKey("Mid");

                    b.ToTable("Mission");
                });

            modelBuilder.Entity("WMSAPI.Model.P_Privilege", b =>
                {
                    b.Property<int>("Pid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AId")
                        .HasColumnType("int");

                    b.Property<int>("KId")
                        .HasColumnType("int");

                    b.HasKey("Pid");

                    b.ToTable("Privilege");
                });

            modelBuilder.Entity("WMSAPI.Model.P_Product", b =>
                {
                    b.Property<int>("Pid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Classes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LnventorySettings")
                        .HasColumnType("int");

                    b.Property<string>("Measure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductStandard")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Pid");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("WMSAPI.Model.W_Warehous", b =>
                {
                    b.Property<int>("Wid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Arrangr")
                        .HasColumnType("int");

                    b.Property<string>("DetailedAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.Property<string>("SuperiorWarehouse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarehouseCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("WarehouseEntities")
                        .HasColumnType("bit");

                    b.Property<string>("WarehouseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarehuoseAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Wid");

                    b.ToTable("Warehous");
                });

            modelBuilder.Entity("WMSAPI.Model.Z_Arrival", b =>
                {
                    b.Property<int>("Arrival_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Acategory")
                        .HasColumnType("int");

                    b.Property<string>("AddType")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("Adelivery")
                        .HasColumnType("datetime2");

                    b.Property<int>("Anumbers")
                        .HasColumnType("int");

                    b.Property<string>("Arrivalregistration")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Asupplier")
                        .HasColumnType("int");

                    b.Property<string>("Atype")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Arrival_Id");

                    b.ToTable("Arrival");
                });

            modelBuilder.Entity("WMSAPI.Model.Z_Inventorylist", b =>
                {
                    b.Property<int>("Inventorylist_NId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Iarticle")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Ibatch")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Icategory")
                        .HasColumnType("int");

                    b.Property<int>("Icoding")
                        .HasColumnType("int");

                    b.Property<string>("Istoreroom")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Iunit")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Iunload")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Iwarehouse")
                        .HasColumnType("int");

                    b.HasKey("Inventorylist_NId");

                    b.ToTable("Inventorylist");
                });

            modelBuilder.Entity("WMSAPI.Model.Z_Material", b =>
                {
                    b.Property<int>("Material_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("MName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Mcoding")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Mquantity")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mspecification")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mstorage")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Mwarm")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Material_Id");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("WMSAPI.Model.Z_Procurement", b =>
                {
                    b.Property<int>("Procurement_PId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Inventorystatus")
                        .HasColumnType("int");

                    b.Property<int>("PAOG")
                        .HasColumnType("int");

                    b.Property<int>("Purchase")
                        .HasColumnType("int");

                    b.Property<string>("Storagecontent")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Procurement_PId");

                    b.ToTable("Procurement");
                });

            modelBuilder.Entity("WMSAPI.Model.Z_Purchasing", b =>
                {
                    b.Property<int>("Purchasing_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Agent")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Ordernumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("Purchasedate")
                        .HasColumnType("datetime2");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<int>("Supplier")
                        .HasColumnType("int");

                    b.HasKey("Purchasing_Id");

                    b.ToTable("Purchasing");
                });

            modelBuilder.Entity("WMSAPI.Model.Z_Supplies", b =>
                {
                    b.Property<int>("Supplies_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("GS1")
                        .HasColumnType("int");

                    b.Property<string>("MAttribute")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MQuantity")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("MUnit")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MaName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Materialcode")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("Mdateproduced")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mlasttoy")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Mremark")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("Mrequiredtime")
                        .HasColumnType("int");

                    b.Property<string>("Mspecification")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Munitprice")
                        .HasColumnType("int");

                    b.HasKey("Supplies_Id");

                    b.ToTable("Supplies");
                });

            modelBuilder.Entity("WMSAPI.Model.Z_Workorder", b =>
                {
                    b.Property<int>("workorder_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("WName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Wcommodity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Wcount")
                        .HasColumnType("int");

                    b.Property<string>("Wodd")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("Wtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Wtype")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("warm")
                        .HasColumnType("int");

                    b.HasKey("workorder_Id");

                    b.ToTable("Workorder");
                });

            modelBuilder.Entity("WMSAPI.Model.Z_product", b =>
                {
                    b.Property<int>("Product_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("PCategory")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Pamount")
                        .HasColumnType("int");

                    b.Property<string>("Pcoding")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Pgoods")
                        .HasColumnType("int");

                    b.Property<string>("Pspecification")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Punit")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Product_Id");

                    b.ToTable("product");
                });
#pragma warning restore 612, 618
        }
    }
}
