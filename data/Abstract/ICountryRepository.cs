using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entity.Model;

namespace data.Abstract
{
    public interface ICountryRepository
    {
        
        Country GetById(int id);
        List<Country> GetAll();
        void Create(Country entity);
        void Update(Country entity);
        void Delete(int id);
    }
}