using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Companysystem.Migrations
{
    /// <inheritdoc />
    public partial class addpurchasesv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salesd_items_ItemId",
                table: "Salesd");

            migrationBuilder.DropIndex(
                name: "IX_Salesd_ItemId",
                table: "Salesd");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Salesd");

            migrationBuilder.CreateIndex(
                name: "IX_Salesd_ItemfkId",
                table: "Salesd",
                column: "ItemfkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Salesd_items_ItemfkId",
                table: "Salesd",
                column: "ItemfkId",
                principalTable: "items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salesd_items_ItemfkId",
                table: "Salesd");

            migrationBuilder.DropIndex(
                name: "IX_Salesd_ItemfkId",
                table: "Salesd");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Salesd",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Salesd_ItemId",
                table: "Salesd",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Salesd_items_ItemId",
                table: "Salesd",
                column: "ItemId",
                principalTable: "items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
