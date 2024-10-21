using Metek.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace Metek.Persistence.Contexts
{
    public class BaseDbContext : DbContext
    {
        protected IConfiguration _configuration { get; set; }
        public DbSet<Mesai> Mesais { get; set; }

        public BaseDbContext(DbContextOptions<BaseDbContext> options, IConfiguration configuration)
             : base(options)
        {
            _configuration = configuration;
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }

}
