using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookingProject.Models;
using CookingProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CookingProject.Controllers
{
    public class SalesController : Controller
    {
        private readonly IFoodRepository FR;
        public SalesController(IFoodRepository fr)
        {
            FR = fr;
        }
        public IActionResult Sales()
        {
            var salesViewModel = new SalesViewModel
            {
                FoodOnSale = FR.GetAllFoodONSale
            };

            return View(salesViewModel);
        }

    }
}
