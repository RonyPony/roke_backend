using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Roke.Data.Migrations
{
    public partial class _7876878768787576 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "contactHasWhatsapp",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "contactName",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "contactNumber",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "Idlocation",
                table: "location");

            migrationBuilder.AddColumn<bool>(
                name: "contactHasWhatsapp",
                table: "location",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "contactName",
                table: "location",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "contactNumber",
                table: "location",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "contactHasWhatsapp",
                table: "location");

            migrationBuilder.DropColumn(
                name: "contactName",
                table: "location");

            migrationBuilder.DropColumn(
                name: "contactNumber",
                table: "location");

            migrationBuilder.AddColumn<bool>(
                name: "contactHasWhatsapp",
                table: "tickets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "contactName",
                table: "tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "contactNumber",
                table: "tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "Idlocation",
                table: "location",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
