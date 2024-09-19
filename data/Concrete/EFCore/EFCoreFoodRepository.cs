using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data.Abstract;
using entity.Model;

namespace data.Concrete.EFCore
{
    public class EFCoreFoodRepository : EFCoreGenericRepository<Food, WorldCuisineShopContext>, IFoodRepository
    {
        public List<Food> GetPopularFoodList()
        {
            using(var context = new WorldCuisineShopContext())
            {
                return context.Foods.ToList();
            }
        }
    }
}