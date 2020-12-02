using CookingProject.Models;
using CookingProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CookingProject.Components
{
    public class ShoppingCartSummary: ViewComponent
    {
        private readonly ShoppingCart SC;
        public ShoppingCartSummary(ShoppingCart sc)
        {
            SC = sc;
        }

        public IViewComponentResult Invoke()
        {
            SC.ShoppingCartItems = SC.GetCartItems();
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = SC,
                ShoppingCartTotal = SC.GetCartTotal()
            };
            return View(shoppingCartViewModel);
        }
    }
}
