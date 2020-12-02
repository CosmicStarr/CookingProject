using CookingProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingProject.ViewModels
{
    public class SalesViewModel
    {
        public IEnumerable<Food> FoodOnSale { get; set; }
   
    }
}
