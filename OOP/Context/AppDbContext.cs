using Microsoft.EntityFrameworkCore;
using OOP.Context.EntityConfiguration;
using OOP.Models;

namespace OOP.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Location> Locations => Set<Location>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LocationEntityConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
