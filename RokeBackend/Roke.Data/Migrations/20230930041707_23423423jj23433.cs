using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Roke.Data.Migrations
{
    public partial class _23423423jj23433 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "idTecnico",
                table: "planning",
                newName: "idBrigade");

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "templateLocationMapping",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "templateLocationMapping");

            migrationBuilder.RenameColumn(
                name: "idBrigade",
                table: "planning",
                newName: "idTecnico");
        }
    }
}
