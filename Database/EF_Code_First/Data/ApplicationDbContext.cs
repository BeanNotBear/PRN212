using Microsoft.EntityFrameworkCore;
using EF_Code_First.Models;

namespace EF_Code_First.Data
{
    public class ApplicationDbContext : DbContext
    {
        DbSet<Category> Categories { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1 ,Name = "Beverages" },
                new Category { Id = 2 , Name = "Condiments" },
                new Category { Id = 3 , Name = "Confections" }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
