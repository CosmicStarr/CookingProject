using CookingProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingProject.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository CR;
        public CategoryMenu(ICategoryRepository cr)
        {
            CR = cr;
        }

        public IViewComponentResult Invoke()
        {
            var categories = CR.GetAllCategories.OrderBy(c => c.CategoryName);
            return View(categories);
        }
    }
}
