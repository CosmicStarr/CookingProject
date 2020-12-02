using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingProject.Models
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int FoodID { get; set; }
        public Food Getfood { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Order GetOrder { get; set; }
    }
}
