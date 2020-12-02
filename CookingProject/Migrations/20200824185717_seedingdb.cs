using Microsoft.EntityFrameworkCore.Migrations;

namespace CookingProject.Migrations
{
    public partial class seedingdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_shoppingCartItems_GetFoods_FoodID",
                table: "shoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_shoppingCartItems",
                table: "shoppingCartItems");

            migrationBuilder.RenameTable(
                name: "shoppingCartItems",
                newName: "ShoppingCartItems");

            migrationBuilder.RenameIndex(
                name: "IX_shoppingCartItems_FoodID",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_FoodID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems",
                column: "ShoppingCartItemID");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CategoryName",
                value: "Fried");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_GetFoods_FoodID",
                table: "ShoppingCartItems",
                column: "FoodID",
                principalTable: "GetFoods",
                principalColumn: "FoodID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_GetFoods_FoodID",
                table: "ShoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems");

            migrationBuilder.RenameTable(
                name: "ShoppingCartItems",
                newName: "shoppingCartItems");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_FoodID",
                table: "shoppingCartItems",
                newName: "IX_shoppingCartItems_FoodID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_shoppingCartItems",
                table: "shoppingCartItems",
                column: "ShoppingCartItemID");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "CategoryName",
                value: "From The Fryer");

            migrationBuilder.AddForeignKey(
                name: "FK_shoppingCartItems_GetFoods_FoodID",
                table: "shoppingCartItems",
                column: "FoodID",
                principalTable: "GetFoods",
                principalColumn: "FoodID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
