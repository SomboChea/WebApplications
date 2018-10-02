using Microsoft.EntityFrameworkCore;
using SE.WebServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SE.WebServices.Data
{
    public class SEDbContext : DbContext
    {
        public SEDbContext(DbContextOptions<SEDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
