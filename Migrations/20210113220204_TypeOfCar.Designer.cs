﻿// <auto-generated />
using System;
using Galgau_Diana_Proiect.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Galgau_Diana_Proiect.Migrations
{
    [DbContext(typeof(Galgau_Diana_ProiectContext))]
    [Migration("20210113220204_TypeOfCar")]
    partial class TypeOfCar
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Galgau_Diana_Proiect.Models.Car", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<int>("TypeOfCarID")
                        .HasColumnType("int");

                    b.Property<DateTime>("YearOfManufacture")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("TypeOfCarID");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("Galgau_Diana_Proiect.Models.TypeOfCar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeOfCarName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Type");
                });

            modelBuilder.Entity("Galgau_Diana_Proiect.Models.Car", b =>
                {
                    b.HasOne("Galgau_Diana_Proiect.Models.TypeOfCar", "TypeOfCar")
                        .WithMany("Cars")
                        .HasForeignKey("TypeOfCarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
