using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Final.Migrations
{
    /// <inheritdoc />
    public partial class migrationFinalized : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BreakfastItems",
                columns: new[] { "breakfastID", "breakfastItemDescription", "breakfastItemName", "breakfastItemPrice", "breakfastItemQuantity", "breakfastTime" },
                values: new object[,]
                {
                    { 1, "Chocolate Chip Waffles and Syrup", "Waffles", 10, 2, new DateTime(2024, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "God's Gift to the World", "Bacon Cheese McGriddle", 4, 2, new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "test", "test", 1, 1, new DateTime(2024, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "test", "test", 1, 1, new DateTime(2024, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "test", "test", 1, 1, new DateTime(2024, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "FavoriteMovie",
                columns: new[] { "ID", "Director", "Genre", "Rating", "ReleaseDate", "Title" },
                values: new object[] { 5, "test", "test", 8.5, new DateTime(2024, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "test" });

            migrationBuilder.InsertData(
                table: "FavoriteSong",
                columns: new[] { "FavoriteSongID", "Artist", "SongName", "TeamMemberID" },
                values: new object[] { 5, "test", "test", 3 });

            migrationBuilder.UpdateData(
                table: "Hobby",
                keyColumn: "HobbyID",
                keyValue: 1,
                column: "HobbyDifficulty",
                value: "test");

            migrationBuilder.InsertData(
                table: "Hobby",
                columns: new[] { "HobbyID", "HobbyActive", "HobbyAge", "HobbyDescription", "HobbyDifficulty", "HobbyName" },
                values: new object[] { 5, true, new DateTime(2010, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "hobby...", "test", "hobby" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BreakfastItems",
                keyColumn: "breakfastID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BreakfastItems",
                keyColumn: "breakfastID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BreakfastItems",
                keyColumn: "breakfastID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BreakfastItems",
                keyColumn: "breakfastID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BreakfastItems",
                keyColumn: "breakfastID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FavoriteMovie",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FavoriteSong",
                keyColumn: "FavoriteSongID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hobby",
                keyColumn: "HobbyID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Hobby",
                keyColumn: "HobbyID",
                keyValue: 1,
                column: "HobbyDifficulty",
                value: "Medium");
        }
    }
}
