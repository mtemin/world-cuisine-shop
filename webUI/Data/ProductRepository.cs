using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webUI.Models;

namespace webUI.Data
{
    public class ProductRepository
    {
        private static List<Product> _products = null;
        static ProductRepository()
        {
            _products = new List<Product>()
            {
                new Product{ProductId=0, Name = "TOGG T10X", Price = 1784000, Description="C sınıfı SUV araç", ImageUrl="img/gyudon.jpg"}, 
                new Product{ProductId=1, Name = "TOGG T10F", Price = 1412500, Description="C sınıfı sedan aile aracı", ImageUrl="img/inegolkofte.jpg"}, 
                new Product{ProductId=2, Name = "TOGG T10S", Price = 2143000, Description="D sınıfı coupe spor araba", ImageUrl="img/leipajuusto.jpg"}, 
                new Product{ProductId=3, Name = "TOGG T10C", Price = 987140, Description="B sınıfı hatchback taze memur aracı", ImageUrl="img/kalakukko.jpg"}, 
            };
        }

        public static List<Product> Products
        {
            get{return _products;}
        }

        public static void AddProduct(Product product)
        {
        _products.Add(product); 
        }

        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.ProductId == id);
        }
    }
}