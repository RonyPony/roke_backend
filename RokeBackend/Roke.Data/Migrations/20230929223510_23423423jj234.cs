using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Roke.Data.Migrations
{
    public partial class _23423423jj234 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "planning",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idTemplate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idTecnico = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    createOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_planning", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "planning");
        }
    }
}
