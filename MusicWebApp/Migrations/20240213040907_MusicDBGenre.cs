using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicWebApp.Migrations
{
    /// <inheritdoc />
    public partial class MusicDBGenre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Music");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Music",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Music");

            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "Music",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
