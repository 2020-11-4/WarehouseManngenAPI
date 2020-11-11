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
        public DbSet<A_Administrator> Administrators { get; set; }
        public DbSet<G_Goods> Goods { get; set; }
        public DbSet<M_Mission> Mission { get; set; }
        public DbSet<P_Privilege> Privilege { get; set; }
        public DbSet<P_Product> Product { get; set; }
        public DbSet<W_Warehous> Warehous { get; set; }
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
