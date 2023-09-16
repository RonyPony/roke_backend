using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Roke.Data.Migrations
{
    public partial class _242342ffff232w : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlanningI",
                table: "templateLocationMapping",
                newName: "PlanningId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlanningId",
                table: "templateLocationMapping",
                newName: "PlanningI");
        }
    }
}
