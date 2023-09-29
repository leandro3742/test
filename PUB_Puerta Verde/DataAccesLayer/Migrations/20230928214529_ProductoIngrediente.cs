using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class ProductoIngrediente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductoIngrediente");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_Ingrediente_id_Ingrediente",
                table: "Producto_Ingrediente",
                column: "id_Ingrediente");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Ingrediente_Ingrediente_id_Ingrediente",
                table: "Producto_Ingrediente",
                column: "id_Ingrediente",
                principalTable: "Ingrediente",
                principalColumn: "id_Ingrediente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Ingrediente_Producto_id_Producto",
                table: "Producto_Ingrediente",
                column: "id_Producto",
                principalTable: "Producto",
                principalColumn: "id_Producto",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Ingrediente_Ingrediente_id_Ingrediente",
                table: "Producto_Ingrediente");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Ingrediente_Producto_id_Producto",
                table: "Producto_Ingrediente");

            migrationBuilder.DropIndex(
                name: "IX_Producto_Ingrediente_id_Ingrediente",
                table: "Producto_Ingrediente");

            migrationBuilder.CreateTable(
                name: "ProductoIngrediente",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "integer", nullable: false),
                    IngredienteId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoIngrediente", x => new { x.ProductoId, x.IngredienteId });
                    table.ForeignKey(
                        name: "FK_ProductoIngrediente_Ingrediente_IngredienteId",
                        column: x => x.IngredienteId,
                        principalTable: "Ingrediente",
                        principalColumn: "id_Ingrediente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductoIngrediente_Producto_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Producto",
                        principalColumn: "id_Producto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductoIngrediente_IngredienteId",
                table: "ProductoIngrediente",
                column: "IngredienteId");
        }
    }
}
