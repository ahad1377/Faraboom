﻿// <auto-generated />
using System;
using DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Migrations
{
    [DbContext(typeof(ContextHampadco))]
    [Migration("20201230062840_state")]
    partial class state
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataLayer.AdminEntities.Address.Tb_Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Officetel1Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Officetel2Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel1Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel2Ad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Adress");
                });

            modelBuilder.Entity("DataLayer.AdminEntities.Agency.Tb_Agency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescreptionAg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageAg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationAg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamePersenAg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficetelAg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelAg")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Agencie");
                });

            modelBuilder.Entity("DataLayer.AdminEntities.Baner.Tb_Baner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryIdSlid")
                        .HasColumnType("int");

                    b.Property<int>("CategoryProductIdSlid")
                        .HasColumnType("int");

                    b.Property<string>("ImageMainSlid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleSlid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeSlid")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Baner");
                });

            modelBuilder.Entity("DataLayer.AdminEntities.Blog.Tb_Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullTextBlo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCtegoryBlo")
                        .HasColumnType("int");

                    b.Property<string>("ImageMainBlo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KeywordsBlo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SummaryBlo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleBLo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Blog");
                });

            modelBuilder.Entity("DataLayer.AdminEntities.Category.Tb_Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FatherIdCat")
                        .HasColumnType("int");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameCat")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_category");
                });

            modelBuilder.Entity("DataLayer.AdminEntities.Comment.Tb_Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateComment")
                        .HasColumnType("datetime2");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.Property<string>("User_Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("blog_id")
                        .HasColumnType("int");

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Comments");
                });

            modelBuilder.Entity("DataLayer.AdminEntities.Experts.Tb_Experts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutEx")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageEx")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationEx")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEx")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficeTelEx")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelEx")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Experts");
                });

            modelBuilder.Entity("DataLayer.AdminEntities.Financial.Tb_Financial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateFi")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepositFi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RemovalFi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateFi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelFi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserNameFi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Financial");
                });

            modelBuilder.Entity("DataLayer.AdminEntities.Gallery.Tb_Gallery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleGal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pathImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Gallery");
                });

            modelBuilder.Entity("DataLayer.AdminEntities.Gallery.Tb_ImageGallery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdGallery")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tb_ImageGalleries");
                });

            modelBuilder.Entity("DataLayer.AdminEntities.Logo.Tb_Logo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FavIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleLogo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Logo");
                });

            modelBuilder.Entity("DataLayer.AdminEntities.Message.Tb_Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateMess")
                        .HasColumnType("datetime2");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResiverMess")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderMess")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("StateMess")
                        .HasColumnType("bit");

                    b.Property<string>("SubjectMess")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TextMess")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pathfile")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Message");
                });

            modelBuilder.Entity("DataLayer.AdminEntities.Order.Tb_Factor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_Order")
                        .HasColumnType("int");

                    b.Property<int>("Product_Count")
                        .HasColumnType("int");

                    b.Property<int>("Product_Id")
                        .HasColumnType("int");

                    b.Property<int>("Total_sum")
                        .HasColumnType("int");

                    b.Property<string>("product_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("product_Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Factors");
                });

            modelBuilder.Entity("DataLayer.AdminEntities.Order.Tb_Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date_Order")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_user")
                        .HasColumnType("int");

                    b.Property<string>("Pay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Order");
                });

            modelBuilder.Entity("DataLayer.AdminEntities.Originality.Tb_Originality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreateOri")
                        .HasColumnType("datetime2");

                    b.Property<string>("HologramCodeOri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdProductOri")
                        .HasColumnType("int");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberProductOri")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Originality");
                });

            modelBuilder.Entity("DataLayer.AdminEntities.Product.Tb_GalleryProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdProduct")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tb_GalleryProducts");
                });

            modelBuilder.Entity("DataLayer.AdminEntities.Product.Tb_Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandPro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryIdPro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColorPro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescreptionPro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageMainPro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialPro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfferPro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PricePro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizePro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleProductPro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalPro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeCarPro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Product");
                });

            modelBuilder.Entity("DataLayer.AdminEntities.Richat.Tbl_Richat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ScriptChat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("enemad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("paternsms")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sms")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("website")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zarinpal")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Richats");
                });

            modelBuilder.Entity("DataLayer.AdminEntities.Slider.Tb_Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryIdSlid")
                        .HasColumnType("int");

                    b.Property<int>("CategoryProductIdSlid")
                        .HasColumnType("int");

                    b.Property<string>("ImageMainSlid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleSlid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeSlid")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Slider");
                });

            modelBuilder.Entity("DataLayer.AdminEntities.SocialNetwork.Tb_SocialNetwork", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aparat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telegram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Twitter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Whatsapp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Youtube")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_SocialNetwork");
                });

            modelBuilder.Entity("DataLayer.AdminEntities.Teaser.Tb_Teaser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryIdTeaser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkVideoTeaser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleTeaser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoPathTeaser")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Teaser");
                });

            modelBuilder.Entity("DataLayer.AdminEntities.User.Tb_User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodeMeli")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameFamily")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UploadFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("state")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Tbl_User");
                });
#pragma warning restore 612, 618
        }
    }
}
