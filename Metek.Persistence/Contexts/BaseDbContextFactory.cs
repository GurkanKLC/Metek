using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;


namespace Metek.Persistence.Contexts
{
    public class BaseDbContextFactory : IDesignTimeDbContextFactory<BaseDbContext>
    {
        public BaseDbContext CreateDbContext(string[] args = null)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory() + @"..\..\Metek.Api") // Adjust the path to the correct location
               .AddJsonFile("appsettings.json")
               .Build();
            var builder = new DbContextOptionsBuilder<BaseDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);

            return new BaseDbContext(builder.Options, configuration); 
        }
    }
}
