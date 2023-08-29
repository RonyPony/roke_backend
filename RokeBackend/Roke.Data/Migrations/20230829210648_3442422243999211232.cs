using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Roke.Data.Migrations
{
    public partial class _3442422243999211232 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ticketTypeId",
                table: "tickets",
                newName: "photoId3");

            migrationBuilder.RenameColumn(
                name: "localidad",
                table: "tickets",
                newName: "ticketType");

            migrationBuilder.AddColumn<Guid>(
                name: "assignedUserId",
                table: "tickets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "locationId",
                table: "tickets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "photoId1",
                table: "tickets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "photoId2",
                table: "tickets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "assignedUserId",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "locationId",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "photoId1",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "photoId2",
                table: "tickets");

            migrationBuilder.RenameColumn(
                name: "ticketType",
                table: "tickets",
                newName: "localidad");

            migrationBuilder.RenameColumn(
                name: "photoId3",
                table: "tickets",
                newName: "ticketTypeId");
        }
    }
}
