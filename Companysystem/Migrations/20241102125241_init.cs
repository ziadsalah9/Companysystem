using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Companysystem.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CostsAndExpensesModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Statment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Salaries = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rints = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PhoneandInternet = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WaterElectericityGas = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Insurance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cars = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Mails = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    others = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Totalcost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostsAndExpensesModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salesd",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    month = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    clientID = table.Column<int>(type: "int", nullable: false),
                    ItemfkId = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    priceValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    deduct = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Commissions = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetPriceValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salesd", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salesd_clients_clientID",
                        column: x => x.clientID,
                        principalTable: "clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Salesd_items_ItemfkId",
                        column: x => x.ItemfkId,
                        principalTable: "items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchasesBillId = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BeginingStore = table.Column<int>(type: "int", nullable: false),
                    incoming = table.Column<int>(type: "int", nullable: false),
                    outgoing = table.Column<int>(type: "int", nullable: false),
                    EndingStore = table.Column<int>(type: "int", nullable: false),
                    InventoryCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    item = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    priceUnit = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stores_Purchases_PurchasesBillId",
                        column: x => x.PurchasesBillId,
                        principalTable: "Purchases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoresTransaction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    storessId = table.Column<int>(type: "int", nullable: false),
                    purchasessId = table.Column<int>(type: "int", nullable: false),
                    salessId = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoresTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoresTransaction_Purchases_purchasessId",
                        column: x => x.purchasessId,
                        principalTable: "Purchases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoresTransaction_Salesd_salessId",
                        column: x => x.salessId,
                        principalTable: "Salesd",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StoresTransaction_Stores_storessId",
                        column: x => x.storessId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_ItemId",
                table: "Purchases",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_SupplierId",
                table: "Purchases",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Salesd_clientID",
                table: "Salesd",
                column: "clientID");

            migrationBuilder.CreateIndex(
                name: "IX_Salesd_ItemfkId",
                table: "Salesd",
                column: "ItemfkId");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_PurchasesBillId",
                table: "Stores",
                column: "PurchasesBillId");

            migrationBuilder.CreateIndex(
                name: "IX_StoresTransaction_purchasessId",
                table: "StoresTransaction",
                column: "purchasessId");

            migrationBuilder.CreateIndex(
                name: "IX_StoresTransaction_salessId",
                table: "StoresTransaction",
                column: "salessId");

            migrationBuilder.CreateIndex(
                name: "IX_StoresTransaction_storessId",
                table: "StoresTransaction",
                column: "storessId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CostsAndExpensesModels");

            migrationBuilder.DropTable(
                name: "StoresTransaction");

            migrationBuilder.DropTable(
                name: "Salesd");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "clients");

            migrationBuilder.DropTable(
                name: "Purchases");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "items");
        }
    }
}
