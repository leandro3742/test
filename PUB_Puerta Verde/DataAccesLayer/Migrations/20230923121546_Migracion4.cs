using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class Migracion4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "registro_Activo",
                table: "Producto",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "registro_Activo",
                table: "Mesa",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "registro_Activo",
                table: "Cliente_Preferencial",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "registro_Activo",
                table: "Categoria",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "registro_Activo",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "registro_Activo",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "registro_Activo",
                table: "Mesa");

            migrationBuilder.DropColumn(
                name: "registro_Activo",
                table: "Cliente_Preferencial");

            migrationBuilder.DropColumn(
                name: "registro_Activo",
                table: "Categoria");

            migrationBuilder.DropColumn(
                name: "registro_Activo",
                table: "AspNetUsers");
        }
    }
}
