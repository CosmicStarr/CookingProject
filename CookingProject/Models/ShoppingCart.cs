using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingProject.Models
{
    public class ShoppingCart
    {
        private readonly ApplicationDB DB;
        public string ShoppingCartID { get; set; }
        public List<ShoppingCartItems> ShoppingCartItems { get; set; }
        public ShoppingCart(ApplicationDB db)
        {
            DB = db;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<ApplicationDB>();
            string cartID = session.GetString("CartID") ?? Guid.NewGuid().ToString();
            session.SetString("CartID", cartID);
            return new ShoppingCart(context) { ShoppingCartID = cartID };
        }
         
        public void AddToCart(Food food,int amount)
        {
            var shoppingCartItem = DB.ShoppingCartItems.SingleOrDefault(s => s.Food.FoodID == food.FoodID && s.ShoppingCartID==ShoppingCartID);
            if(shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItems
                {
                    ShoppingCartID = ShoppingCartID,
                    Food = food,
                    Amount =amount
                };
                DB.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            DB.SaveChanges();
        }

        public int RemoveFromCart(Food food)
        {
            var shoppingCartItem = DB.ShoppingCartItems.SingleOrDefault(s => s.Food.FoodID == food.FoodID && s.ShoppingCartID == ShoppingCartID);
            var localAmount = 0;

            if(shoppingCartItem != null)
            {
                if(shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    DB.ShoppingCartItems.Remove(shoppingCartItem);
                }

            }

            DB.SaveChanges();
            return localAmount;
        }

        public List<ShoppingCartItems>GetCartItems()
        {
            return ShoppingCartItems ??= DB.ShoppingCartItems.
                Where(c => c.ShoppingCartID == ShoppingCartID).Include(s => s.Food).ToList();
        }
        public void ClearCart()
        {
            var cartitems = DB.ShoppingCartItems.Where(c => c.ShoppingCartID == ShoppingCartID);
            DB.ShoppingCartItems.RemoveRange(cartitems);
            DB.SaveChanges();
        }

        public decimal GetCartTotal()
        {
            var total = DB.ShoppingCartItems.Where(g => g.ShoppingCartID == ShoppingCartID).Select(g=>g.Food.Price * g.Amount).Sum();
            return total;
        }

    }
}
