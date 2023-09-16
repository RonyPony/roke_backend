using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Roke.Data.Migrations
{
    public partial class _242342ffff232wws : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlanningId",
                table: "templateLocationMapping",
                newName: "TemplateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TemplateId",
                table: "templateLocationMapping",
                newName: "PlanningId");
        }
    }
}
