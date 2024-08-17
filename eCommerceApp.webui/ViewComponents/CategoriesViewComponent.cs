using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceApp.webui.Models;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceApp.webui.ViewComponents
{
    public class CountriesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            var countries = new List<Country>()
            {
                new Country{Name = "Türkiye", Description = "anadolu"},
                new Country{Name = "Finland", Description = "soğuk"},
                new Country{Name = "Japan", Description = "okyanusta ada"},
            };
            return View(countries);

        }


    }
}