using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StockSystem.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.Data
{
    public class StockDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("StockDB"));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
