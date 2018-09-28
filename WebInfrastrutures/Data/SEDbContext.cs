using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SE.WebInfrastrutures
{
    public class SEDbContext : DbContext
    {
        public SEDbContext(DbContextOptions<SEDbContext> options) : base(options) { }
        public DbSet<object> GetDbSet { get; set; } 
    }
}
