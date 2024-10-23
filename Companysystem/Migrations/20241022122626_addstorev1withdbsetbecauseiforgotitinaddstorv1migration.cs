using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Companysystem.Migrations
{
    /// <inheritdoc />
    public partial class addstorev1withdbsetbecauseiforgotitinaddstorv1migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Store_Purchases_PurchasesBillId",
                table: "Store");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Store",
                table: "Store");

            migrationBuilder.RenameTable(
                name: "Store",
                newName: "Stores");

            migrationBuilder.RenameIndex(
                name: "IX_Store_PurchasesBillId",
                table: "Stores",
                newName: "IX_Stores_PurchasesBillId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stores",
                table: "Stores",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Purchases_PurchasesBillId",
                table: "Stores",
                column: "PurchasesBillId",
                principalTable: "Purchases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Purchases_PurchasesBillId",
                table: "Stores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stores",
                table: "Stores");

            migrationBuilder.RenameTable(
                name: "Stores",
                newName: "Store");

            migrationBuilder.RenameIndex(
                name: "IX_Stores_PurchasesBillId",
                table: "Store",
                newName: "IX_Store_PurchasesBillId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Store",
                table: "Store",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Store_Purchases_PurchasesBillId",
                table: "Store",
                column: "PurchasesBillId",
                principalTable: "Purchases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
