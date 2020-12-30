using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class comment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateMess",
                table: "Tbl_Order");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Tbl_Order");

            migrationBuilder.DropColumn(
                name: "ResiverMess",
                table: "Tbl_Order");

            migrationBuilder.DropColumn(
                name: "SenderMess",
                table: "Tbl_Order");

            migrationBuilder.DropColumn(
                name: "StateMess",
                table: "Tbl_Order");

            migrationBuilder.DropColumn(
                name: "SubjectMess",
                table: "Tbl_Order");

            migrationBuilder.DropColumn(
                name: "TextMess",
                table: "Tbl_Order");

            migrationBuilder.DropColumn(
                name: "CommentCom",
                table: "Tbl_Comments");

            migrationBuilder.DropColumn(
                name: "DateCom",
                table: "Tbl_Comments");

            migrationBuilder.DropColumn(
                name: "NamePersenCom",
                table: "Tbl_Comments");

            migrationBuilder.DropColumn(
                name: "UserNameCom",
                table: "Tbl_Comments");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date_Order",
                table: "Tbl_Order",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Id_user",
                table: "Tbl_Order",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Pay",
                table: "Tbl_Order",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Tbl_Order",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Tbl_Comments",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateComment",
                table: "Tbl_Comments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "User_Id",
                table: "Tbl_Comments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "blog_id",
                table: "Tbl_Comments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "product_id",
                table: "Tbl_Comments",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date_Order",
                table: "Tbl_Order");

            migrationBuilder.DropColumn(
                name: "Id_user",
                table: "Tbl_Order");

            migrationBuilder.DropColumn(
                name: "Pay",
                table: "Tbl_Order");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Tbl_Order");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Tbl_Comments");

            migrationBuilder.DropColumn(
                name: "DateComment",
                table: "Tbl_Comments");

            migrationBuilder.DropColumn(
                name: "User_Id",
                table: "Tbl_Comments");

            migrationBuilder.DropColumn(
                name: "blog_id",
                table: "Tbl_Comments");

            migrationBuilder.DropColumn(
                name: "product_id",
                table: "Tbl_Comments");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateMess",
                table: "Tbl_Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Tbl_Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResiverMess",
                table: "Tbl_Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenderMess",
                table: "Tbl_Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "StateMess",
                table: "Tbl_Order",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SubjectMess",
                table: "Tbl_Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TextMess",
                table: "Tbl_Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommentCom",
                table: "Tbl_Comments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCom",
                table: "Tbl_Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "NamePersenCom",
                table: "Tbl_Comments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserNameCom",
                table: "Tbl_Comments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
