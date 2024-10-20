using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Companysystem.Migrations
{
    /// <inheritdoc />
    public partial class addpurchases : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    deduct = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransportAndShipping = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Customs = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    others = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetPriceValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    priceUnit = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Purchases_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Purchases_items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Salesd_ItemId",
                table: "Salesd",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_ItemId",
                table: "Purchases",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_SupplierId",
                table: "Purchases",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Salesd_items_ItemId",
                table: "Salesd",
                column: "ItemId",
                principalTable: "items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salesd_items_ItemId",
                table: "Salesd");

            migrationBuilder.DropTable(
                name: "Purchases");

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
    }
}
