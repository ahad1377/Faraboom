using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class fact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Factors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Order = table.Column<int>(nullable: false),
                    Product_Id = table.Column<int>(nullable: false),
                    product_Name = table.Column<string>(nullable: true),
                    Product_Count = table.Column<int>(nullable: false),
                    product_Price = table.Column<int>(nullable: false),
                    Total_sum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Factors", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Factors");
        }
    }
}
