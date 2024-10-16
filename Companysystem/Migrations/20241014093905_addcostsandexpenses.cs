using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Companysystem.Migrations
{
    /// <inheritdoc />
    public partial class addcostsandexpenses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    others = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostsAndExpensesModels", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CostsAndExpensesModels");
        }
    }
}
