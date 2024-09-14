using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace webUI.Models
{
    public class Food
    {
        [BindProperty]
        public int FoodId { get; set; }
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string? Description { get; set; }
        [BindProperty]
        public int Price { get; set; }
        [BindProperty]
        public string ImgSrc { get; set; }
        [BindProperty]
        public string Country { get; set; }
        [BindProperty]
        public string MoneyUnit { get; set; }
        [BindProperty]
        public bool IsAvailable { get; set; }

    }
}