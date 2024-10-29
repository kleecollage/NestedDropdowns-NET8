using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DropDownsAnidadosMVC.Migrations
{
    /// <inheritdoc />
    public partial class MigraconInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sucursal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SucursalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categoria_Sucursal_SucursalId",
                        column: x => x.SucursalId,
                        principalTable: "Sucursal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Producto_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Sucursal",
                columns: new[] { "Id", "Direccion", "Nombre" },
                values: new object[,]
                {
                    { 1, "123 Calle Principal", "Sucursal Principal" },
                    { 2, "456 Calle Central", "Sucursal Central" },
                    { 3, "789 Calle Norte", "Sucursal Norte" }
                });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Nombre", "SucursalId" },
                values: new object[,]
                {
                    { 1, "Aperitivos", 1 },
                    { 2, "Plato Principal", 1 },
                    { 3, "Postres", 2 },
                    { 4, "Bebidas", 2 },
                    { 5, "Especialidades", 3 }
                });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "Id", "CategoriaId", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, 1, "Rollitos Primavera", 4.9900000000000002 },
                    { 2, 2, "Tacos al Pastor", 9.9900000000000002 },
                    { 3, 3, "Pizza Margarita", 12.5 },
                    { 4, 4, "Sushi de Salmón", 14.75 },
                    { 5, 1, "Ensalada César", 7.9900000000000002 },
                    { 6, 2, "Hamburguesa Clásica", 8.5 },
                    { 7, 3, "Pasta Carbonara", 10.25 },
                    { 8, 4, "Paella Valenciana", 15.5 },
                    { 9, 5, "Churrasco a la Parrilla", 18.0 },
                    { 10, 1, "Empanadas de Carne", 3.75 },
                    { 11, 2, "Crepes de Nutella", 5.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_SucursalId",
                table: "Categoria",
                column: "SucursalId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_CategoriaId",
                table: "Producto",
                column: "CategoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Sucursal");
        }
    }
}
