﻿// <auto-generated />
using System;
using Assignment1.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment1.Migrations
{
    [DbContext(typeof(OrderContext))]
    [Migration("20191112110127_order1")]
    partial class order1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Assignment1.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IName")
                        .IsRequired()
                        .HasColumnName("IName")
                        .HasColumnType("varchar(20)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ItemId");

                    b.ToTable("Item");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            IName = "Pen",
                            Price = 10.0
                        },
                        new
                        {
                            ItemId = 2,
                            IName = "Watch",
                            Price = 500.10000000000002
                        });
                });

            modelBuilder.Entity("Assignment1.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DeliveryDate")
                        .HasColumnType("Date");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("Date");

                    b.HasKey("OrderId");

                    b.HasIndex("ItemId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            DeliveryDate = new DateTime(2019, 11, 19, 16, 31, 25, 893, DateTimeKind.Local).AddTicks(1333),
                            ItemId = 2,
                            OrderDate = new DateTime(2019, 11, 12, 16, 31, 25, 890, DateTimeKind.Local).AddTicks(4743)
                        },
                        new
                        {
                            OrderId = 2,
                            DeliveryDate = new DateTime(2019, 11, 19, 16, 31, 25, 893, DateTimeKind.Local).AddTicks(5909),
                            ItemId = 1,
                            OrderDate = new DateTime(2019, 11, 12, 16, 31, 25, 893, DateTimeKind.Local).AddTicks(5855)
                        },
                        new
                        {
                            OrderId = 3,
                            DeliveryDate = new DateTime(2019, 11, 19, 16, 31, 25, 893, DateTimeKind.Local).AddTicks(6016),
                            ItemId = 2,
                            OrderDate = new DateTime(2019, 11, 12, 16, 31, 25, 893, DateTimeKind.Local).AddTicks(6009)
                        });
                });

            modelBuilder.Entity("Assignment1.Models.Order", b =>
                {
                    b.HasOne("Assignment1.Models.Item", "Item")
                        .WithMany("Order")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
