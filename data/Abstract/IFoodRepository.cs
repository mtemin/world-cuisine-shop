using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entity.Model;

namespace data.Abstract
{
    public interface IFoodRepository:IRepository<Food>
    {
        List<Food> GetPopularFoodList();

    }
}