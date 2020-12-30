using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class zar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "enemad",
                table: "Tbl_Richats",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sms",
                table: "Tbl_Richats",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "zarinpal",
                table: "Tbl_Richats",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "enemad",
                table: "Tbl_Richats");

            migrationBuilder.DropColumn(
                name: "sms",
                table: "Tbl_Richats");

            migrationBuilder.DropColumn(
                name: "zarinpal",
                table: "Tbl_Richats");
        }
    }
}
