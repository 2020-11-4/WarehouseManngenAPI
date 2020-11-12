using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMSAPI.Model;

namespace WMSAPI.Data
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> options)
           : base(options)
        {
        }
        //申文杰
        public DbSet<Administrators> Administrators { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Mission> Mission { get; set; }
        public DbSet<Privilege> Privilege { get; set; }
        public DbSet<Productlist> Productlist { get; set; }
        public DbSet<Warehous> Warehous { get; set; }

        //张春雨
        public DbSet<Purchasing> Purchasing { get; set; }//采购表
        public DbSet<Material> Material { get; set; }//原料表
        public DbSet<Supplies> Supplies { get; set; }//物料表
        public DbSet<Arrival> Arrival { get; set; }//到货表
        public DbSet<Procurement> Procurement { get; set; }//采购入库表
        public DbSet<Inventorylist> Inventorylist { get; set; }//入库明细表
        public DbSet<product> product { get; set; }//产品表
        public DbSet<Workorder> Workorder { get; set; }//产品表
        public DbSet<Audits> Audits { get; set; }
        public DbSet<Itemdetails>  Itemdetails { get; set; }
        public DbSet<Replenishments> Replenishments { get; set; }
        public DbSet<Singlerows> Singlerows { get; set; }
        public DbSet<Distributor> Distributor { get; set; }
        public DbSet<Frmloss> Frmlosses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Frmloss>().ToTable("Frmlosses");
            modelBuilder.Entity<Administrators>().ToTable("Administrators");
            modelBuilder.Entity<Goods>().ToTable("Goods");
            modelBuilder.Entity<Mission>().ToTable("Mission");
            modelBuilder.Entity<Privilege>().ToTable("Privilege");
            modelBuilder.Entity<Productlist>().ToTable("Productlist");
            modelBuilder.Entity<Warehous>().ToTable("Warehous");
            modelBuilder.Entity<Purchasing>().ToTable("Purchasing");
            modelBuilder.Entity<Material>().ToTable("Material");
            modelBuilder.Entity<Supplies>().ToTable("Supplies");
            modelBuilder.Entity<Arrival>().ToTable("Arrival");
            modelBuilder.Entity<Procurement>().ToTable("Procurement");
            modelBuilder.Entity<Inventorylist>().ToTable("Inventorylist");
            modelBuilder.Entity<product>().ToTable("product");
            modelBuilder.Entity<Distributor>().ToTable("Suppliers");
            modelBuilder.Entity<Workorder>().ToTable("Workorder");
            modelBuilder.Entity<Singlerows>().ToTable("Singlerows");
            modelBuilder.Entity<Audits>().ToTable("Audits");
            modelBuilder.Entity<Itemdetails>().ToTable("Itemdetails");
            modelBuilder.Entity<Replenishments>().ToTable("Replenishments");
        }
    }
}
