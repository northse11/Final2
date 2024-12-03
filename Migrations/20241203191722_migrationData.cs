using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Final.Migrations
{
    /// <inheritdoc />
    public partial class migrationData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FavoriteMovie",
                columns: new[] { "ID", "Director", "Genre", "Rating", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "Christopher Nolan", "Sci-Fi", 8.8000000000000007, new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception" },
                    { 2, "Irvin Kershner", "Sci-Fi", 8.6999999999999993, new DateTime(1980, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode V - The Empire Strikes Back" },
                    { 3, "M Night Shyamalan", "Sci-Fi", 10.0, new DateTime(2002, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Signs" },
                    { 4, "Parker Finn", "Horror", 8.5, new DateTime(2024, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Smile 2" }
                });

            migrationBuilder.InsertData(
                table: "FavoriteSong",
                columns: new[] { "FavoriteSongID", "Artist", "SongName", "TeamMemberID" },
                values: new object[,]
                {
                    { 1, "Queen", "Bohemian Rhapsody", 4 },
                    { 2, "Duran Duran", "Invisible", 2 },
                    { 3, "Eagles", "Lyin' Eyes", 1 },
                    { 4, "Black Out The Sun", "Wildfire", 5 }
                });

            migrationBuilder.InsertData(
                table: "Hobby",
                columns: new[] { "HobbyID", "HobbyActive", "HobbyAge", "HobbyDescription", "HobbyDifficulty", "HobbyName" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hobby....", "Medium", "Hobby" },
                    { 2, true, new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Playing the trumpet for the University of Cincinnati Marching Band.", "Medium", "Marching Band" },
                    { 3, true, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Learning new recipes and cooking new foods", "Medium", "Cooking" },
                    { 4, false, new DateTime(2010, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Playing classical piano music", "Medium", "Playing Piano" }
                });

            migrationBuilder.InsertData(
                table: "TeamMember",
                columns: new[] { "ID", "Birthdate", "FirstName", "LastName", "Program", "Year" },
                values: new object[,]
                {
                    { 1, new DateTime(2004, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steve", "North", "Software", "junior" },
                    { 2, new DateTime(2003, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack", "Cooper", "IT", "test" },
                    { 3, new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isan", "Kalhan", "test", "test" },
                    { 4, new DateTime(2003, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Earl", "Schreck", "IT", "Junior" },
                    { 5, new DateTime(2000, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jon", "Soriano Sanjuan", "Software", "Junior" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FavoriteMovie",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FavoriteMovie",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FavoriteMovie",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FavoriteMovie",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FavoriteSong",
                keyColumn: "FavoriteSongID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FavoriteSong",
                keyColumn: "FavoriteSongID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FavoriteSong",
                keyColumn: "FavoriteSongID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FavoriteSong",
                keyColumn: "FavoriteSongID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hobby",
                keyColumn: "HobbyID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hobby",
                keyColumn: "HobbyID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hobby",
                keyColumn: "HobbyID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hobby",
                keyColumn: "HobbyID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
