using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CookingProject.Models
{
    public class ShoppingCartItems
    {
        [Key]
        public int ShoppingCartItemID { get; set; }
        public string ShoppingCartID { get; set; }
        public Food Food { get; set; }
        public int Amount { get; set; }
    }
}
