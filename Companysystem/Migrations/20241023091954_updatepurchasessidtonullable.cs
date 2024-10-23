using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Companysystem.Migrations
{
    /// <inheritdoc />
    public partial class updatepurchasessidtonullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Purchases_PurchasesBillId",
                table: "Stores");

            migrationBuilder.AlterColumn<int>(
                name: "PurchasesBillId",
                table: "Stores",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Purchases_PurchasesBillId",
                table: "Stores",
                column: "PurchasesBillId",
                principalTable: "Purchases",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Purchases_PurchasesBillId",
                table: "Stores");

            migrationBuilder.AlterColumn<int>(
                name: "PurchasesBillId",
                table: "Stores",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Purchases_PurchasesBillId",
                table: "Stores",
                column: "PurchasesBillId",
                principalTable: "Purchases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
