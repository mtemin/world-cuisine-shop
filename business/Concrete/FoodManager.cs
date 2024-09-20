using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data.Abstract;
using data.Concrete.EFCore;
using entity.Model;

namespace business.Concrete
{
    public class FoodManager : IFoodService
    {
        private IFoodRepository _foodRepository;

        public FoodManager(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }
        public void Create(Food entity)
        {
            _foodRepository.Create(entity);
        }

        public void Delete(int id)
        {
            // try{
            // _foodRepository.Delete(entity);
            // }
            // catch(Exception ex)
            // {

            // }
            throw new NotImplementedException();
        }

        public List<Food> GetAll()
        {
            return _foodRepository.GetAll();
        }

        public Food GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Food entity)
        {
            throw new NotImplementedException();
        }
    }
}