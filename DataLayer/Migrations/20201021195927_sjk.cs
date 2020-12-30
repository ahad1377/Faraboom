using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class sjk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryIdGal",
                table: "Tbl_Gallery");

            migrationBuilder.AddColumn<string>(
                name: "pathImage",
                table: "Tbl_Gallery",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pathImage",
                table: "Tbl_Gallery");

            migrationBuilder.AddColumn<string>(
                name: "CategoryIdGal",
                table: "Tbl_Gallery",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
