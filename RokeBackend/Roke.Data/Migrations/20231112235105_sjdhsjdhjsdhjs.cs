using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Roke.Data.Migrations
{
    public partial class sjdhsjdhjsdhjs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "brigadeId",
                table: "tickets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "formularios",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idplanning = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idForm = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idTecnico = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    inventarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    startTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    checkOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    frecuencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unidad_AC_antes_preventivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    temperatura_antes_preventivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aviso_precaucion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    equipo_limpio = table.Column<bool>(type: "bit", nullable: false),
                    temperatura_despues_preventivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    limpieza_serpentir_condesador = table.Column<bool>(type: "bit", nullable: false),
                    limpieza_serpentir_evaporador = table.Column<bool>(type: "bit", nullable: false),
                    limpieza_filtro = table.Column<bool>(type: "bit", nullable: false),
                    cambio_filtro = table.Column<bool>(type: "bit", nullable: false),
                    limpieza_bandeja_desague = table.Column<bool>(type: "bit", nullable: false),
                    sopleteo_drenaje = table.Column<bool>(type: "bit", nullable: false),
                    limpieza_rejillas_suministro_retorno = table.Column<bool>(type: "bit", nullable: false),
                    lubricacion_motores = table.Column<bool>(type: "bit", nullable: false),
                    manchas_aceite = table.Column<bool>(type: "bit", nullable: false),
                    medida_amperajeL1_L2_L3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    voltajeL1_L2_L3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    revision_Contactatores = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    revision_relevadores = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    revision_capacitadores = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    revision_sensores_temperatura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    revision_sensores_humedad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    presion_succion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    presion_descarga = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    niveles_aceite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fuga_refigerante = table.Column<bool>(type: "bit", nullable: false),
                    carga_aceite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cantidad_refigerante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    resistencia_calentamiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valvulos_servicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    switch_baja = table.Column<bool>(type: "bit", nullable: false),
                    switch_alta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DGT = table.Column<bool>(type: "bit", nullable: false),
                    switch_aceite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    chequeo_ducteria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    chequeo_estado_aislamiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    capacidad_BTU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipologia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    actividad_ejecutada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formularios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ticketGestions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    IdPlannig = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMedia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTecnico = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdFormulario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CheckIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckStar = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticketGestions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "formularios");

            migrationBuilder.DropTable(
                name: "ticketGestions");

            migrationBuilder.DropColumn(
                name: "brigadeId",
                table: "tickets");
        }
    }
}
