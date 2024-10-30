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
    [Migration("20241030092210_addPriceUnitForStore")]
    partial class addPriceUnitForStore
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

            modelBuilder.Entity("Companysystem.Models.Purchases", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Customs")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<decimal>("NetPriceValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PriceValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<decimal>("TransportAndShipping")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("deduct")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("month")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("others")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("priceUnit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("Companysystem.Models.Sales", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Commissions")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ItemfkId")
                        .HasColumnType("int");

                    b.Property<decimal>("NetPriceValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("clientID")
                        .HasColumnType("int");

                    b.Property<decimal>("deduct")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("month")
                        .HasColumnType("int");

                    b.Property<decimal>("priceValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemfkId");

                    b.HasIndex("clientID");

                    b.ToTable("Salesd");
                });

            modelBuilder.Entity("Companysystem.Models.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BeginingStore")
                        .HasColumnType("int");

                    b.Property<int>("EndingStore")
                        .HasColumnType("int");

                    b.Property<decimal>("InventoryCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("PurchasesBillId")
                        .HasColumnType("int");

                    b.Property<int>("incoming")
                        .HasColumnType("int");

                    b.Property<string>("item")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("outgoing")
                        .HasColumnType("int");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("priceUnit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("salesid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PurchasesBillId");

                    b.HasIndex("salesid");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("Companysystem.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Companysystem.Models.Purchases", b =>
                {
                    b.HasOne("Companysystem.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Companysystem.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Companysystem.Models.Sales", b =>
                {
                    b.HasOne("Companysystem.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemfkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Companysystem.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("clientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Companysystem.Models.Store", b =>
                {
                    b.HasOne("Companysystem.Models.Purchases", "PurchasesBill")
                        .WithMany()
                        .HasForeignKey("PurchasesBillId");

                    b.HasOne("Companysystem.Models.Sales", "Sales")
                        .WithMany()
                        .HasForeignKey("salesid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("PurchasesBill");

                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}
