using Microsoft.EntityFrameworkCore.Migrations;

namespace CookingProject.Migrations
{
    public partial class seedingdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsAvailable",
                table: "GetFoods",
                newName: "isAvailable");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Having a Sunday afternoon family gathering? These meals will keep any conversation going!", "From The Fryer" },
                    { 2, "Keeping a balanced diet is always good for the mind & body.", "Keto" },
                    { 3, "Breakfast is the most essential meal of the day. Start it right by enjoying one of our meals.", "Breakfast" },
                    { 4, "Craving Italian? We have a variety of restauraunt quality Italian meals to choose from.", "Pizza & Pasta" },
                    { 5, "We have an amazing selection of Spices to choose from!", "Spices" },
                    { 6, "Enjoy the wide selection of meals we offer that are low in calories but not in flavor.", "Healthy Meals" }
                });

            migrationBuilder.InsertData(
                table: "GetFoods",
                columns: new[] { "FoodID", "CategoryID", "Description", "ImageThumb", "ImageURL", "Name", "Price", "isAvailable", "isOnSale" },
                values: new object[] { 1, 1, "Crispy Fried Chicken made from scratch", "jj", "/Images/FriedChicken.jpeg", "Southern Fried Chicken", 9.99m, true, true });

            migrationBuilder.InsertData(
                table: "GetFoods",
                columns: new[] { "FoodID", "CategoryID", "Description", "ImageThumb", "ImageURL", "Name", "Price", "isAvailable", "isOnSale" },
                values: new object[] { 2, 1, "Fried Soft Shell Crab cooked to golden perfection", "jj", "/Images/Crab.jpg", "Soft Shell Crab", 74.99m, true, false });

            migrationBuilder.InsertData(
                table: "GetFoods",
                columns: new[] { "FoodID", "CategoryID", "Description", "ImageThumb", "ImageURL", "Name", "Price", "isAvailable", "isOnSale" },
                values: new object[] { 3, 1, "Very tender, spicy, crispy fish thats full of flavor and made from scratch!", "ll", "/Images/Fish.jpg", "Lahori Fried Fish", 29.99m, true, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GetFoods",
                keyColumn: "FoodID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GetFoods",
                keyColumn: "FoodID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GetFoods",
                keyColumn: "FoodID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "isAvailable",
                table: "GetFoods",
                newName: "IsAvailable");
        }
    }
}
