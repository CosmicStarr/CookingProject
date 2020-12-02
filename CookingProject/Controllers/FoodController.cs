using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookingProject.Models;
using CookingProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CookingProject.Controllers
{
    public class FoodController : Controller
    {
        private readonly IFoodRepository FR;
        private readonly ICategoryRepository CR;
        public FoodController(IFoodRepository fr, ICategoryRepository cr)
        {
            FR = fr;
            CR = cr;
        }

        public ViewResult Lists(string category)
        {
            IEnumerable<Food> foods;
            string currentCategory;
            if(string.IsNullOrEmpty(category))
            {
                foods = FR.GetAllFood.OrderBy(c => c.FoodID);
                currentCategory = "All Food";   
            }
            else
            {
                foods = FR.GetAllFood.Where(c => c.GetCategory.CategoryName == category);
                currentCategory = CR.GetAllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
            return View(new FoodListView
            {
                Foods=foods,
                CurrentCategory=category
            });


        }

        public IActionResult List()
        {
            var foodlistView = new FoodListView();
            foodlistView.Foods = FR.GetAllFood;
            foodlistView.CurrentCategory = "Best Sellers!";
            return View(foodlistView);

            //return View(FR.GetAllFood);
        }
        public IActionResult Details(int id)
        {
            var food = FR.GetFoodByID(id);
            if (food == null)
                return NotFound();

            return View(food);
        }

    }
}
