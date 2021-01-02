using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class s : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Tbl_infos",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
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
                    maritalstatus = table.Column<string>(nullable: true),
                    Bankname = table.Column<string>(nullable: true),
                    Bankcode = table.Column<string>(nullable: true),
                    Branchname = table.Column<string>(nullable: true),
                    Accounttype = table.Column<string>(nullable: true),
                    cardnumber = table.Column<string>(nullable: true),
                    Shabanumber = table.Column<string>(nullable: true),
                    accountnumber = table.Column<string>(nullable: true),
                    AccountName = table.Column<string>(nullable: true),
                    PostalcodeBank = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    PhoneHome = table.Column<string>(nullable: true),
                    PhonelocationN = table.Column<string>(nullable: true),
                    PhoneNikatak = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Postalcode = table.Column<string>(nullable: true),
                    homeaddress = table.Column<string>(nullable: true),
                    Locationaddress = table.Column<string>(nullable: true),
                    DiplomDate = table.Column<string>(nullable: true),
                    DiplomLocation = table.Column<string>(nullable: true),
                    KardaniDate = table.Column<string>(nullable: true),
                    KardaniLocation = table.Column<string>(nullable: true),
                    KarshenasiDate = table.Column<string>(nullable: true),
                    KarshenasiLocation = table.Column<string>(nullable: true),
                    ArshadDate = table.Column<string>(nullable: true),
                    ArshadLocation = table.Column<string>(nullable: true),
                    DoktoraDate = table.Column<string>(nullable: true),
                    DoktoraLocation = table.Column<string>(nullable: true),
                    photos = table.Column<string>(nullable: true),
                    Nationalcard = table.Column<string>(nullable: true),
                    Nationalcardback = table.Column<string>(nullable: true),
                    Certificate = table.Column<string>(nullable: true),
                    Shaba = table.Column<string>(nullable: true),
                    Degreeeducation = table.Column<string>(nullable: true),
                    PostalcodeDoc = table.Column<string>(nullable: true),
                    Document = table.Column<string>(nullable: true),
                    Badbackground = table.Column<string>(nullable: true),
                    Receipt = table.Column<string>(nullable: true),
                    Companyname = table.Column<string>(nullable: true),
                    start = table.Column<string>(nullable: true),
                    End = table.Column<string>(nullable: true),
                    Typeactivity = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_infos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_infos");

            migrationBuilder.CreateTable(
                name: "Tbl_Contacts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Locationaddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneHome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNikatak = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhonelocationN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postalcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    homeaddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_info_documents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Badbackground = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Certificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Degreeeducation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationalcard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationalcardback = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postalcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Receipt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shaba = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    photos = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_info_documents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_info_persenals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datebirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Familyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Familyper = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fathernameen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fathernameper = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nameen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nameper = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Religion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Serial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maritalstatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_info_persenals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_info_recordss",
                columns: table => new
                {
                    Companyname = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    End = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Typeactivity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    start = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_info_recordss", x => x.Companyname);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_levels",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ArshadDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArshadLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiplomDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiplomLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoktoraDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoktoraLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KardaniDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KardaniLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KarshenasiDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KarshenasiLocation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_levels", x => x.Id);
                });
        }
    }
}
