using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using webUI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using entity.Model;

namespace webUI.Controllers
{
    public class FoodsController : Controller
    {
        [Route("foods")]
        public IActionResult Index(string? q)
        {

            var foodViewModel = new FoodViewModel()
            {
                Foods = FoodRepository.Foods,
            };

            if (!string.IsNullOrEmpty(q))
            {
                foodViewModel.Foods = foodViewModel.Foods.Where(x => x.Name.ToLower().Contains(q.ToLower())).ToList();
            }
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
            if (country != null)
            {
                ViewBag.SelectedCountry = country;
                var foodViewModel = new FoodViewModel()
                {
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

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Countries = new SelectList(CountryRepository.GetCountries(), "CountryId", "Name");

            return View();
        }

        [HttpPost]
        public IActionResult Create(Food food)
        {
            FoodRepository.AddFood(food);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("foods/edit/{id}")]
        public IActionResult Edit(int id)
        {
            Food food = FoodRepository.GetFoodById(id);
            ViewBag.Countries = new SelectList(CountryRepository.GetCountries(), "Name", "Name", food.Country);
            if (food != null)
            {
                return View(food);
            }
            return View(FoodRepository.GetFoodById(id));
        }


        [HttpPost]
        [Route("foods/edit/{id}")]
        public IActionResult Edit(Food food)
        {
            try
            {
                FoodRepository.EditFood(food);
                return RedirectToAction("Index", "Foods");
            }
            catch (ArgumentException ex)
            {
                ModelState.AddModelError("", ex.Message);
                ViewBag.Countries = new SelectList(CountryRepository.GetCountries(), "CountryId", "Name");
                return View();
            }
            catch (InvalidOperationException ex)
            {
                ModelState.AddModelError("", ex.Message);
                ViewBag.Countries = new SelectList(CountryRepository.GetCountries(), "CountryId", "Name");
                return View(new Food { FoodId = food.FoodId }); // Return existing food data
            }
        }

        [Route("foods/delete/{id:int}")]
        [HttpPost]
        public IActionResult Delete(int FoodId)
        {
            FoodRepository.DeleteFood(FoodId);

            return RedirectToAction("Index");
            // return View();
        }

    }
}