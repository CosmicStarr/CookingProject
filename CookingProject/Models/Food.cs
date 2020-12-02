using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingProject.Models
{
    public class Food
    {
        public int FoodID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public string ImageThumb { get; set; }
        public bool isOnSale { get; set; }
        public bool isAvailable { get; set; }
        public int CategoryID { get; set; }
        public Category GetCategory { get; set; }
    }
}
