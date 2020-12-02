using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingProject.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDB DB;
        public CategoryRepository(ApplicationDB db)
        {
            DB = db;
        }
        public IEnumerable<Category> GetAllCategories => DB.Categories;

    }
}
