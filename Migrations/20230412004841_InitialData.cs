using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppEF.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "ClienteId", "Email", "Nombre", "Numero" },
                values: new object[,]
                {
                    { 1, "juan@gmail.com", "Juan", "1234567890" },
                    { 2, "pedro@gmail.com", "Pedro", "1234567890" },
                    { 3, "maria@gmail.com", "Maria", "1234567890" },
                    { 4, "luis@gmail.com", "Luis", "1234567890" }
                });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "ProductoId", "Descripcion", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, "Descripcion 1", "Producto 1", 100.0 },
                    { 2, "Descripcion 2", "Producto 2", 200.0 },
                    { 3, "Descripcion 3", "Producto 3", 300.0 },
                    { 4, "Descripcion 4", "Producto 4", 400.0 },
                    { 5, "Descripcion 5", "Producto 5", 500.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "ClienteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "ClienteId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "ClienteId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "ClienteId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "ProductoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "ProductoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "ProductoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "ProductoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "ProductoId",
                keyValue: 5);
        }
    }
}
