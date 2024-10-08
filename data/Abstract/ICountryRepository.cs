using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entity.Model;

namespace data.Abstract
{
    public interface ICountryRepository:IRepository<Country>
    {
        List<Country> GetPopularCountries();
    }
}