using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entity.Model;
using Microsoft.EntityFrameworkCore;

namespace data.Concrete.EFCore
{
    public class WorldCuisineShopContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=postgres;Database=WORLD_CUISINE;Username=postgres;Password=postgres");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodCountry>()
            .HasKey(x => new { x.CountryId, x.FoodId });
        }
    }
}