﻿// <auto-generated />
using System;
using Final.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Final.Migrations
{
    [DbContext(typeof(FinalContext))]
    [Migration("20241203191334_migrationSogns")]
    partial class migrationSogns
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Final.Models.BreakfastItems", b =>
                {
                    b.Property<int?>("breakfastID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("breakfastID"));

                    b.Property<string>("breakfastItemDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("breakfastItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("breakfastItemPrice")
                        .HasColumnType("int");

                    b.Property<int>("breakfastItemQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("breakfastTime")
                        .HasColumnType("datetime2");

                    b.HasKey("breakfastID");

                    b.ToTable("BreakfastItems");
                });

            modelBuilder.Entity("Final.Models.FavoriteMovie", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("ID"));

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("FavoriteMovie");
                });

            modelBuilder.Entity("Final.Models.Hobby", b =>
                {
                    b.Property<int?>("HobbyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("HobbyID"));

                    b.Property<bool>("HobbyActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("HobbyAge")
                        .HasColumnType("datetime2");

                    b.Property<string>("HobbyDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HobbyDifficulty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HobbyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HobbyID");

                    b.ToTable("Hobby");
                });

            modelBuilder.Entity("Final.Models.TeamMember", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Program")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TeamMember");
                });
#pragma warning restore 612, 618
        }
    }
}
