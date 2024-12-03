using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final.Migrations
{
    /// <inheritdoc />
    public partial class migrationBreakfast : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BreakfastItems",
                columns: table => new
                {
                    breakfastID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    breakfastItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    breakfastItemDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    breakfastItemPrice = table.Column<int>(type: "int", nullable: false),
                    breakfastItemQuantity = table.Column<int>(type: "int", nullable: false),
                    breakfastTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreakfastItems", x => x.breakfastID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BreakfastItems");
        }
    }
}
