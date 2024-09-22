using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data.Concrete.EFCore;
using entity.Model;
using Microsoft.EntityFrameworkCore;

namespace data.Concrete
{
    public class SeedDatabase
    {
        public static void Seed()
        {
            var context = new WorldCuisineShopContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Countries.Count() == 0)
                {
                    context.Countries.AddRange(Countries);
                }


                if (context.Foods.Count() == 0)
                {
                    context.Foods.AddRange(Foods);
                }

            }
            context.SaveChanges();
        }
        private static Country[] Countries =
        {
            new Country(){CountryId=0, Name="Finland"},
            new Country(){CountryId=1, Name="Türkiye"},
            new Country(){CountryId=2, Name="Japan"}
        };


        private static Food[] Foods =
        {
                    new Food{FoodId=1,  IsAvailable=true, Name="Gyudon", Description="", ImgSrc="gyudon.jpg",Price=200,Country="Japan"},
                    new Food{FoodId=2,  IsAvailable=true, Name="Lahmacun", Description="", ImgSrc="lahmacun.jpg",Price=15,Country="Türkiye"},
                    new Food{FoodId=3,  IsAvailable=true, Name="Leipajuusto", Description="", ImgSrc="leipajuusto.jpg",Price=20,Country="Finland"},
        };
    }


}