using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Roke.Data.Migrations
{
    public partial class _34gggghfge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Usuario",
                table: "users",
                newName: "User");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "users",
                newName: "IdUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "User",
                table: "users",
                newName: "Usuario");

            migrationBuilder.RenameColumn(
                name: "IdUser",
                table: "users",
                newName: "IdUsuario");
        }
    }
}
