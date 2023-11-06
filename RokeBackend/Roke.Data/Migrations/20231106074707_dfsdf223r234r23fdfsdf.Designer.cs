﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RokeBackend.data.DataContext;

#nullable disable

namespace Roke.Data.Migrations
{
    [DbContext(typeof(RokeContext))]
    [Migration("20231106074707_dfsdf223r234r23fdfsdf")]
    partial class dfsdf223r234r23fdfsdf
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<DateTime>("createdOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("locationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("photoId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("photoId2")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("photoId3")
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
