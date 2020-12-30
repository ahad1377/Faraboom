using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class us : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Tbl_User");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Tbl_User");

            migrationBuilder.DropColumn(
                name: "NumberPhone",
                table: "Tbl_User");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Tbl_User");

            migrationBuilder.DropColumn(
                name: "UploadFile",
                table: "Tbl_User");

            migrationBuilder.AddColumn<string>(
                name: "AddressUs",
                table: "Tbl_User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailUS",
                table: "Tbl_User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Tbl_User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordUs",
                table: "Tbl_User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneUs",
                table: "Tbl_User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfileImageUs",
                table: "Tbl_User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserNameUs",
                table: "Tbl_User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressUs",
                table: "Tbl_User");

            migrationBuilder.DropColumn(
                name: "EmailUS",
                table: "Tbl_User");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Tbl_User");

            migrationBuilder.DropColumn(
                name: "PasswordUs",
                table: "Tbl_User");

            migrationBuilder.DropColumn(
                name: "PhoneUs",
                table: "Tbl_User");

            migrationBuilder.DropColumn(
                name: "ProfileImageUs",
                table: "Tbl_User");

            migrationBuilder.DropColumn(
                name: "UserNameUs",
                table: "Tbl_User");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Tbl_User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Tbl_User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumberPhone",
                table: "Tbl_User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Tbl_User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UploadFile",
                table: "Tbl_User",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
