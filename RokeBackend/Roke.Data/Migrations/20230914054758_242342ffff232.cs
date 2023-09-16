using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Roke.Data.Migrations
{
    public partial class _242342ffff232 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "plannings");

            migrationBuilder.CreateTable(
                name: "template",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idLocation = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    createOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_template", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "templateLocationMapping",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlanningI = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_templateLocationMapping", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "template");

            migrationBuilder.DropTable(
                name: "templateLocationMapping");

            migrationBuilder.CreateTable(
                name: "plannings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plannings", x => x.Id);
                });
        }
    }
}
