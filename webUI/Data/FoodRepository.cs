using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webUI.Models;

namespace webUI.Data
{
    public class FoodRepository
    {
        private static List<Food> _foods = null;
        static FoodRepository()
        {
            _foods = new List<Food>()
            {
                new Food{FoodId=0,  IsAvailable=true, Name="Karjalanpiirakka", Description="lorem ipsum dolor sit amet lorem ipsum dolor sit ametlorem ipsum dolor sit ametlorem ipsum dolor sit ametlorem ipsum dolor sit ametlorem ipsum dolor sit ametlorem ipsum dolor sit amet", ImgSrc="karjalanpiirakka.jpg",Price=10,Country="Finland"},
                new Food{FoodId=1,  IsAvailable=true, Name="Gyudon", Description="", ImgSrc="gyudon.jpg",Price=200,Country="Japan"},
                new Food{FoodId=2,  IsAvailable=true, Name="Lahmacun", Description="", ImgSrc="lahmacun.jpg",Price=15,Country="Türkiye"},
                new Food{FoodId=3,  IsAvailable=true, Name="Leipajuusto", Description="", ImgSrc="leipajuusto.jpg",Price=20,Country="Finland"},
                new Food{FoodId=4,  IsAvailable=true, Name="Sarma Dolma", Description="", ImgSrc="sarma.jpg",Price=10,Country="Türkiye"},
                new Food{FoodId=5,  IsAvailable=true, Name="Tempura", Description="", ImgSrc="tempura.webp",Price=300,Country="Japan"},
                new Food{FoodId=6,  IsAvailable=true, Name="Ramen", Description="", ImgSrc="ramen.webp",Price=250,Country="Japan"},
                new Food{FoodId=7,  IsAvailable=true, Name="Iskender Kebab", Description="", ImgSrc="iskender.jpg",Price=35,Country="Türkiye"},
                new Food{FoodId=8,  IsAvailable=true, Name="Kalakukko", Description="", ImgSrc="kalakukko.jpg",Price=30,Country="Finland"},
                new Food{FoodId=9,  IsAvailable=true, Name="Sushi", Description="", ImgSrc="sushi.webp",Price=150,Country="Japan"},
                new Food{FoodId=10, IsAvailable=false, Name="Yakitori", Description="", ImgSrc="yakitori.webp",Price=150,Country="Japan"},
                new Food{FoodId=11, IsAvailable=false, Name="Sushi", Description="", ImgSrc="lahmacun.jpg",Price=150,Country="Japan"},
                new Food{FoodId=12, IsAvailable=false, Name="Ruisleipa", Description="", ImgSrc="ruisleipa.jpg",Price=5,Country="Finland"},
                new Food{FoodId=13, IsAvailable=false, Name="Lokum", Description="", ImgSrc="lokum.jpg",Price=10,Country="Türkiye"},
                new Food{FoodId=14, IsAvailable=false, Name="Ruisleipa", Description="", ImgSrc="ruisleipa.jpg",Price=5,Country="Finland"},
                new Food{FoodId=15, IsAvailable=false, Name="Mustikkapiirakka", Description="", ImgSrc="mustikkapiirakka.jpg",Price=15,Country="Finland"}
            };
        }

        public static List<Food> Foods
        {
            get { return _foods; }
        }

        public static void AddFood(Food food)
        {
            _foods.Add(food);
        }

        public static Food GetFoodById(int id)
        {
            return _foods.FirstOrDefault(p => p.FoodId == id);
        }
        public static List<Food> GetFoodByCountry(string country)
        {
            var foods = FoodRepository.Foods;
            if (country != null)
            {
                foods = foods.Where(f => f.Country == country).ToList();
            }
            return foods;
        }

        public static void EditFood(Food food)
        {
            if (food == null || food.FoodId <= 0)
            {
                throw new ArgumentException("Food cannot be null or FoodId must be greater than zero.");
            }

            var existingFood = _foods.FirstOrDefault(f => f.FoodId == food.FoodId);
            System.Console.WriteLine(existingFood);
            if (existingFood != null)
            {
                existingFood.Name = food.Name;
                existingFood.Description = food.Description;
                existingFood.Price = food.Price;
                existingFood.ImgSrc = food.ImgSrc;
                existingFood.Country = food.Country;
                existingFood.IsAvailable = food.IsAvailable;
            }
            else
            {
                throw new InvalidOperationException($"Food with ID {food.FoodId} not found.");
            }
        }

        public static void DeleteFood(int id)
        {
            var food = GetFoodById(id);

            try
            {
                _foods.Remove(food);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

        }

    }
}