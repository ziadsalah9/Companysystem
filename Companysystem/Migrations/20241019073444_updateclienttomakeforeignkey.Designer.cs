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
    [Migration("20241019073444_updateclienttomakeforeignkey")]
    partial class updateclienttomakeforeignkey
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Companysystem.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClientNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("clients");
                });

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

                    b.Property<decimal>("Totalcost")
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

            modelBuilder.Entity("Companysystem.Models.Sales", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("clientID")
                        .HasColumnType("int");

                    b.Property<int>("month")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("clientID");

                    b.ToTable("Salesd");
                });

            modelBuilder.Entity("Companysystem.Models.Sales", b =>
                {
                    b.HasOne("Companysystem.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("clientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });
#pragma warning restore 612, 618
        }
    }
}
