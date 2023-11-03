using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Roke.Data.Migrations
{
    public partial class _23234jk232323232 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "brigadeAssinge",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    brigadeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tecnicosId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brigadeAssinge", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "brigades",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    createOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brigades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    sucursal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstallDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location_Conden = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Serial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location_Evap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    area_supply = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    floor_Evap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    floor_Conden = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model_Conden = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model_evap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    item_type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "location",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    sucursal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    latitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    longitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    contactName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contactHasWhatsapp = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "months",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_months", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "planning",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idMonth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idTemplate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idLocation = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idBrigade = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    finalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_planning", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "template",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    TemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_templateLocationMapping", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    createdOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ticketType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    locationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    assignedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    photoId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    photoId2 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    photoId3 = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Statusuario = table.Column<int>(type: "int", nullable: false),
                    contacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rol = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "brigadeAssinge");

            migrationBuilder.DropTable(
                name: "brigades");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "location");

            migrationBuilder.DropTable(
                name: "months");

            migrationBuilder.DropTable(
                name: "planning");

            migrationBuilder.DropTable(
                name: "template");

            migrationBuilder.DropTable(
                name: "templateLocationMapping");

            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
