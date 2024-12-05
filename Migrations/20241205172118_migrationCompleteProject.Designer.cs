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
    [Migration("20241205172118_migrationCompleteProject")]
    partial class migrationCompleteProject
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

                    b.HasData(
                        new
                        {
                            breakfastID = 1,
                            breakfastItemDescription = "Chocolate Chip Waffles and Syrup",
                            breakfastItemName = "Waffles",
                            breakfastItemPrice = 10,
                            breakfastItemQuantity = 2,
                            breakfastTime = new DateTime(2024, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            breakfastID = 2,
                            breakfastItemDescription = "God's Gift to the World",
                            breakfastItemName = "Bacon Cheese McGriddle",
                            breakfastItemPrice = 4,
                            breakfastItemQuantity = 2,
                            breakfastTime = new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            breakfastID = 3,
                            breakfastItemDescription = "Scrambled eggs",
                            breakfastItemName = "Eggs",
                            breakfastItemPrice = 2,
                            breakfastItemQuantity = 2,
                            breakfastTime = new DateTime(2024, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            breakfastID = 4,
                            breakfastItemDescription = "Flat",
                            breakfastItemName = "Pancake",
                            breakfastItemPrice = 1,
                            breakfastItemQuantity = 5,
                            breakfastTime = new DateTime(2024, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            breakfastID = 5,
                            breakfastItemDescription = "Maple flavored sausage links",
                            breakfastItemName = "Sausage",
                            breakfastItemPrice = 3,
                            breakfastItemQuantity = 5,
                            breakfastTime = new DateTime(2020, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
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

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Director = "Christopher Nolan",
                            Genre = "Sci-Fi",
                            Rating = 8.8000000000000007,
                            ReleaseDate = new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Inception"
                        },
                        new
                        {
                            ID = 2,
                            Director = "Irvin Kershner",
                            Genre = "Sci-Fi",
                            Rating = 8.6999999999999993,
                            ReleaseDate = new DateTime(1980, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Star Wars: Episode V - The Empire Strikes Back"
                        },
                        new
                        {
                            ID = 3,
                            Director = "M Night Shyamalan",
                            Genre = "Sci-Fi",
                            Rating = 10.0,
                            ReleaseDate = new DateTime(2002, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Signs"
                        },
                        new
                        {
                            ID = 4,
                            Director = "Parker Finn",
                            Genre = "Horror",
                            Rating = 8.5,
                            ReleaseDate = new DateTime(2024, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Smile 2"
                        },
                        new
                        {
                            ID = 5,
                            Director = "Larry Charles",
                            Genre = "Comedy",
                            Rating = 9.0,
                            ReleaseDate = new DateTime(2006, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Borat"
                        });
                });

            modelBuilder.Entity("Final.Models.FavoriteSong", b =>
                {
                    b.Property<int>("FavoriteSongID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FavoriteSongID"));

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SongName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamMemberID")
                        .HasColumnType("int");

                    b.HasKey("FavoriteSongID");

                    b.ToTable("FavoriteSong");

                    b.HasData(
                        new
                        {
                            FavoriteSongID = 1,
                            Artist = "Queen",
                            SongName = "Bohemian Rhapsody",
                            TeamMemberID = 4
                        },
                        new
                        {
                            FavoriteSongID = 2,
                            Artist = "Duran Duran",
                            SongName = "Invisible",
                            TeamMemberID = 2
                        },
                        new
                        {
                            FavoriteSongID = 3,
                            Artist = "Eagles",
                            SongName = "Lyin' Eyes",
                            TeamMemberID = 1
                        },
                        new
                        {
                            FavoriteSongID = 4,
                            Artist = "Black Out The Sun",
                            SongName = "Wildfire",
                            TeamMemberID = 5
                        },
                        new
                        {
                            FavoriteSongID = 5,
                            Artist = "Bob Marley",
                            SongName = "Could You be Loved",
                            TeamMemberID = 3
                        });
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

                    b.HasData(
                        new
                        {
                            HobbyID = 1,
                            HobbyActive = true,
                            HobbyAge = new DateTime(2014, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HobbyDescription = "Playing video games on a pc",
                            HobbyDifficulty = "Easy",
                            HobbyName = "Gaming"
                        },
                        new
                        {
                            HobbyID = 2,
                            HobbyActive = true,
                            HobbyAge = new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HobbyDescription = "Playing the trumpet for the University of Cincinnati Marching Band.",
                            HobbyDifficulty = "Medium",
                            HobbyName = "Marching Band"
                        },
                        new
                        {
                            HobbyID = 3,
                            HobbyActive = true,
                            HobbyAge = new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HobbyDescription = "Learning new recipes and cooking new foods",
                            HobbyDifficulty = "Medium",
                            HobbyName = "Cooking"
                        },
                        new
                        {
                            HobbyID = 4,
                            HobbyActive = false,
                            HobbyAge = new DateTime(2010, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HobbyDescription = "Playing classical piano music",
                            HobbyDifficulty = "Medium",
                            HobbyName = "Playing Piano"
                        },
                        new
                        {
                            HobbyID = 5,
                            HobbyActive = true,
                            HobbyAge = new DateTime(2016, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HobbyDescription = "Playing golf and trying to lower my score",
                            HobbyDifficulty = "Medium",
                            HobbyName = "Golf"
                        });
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

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Birthdate = new DateTime(2004, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Steve",
                            LastName = "North",
                            Program = "Software",
                            Year = "junior"
                        },
                        new
                        {
                            ID = 2,
                            Birthdate = new DateTime(2003, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jack",
                            LastName = "Cooper",
                            Program = "IT",
                            Year = "test"
                        },
                        new
                        {
                            ID = 3,
                            Birthdate = new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Isan",
                            LastName = "Kalhan",
                            Program = "test",
                            Year = "test"
                        },
                        new
                        {
                            ID = 4,
                            Birthdate = new DateTime(2003, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Earl",
                            LastName = "Schreck",
                            Program = "IT",
                            Year = "Junior"
                        },
                        new
                        {
                            ID = 5,
                            Birthdate = new DateTime(2000, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jon",
                            LastName = "Soriano Sanjuan",
                            Program = "Software",
                            Year = "Junior"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
