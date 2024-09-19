using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webUI.Data;
using Microsoft.AspNetCore.Mvc;
using data.Abstract;

namespace webUI.Controllers
{
    public class HomeController : Controller
    {
        private IFoodRepository _foodRepository;

        public HomeController(IFoodRepository foodRepository)
        {
            this._foodRepository = foodRepository;
        }
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