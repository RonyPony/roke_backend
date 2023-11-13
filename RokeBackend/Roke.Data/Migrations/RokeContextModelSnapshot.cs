﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RokeBackend.data.DataContext;

#nullable disable

namespace Roke.Data.Migrations
{
    [DbContext(typeof(RokeContext))]
    partial class RokeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Roke.Core.Model.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("assignedUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("brigadeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("contactHasWhatsapp")
                        .HasColumnType("bit");

                    b.Property<string>("contactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("idmedia")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("locationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<string>("ticketType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("tickets");
                });

            modelBuilder.Entity("Roke.Core.Model.TicketGestion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckStar")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdFormulario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdMedia")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdPlannig")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdTecnico")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ticketGestions");
                });

            modelBuilder.Entity("RokeBackend.Model.brigade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("lastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("brigades");
                });

            modelBuilder.Entity("RokeBackend.Model.brigadeAssigne", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("brigadeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("tecnicosId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("brigadeAssinge");
                });

            modelBuilder.Entity("RokeBackend.Model.Form", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DGT")
                        .HasColumnType("bit");

                    b.Property<string>("Unidad_AC_antes_preventivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("actividad_ejecutada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aviso_precaucion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("cambio_filtro")
                        .HasColumnType("bit");

                    b.Property<string>("cantidad_refigerante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("capacidad_BTU")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("carga_aceite")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("checkOut")
                        .HasColumnType("datetime2");

                    b.Property<string>("chequeo_ducteria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("chequeo_estado_aislamiento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("equipo_limpio")
                        .HasColumnType("bit");

                    b.Property<string>("frecuencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("fuga_refigerante")
                        .HasColumnType("bit");

                    b.Property<Guid>("idForm")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("idTecnico")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("idplanning")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("inventarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("limpieza_bandeja_desague")
                        .HasColumnType("bit");

                    b.Property<bool>("limpieza_filtro")
                        .HasColumnType("bit");

                    b.Property<bool>("limpieza_rejillas_suministro_retorno")
                        .HasColumnType("bit");

                    b.Property<bool>("limpieza_serpentir_condesador")
                        .HasColumnType("bit");

                    b.Property<bool>("limpieza_serpentir_evaporador")
                        .HasColumnType("bit");

                    b.Property<bool>("lubricacion_motores")
                        .HasColumnType("bit");

                    b.Property<bool>("manchas_aceite")
                        .HasColumnType("bit");

                    b.Property<string>("medida_amperajeL1_L2_L3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("niveles_aceite")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("observaciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("presion_descarga")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("presion_succion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("resistencia_calentamiento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("revision_Contactatores")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("revision_capacitadores")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("revision_relevadores")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("revision_sensores_humedad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("revision_sensores_temperatura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("sopleteo_drenaje")
                        .HasColumnType("bit");

                    b.Property<DateTime>("startTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("switch_aceite")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("switch_alta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("switch_baja")
                        .HasColumnType("bit");

                    b.Property<string>("temperatura_antes_preventivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("temperatura_despues_preventivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipologia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ubicacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("valvulos_servicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("voltajeL1_L2_L3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("formularios");
                });

            modelBuilder.Entity("RokeBackend.Model.Inventory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("InstallDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location_Conden")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location_Evap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model_Conden")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model_evap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Serial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("area_supply")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("floor_Conden")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("floor_Evap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("item_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("sucursal")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("RokeBackend.Model.location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("contactHasWhatsapp")
                        .HasColumnType("bit");

                    b.Property<string>("contactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("latitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("longitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<string>("sucursal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("location");
                });

            modelBuilder.Entity("RokeBackend.Model.locationMapping", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("idInventory")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("idlocation")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("locationMapping");
                });

            modelBuilder.Entity("RokeBackend.Model.Media", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("uploadDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("media");
                });

            modelBuilder.Entity("RokeBackend.Model.month", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Month")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("order")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("months");
                });

            modelBuilder.Entity("RokeBackend.Model.planning", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdPlan")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("createOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("finalDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("idBrigade")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("idLocation")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("idMonth")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("idTemplate")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("lastUpdate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("planning");
                });

            modelBuilder.Entity("RokeBackend.Model.Template", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("lastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("template");
                });

            modelBuilder.Entity("RokeBackend.Model.TemplateLocationMapping", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TemplateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("templateLocationMapping");
                });

            modelBuilder.Entity("RokeBackend.Model.user", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Statusuario")
                        .HasColumnType("int");

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contacto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rol")
                        .HasColumnType("int");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}
