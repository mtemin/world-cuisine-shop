using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data.Abstract;
using entity.Model;

namespace data.Concrete.EFCore
{
    public class EFCoreCountryRepository : ICountryRepository
    {
        private WorldCuisineShopContext db = new WorldCuisineShopContext();
        public void Create(Country entity)
        {
            db.Countries.Add(entity);
            db.SaveChanges();            
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Country> GetAll()
        {
            throw new NotImplementedException();
        }

        public Country GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Country> GetPopularCountries()
        {
            throw new NotImplementedException();
        }

        public void Update(Country entity)
        {
            throw new NotImplementedException();
        }
    }
}