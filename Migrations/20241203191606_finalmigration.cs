using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final.Migrations
{
    /// <inheritdoc />
    public partial class finalmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteSong",
                columns: table => new
                {
                    FavoriteSongID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamMemberID = table.Column<int>(type: "int", nullable: false),
                    SongName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteSong", x => x.FavoriteSongID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteSong");
        }
    }
}
