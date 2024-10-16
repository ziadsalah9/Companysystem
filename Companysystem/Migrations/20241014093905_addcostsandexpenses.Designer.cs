﻿// <auto-generated />
using System;
using Companysystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Companysystem.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20241014093905_addcostsandexpenses")]
    partial class addcostsandexpenses
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Companysystem.Models.CostsAndExpensesModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Cars")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Insurance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Mails")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PhoneandInternet")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Rints")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Salaries")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Statment")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("WaterElectericityGas")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("others")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("CostsAndExpensesModels");
                });

            modelBuilder.Entity("Companysystem.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("items");
                });
#pragma warning restore 612, 618
        }
    }
}
