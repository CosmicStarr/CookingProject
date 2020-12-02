using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingProject.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDB DB;
        private readonly ShoppingCart SC;
        public OrderRepository(ApplicationDB db,ShoppingCart sc)
        {
            DB = db;
            SC = sc;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = SC.GetCartTotal();
            DB.Orders.Add(order);
            DB.SaveChanges();

            var shoppingCartItems = SC.GetCartItems();
            foreach (var item in shoppingCartItems)
            {
                var orderdetails = new OrderDetail
                {
                    Amount = item.Amount,
                    Price = item.Food.Price,
                    FoodID = item.Food.FoodID,
                    OrderID = order.OrderID
                };

                DB.OrderDetails.Add(orderdetails);   
            }
            DB.SaveChanges();
        }
    }
}
