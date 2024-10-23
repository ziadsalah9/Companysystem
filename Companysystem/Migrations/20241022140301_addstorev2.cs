using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Companysystem.Migrations
{
    /// <inheritdoc />
    public partial class addstorev2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BeginingStore",
                table: "Stores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EndingStore",
                table: "Stores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "InventoryCost",
                table: "Stores",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "incoming",
                table: "Stores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "outgoing",
                table: "Stores",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BeginingStore",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "EndingStore",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "InventoryCost",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "incoming",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "outgoing",
                table: "Stores");
        }
    }
}
