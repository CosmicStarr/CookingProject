using CookingProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingProject.ViewModels
{
    public class FoodListView
    {
        public IEnumerable<Food> Foods { get; set; }
        public string CurrentCategory { get; set; }
    }
}
