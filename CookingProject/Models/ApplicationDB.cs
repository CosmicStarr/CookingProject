using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingProject.Models
{
    public class ApplicationDB : IdentityDbContext<IdentityUser>
    {
        public ApplicationDB(DbContextOptions<ApplicationDB> options) : base(options)
        {

        }
        public DbSet<Food> GetFoods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItems> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryID = 1,
                CategoryName = "Fried",
                CategoryDescription = "Having a Sunday afternoon family gathering? These meals will keep any conversation going!"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryID = 2,
                CategoryName = "Keto",
                CategoryDescription = "Keeping a balanced diet is always good for the mind & body."
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryID = 3,
                CategoryName = "Breakfast",
                CategoryDescription = "Breakfast is the most essential meal of the day. Start it right by enjoying one of our meals."
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryID = 4,
                CategoryName = "Pizza & Pasta",
                CategoryDescription = "Craving Italian? We have a variety of restauraunt quality Italian meals to choose from."
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryID = 5,
                CategoryName = "Spices",
                CategoryDescription = "We have an amazing selection of Spices to choose from!"
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryID = 6,
                CategoryName = "Nutritious",
                CategoryDescription = "Enjoy the wide selection of meals we offer that are low in calories but not in flavor."
            });







            modelBuilder.Entity<Food>().HasData(new Food
            {
                FoodID = 1,
                Name = "Southern Fried Chicken",
                Description = "Crispy Fried Chicken made from scratch",
                Price = 9.99m,
                CategoryID = 1,
                ImageURL = "/Images/FriedChicken.jpeg",
                ImageThumb = "jj",
                isAvailable = true,
                isOnSale = true
            });
            modelBuilder.Entity<Food>().HasData(new Food
            {
                FoodID = 2,
                Name = "Soft Shell Crab",
                Description = "Fried Soft Shell Crab cooked to golden perfection",
                Price = 74.99m,
                CategoryID = 1,
                ImageURL = "/Images/Crab.jpg",
                ImageThumb = "jj",
                isAvailable = true,
                isOnSale = false
            });
            modelBuilder.Entity<Food>().HasData(new Food
            {
                FoodID = 3,
                Name = "Lahori Fried Fish",
                Description = "Very tender, spicy, crispy fish thats full of flavor and made from scratch!",
                Price = 29.99m,
                CategoryID = 1,
                ImageURL = "/Images/Fish.jpg",
                ImageThumb = "ll",
                isAvailable = true,
                isOnSale = false
            });

        }

    }
}
