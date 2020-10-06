using Microsoft.EntityFrameworkCore.Migrations;

namespace CarFleet.Migrations
{
    public partial class addNewFieldsInCarModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FuelType",
                table: "Car",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Transmission",
                table: "Car",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FuelType",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "Transmission",
                table: "Car");
        }
    }
}
