﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using knowledge.common.mysql;

#nullable disable

namespace knowledge.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("knowledge.common.entities.Types.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("CUIT")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("varchar(14)");

                    b.Property<string>("CellphoneNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(320)
                        .HasColumnType("varchar(320)");

                    b.Property<string>("Names")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Surnames")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            Address = "Address1",
                            BirthDate = new DateOnly(1993, 11, 25),
                            CUIT = "20-37978110-2",
                            CellphoneNumber = "1160166647",
                            Email = "facundonicolasminicucci+test1@gmail.com",
                            Names = "Name1",
                            Surnames = "Surname1"
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            Address = "Address2",
                            BirthDate = new DateOnly(1992, 11, 25),
                            CUIT = "20-37978110-2",
                            CellphoneNumber = "1160166647",
                            Email = "facundonicolasminicucci+test2@gmail.com",
                            Names = "Name2",
                            Surnames = "Surname2"
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            Address = "Address3",
                            BirthDate = new DateOnly(1991, 11, 25),
                            CUIT = "20-37978110-2",
                            CellphoneNumber = "1160166647",
                            Email = "facundonicolasminicucci+test3@gmail.com",
                            Names = "Name3",
                            Surnames = "Surname3"
                        },
                        new
                        {
                            Id = 4,
                            Active = true,
                            Address = "Address4",
                            BirthDate = new DateOnly(1990, 11, 25),
                            CUIT = "20-37978110-2",
                            CellphoneNumber = "1160166647",
                            Email = "facundonicolasminicucci+test4@gmail.com",
                            Names = "Name4",
                            Surnames = "Surname4"
                        },
                        new
                        {
                            Id = 5,
                            Active = true,
                            Address = "Address5",
                            BirthDate = new DateOnly(1989, 11, 25),
                            CUIT = "20-37978110-2",
                            CellphoneNumber = "1160166647",
                            Email = "facundonicolasminicucci+test5@gmail.com",
                            Names = "Name5",
                            Surnames = "Surname5"
                        },
                        new
                        {
                            Id = 6,
                            Active = true,
                            Address = "Address6",
                            BirthDate = new DateOnly(1988, 11, 25),
                            CUIT = "20-37978110-2",
                            CellphoneNumber = "1160166647",
                            Email = "facundonicolasminicucci+test6@gmail.com",
                            Names = "Name6",
                            Surnames = "Surname6"
                        },
                        new
                        {
                            Id = 7,
                            Active = true,
                            Address = "Address7",
                            BirthDate = new DateOnly(1987, 11, 25),
                            CUIT = "20-37978110-2",
                            CellphoneNumber = "1160166647",
                            Email = "facundonicolasminicucci+test7@gmail.com",
                            Names = "Name7",
                            Surnames = "Surname7"
                        },
                        new
                        {
                            Id = 8,
                            Active = true,
                            Address = "Address8",
                            BirthDate = new DateOnly(1986, 11, 25),
                            CUIT = "20-37978110-2",
                            CellphoneNumber = "1160166647",
                            Email = "facundonicolasminicucci+test8@gmail.com",
                            Names = "Name8",
                            Surnames = "Surname8"
                        },
                        new
                        {
                            Id = 9,
                            Active = true,
                            Address = "Address9",
                            BirthDate = new DateOnly(1985, 11, 25),
                            CUIT = "20-37978110-2",
                            CellphoneNumber = "1160166647",
                            Email = "facundonicolasminicucci+test9@gmail.com",
                            Names = "Name9",
                            Surnames = "Surname9"
                        },
                        new
                        {
                            Id = 10,
                            Active = true,
                            Address = "Address10",
                            BirthDate = new DateOnly(1984, 11, 25),
                            CUIT = "20-37978110-2",
                            CellphoneNumber = "1160166647",
                            Email = "facundonicolasminicucci+test10@gmail.com",
                            Names = "Name10",
                            Surnames = "Surname10"
                        });
                });

            modelBuilder.Entity("knowledge.common.entities.Types.Trace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Aplicacion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Componente")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<bool>("Exception")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Mensaje")
                        .IsRequired()
                        .HasMaxLength(65535)
                        .HasColumnType("longtext");

                    b.Property<string>("Modulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Traces");
                });

            modelBuilder.Entity("knowledge.common.entities.Types.TraceDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("TraceId")
                        .HasColumnType("int");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasMaxLength(65535)
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("TraceId");

                    b.ToTable("TraceDetails");
                });

            modelBuilder.Entity("knowledge.common.entities.Types.TraceDetail", b =>
                {
                    b.HasOne("knowledge.common.entities.Types.Trace", "Trace")
                        .WithMany("Detalles")
                        .HasForeignKey("TraceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trace");
                });

            modelBuilder.Entity("knowledge.common.entities.Types.Trace", b =>
                {
                    b.Navigation("Detalles");
                });
#pragma warning restore 612, 618
        }
    }
}
