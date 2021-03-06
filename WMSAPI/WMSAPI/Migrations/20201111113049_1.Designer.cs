﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WMSAPI.Data;

namespace WMSAPI.Migrations
{
    [DbContext(typeof(SqlServerContext))]
    [Migration("20201111113049_1")]
    partial class _1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
#pragma warning restore 612, 618
        }
    }
}
