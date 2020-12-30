using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class zars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "paternsms",
                table: "Tbl_Richats",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "website",
                table: "Tbl_Richats",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "paternsms",
                table: "Tbl_Richats");

            migrationBuilder.DropColumn(
                name: "website",
                table: "Tbl_Richats");
        }
    }
}
