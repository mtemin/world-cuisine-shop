using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceApp.webui.Models;

namespace eCommerceApp.webui.Data
{
    public class CountryRepository
    {
         private static List<Country> _countries = null;
        static CountryRepository()
        {
            _countries = new List<Country>()
            {
                new Country{CountryId=0, Name = "Araba", Description = "4 tekerli falan"},
                new Country{CountryId=1, Name = "Tank", Description = "oldukça tehlikeli"},
                new Country{CountryId=2, Name = "Uçak", Description = "havada gider"},
                new Country{CountryId=3, Name = "Helikopter", Description="döner kanat" }, 
            };
        }

        public static List<Country> Countrys
        {
            get{return _countries;}
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