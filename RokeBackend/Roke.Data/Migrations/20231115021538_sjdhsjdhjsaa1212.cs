using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Roke.Data.Migrations
{
    public partial class sjdhsjdhjsaa1212 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InstallDate",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "Location_Conden",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "Location_Evap",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "Model_Conden",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "Model_evap",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "area_supply",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "floor_Conden",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "floor_Evap",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "item_type",
                table: "Inventories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InstallDate",
                table: "Inventories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Location_Conden",
                table: "Inventories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Location_Evap",
                table: "Inventories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Model_Conden",
                table: "Inventories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Model_evap",
                table: "Inventories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "area_supply",
                table: "Inventories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "floor_Conden",
                table: "Inventories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "floor_Evap",
                table: "Inventories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "item_type",
                table: "Inventories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
