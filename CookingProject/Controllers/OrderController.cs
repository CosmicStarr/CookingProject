using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookingProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CookingProject.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderRepository OR;
        private readonly ShoppingCart SC;
        public OrderController(IOrderRepository or, ShoppingCart sc)
        {
            OR = or;
            SC = sc;
        }
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            SC.ShoppingCartItems = SC.GetCartItems();
            if(SC.ShoppingCartItems.Count ==0)
            {
                ModelState.AddModelError("", "Your cart is empty!");
            }
            if(ModelState.IsValid)
            {
                OR.CreateOrder(order);
                SC.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(order);
        }
        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thank you for your order. Your food will arrive soon!";
            return View();
        }
    }
}
