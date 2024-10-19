using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AtuliaRestauruntv2.Migrations
{
    /// <inheritdoc />
    public partial class NewDataSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DropColumn(
                name: "ProductIngredientId",
                table: "ProductIngredients");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "Name",
                value: "Main");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "Name",
                value: "Dessert");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "Name",
                value: "Beverage");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 1,
                column: "Name",
                value: "Potato");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 4,
                column: "Name",
                value: "Naan");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 5,
                column: "Name",
                value: "Spinach");

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientId", "Name" },
                values: new object[,]
                {
                    { 7, "White Rice" },
                    { 8, "Peas" },
                    { 9, "Coriander" },
                    { 10, "Lentils" },
                    { 11, "Gulab Jamun" },
                    { 12, "Ice Cream" },
                    { 13, "Water" },
                    { 14, "Mango Lassi" },
                    { 15, "Coke" }
                });

            migrationBuilder.InsertData(
                table: "ProductIngredients",
                columns: new[] { "IngredientId", "ProductId" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price", "Stock" },
                values: new object[] { "A fluffy bread popular in North India", "Naan", 7.99m, 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price", "Stock" },
                values: new object[] { "Mild yummy rice with peas", "Fried Rice", 10.99m, 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price", "Stock" },
                values: new object[] { "Fried Potato Curry served with Naan and Rice", "Aloo Fry", 8.50m, 10 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 4, 4, "Chilled Fizzy Beverage", "https://via.placeholder.com/150", "Coke", 2.99m, 50 },
                    { 5, 4, "Beverage", "https://via.placeholder.com/150", "Water", 3.99m, 50 },
                    { 6, 3, "Cool Mango drink", "https://via.placeholder.com/150", "Mango Lassi", 5.00m, 20 },
                    { 7, 3, "Indian sweet made with milk powder", "https://via.placeholder.com/150", "Gulab Jamun", 4.99m, 30 },
                    { 8, 3, "Frozen dessert", "https://via.placeholder.com/150", "Ice Cream", 2.99m, 60 },
                    { 9, 2, "Chiken flavoured lightly in spices and served with rice", "https://via.placeholder.com/150", "Butter Chicken", 20.99m, 30 },
                    { 10, 2, "Fish curry served with rice", "https://via.placeholder.com/150", "Fish Madrasi", 19.99m, 20 },
                    { 11, 1, "Spinach deepfried coated in batter", "https://via.placeholder.com/150", "Palak Fritters", 6.99m, 30 },
                    { 12, 1, "Chicken lightly coated in spices and fried", "https://via.placeholder.com/150", "Chicken Lollipops", 8.9m, 30 },
                    { 13, 2, "Lentil cooked with tomato and garnished with coriander.", "https://via.placeholder.com/150", "Daal Fry", 7.99m, 20 }
                });

            migrationBuilder.InsertData(
                table: "ProductIngredients",
                columns: new[] { "IngredientId", "ProductId" },
                values: new object[,]
                {
                    { 7, 2 },
                    { 8, 2 },
                    { 7, 3 },
                    { 15, 4 },
                    { 13, 5 },
                    { 14, 6 },
                    { 11, 7 },
                    { 12, 8 },
                    { 2, 9 },
                    { 7, 9 },
                    { 3, 10 },
                    { 7, 10 },
                    { 5, 11 },
                    { 2, 12 },
                    { 6, 13 },
                    { 9, 13 },
                    { 10, 13 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 14, 6 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 7, 10 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 9, 13 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 10, 13 });

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.AddColumn<int>(
                name: "ProductIngredientId",
                table: "ProductIngredients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "Name",
                value: "Entree");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "Name",
                value: "Side Dish");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "Name",
                value: "Dessert");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 5, "Beverage" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 1,
                column: "Name",
                value: "Beef");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 4,
                column: "Name",
                value: "Tortilla");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 5,
                column: "Name",
                value: "Lettuce");

            migrationBuilder.UpdateData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 4, 1 },
                column: "ProductIngredientId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 4, 3 },
                column: "ProductIngredientId",
                value: 0);

            migrationBuilder.InsertData(
                table: "ProductIngredients",
                columns: new[] { "IngredientId", "ProductId", "ProductIngredientId" },
                values: new object[,]
                {
                    { 1, 1, 0 },
                    { 5, 1, 0 },
                    { 6, 1, 0 },
                    { 2, 2, 0 },
                    { 4, 2, 0 },
                    { 5, 2, 0 },
                    { 6, 2, 0 },
                    { 3, 3, 0 },
                    { 5, 3, 0 },
                    { 6, 3, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price", "Stock" },
                values: new object[] { "A delicious beef taco", "Beef Taco", 2.50m, 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price", "Stock" },
                values: new object[] { "A delicious chicken taco", "Chicken Taco", 1.99m, 101 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price", "Stock" },
                values: new object[] { "A delicious fish taco", "Fish Taco", 3.99m, 90 });
        }
    }
}
