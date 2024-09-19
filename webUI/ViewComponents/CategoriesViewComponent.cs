using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entity.Model;
using Microsoft.AspNetCore.Mvc;

namespace webUI.ViewComponents
{
    public class CountriesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            var countries = new List<Country>()
            {
                new Country{Name = "Türkiye"},
                new Country{Name = "Finland"},
                new Country{Name = "Japan"},
            };
            return View(countries);

        }


    }
}