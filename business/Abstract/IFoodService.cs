using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entity.Model;

namespace business.Concrete
{
    public interface IFoodService
    {
        Food GetById(int id);
        List<Food> GetAll();
        void Create(Food entity);
        void Update(Food entity);
        void Delete(int id);
    }
}