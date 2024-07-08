using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First.Data
{
    public class ApplicationDbContextFactory
    {
        public ApplicationDbContext CreateDbContext()
        {

            var options = new DbContextOptionsBuilder<ApplicationDbContext>();
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            options.UseSqlServer(configuration.GetConnectionString("MyStoreDB"));
            return new ApplicationDbContext(options.Options);
        }
    }
}
