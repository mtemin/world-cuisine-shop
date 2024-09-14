using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webUI.Models;

namespace webUI.Data
{
    public class CountryRepository
    {
         private static List<Country> _countries = null;
        static CountryRepository()
        {
            _countries = new List<Country>()
            {
                new Country{CountryId=0, Name = "Türkiye", Description = ""},
                new Country{CountryId=1, Name = "Japan", Description = ""},
                new Country{CountryId=2, Name = "Finland", Description = ""},
                // new Country{CountryId=3, Name = "Helikopter", Description="döner kanat" }, 
            };
        }

        public static List<Country> GetCountries()
        {
            return _countries;
        }

        public static void AddCountry(Country country)
        {
        _countries.Add(country); 
        }

        public static Country GetCountryById(int id)
        {
            return _countries.FirstOrDefault(p => p.CountryId == id);
        }
    
    }
}