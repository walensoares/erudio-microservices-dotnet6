using Microsoft.EntityFrameworkCore.Migrations;

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 2L, "T-shirt", "Camiseta", "", "Name", 69.9m },
                    { 3L, "T-shirt", "Camiseta", "", "Name 2", 70m },
                    { 4L, "T-shirt", "Camiseta", "", "Name 3", 69.5m },
                    { 5L, "T-shirt", "Camiseta", "", "Name 4", 39.9m },
                    { 6L, "T-shirt", "Camiseta", "", "Name 5", 49.9m },
                    { 7L, "T-shirt", "Camiseta", "", "Name 6", 79.9m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);
        }
    }
}
