using Microsoft.EntityFrameworkCore;
using SE.WebInfrastrutures.Models;
using SE.WebInfrastrutures.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SE.WebInfrastrutures.Data
{
    public class SEDbContext : DbContext
    {
        public SEDbContext(DbContextOptions<SEDbContext> options) : base(options) { }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Product> Products { get; set; }
        public Repository<Post> PostRepos { get; set; }
    }
}
