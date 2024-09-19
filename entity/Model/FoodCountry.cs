using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entity.Model
{
    public class FoodCountry
    {
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int FoodId { get; set; }
        public Food Food { get; set; }

    }
}