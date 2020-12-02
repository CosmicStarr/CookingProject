using Microsoft.EntityFrameworkCore.Migrations;

namespace CookingProject.Migrations
{
    public partial class addingshoppingCartItemstodb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "shoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartID = table.Column<string>(nullable: true),
                    FoodID = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shoppingCartItems", x => x.ShoppingCartItemID);
                    table.ForeignKey(
                        name: "FK_shoppingCartItems_GetFoods_FoodID",
                        column: x => x.FoodID,
                        principalTable: "GetFoods",
                        principalColumn: "FoodID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_shoppingCartItems_FoodID",
                table: "shoppingCartItems",
                column: "FoodID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "shoppingCartItems");
        }
    }
}
