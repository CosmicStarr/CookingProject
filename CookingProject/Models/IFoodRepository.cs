using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingProject.Models
{
    public interface IFoodRepository
    {
        IEnumerable<Food> GetAllFood { get; }
        IEnumerable<Food>GetAllFoodONSale { get; }
        Food GetFoodByID(int foodID);
    }
}
