using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Companysystem.Migrations
{
    /// <inheritdoc />
    public partial class addsalestostore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "salesid",
                table: "Stores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stores_salesid",
                table: "Stores",
                column: "salesid");

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Salesd_salesid",
                table: "Stores",
                column: "salesid",
                principalTable: "Salesd",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Salesd_salesid",
                table: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_Stores_salesid",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "salesid",
                table: "Stores");
        }
    }
}
