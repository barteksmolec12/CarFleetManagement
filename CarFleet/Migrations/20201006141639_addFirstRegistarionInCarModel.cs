using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarFleet.Migrations
{
    public partial class addFirstRegistarionInCarModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Mileage",
                table: "Car",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "FirstRegistarion",
                table: "Car",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstRegistarion",
                table: "Car");

            migrationBuilder.AlterColumn<int>(
                name: "Mileage",
                table: "Car",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
