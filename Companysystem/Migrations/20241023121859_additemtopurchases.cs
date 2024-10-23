using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Companysystem.Migrations
{
    /// <inheritdoc />
    public partial class additemtopurchases : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "item",
                table: "Stores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "item",
                table: "Stores");
        }
    }
}
