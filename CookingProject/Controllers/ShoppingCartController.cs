using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookingProject.Models;
using CookingProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CookingProject.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IFoodRepository FR;
        private readonly ShoppingCart SC;
        public ShoppingCartController(IFoodRepository fr, ShoppingCart sc)
        {
            FR = fr;
            SC = sc;
        }
        public ViewResult Index()
        {
            SC.ShoppingCartItems = SC.GetCartItems();
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = SC,
                ShoppingCartTotal = SC.GetCartTotal()

            };
            
            return View(shoppingCartViewModel);
        }
        public RedirectToActionResult AddToShoppingCart(int foodid)
        {
            var selectedFood = FR.GetAllFood.FirstOrDefault(f => f.FoodID == foodid);
            if (selectedFood != null)
            {
                SC.AddToCart(selectedFood,1);
            }
            return RedirectToAction("Index");
        }
        public RedirectToActionResult RemoveFromShoppingCart(int foodid)
        {
            var selectedFood = FR.GetAllFood.FirstOrDefault(f => f.FoodID == foodid);
            if (selectedFood != null)
            {
                SC.RemoveFromCart(selectedFood);
            }
            return RedirectToAction("Index");
        }
        
        public RedirectToActionResult ClearCart()
        {
            SC.ClearCart();
            return RedirectToAction("Index");
        }
    }
}
