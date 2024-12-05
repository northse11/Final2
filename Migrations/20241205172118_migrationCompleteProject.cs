using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final.Migrations
{
    /// <inheritdoc />
    public partial class migrationCompleteProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BreakfastItems",
                keyColumn: "breakfastID",
                keyValue: 3,
                columns: new[] { "breakfastItemDescription", "breakfastItemName", "breakfastItemPrice", "breakfastItemQuantity" },
                values: new object[] { "Scrambled eggs", "Eggs", 2, 2 });

            migrationBuilder.UpdateData(
                table: "BreakfastItems",
                keyColumn: "breakfastID",
                keyValue: 4,
                columns: new[] { "breakfastItemDescription", "breakfastItemName", "breakfastItemQuantity" },
                values: new object[] { "Flat", "Pancake", 5 });

            migrationBuilder.UpdateData(
                table: "BreakfastItems",
                keyColumn: "breakfastID",
                keyValue: 5,
                columns: new[] { "breakfastItemDescription", "breakfastItemName", "breakfastItemPrice", "breakfastItemQuantity", "breakfastTime" },
                values: new object[] { "Maple flavored sausage links", "Sausage", 3, 5, new DateTime(2020, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "FavoriteMovie",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Director", "Genre", "Rating", "ReleaseDate", "Title" },
                values: new object[] { "Larry Charles", "Comedy", 9.0, new DateTime(2006, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borat" });

            migrationBuilder.UpdateData(
                table: "FavoriteSong",
                keyColumn: "FavoriteSongID",
                keyValue: 5,
                columns: new[] { "Artist", "SongName" },
                values: new object[] { "Bob Marley", "Could You be Loved" });

            migrationBuilder.UpdateData(
                table: "Hobby",
                keyColumn: "HobbyID",
                keyValue: 1,
                columns: new[] { "HobbyAge", "HobbyDescription", "HobbyDifficulty", "HobbyName" },
                values: new object[] { new DateTime(2014, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Playing video games on a pc", "Easy", "Gaming" });

            migrationBuilder.UpdateData(
                table: "Hobby",
                keyColumn: "HobbyID",
                keyValue: 5,
                columns: new[] { "HobbyAge", "HobbyDescription", "HobbyDifficulty", "HobbyName" },
                values: new object[] { new DateTime(2016, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Playing golf and trying to lower my score", "Medium", "Golf" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BreakfastItems",
                keyColumn: "breakfastID",
                keyValue: 3,
                columns: new[] { "breakfastItemDescription", "breakfastItemName", "breakfastItemPrice", "breakfastItemQuantity" },
                values: new object[] { "test", "test", 1, 1 });

            migrationBuilder.UpdateData(
                table: "BreakfastItems",
                keyColumn: "breakfastID",
                keyValue: 4,
                columns: new[] { "breakfastItemDescription", "breakfastItemName", "breakfastItemQuantity" },
                values: new object[] { "test", "test", 1 });

            migrationBuilder.UpdateData(
                table: "BreakfastItems",
                keyColumn: "breakfastID",
                keyValue: 5,
                columns: new[] { "breakfastItemDescription", "breakfastItemName", "breakfastItemPrice", "breakfastItemQuantity", "breakfastTime" },
                values: new object[] { "test", "test", 1, 1, new DateTime(2024, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "FavoriteMovie",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Director", "Genre", "Rating", "ReleaseDate", "Title" },
                values: new object[] { "test", "test", 8.5, new DateTime(2024, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "test" });

            migrationBuilder.UpdateData(
                table: "FavoriteSong",
                keyColumn: "FavoriteSongID",
                keyValue: 5,
                columns: new[] { "Artist", "SongName" },
                values: new object[] { "test", "test" });

            migrationBuilder.UpdateData(
                table: "Hobby",
                keyColumn: "HobbyID",
                keyValue: 1,
                columns: new[] { "HobbyAge", "HobbyDescription", "HobbyDifficulty", "HobbyName" },
                values: new object[] { new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hobby....", "test", "Hobby" });

            migrationBuilder.UpdateData(
                table: "Hobby",
                keyColumn: "HobbyID",
                keyValue: 5,
                columns: new[] { "HobbyAge", "HobbyDescription", "HobbyDifficulty", "HobbyName" },
                values: new object[] { new DateTime(2010, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "hobby...", "test", "hobby" });
        }
    }
}
