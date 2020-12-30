using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class firsr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Adress",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstAddress = table.Column<string>(nullable: true),
                    SecondAddress = table.Column<string>(nullable: true),
                    LocationAd = table.Column<string>(nullable: true),
                    Tel1Ad = table.Column<string>(nullable: true),
                    Tel2Ad = table.Column<string>(nullable: true),
                    Officetel1Ad = table.Column<string>(nullable: true),
                    Officetel2Ad = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Adress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Agencie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageAg = table.Column<string>(nullable: true),
                    NameAg = table.Column<string>(nullable: true),
                    NamePersenAg = table.Column<string>(nullable: true),
                    TelAg = table.Column<string>(nullable: true),
                    OfficetelAg = table.Column<string>(nullable: true),
                    LocationAg = table.Column<string>(nullable: true),
                    DescreptionAg = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Agencie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Blog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleBLo = table.Column<string>(nullable: true),
                    IdCtegoryBlo = table.Column<int>(nullable: false),
                    SummaryBlo = table.Column<string>(nullable: true),
                    ImageMainBlo = table.Column<string>(nullable: true),
                    FullTextBlo = table.Column<string>(nullable: true),
                    KeywordsBlo = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Blog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserNameCom = table.Column<string>(nullable: true),
                    NamePersenCom = table.Column<string>(nullable: true),
                    CommentCom = table.Column<string>(nullable: true),
                    DateCom = table.Column<DateTime>(nullable: false),
                    State = table.Column<bool>(nullable: false),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Comments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Experts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEx = table.Column<string>(nullable: true),
                    ImageEx = table.Column<string>(nullable: true),
                    TelEx = table.Column<string>(nullable: true),
                    OfficeTelEx = table.Column<string>(nullable: true),
                    LocationEx = table.Column<string>(nullable: true),
                    AboutEx = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Experts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Financial",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserNameFi = table.Column<string>(nullable: true),
                    TelFi = table.Column<string>(nullable: true),
                    RemovalFi = table.Column<string>(nullable: true),
                    DepositFi = table.Column<string>(nullable: true),
                    DateFi = table.Column<DateTime>(nullable: false),
                    StateFi = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Financial", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Gallery",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleGal = table.Column<string>(nullable: true),
                    CategoryIdGal = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Gallery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Logo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleLogo = table.Column<string>(nullable: true),
                    ImageLogo = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Logo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Message",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderMess = table.Column<string>(nullable: true),
                    ResiverMess = table.Column<string>(nullable: true),
                    DateMess = table.Column<DateTime>(nullable: false),
                    SubjectMess = table.Column<string>(nullable: true),
                    TextMess = table.Column<string>(nullable: true),
                    StateMess = table.Column<bool>(nullable: false),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Message", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderMess = table.Column<string>(nullable: true),
                    ResiverMess = table.Column<string>(nullable: true),
                    DateMess = table.Column<DateTime>(nullable: false),
                    SubjectMess = table.Column<string>(nullable: true),
                    TextMess = table.Column<string>(nullable: true),
                    StateMess = table.Column<bool>(nullable: false),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Originality",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProductOri = table.Column<int>(nullable: false),
                    NumberProductOri = table.Column<string>(nullable: true),
                    DateCreateOri = table.Column<DateTime>(nullable: false),
                    HologramCodeOri = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Originality", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleProductPro = table.Column<string>(nullable: true),
                    ImageMainPro = table.Column<string>(nullable: true),
                    CategoryIdPro = table.Column<string>(nullable: true),
                    PricePro = table.Column<string>(nullable: true),
                    OfferPro = table.Column<string>(nullable: true),
                    SizePro = table.Column<string>(nullable: true),
                    ColorPro = table.Column<string>(nullable: true),
                    BrandPro = table.Column<string>(nullable: true),
                    TypeCarPro = table.Column<string>(nullable: true),
                    MaterialPro = table.Column<string>(nullable: true),
                    TotalPro = table.Column<string>(nullable: true),
                    DescreptionPro = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Slider",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleSlid = table.Column<string>(nullable: true),
                    CategoryIdSlid = table.Column<int>(nullable: false),
                    CategoryProductIdSlid = table.Column<int>(nullable: false),
                    TypeSlid = table.Column<string>(nullable: true),
                    ImageMainSlid = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Slider", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_SocialNetwork",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Instagram = table.Column<string>(nullable: true),
                    Telegram = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    Twitter = table.Column<string>(nullable: true),
                    Whatsapp = table.Column<string>(nullable: true),
                    Aparat = table.Column<string>(nullable: true),
                    Youtube = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_SocialNetwork", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Teaser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleTeaser = table.Column<string>(nullable: true),
                    CategoryIdTeaser = table.Column<string>(nullable: true),
                    VideoPathTeaser = table.Column<string>(nullable: true),
                    LinkVideoTeaser = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Teaser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserNameUs = table.Column<string>(nullable: true),
                    EmailUS = table.Column<string>(nullable: true),
                    PhoneUs = table.Column<string>(nullable: true),
                    PasswordUs = table.Column<string>(nullable: true),
                    AddressUs = table.Column<string>(nullable: true),
                    ProfileImageUs = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Adress");

            migrationBuilder.DropTable(
                name: "Tbl_Agencie");

            migrationBuilder.DropTable(
                name: "Tbl_Blog");

            migrationBuilder.DropTable(
                name: "Tbl_Comments");

            migrationBuilder.DropTable(
                name: "Tbl_Experts");

            migrationBuilder.DropTable(
                name: "Tbl_Financial");

            migrationBuilder.DropTable(
                name: "Tbl_Gallery");

            migrationBuilder.DropTable(
                name: "Tbl_Logo");

            migrationBuilder.DropTable(
                name: "Tbl_Message");

            migrationBuilder.DropTable(
                name: "Tbl_Order");

            migrationBuilder.DropTable(
                name: "Tbl_Originality");

            migrationBuilder.DropTable(
                name: "Tbl_Product");

            migrationBuilder.DropTable(
                name: "Tbl_Slider");

            migrationBuilder.DropTable(
                name: "Tbl_SocialNetwork");

            migrationBuilder.DropTable(
                name: "Tbl_Teaser");

            migrationBuilder.DropTable(
                name: "Tbl_User");
        }
    }
}
