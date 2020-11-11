using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMSAPI.Model;

namespace WMSAPI
{
    public class MYDBContext:DbContext
    {
        public MYDBContext(DbContextOptions<MYDBContext> options) : base(options) { }

        public DbSet<Cdelivery> x { get; set; }
    }
}
