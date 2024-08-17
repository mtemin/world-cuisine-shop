using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceApp.webui.Models;

namespace eCommerceApp.webui.Data
{
    public class FoodRepository
    {
         private static List<Food> _foods = null;
        static FoodRepository()
        {
            _foods = new List<Food>()
            {
                new Food{FoodId=0, Name="Karjalanpiirakka", Description="", ImgSrc="karjalanpiirakka.jpg",Price=10,Country="Finland", MoneyUnit="€"},
                new Food{FoodId=1, Name="Gyudon", Description="", ImgSrc="gyudon.jpg",Price=200,Country="Japan", MoneyUnit="¥"},
                new Food{FoodId=2, Name="Lahmacun", Description="", ImgSrc="lahmacun.jpg",Price=15,Country="Türkiye", MoneyUnit="₺"},
                new Food{FoodId=3, Name="Leipajuusto", Description="", ImgSrc="leipajuusto.jpg",Price=20,Country="Finland", MoneyUnit="€"},
                new Food{FoodId=4, Name="Sarma Dolma", Description="", ImgSrc="sarma.jpg",Price=10,Country="Türkiye", MoneyUnit="₺"},
                new Food{FoodId=5, Name="Tempura", Description="", ImgSrc="tempura.webp",Price=300,Country="Japan", MoneyUnit="¥"},
                new Food{FoodId=6, Name="Ramen", Description="", ImgSrc="ramen.webp",Price=250,Country="Japan", MoneyUnit="¥"},
                new Food{FoodId=7, Name="Iskender Kebab", Description="", ImgSrc="iskender.jpg",Price=35,Country="Türkiye", MoneyUnit="₺"},
                new Food{FoodId=8, Name="Kalakukko", Description="", ImgSrc="kalakukko.jpg",Price=30,Country="Finland", MoneyUnit="€"},
                new Food{FoodId=9, Name="Sushi", Description="", ImgSrc="sushi.webp",Price=150,Country="Japan", MoneyUnit="¥"},
                new Food{FoodId=10, Name="Yakitori", Description="", ImgSrc="yakitori.webp",Price=150,Country="Japan", MoneyUnit="¥"},
                new Food{FoodId=11, Name="Sushi", Description="", ImgSrc="lahmacun.jpg",Price=150,Country="Japan", MoneyUnit="¥"},
                new Food{FoodId=12, Name="Ruisleipa", Description="", ImgSrc="ruisleipa.jpg",Price=5,Country="Finland", MoneyUnit="€"},
                new Food{FoodId=13, Name="Lokum", Description="", ImgSrc="lokum.jpg",Price=10,Country="Türkiye", MoneyUnit="₺"},
                new Food{FoodId=14, Name="Ruisleipa", Description="", ImgSrc="ruisleipa.jpg",Price=5,Country="Finland", MoneyUnit="€"},
                new Food{FoodId=15, Name="Mustikkapiirakka", Description="", ImgSrc="mustikkapiirakka.jpg",Price=15,Country="Finland", MoneyUnit="€"}
            };
        }

        public static List<Food> Foods
        {
            get{return _foods;}
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
            if(country != null){
                foods = foods.Where(f => f.Country == country).ToList();
            }
            return foods;
        }
    
    }
}