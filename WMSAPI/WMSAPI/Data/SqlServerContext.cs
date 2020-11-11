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
        public DbSet<A_Administrator> Administrators { get; set; }
        public DbSet<G_Goods> Goods { get; set; }
        public DbSet<M_Mission> Mission { get; set; }
        public DbSet<P_Privilege> Privilege { get; set; }
        public DbSet<Productlist> Productlist { get; set; }
        public DbSet<W_Warehous> Warehous { get; set; }

        //张春雨
        public DbSet<Z_Purchasing> Purchasing { get; set; }//采购表
        public DbSet<Z_Material> Material { get; set; }//原料表
        public DbSet<Z_Supplies> Supplies { get; set; }//物料表
        public DbSet<Z_Arrival> Arrival { get; set; }//到货表
        public DbSet<Z_Procurement> Procurement { get; set; }//采购入库表
        public DbSet<Z_Inventorylist> Inventorylist { get; set; }//入库明细表
        public DbSet<Z_product> product { get; set; }//产品表
        public DbSet<Z_Workorder> Workorder { get; set; }//产品表


        public DbSet<T_audit> Audits { get; set; }
        public DbSet<T_Itemdetails>  Itemdetails { get; set; }
        public DbSet<T_replenishment> Replenishments { get; set; }
        public DbSet<T_singlerow> Singlerows { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<A_Administrator>().ToTable("Administrators");
            modelBuilder.Entity<G_Goods>().ToTable("Goods");
            modelBuilder.Entity<M_Mission>().ToTable("Mission");
            modelBuilder.Entity<P_Privilege>().ToTable("Privilege");
            modelBuilder.Entity<Productlist>().ToTable("Productlist");
            modelBuilder.Entity<W_Warehous>().ToTable("Warehous");
            modelBuilder.Entity<Z_Purchasing>().ToTable("Purchasing");
            modelBuilder.Entity<Z_Material>().ToTable("Material");
            modelBuilder.Entity<Z_Supplies>().ToTable("Supplies");
            modelBuilder.Entity<Z_Arrival>().ToTable("Arrival");
            modelBuilder.Entity<Z_Procurement>().ToTable("Procurement");
            modelBuilder.Entity<Z_Inventorylist>().ToTable("Inventorylist");
            modelBuilder.Entity<Z_product>().ToTable("product");

            modelBuilder.Entity<Z_Workorder>().ToTable("Workorder");

            modelBuilder.Entity<T_singlerow>().ToTable("Singlerows");
            modelBuilder.Entity<T_audit>().ToTable("Audits");
            modelBuilder.Entity<T_Itemdetails>().ToTable("Itemdetails");
            modelBuilder.Entity<T_replenishment>().ToTable("Replenishments");
        }
    }
}
