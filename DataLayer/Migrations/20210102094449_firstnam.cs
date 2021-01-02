using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class firstnam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Contacts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    PhonelocationN = table.Column<string>(nullable: true),
                    PhoneNikatak = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Postalcode = table.Column<string>(nullable: true),
                    homeaddress = table.Column<string>(nullable: true),
                    Locationaddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_info_documents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    photos = table.Column<string>(nullable: true),
                    Nationalcard = table.Column<string>(nullable: true),
                    Nationalcardback = table.Column<string>(nullable: true),
                    Certificate = table.Column<string>(nullable: true),
                    Shaba = table.Column<string>(nullable: true),
                    Degreeeducation = table.Column<string>(nullable: true),
                    Postalcode = table.Column<string>(nullable: true),
                    Document = table.Column<string>(nullable: true),
                    Badbackground = table.Column<string>(nullable: true),
                    Receipt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_info_documents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_info_persenals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nameper = table.Column<string>(nullable: true),
                    Familyper = table.Column<string>(nullable: true),
                    Fathernameper = table.Column<string>(nullable: true),
                    NationalCode = table.Column<string>(nullable: true),
                    Nameen = table.Column<string>(nullable: true),
                    Familyen = table.Column<string>(nullable: true),
                    Fathernameen = table.Column<string>(nullable: true),
                    Place = table.Column<string>(nullable: true),
                    Serial = table.Column<string>(nullable: true),
                    Religion = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Datebirth = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    maritalstatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_info_persenals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_info_recordss",
                columns: table => new
                {
                    Companyname = table.Column<string>(nullable: false),
                    start = table.Column<string>(nullable: true),
                    End = table.Column<string>(nullable: true),
                    Typeactivity = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_info_recordss", x => x.Companyname);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_levels",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    DiplomDate = table.Column<string>(nullable: true),
                    DiplomLocation = table.Column<string>(nullable: true),
                    KardaniDate = table.Column<string>(nullable: true),
                    KardaniLocation = table.Column<string>(nullable: true),
                    KarshenasiDate = table.Column<string>(nullable: true),
                    KarshenasiLocation = table.Column<string>(nullable: true),
                    ArshadDate = table.Column<string>(nullable: true),
                    ArshadLocation = table.Column<string>(nullable: true),
                    DoktoraDate = table.Column<string>(nullable: true),
                    DoktoraLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_levels", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Contacts");

            migrationBuilder.DropTable(
                name: "Tbl_info_documents");

            migrationBuilder.DropTable(
                name: "Tbl_info_persenals");

            migrationBuilder.DropTable(
                name: "Tbl_info_recordss");

            migrationBuilder.DropTable(
                name: "Tbl_levels");
        }
    }
}
