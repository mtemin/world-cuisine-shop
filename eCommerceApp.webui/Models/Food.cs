using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceApp.webui.Models
{
    public class Food
    {
        public int FoodId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
        public string ImgSrc { get; set; }
        public string Country { get; set; }
        public string MoneyUnit { get; set; }

    }
}