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
        public DbSet<P_Product> Product { get; set; }
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<A_Administrator>().ToTable("Administrators");
            modelBuilder.Entity<G_Goods>().ToTable("Goods");
            modelBuilder.Entity<M_Mission>().ToTable("Mission");
            modelBuilder.Entity<P_Privilege>().ToTable("Privilege");
            modelBuilder.Entity<P_Product>().ToTable("Product");
            modelBuilder.Entity<W_Warehous>().ToTable("Warehous");
        }
    }
}
