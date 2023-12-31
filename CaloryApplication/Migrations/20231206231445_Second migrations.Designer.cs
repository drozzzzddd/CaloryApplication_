﻿// <auto-generated />
using System;
using CaloryApplication.ProductDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CaloryApplication.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20231206231445_Second migrations")]
    partial class Secondmigrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CaloryApplication.Models.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<double>("Quantity")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("CaloryApplication.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CaloriesPer100gr")
                        .HasColumnType("int");

                    b.Property<double>("Carbohydrates")
                        .HasColumnType("double");

                    b.Property<double>("Fats")
                        .HasColumnType("double");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Squirrels")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CaloryApplication.Models.TotalCalories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("TotalConsumeSquirrels")
                        .HasColumnType("double");

                    b.Property<double>("TotalConsumedCalories")
                        .HasColumnType("double");

                    b.Property<double>("TotalConsumedCarbohydrates")
                        .HasColumnType("double");

                    b.Property<double>("TotalConsumedFats")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Calories_table");
                });

            modelBuilder.Entity("CaloryApplication.Models.Meal", b =>
                {
                    b.HasOne("CaloryApplication.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
