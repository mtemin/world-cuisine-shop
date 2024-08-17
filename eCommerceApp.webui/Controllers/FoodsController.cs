using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using eCommerceApp.webui.Data;
using eCommerceApp.webui.Models;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceApp.webui.Controllers
{
    public class FoodsController:Controller
    {
        [Route("foods")]
        public IActionResult Index()
        {

            var foodViewModel = new FoodViewModel(){
                Foods = FoodRepository.Foods,
            };
            
            return View(foodViewModel);
        }

        [Route("foods/{id:int}")]
        public IActionResult Details(int id)
        {
            Food food = FoodRepository.GetFoodById(id);

            return View(food);
        }

        [Route("foods/by-country/{country}")]
        public IActionResult FilterByCountry([RegularExpression(@"\p{L}+")] string country)
        {
            if(country !=null)
            {
            ViewBag.SelectedCountry = country; 
            var foodViewModel = new FoodViewModel(){
                Foods = FoodRepository.GetFoodByCountry(country),
                SelectedCountry = country
            };

            return View(foodViewModel);
            }
            else
            {
            return View();
            }
        }
    }
}