using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Companysystem.Migrations
{
    /// <inheritdoc />
    public partial class updateclienttomakeforeignkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "clientName",
                table: "Salesd");

            migrationBuilder.DropColumn(
                name: "clientno",
                table: "Salesd");

            migrationBuilder.AddColumn<int>(
                name: "clientID",
                table: "Salesd",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Salesd_clientID",
                table: "Salesd",
                column: "clientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Salesd_clients_clientID",
                table: "Salesd",
                column: "clientID",
                principalTable: "clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salesd_clients_clientID",
                table: "Salesd");

            migrationBuilder.DropIndex(
                name: "IX_Salesd_clientID",
                table: "Salesd");

            migrationBuilder.DropColumn(
                name: "clientID",
                table: "Salesd");

            migrationBuilder.AddColumn<string>(
                name: "clientName",
                table: "Salesd",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "clientno",
                table: "Salesd",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
