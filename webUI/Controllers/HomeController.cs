using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webUI.Data;
using Microsoft.AspNetCore.Mvc;
using data.Abstract;
using business.Concrete;

namespace webUI.Controllers
{
    public class HomeController : Controller
    {
        private IFoodService _foodService;

        public HomeController(IFoodService foodService)
        {
            this._foodService = foodService;
        }
        public IActionResult Index()
        {
            int currentHour = DateTime.Now.Hour;
            string welcomeMsg = currentHour > 12 ? "İyi günler" : "Günaydın";

            ViewBag.Greeting = welcomeMsg;
            ViewBag.UserName = "Mehmet Emin";
            var foodViewModel = new FoodViewModel()
            {
                Foods = _foodService.GetAll()
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