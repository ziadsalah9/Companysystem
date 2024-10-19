using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Companysystem.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
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

            migrationBuilder.CreateIndex(
                name: "IX_Salesd_clientID",
                table: "Salesd",
                column: "clientID");

            migrationBuilder.CreateIndex(
                name: "IX_Salesd_ItemfkId",
                table: "Salesd",
                column: "ItemfkId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CostsAndExpensesModels");

            migrationBuilder.DropTable(
                name: "Salesd");

            migrationBuilder.DropTable(
                name: "clients");

            migrationBuilder.DropTable(
                name: "items");
        }
    }
}
