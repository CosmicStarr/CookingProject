using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingProject.Models
{
    public class FoodRepository : IFoodRepository
    {
        private readonly ApplicationDB DB;
        public FoodRepository(ApplicationDB db)
        {
            DB = db;
        }
     
        public IEnumerable<Food> GetAllFood
        {
            get
            {
                return DB.GetFoods.Include(c => c.GetCategory);
            }

        }

        public IEnumerable<Food> GetAllFoodONSale
        {
            get
            {
                return DB.GetFoods.Include(c => c.GetCategory).Where(p => p.isOnSale);
            }

        }


        public Food GetFoodByID(int foodID)
        {
            return DB.GetFoods.FirstOrDefault(f => f.FoodID == foodID);
        }

    }
}
