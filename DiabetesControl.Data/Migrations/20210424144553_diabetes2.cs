using Microsoft.EntityFrameworkCore.Migrations;

namespace DiabetesControl.Data.Migrations
{
    public partial class diabetes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BreadGroup",
                table: "NutritiveGroups");

            migrationBuilder.DropColumn(
                name: "EatGroup",
                table: "NutritiveGroups");

            migrationBuilder.DropColumn(
                name: "FatGroup",
                table: "NutritiveGroups");

            migrationBuilder.DropColumn(
                name: "FruitGroup",
                table: "NutritiveGroups");

            migrationBuilder.DropColumn(
                name: "MeatGroup",
                table: "NutritiveGroups");

            migrationBuilder.DropColumn(
                name: "MilkGroup",
                table: "NutritiveGroups");

            migrationBuilder.AddColumn<int>(
                name: "NutritiveGroupName",
                table: "NutritiveGroups",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NutritiveGroupName",
                table: "NutritiveGroups");

            migrationBuilder.AddColumn<string>(
                name: "BreadGroup",
                table: "NutritiveGroups",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EatGroup",
                table: "NutritiveGroups",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FatGroup",
                table: "NutritiveGroups",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FruitGroup",
                table: "NutritiveGroups",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MeatGroup",
                table: "NutritiveGroups",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MilkGroup",
                table: "NutritiveGroups",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
