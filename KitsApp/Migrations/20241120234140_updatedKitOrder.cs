using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KitsApp.Migrations
{
    /// <inheritdoc />
    public partial class updatedKitOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PizzaName",
                table: "KitOrders",
                newName: "KitNumber");

            migrationBuilder.AddColumn<string>(
                name: "KitName",
                table: "KitOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KitName",
                table: "KitOrders");

            migrationBuilder.RenameColumn(
                name: "KitNumber",
                table: "KitOrders",
                newName: "PizzaName");
        }
    }
}
