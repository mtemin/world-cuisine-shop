using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace webUI.Models
{
    public class Food
    {
        public int FoodId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
        public string ImgSrc { get; set; }
        public string Country { get; set; }
        public bool IsAvailable { get; set; }

    }
}