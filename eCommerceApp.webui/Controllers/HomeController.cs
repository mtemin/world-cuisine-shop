using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceApp.webui.Data;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceApp.webui.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            int currentHour = DateTime.Now.Hour;
            string welcomeMsg = currentHour > 12 ? "İyi günler" : "Günaydın";
            
            ViewBag.Greeting = welcomeMsg;
            ViewBag.UserName = "Mehmet Emin";
            var foodViewModel = new FoodViewModel()
            {
                Foods = FoodRepository.Foods
            };
            
            return View(foodViewModel);
        }
        [Route("/about")]
        public IActionResult About()
        {
            return View();
        }
        [Route("/contact")]
        public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}