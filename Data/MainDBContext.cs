using Microsoft.EntityFrameworkCore;
using aspnetcoregraphql.Models;
using aspnetcoregraphql.Models.Entities;

namespace aspnetcoregraphql.Data
{
    public class MainDBContext : DbContext
    {
        public MainDBContext(DbContextOptions options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Category> Cateogries {get; set;}
        public DbSet<Product> Products {get; set;}
    }
}