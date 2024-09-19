using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entity.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace data.Concrete.EFCore
{
    public class WorldCuisineShopContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<FoodCountry> FoodCountry { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=WORLD_CUISINE;Username=postgres;Password=postgres");
            // string connectionString = _configuration.GetConnectionString("worldCuisine");
            // optionsBuilder.UseNpgsql(connectionString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodCountry>()
            .HasKey(x => new { x.CountryId, x.FoodId });
        }
    }
}