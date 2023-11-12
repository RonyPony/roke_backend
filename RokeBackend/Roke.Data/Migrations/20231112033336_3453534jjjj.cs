using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Roke.Data.Migrations
{
    public partial class _3453534jjjj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "photoId1",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "photoId2",
                table: "tickets");

            migrationBuilder.RenameColumn(
                name: "photoId3",
                table: "tickets",
                newName: "idmedia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "idmedia",
                table: "tickets",
                newName: "photoId3");

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
    }
}
