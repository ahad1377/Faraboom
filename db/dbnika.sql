USE [master]
GO
/****** Object:  Database [nikatek_db]    Script Date: 30/12/2020 04:27:45 ب.ظ ******/
CREATE DATABASE [nikatek_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'nikatek_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\nikatek_db.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'nikatek_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\nikatek_db_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [nikatek_db] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [nikatek_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [nikatek_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [nikatek_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [nikatek_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [nikatek_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [nikatek_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [nikatek_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [nikatek_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [nikatek_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [nikatek_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [nikatek_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [nikatek_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [nikatek_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [nikatek_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [nikatek_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [nikatek_db] SET  ENABLE_BROKER 
GO
ALTER DATABASE [nikatek_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [nikatek_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [nikatek_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [nikatek_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [nikatek_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [nikatek_db] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [nikatek_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [nikatek_db] SET RECOVERY FULL 
GO
ALTER DATABASE [nikatek_db] SET  MULTI_USER 
GO
ALTER DATABASE [nikatek_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [nikatek_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [nikatek_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [nikatek_db] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [nikatek_db] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'nikatek_db', N'ON'
GO
USE [nikatek_db]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 30/12/2020 04:27:45 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_GalleryProducts]    Script Date: 30/12/2020 04:27:46 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_GalleryProducts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdProduct] [int] NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_tb_GalleryProducts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_ImageGalleries]    Script Date: 30/12/2020 04:27:46 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_ImageGalleries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdGallery] [int] NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_tb_ImageGalleries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Adress]    Script Date: 30/12/2020 04:27:46 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Adress](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstAddress] [nvarchar](max) NULL,
	[SecondAddress] [nvarchar](max) NULL,
	[LocationAd] [nvarchar](max) NULL,
	[Tel1Ad] [nvarchar](max) NULL,
	[Tel2Ad] [nvarchar](max) NULL,
	[Officetel1Ad] [nvarchar](max) NULL,
	[Officetel2Ad] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Adress] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Agencie]    Script Date: 30/12/2020 04:27:46 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Agencie](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImageAg] [nvarchar](max) NULL,
	[NameAg] [nvarchar](max) NULL,
	[NamePersenAg] [nvarchar](max) NULL,
	[TelAg] [nvarchar](max) NULL,
	[OfficetelAg] [nvarchar](max) NULL,
	[LocationAg] [nvarchar](max) NULL,
	[DescreptionAg] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
	[Adress] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Agencie] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Baner]    Script Date: 30/12/2020 04:27:46 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Baner](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleSlid] [nvarchar](max) NULL,
	[CategoryIdSlid] [int] NOT NULL,
	[CategoryProductIdSlid] [int] NOT NULL,
	[TypeSlid] [nvarchar](max) NULL,
	[ImageMainSlid] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Baner] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Blog]    Script Date: 30/12/2020 04:27:46 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Blog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleBLo] [nvarchar](max) NULL,
	[IdCtegoryBlo] [int] NOT NULL,
	[SummaryBlo] [nvarchar](max) NULL,
	[ImageMainBlo] [nvarchar](max) NULL,
	[FullTextBlo] [nvarchar](max) NULL,
	[KeywordsBlo] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Blog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_category]    Script Date: 30/12/2020 04:27:46 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameCat] [nvarchar](max) NULL,
	[FatherIdCat] [int] NOT NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbl_category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Comments]    Script Date: 30/12/2020 04:27:46 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Comments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[State] [bit] NOT NULL,
	[Language] [nvarchar](max) NULL,
	[Comment] [nvarchar](max) NULL,
	[DateComment] [datetime2](7) NOT NULL,
	[User_Id] [nvarchar](max) NULL,
	[blog_id] [int] NOT NULL,
	[product_id] [int] NOT NULL,
 CONSTRAINT [PK_Tbl_Comments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Experts]    Script Date: 30/12/2020 04:27:46 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Experts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameEx] [nvarchar](max) NULL,
	[ImageEx] [nvarchar](max) NULL,
	[TelEx] [nvarchar](max) NULL,
	[OfficeTelEx] [nvarchar](max) NULL,
	[LocationEx] [nvarchar](max) NULL,
	[AboutEx] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
	[address] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Experts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Factors]    Script Date: 30/12/2020 04:27:46 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Factors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Order] [int] NOT NULL,
	[Product_Id] [int] NOT NULL,
	[product_Name] [nvarchar](max) NULL,
	[Product_Count] [int] NOT NULL,
	[product_Price] [int] NOT NULL,
	[Total_sum] [int] NOT NULL,
 CONSTRAINT [PK_Tbl_Factors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Financial]    Script Date: 30/12/2020 04:27:46 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Financial](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserNameFi] [nvarchar](max) NULL,
	[TelFi] [nvarchar](max) NULL,
	[RemovalFi] [nvarchar](max) NULL,
	[DepositFi] [nvarchar](max) NULL,
	[DateFi] [datetime2](7) NOT NULL,
	[StateFi] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Financial] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Gallery]    Script Date: 30/12/2020 04:27:46 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Gallery](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleGal] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
	[pathImage] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Gallery] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Logo]    Script Date: 30/12/2020 04:27:46 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Logo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleLogo] [nvarchar](max) NULL,
	[ImageLogo] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
	[FavIcon] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Logo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Message]    Script Date: 30/12/2020 04:27:46 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Message](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SenderMess] [nvarchar](max) NULL,
	[ResiverMess] [nvarchar](max) NULL,
	[DateMess] [datetime2](7) NOT NULL,
	[SubjectMess] [nvarchar](max) NULL,
	[TextMess] [nvarchar](max) NULL,
	[StateMess] [bit] NOT NULL,
	[Language] [nvarchar](max) NULL,
	[pathfile] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Message] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Order]    Script Date: 30/12/2020 04:27:46 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Order](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date_Order] [datetime2](7) NOT NULL,
	[Id_user] [int] NOT NULL,
	[Pay] [nvarchar](max) NULL,
	[State] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Originality]    Script Date: 30/12/2020 04:27:46 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Originality](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdProductOri] [int] NOT NULL,
	[NumberProductOri] [nvarchar](max) NULL,
	[DateCreateOri] [datetime2](7) NOT NULL,
	[HologramCodeOri] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Originality] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Product]    Script Date: 30/12/2020 04:27:46 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleProductPro] [nvarchar](max) NULL,
	[ImageMainPro] [nvarchar](max) NULL,
	[CategoryIdPro] [nvarchar](max) NULL,
	[PricePro] [nvarchar](max) NULL,
	[OfferPro] [nvarchar](max) NULL,
	[SizePro] [nvarchar](max) NULL,
	[ColorPro] [nvarchar](max) NULL,
	[BrandPro] [nvarchar](max) NULL,
	[TypeCarPro] [nvarchar](max) NULL,
	[MaterialPro] [nvarchar](max) NULL,
	[TotalPro] [nvarchar](max) NULL,
	[DescreptionPro] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Richats]    Script Date: 30/12/2020 04:27:46 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Richats](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ScriptChat] [nvarchar](max) NULL,
	[enemad] [nvarchar](max) NULL,
	[sms] [nvarchar](max) NULL,
	[zarinpal] [nvarchar](max) NULL,
	[paternsms] [nvarchar](max) NULL,
	[website] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Richats] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Slider]    Script Date: 30/12/2020 04:27:46 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Slider](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleSlid] [nvarchar](max) NULL,
	[CategoryIdSlid] [int] NOT NULL,
	[CategoryProductIdSlid] [int] NOT NULL,
	[TypeSlid] [nvarchar](max) NULL,
	[ImageMainSlid] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Slider] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_SocialNetwork]    Script Date: 30/12/2020 04:27:46 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_SocialNetwork](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Instagram] [nvarchar](max) NULL,
	[Telegram] [nvarchar](max) NULL,
	[Facebook] [nvarchar](max) NULL,
	[Twitter] [nvarchar](max) NULL,
	[Whatsapp] [nvarchar](max) NULL,
	[Aparat] [nvarchar](max) NULL,
	[Youtube] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_SocialNetwork] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Teaser]    Script Date: 30/12/2020 04:27:46 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Teaser](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleTeaser] [nvarchar](max) NULL,
	[CategoryIdTeaser] [nvarchar](max) NULL,
	[VideoPathTeaser] [nvarchar](max) NULL,
	[LinkVideoTeaser] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_Teaser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_User]    Script Date: 30/12/2020 04:27:46 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CodeMeli] [nvarchar](max) NULL,
	[NameFamily] [nvarchar](max) NULL,
	[state] [bit] NOT NULL DEFAULT (CONVERT([bit],(0))),
	[AddressUs] [nvarchar](max) NULL,
	[EmailUS] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
	[PasswordUs] [nvarchar](max) NULL,
	[PhoneUs] [nvarchar](max) NULL,
	[ProfileImageUs] [nvarchar](max) NULL,
	[UserNameUs] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201008172122_firsr', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201011134135_tbl_cat', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201012075047_adadsss', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201018095537_gallerproduct', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201019071104_add', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201019082954_adds', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201021195927_sjk', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201021201102_sjkfg', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201021204328_sjkfgsd', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201028095544_filemsg', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201108180309_comment', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201109112656_richat', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201109113727_richatd', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201110131106_7star', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201110131702_sevenstarrr', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201110133148_sevenstarr', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201116205854_fact', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201118090103_gavicon', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201118144904_zar', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201118150625_zars', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201122073322_db990902', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201230062646_nika', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201230062840_state', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201230072204_us', N'3.1.8')
SET IDENTITY_INSERT [dbo].[Tbl_Blog] ON 

INSERT [dbo].[Tbl_Blog] ([Id], [TitleBLo], [IdCtegoryBlo], [SummaryBlo], [ImageMainBlo], [FullTextBlo], [KeywordsBlo], [Language]) VALUES (1, N'اطلاعیه شماره یک نیکا تک', 12, N'قابل توجه نمایندگان ثبت نام شده تا 8 دی ماه 99 ارسال پیام از طریق واتساب به شماره 09220648677 جهت هماهنگی حضور در شرکت نهایت تا 13 دی ماه میباشد.', N'ec28b0f3-767e-4e67-b849-7c049914475a.jpg', N'<div class="ql-editor ql-blank" data-gramm="false" contenteditable="true"><p class="ql-align-justify">اطلاعیه شماره یک نیکا تک</p><p class="ql-align-justify">قابل توجه نمایندگان ثبت نام شده تا 8 دی ماه 99 ارسال پیام از طریق واتساب به شماره 09220648677 جهت هماهنگی حضور در شرکت نهایت تا 13 دی ماه میباشد. حضور کلیه نمایندگان مستقر در استانها و شهرستانها که تا مورخه هشتم دی ماه سال جاری درخواست نمایندگی ویا ثبت نام نموده اند می رساند. جهت انعقاد قرارداد از مورخه 13 دی ماه تا 30 دی ماه از طریق واتساب پیام ارسال نموده تا جهت هماهنگی برای مراجعه حضوری به همراه اصل مدارک ذیل به آدرس شرکت مندرج در سایت شرکت مراجعه فرمایند . بدیهی است در صورت عدم هماهنگی قبلی و تنظیم زمان حضور در موعد مقرر در مرحله نخست مجوز فعالیت بمدت۶ماه لغو ودرصورت تکرار باعث لغو خاتمه همکاری می باشد . این اطلاعیه به منزله ابلاغ قانونی جهت ثبت نام کنندگان تا هشتم دی ماه است . در هنگام مراجعه اصل مدارک ذیل وخود نماینده الزامی میباشد: اصل شناسنامه و کارت ملی . اصل مدرک تحصیلی عکس 3*4 به تعداد 4 قطعه اصل کلیه مدارک به همراه رسید پرداخت وجه به حساب شرکت با سپاس مدیریت حقوقی وامور قراردادها تاریخ 99.1.09</p><p class="ql-align-center"><a href="https://nikatak.ir/home/maplogin" target="_blank" class="ql-size-large" style="background-color: rgb(0, 102, 204); color: rgb(255, 255, 255);">برای ثبت نام کلیک کنید</a></p></div><div class="ql-clipboard" contenteditable="true" tabindex="-1"></div><div class="ql-tooltip ql-editing ql-flip ql-hidden" data-mode="link" style="left: 388.859px; top: 107.899px;"><a class="ql-preview" target="_blank" href="about:blank"></a><input type="text" data-formula="e=mc^2" data-link="https://quilljs.com" data-video="Embed URL" placeholder="https://quilljs.com"><a class="ql-action"></a><a class="ql-remove"></a></div>', N'نیکاتک', N'fa')
INSERT [dbo].[Tbl_Blog] ([Id], [TitleBLo], [IdCtegoryBlo], [SummaryBlo], [ImageMainBlo], [FullTextBlo], [KeywordsBlo], [Language]) VALUES (2, N'اطلاعیه شماره دو نیکا تک', 12, N'اطلاعیه شماره دو نیکا تک فراخوان دعوت به همکاری 9 تا 19 دی ماه 99 شرکت نیکا تک پیشرو در ارائه خدمات الکترونیکی به مناسبت دهه بصیرت از 9 دی تا 19 دی نسبت به پذیرش و اعطای نمایندگی در سراسر ایران اسلامی برای خدمات هوشمند یکپارچه نیکاتک اقدام می نماید', N'52b28a9a-75cb-4d1f-90e5-a7f5f72a523d.jpg', N'<div class="ql-editor ql-blank" data-gramm="false" contenteditable="true"><p class="ql-align-justify">اطلاعیه شماره دو نیکا تک</p><p class="ql-align-justify">اطلاعیه شماره دو نیکا تک فراخوان دعوت به همکاری 9 تا 19 دی ماه 99 شرکت نیکا تک پیشرو در ارائه خدمات الکترونیکی به مناسبت دهه بصیرت از 9 دی تا 19 دی نسبت به پذیرش و اعطای نمایندگی در سراسر ایران اسلامی برای خدمات هوشمند یکپارچه نیکاتک اقدام می نماید علاقمندان می توانند با مراجعه به آدرس اینترنی nikatak.ir نسبت به ثبت نام و ارسال مدارک اقدام نمایند . شرکت بر اساس رزومه و مدارک ارسالی نسبت به اعطای نمایندگی اقدام خواهد نمود. تاریخ 99.1.09</p><p class="ql-align-center"><a href="https://nikatak.ir/home/maplogin" target="_blank" class="ql-size-large" style="background-color: rgb(0, 102, 204); color: rgb(255, 255, 255);">برای ثبت نام کلیک کنید</a></p></div><div class="ql-clipboard" contenteditable="true" tabindex="-1"></div><div class="ql-tooltip ql-hidden"><a class="ql-preview" target="_blank" href="about:blank"></a><input type="text" data-formula="e=mc^2" data-link="https://quilljs.com" data-video="Embed URL"><a class="ql-action"></a><a class="ql-remove"></a></div>', N'نیکاتک', N'fa')
INSERT [dbo].[Tbl_Blog] ([Id], [TitleBLo], [IdCtegoryBlo], [SummaryBlo], [ImageMainBlo], [FullTextBlo], [KeywordsBlo], [Language]) VALUES (3, N'خوش آمدگویی نیکاتک', 12, N'ضمن عرض سلام و وقت بخیر  خدمت تمام دوستان عزیز 

نیکاتک ورود شما به جامعه نیکاتک را خیر مقدم عرض می نماید', N'975b9596-2826-4e61-b3a1-9a43456f2a99.png', N'<div class="ql-editor ql-blank" data-gramm="false" contenteditable="true"><p class="ql-align-center">ضمن عرض سلام و وقت بخیر  خدمت تمام دوستان عزیز </p><p class="ql-align-center">نیکاتک ورود شما به جامعه نیکاتک را خیر مقدم عرض می نماید.</p><p class="ql-align-center"><img src="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAgAAAADQCAIAAAD+u06rAAAAA3NCSVQICAjb4U/gAAAgAElEQVR4nOzdd5ycxXk48Gfm7e++W2/3epNOOt2pFySBJIwA02zAYBmIe+zEcZzEOPEvsWNc47gndhxjbMc2Nqa40DuIDgIEEuq9Xq+7t/3t78z8/hBgTFU53enu5vuPPvrsu+/Ou7fvPPPOPDODGGPAcRzHTT14vAvAcRzHjQ8eADiO46YoHgA4juOmKB4AOI7jpigeADiO46YoHgA4juOmKB4AOI7jpigeADiO46YoHgA4juOmKB4AOI7jpigeADiO46YoHgA4juOmKB4AOI7jpigeADiO46YoHgA4juOmKB4AOI7jpigeADiO46YoHgA4juOmKB4AOI7jpigeADiO46YoHgA4juOmKB4AOI7jpigeADiO46YoHgA4juOmKB4AOI7jpigeADiO46YoHgA4juOmKB4AOI7jpigeADiO46YoHgA4juOmKB4AOI7jpigeADiO46YoHgA4juOmKB4AOI7jpigeADiO46YoHgA4juOmKB4AOI7jpigeADiO46YoHgA4jntzjFKgdLxLwZ1E4ngXgOO4U5JjD6572i6UmxYtFlqmj3dpuJOCPwFwHPcmCjt23nP+RV+/4oqHvvz1wo6d410c7qTgTwAcd2qxd+0rbt9RNbsd2lpBkcanEK5PbvvjAoDFtYnCn27uJ0H4P76KZ88en8JwJ43wjW98Y7zLwHHcy5hpvfjzXz3zz/+ANuzVGyvV1tZxKUb/E08NfOYzIYC6iKLK+qFNG83unsT8eWJl5biUhztJ+BMAx50yKLOfep4+uWEWVAmbn+j6+370ayF63rtBGNP7lJaK+x97vAagSgY8XKrGkg9C7/33DSxc2FzfALHoWBaGO6n4GADHnTII6fzlHwef31OjRmdpbX7fyP3f/lau49AYl6Jn147em++KyVIMIEJJ2HWmhaNhI7HpW/+Z2bVrjAvDnVQ8AHDcqYJ2dZTvvX4RdFVLgxrkp6tB/bPPHbz6C5AtAgAD8IARYK8ezwBGOUmTMTDL7NGnFwzsFQI5AERSek7ECnIamZsHGOjuHN0P5MYXDwAcd2owy/nnn8YAMxVJdYrgDsa9XJtsmA/dS3KFI4cEo17jvw5C9v799u33VYEQAQFjVDYDATNmWZUoaAYIiHdSP/8kYowSCpS985FTCQ8Ao4fx3xZ3/FzLWn/DzRrAiELdBMpEIaeKhhozAEi6CAAIQAEQ/vJdaHQLYZud9967f/sLpliNsIR9jMueoRvFANKiEAaoaWga3Q8cCxQAgBU8ejDn7h7wc1ZQdpjzFpGMAaMUpsytzAeB3xkNCBaFN3+NASAgfpDrGAiFDdBkLRYa29JxEx9jgFD388+NPPf0rKZEMZ01JFT0QQNmeEQBAJccOVD4ywp/dGt/BgD5XO7Z9Umoiao6KqcDCPSIhv1AR5DJW/C+iyvnzB3VzzyJCKWMMlEUnFwps+uQirWopHu2baYzDEPVkplHvj0KELgec7xix4A3lBWTkVBzjVERHfXYemriAeCdMEYKVnlnt+05Wn1KRFiOGzisY0kEAUFAypsOucMF0Q20ZMp07WytEZ5WI0U0YODnykJExSL/krm3hRCUrP2XXT0foNkWbBtYhoUxEIKGXHMYoL2lZixKAZDN5p5/7JFWvdnUohjV2aWOShw1S2kcjmeKOf2i83AyNQYlGQ0Mma4/XBQUWcw7xn4LQ8nUFWIoLPATggwHS7SSuPnCUP9AoaPPOdxrdg3V1NQ0XHC62MimSO0PPAC8M4SQIKhlkt3f1f/Cdtdx9cp4tLm2qrZajVdAwULdWYVRLRQqpkeAUZESz6Q56suVESMVQ4h3snHvhDF77wFRFquM+ky+vzKOGGGUgY9E3y1OX3i+GAuPTUGMZOWqD/519g+PDFi9kYihSioquTJIQ8VcfPUZzWesGptinJCXa2+EVVlOxvb8z+3TZ8+KNTUCBkKp5ZuW47rlotSJPFMnrhNyIRpL4ZYQnr9YNaJiheFPpdWPeAB4Z4wxMVVRp2jxgumXbaZgsF0h70NgsrIlMMAUYw+pkRRGSPSJtXew2NVTc/Hp4szQyy2JKdSk4I4Z9fwn/3QH8gaRXx1SkmZ5WEeSwSQTpD3gt3zlkxBSx6YkcmXlsv/+ztDKlZu/81O7NBIx4k2egiBywOxqufxydf7isSnGiXBNm7o+dgMoWuKImxoIrOJBVjGiVaVwNIQR0UFmThmEMtGIJMp6vAInRIh5EPjM97r279fC06uq4uN9HWOEB4B3QllhMGPoAh00o7ICcQ1ScUZNsBxnKB34LnFdDUlAPKGUFgTRHClkR4ZZ4JNc2T48DDIgVRI0RdRUJPCnAe5NYFla/N6Ltv3kj3bpQIUUZwSDrILvBdQN5rXrCxaOXesBIVxbU/2Rq85IVu757nfK23bngFEYrL/s/dWXXj5WhTghCEF660FhoGgU3HAZxSsSmf4hsHxEID80lJOCeGVlLBzBmqLJMhYlEGWwXJLO+FbZcR1tSWOsrnq8L2Ls8KUg3glCWBY96qf3diDTVimAQFEyAoqEAChGIhaJ5ZSG0sFQTsxbfq5UHika4XCIYLtj2B3OFPqHjMZqUVP5QwD35hAymhtC5y568NZbRMeMa1WOh32KDoCT/McP1b37fKSMaWYBUhWtvq7i9IUFHTZveMoFmPfjH6tLlhzpWhnLkhwHQZLcku0c6E+ALpoEBUgEJASUIjRSKkaj0WhTs6xh0CXQFCRgRgIoW6RcKvmu1xBPrZwvaWP0vHUq4AHgnYmqjCURZNHqHDYkhSDiiiAKAhIQA1AEUdBCWA2VOvvdoqViWaAsFI0oSKRuYDM7NLc5VJ9CwlvkEXEcACAI1dUk5s5Rdh4o9h2MaVXEp8KslrqPXSK3NgTZDAIFyfLYlUeV5fqGiqVLUwtPb/7bT0dXnwmSdOrX/gAACBRDg75CKFAQlqHklIbTQGhACUFQu2qVHAnneg96gUdFzCihng+Oy/zAooHW3qDVJcf7AsYU75Q4KlJIC9UkLRo4jAQYeY7rOrbluQXbzJWKWFG1+oaIYVAvMItF07KBAlFVOZnwRazWpZA0Tms6chMHgaDlvWfU/vDfdq487War60+Qzi9v0ebOpl39m/71Cz3f/282kBnjIinJyoYPXFpx7pmgKmP80SdC1BVtUVOZmiwsQ1guE3e4XMibZU1VsG4E6Uw2nS5Y5SDwgTFgjFJGCdOmV4eap1DnzxH8CeBoCYpMGKXpElZlFNYYQj4jhUIxMzSkeFSTdJS3rcH0QH9foVisb26WqqrswNOWNOiNVbz3n3t7FEDEEkU5ubKyon1hNjNUvWzZvGv+RdTQ81/73uGb78k981RwYDC0ZLZcMbZNVEGACffwipCoq5T6Ql8JqzphuGPrDsvzqhfMUwM/39vlq0hPxsKxCBYE4vnEdn3bkVtr5caJkuQ6avgg8NFCAooaETHIoLKPZAKYgSSKQghwKbBtKBYDoJlC3iassqlerEk4YBdrpapZ9UiaaPcPN7b8/u7td9wyu32murANkFq5bMl53/kPhlA4VUXXPtZ08/2L1CTyLevem3JR0L76FTxzfNaInkCQKipzm5yQKm8cUCpCUl2imC+wkObkcrIbxA1VZ6LkA3g+FKzAciTTE0wXCJl40e7E8JbpMcBAsYCJ53ll03NdjJCqKLKm+q7n54sQCuULOUPTGlqmUUHwKqTkoumCOob9ttwYoJRYNhvFnXID/6mbrr/x6muu+egV2++/H2QNBKxXp8Kz28Bx9j/3QgYYckohxQiBuvOmm9b95hd+qTBqnz5ZISRENK0yjgUkStKc5UsTyWRQLsoYM0opCagXUNPxLdtzXBoEoiwVh7PBW60PMXnxLqCjxXxqbe9U+izBp0IAmAkYRHA8r1D28yZyfQWrZjpT3dgQqasuShS3V+rTUoAnwrgZd3QoYwM79zx/y+1N8+cIo9QtTp95fOhTnzoH6pYWbfGebQKlKJGSGmdDKbDvfWz4f39XZ+cNmSHRg4CGsNy97ln99BWxWbNG5dMnNwowvKdDiYV1TQ08l9q2AuC7nqpJsqQgQMjxcNkT3EB0g0x3n9xUKVdMrd0O+BPA0fJL5uD6HeC44AXg+pgwFhDqBQIDUZSoH3h9/VVV1RUzZoCua63VoSZe+08ilDHL2n7v/T/89Ge7DhySw6MyNZeB5+x/dl3CgRmAWnCUQO7R7//m+WeehbJpDqY3bNhsZTuiehhTXLI8USKVyQoFoKejczQ+ffJDqmxqgEK6WcxHYzESkPRwWkBYxgJmDFHKPOK7nlUu5zNZv2hTNxjvIo81PgZwtJgTIB8HdtkVXFIFwBIMx4OwUBY05jt+tqj1ZRKVcUxMxzKzjl8p1/LoOjkEhTzdvmv41zf03/jrxctOf+/nP318DScGQIG9ZkE3NPzsk/DVb6lILJFBqbpSKMAcZ0D9wjVgFnPlkerrr6sGyXGskG4orl0kPiuUpwN4uTzYFmj66F3i5IQlbFTFdj28rj6aEpEoySFqB5ZFkKDjgGl5G3uuWB4plkoFgThzaqSGqZUDCjwAHD3R0MMzas0XuyECPmGBZ0KgBVhxgCAaqMBiNbWiQGhftymBN2M2Xx36FHLkb4GO/YEs8L2B3sO/v2XoptvDu7ZJABdecUVs5szjKwUCwK9JpSelbM9z6wjAzFAI7FLWzMVjmj2CYq5XfOSBIvMEgKge9dy8b5sOo7KqOI5tA0QFEUZxEGJSi1ZWZLDouj5jDGEsiJLvE8v1BAbIsrBtEsfGCCij4eqkpGvjXd6xxgPA0RLCitJe27f1YA3Ton0BCxG/YBLkCY4TFCxc8omEBEUesckIJRXVKXFCpU5PSpQQ37YgPcK6+7AkoVSSJWKgqQhjLAjCW0zOYMBo4LGA0P0HyGNPdl/349LhroaKpnUAyruWVXzuH+EEZnW8NgQNPrGu8LXvNoZDzLf1iphcKMgUlQQ9J4qlHXscQ26IxJnHRAYigKgqZepTOZRzPKWxFkLGcZdhStHaGurWrOi99ekE0pSCj/NOcTgXBFWhsMGIZ7pln3hMEaFCq17QLshTrj6cchd8/BAyGqtD9ZV0IFculzAwDyE7gFLZwo6jBdTyPFGuMGJRbX6t3t40IWZNTlqu69n2jqcee/GRx4K+oUQ6Fw0ZJGzko4YVUpPxxKLVZ7UsWwYYAwAgBAwoMMbAZaR7eH/XY4/Z3Wm6Zaf80COtYpUUqUmP9CUba8/49vdBUoDSl994Ijw//+zzCCAUjgwNDuqIidHIULpgaJLPfLtMy8RHcsh2CwiohAAj5HhUlXANQKo2BQCMEoSnVs7i8cAo2tacrt5ePpjBLiRCht6g7R4etB1HMjTKmGVa1AapPi4ZU7FLjQeAo4ZAqop4s1P9ezqaMlhyaajoSLZJCjmMBdXQcyLpGukWquPT5yzHMr8zxw3t6XGu/WnfnX8KHer6AID8ymKsGMAFcAB8gOBb/7lzznxUncKKgkWkEEF0fNmy5cPp6NAuCWAaQA2ApDWogdtl+k9C8O4/3JhYfiYAjELtD1DYvBX/9w/mizE0PDBdEyCddwAnmWRiGTdWp4M0jSo7Dw0sQbFoyMiUepHp4mRiVyaj/vgHM847nzEKvPZ/jTeut0sZDYKAUYpF0OfWFPt680NZVAyY6TKNYDCZWgWEZnN5NKt21gUrxKnX/wM8ABwbhKpam4ZndJOBfuq6hFLPdT3XxYIgMkXVVZOAqMiMAmWMBMGRnobxLvRUQoLy449t+d+fyA8+FAaoFg0NIR+RwLdlBhqEdUEismTLgimA39Ft79rpARUAQgAqgAwgg6ao1Y0NhBzKRpFWDrK2b+JU/SU/+HVqxdkAmFKCT7zmLZvDGzflAWoEATGQKyrMoRzzGTZibnnYm954zuc+y8ojxd/90dm8R7dxFEcCUTycyQgA81pnAEVoNILQpEIpZQwLAmOMMUaBZvIjw9lhwaWqR8u9/UACVUSyKomCGNGpoMie61quS2lQ19YSaq4FcSp+pTwAHAuMws3V5oq2wacPS4gqjEkqUYBY1B0AZ9AMSDwiVRhm5vC0tJrJpsPRSGWyWhAEzG/Xk+PIOPuRph/JDpduuqHnn784EyAMICMkyhZSEaWkHIBuA4YiYog5yHAhgqESoUBmwDAAYMREghDCCAgjI40dSJJjwPCwm97cXHfaddemzr7gSM70if4pGQOEsgO9O597RACYkwqFC47dMywCSFgesM1NwIzVp7d9+ErIDwdabO/V/zPkdM4w2koyeiGbXfCj7ygXXOwST8EaBUATY3m2sYAwRowBgOd5ZadMEVNUdVr9NE1ULDPPCpm8NZIt9+dooEcUpmBRx1krl3et6MKZiQtWgDGFVgB9LT4R7NggAWuGkd28t1goYCFQdIFhajHfFEhoVkPre89uPWt59bRmPWwYhhEKGa7jMmCSyBeDOymO7N6NGEA2vev/rt36ha/FAaIhWSVExIhR5gbMoSDIIAcAwZFsIIaAIcoYZQAgYYaAMQqIMcYoYYQiBlQq+qURYsXPv3jGT69NnrkaK68O6Z9YlYsQAMihkG6E+v7wJ6dYSMoSASTKEgZpJCijK6467cvXSKkGMBJy27zErBZlS3d6eH/Z9qd97MrWv/+0mEhhdCRoHUdW06SGEABgjGVZUWVFk1VVUjAWFFWP1NVGo9GkpothzWG+R2ysSdQIBarSfObyxMJZIEzR7xIxnq147Lqe3vjCLbclQjgqglUqBhISqmLxeYvnXvAeUX1NTyIDQglCiD8BnCSMMYRQkO7t/tEP+7734yqA5kjIclwdETEkeh4pW5QBRFTBQ8z2qcwghEFAAAEwACQhSsDymSUA1sBTkM0YIyLK4w7wwl/90ml/9RGprW1UOv1fh/rOlhuvfeFvv3AuwPR4RdFyfKQ95GRW3/3H6e+76s/HmVb6vrV/+OBnK1Yu+NAN16LpTa90/fNN5o4WIUEm3ZtN91cm6wSED2/dYO7fatvOnHPXiKF4orFB1LUpG0x5ADg2jDHKKLN9O5Mp9nYNvfScSn0UUo36aiteUzt7IRNEWZJVRYVXqqfxLvIkxoAx1rln63X/s/WH1y/VY/UiU3xbiGiBY5ddEgRYwUgXQZUlB3s28cUANIqxB5QyYAgjCAACLHg6cmSWY76TB0qh8aIP61dern7oYlE+ibm81MwUnnyk/IUvw55OGoo6ZmHwUx8967pfgvSX3REBKXf2CoqkNdSevMJMSoyB41j54sjuHZtmzGirb5wpYOGlFx/T0vsQ4OYz3q9VVCEARghgzBhDGKEpFlb5GMDRYoxRSgMS0CDQQqFwqF5IqBnodKwRm9CqRa218XlFs7xz/7a6mrq6qnpRwIT6kqDwfeFPGgQH91nf/L55802rtOqaRKKvd7cGkLE9CiAaaiQRj7mCUnIDp5wVqA0QYaICokQAAcVIAhAFJiiK4iE2MjKYA4gAxP7ls6kvfg2FDTiZtT8A4FAyftEHYp782JqrPLNAL7zg7C9+7fW1PwCIgjGj6aSWZLIiLMgMDyUrq5YuW63rIQELDIAl43uGBhrral2JHEn8RILAGLM9T5ZEDICxMHXabTwAvDPGGKEEAcoXcroeUl+Zgi9rhh6NHhjYE4q1JKoWAYhRSV6xZCUhQe9QdzRsxMNJXvufRI6Tf+jBjptvioBq2oPDvYN1C5Znm2oZclWEWFdnesuuMkAEIAKCIKqyhiQqEJ9ZYHuEMOYxAA/As6AIoJ+1eubqM5Urr4LZc8buEgQZXbbm7K6u577+1ZX/8U2xsX7sPnoKELFQW98oCIL2yj2LAHRF29e1N2DejBl/7vxACOmKElCaL2U1RZMlVRSnRN04JS7yRDDKXN+1bSsSjsZicYz+PPZWsou7Mt0bB/ctr5j+cooIwoBAwHJ9VaOAMcb86z2Jcgc77vuv73cC1C6a3brqXVXLl4krltfHEjWMIoSKhczedU+9+PCjXu9Asn9IO3hA8UADWYEqFxQb0gBJs60+XRUTayoXXbFm+qqzlEgU1DHPBsFIbKxfde21gsEn94469MY87MZkY2VT7aHMbqz8ReMMISQJQiJaUSzlLNuMR5NTIYeb11Bvh1CSzWb1kB6Lxd/YOYgFwXYdXdXbW+e/bkROlvg2ACeXW7bu+NHPWO/wFV/8QvtffQgWLnj1pSO3dSIeX9E8c8VHPwUjI9DXH2zelOvqGPS9nO/LktgSjtQ1zIC5c2F6ExhjuuX6G1EAXvuPmbBq6GrY0MOGGn/jqwjhaKSCkKBYKmqaLkqSOKkzOHgAeHMMGGUskxsJhwxN1d50aCisR/VQUo3W1KZaeErGWGI+2btuw/r7nv/wb29oX/N+0N92En9FBVRUiLPbUp5XQSljDBASRBFECTA+GRk+x4QBBMAEAIH/hMYKdWxJpJadi2g1b3qAIIiRSIRQZrtuWJvMM4R5AHhzjIHlOJFwVHubkUDGPNfChErCFJ1FMl5c09yxcfPn/vSTOWcuA0E4ikqcgSiBKJ2CbTkKIAEQxo5nsVLuuCiK2pcb6RvqijS/eQAAAAELAgZpsvcC8QDw5jBCIUVFb7ujy0C60yxvkPEuRghM8t/JqUWJGJf80yeMsPFWK3q+walbtwoAAEjktf8YytB+U7Az5QEGBL3trTvp04FOwSbRqQJj/PZJwaVi2SdFUXYC4o9ZqTgAQBhHE/Gjrv057i+IWI6FK4hYtl1rvMsyzngAOE4B8eOxVCreLuH4ZG8lcNxE4vvvsLd7Um+ojbe01s0xzdLYFOmUxQPAcSqVS8lETSLaoMgVAnq7p8iA8ucDjhsjDNjug9uHRvo84jB4833TkvG6Cn1abXiRro7K3s4TGB8DOB6EBpoaErBAPFybWCa8ZdInGyr0bN23/t1L1wiIf9Ucd9KVzPwtd/+ixIZXLT1/VtOctubFhhx93THNFQv2HHwRAIX08BRfr4XXSsfDsV1REBkjAXGb6ue8rnJ3fcfzPC9wHnv2gY17ntzfvbGldu70unbMZwVz3Em2v2NPAF46nb770ZvNktM2bdl5Z1x8+sJVYT0sCi8PGoXDySCghASCMNUrwKl+/cdH0zQECBAzQlW6Wg2vdAF5vjs40rd17+Y/PPibwdyOWDiMRKRH0dYDzzdWt8gizxbluJOKDWUHTZoJV4g2LQfByI7+J5+96XZ6Pf3cFT++7Ow1YT0MALJgNFbNPVL7T+XmP/AAcHyOLO98ZP14SVQRAGMwkOlYv3XdzXfdGAqFKcEhqUYSkaKCpgu5fJG3NTju5EOaqhfLWTkkYIQ1JZTLejPqlngWvv3hPxEPLjrroqpElSjIonRyV/qbKHinxAkJAqTJCQDk+e69T9344HN/klXZZ07RznpgajEBZJYvdge+x4Avu81NJBSAjHcZjoMki7F43KeWrGMk+rJOynbWCSw9qj743F0v7thIGMNICry3vB8pffOh40mJN0vfme97gii+WQ8+kiVVljTGYOuerc+9tNb2GECUEaKpOpIDygIRsKRWxyIxfArPRZrkGLgjWWzo0tgv9DaB+AH4BDT51QnJE/T36nu+bbmBxzRdlGU9FEK26TFPMBRSKpc37dx45mkrdVGT3rDs9uDwoB8EGKHB4cHqqupELKGq6qTfHoAHgLdDKMnmcuVSMRKLOrYtClJVZdVrXmeORxBIfuA/9PjDZadTVups1/ZcT1VDioJdWhaZIQWGwET+BDBe7OF0ZsPmypXLxmGlz4mAAbiDg+6eQ+5ghlTGaU1SjRvR6hoRSROx8gvrRk1F83CeUN9zXUIDySxZAoDrOwHxtx/c0Jvubqtr98mf70dK6UBm4IG1D5qWFY0kQprueYGmaIqiTvoBAh4A3o7net093blC1tprPb3+cVlWP3Llh5saGg01BkfuHN91g6Jps8HMgCSFRFEITGKatiAqGhYZIIHJsqTHYxUTtkU14e1Y96y9e1/92avGuyCnpFyutHvHru/+N3ngPh+gDJAHkC+av/CTn62WKsP10/GSuW/+RkZH9u4byOTaT1siaKdQf3pLY2tr85zDz24FCXQ5Yga+JKkS1hBCmq4GgTuSG6a1bX7gU6AYsOmWd+/fedu9t2XzxZBmtIjK+y58b0U8Md7XMUZ4AHg7mqotmDt/MD300vYNlbU1Pf2d1/3upwvntbz/PVckw00YCTVVjSNB9+bdh0te2vaLAROIHwMQgIkMAoqIX0aL2lcubl/J5wGMi6B/YODBh2fNXYAm+6pex2fgqcf2/OPnEgMDLYA1VEll0XSHDz60Pb3+U+U8TLvgE9IPv0iSMVGTVV0DhBA1sR/kh7K0f+CO//jWYRt/8+7bTqkAkIhUvmvhhQcO7NjRvakiWWkzOyRrhDDXc1VFQgy8oIwRSlQkMWDHt9dteeL2B24tla14rHrpwtNWLT0rHo2N90WMHV4rvS0EoijW19QZxtke8Q5277dN564HbxPkwvvP+3zcSNZXT/OkId/3MRIYBcdxsSgYYVUUJd8rMFaOGm2rV16QiFWO95VMUf179mz87S9X3HwH8EkYAADAGGMM8JFVDnu6Nv3m1/mBgSX1c0KFclAqMdcmopgIS7YmIB/ya+/Ysva3fQDNV5yz6Px3BwIxiBfL5R/+wrUlABvDmq98VU6catUlmt7Q9pmP/ftv7/3p09vuEliKeNh1iB+QeDicqohXp2pFUVJUrTfb1dFz8I6H/pDLFVyXapo7f86C5tqptSkbDwBHJRaOLVu0fH/v/g1bN4AkPr/5xpi69LR552fMntpGfdbM9j95t4ohr5S3RUjJqsoEpmowbUb7X6/6xrSa2ZN+KOkUFfiHNm6sAwi5BOhETGk5CRBiiAEA+MHQHQ9W3v/IfNCc3l0KAALAAEkCyQJiOUYBMEBMFvsZCm57auS2J8IAKoAAsAYAQH2ROu0zk2rssRcAACAASURBVIBcgFPoCQAAEAgNybarr/ra+SvX7Di8fduuzXsO7qaWScGJGkpVohoh5Abeb+7/WW9f53BugDC6P7f9xqsfmTtjDHcDPTXwAHC0mmua15x/xc6d+wcKvWU7ct+6O7fsG6qdbl7ZcHFtRSqs6WW3jpmmSdx501csaF8SrYD6hsqWhrmI59qOLfbKeIt18HD5d78PA9gRSZ+cW7xSANy5Y0fT7NlH08fFjrwBEDBW2rjpud/+jgB4YIvttRU4Kuza4wCoDEIIdF3UgwAJCpK1pKKP2Ba1nYQS15lPrCwJaRnLdGYlxTlLT9k6JBaqPH1W5aymeQtblu7at/OxZx7defiJD5zzobieYowNZ/pHBjJ+mZRzjuP7f/eeLy9qWzQFU/VO0T/eqam9ue2fPnb1L+/41c70fQ1VHaTUlyBnyJKBBfb+C9/7q1/lw1R6/6VXnrF0ZVNjsyQihDGv/ccYg5fTrZBlyfc/dNre7ZsAnBod5En5U0dWKbf2t7/85Ne/K0XfeVNJBlAE0BhVCT10x63i9hcbr/7r0KWX6dNaqAOsO087e4qPPmLeeQNYwTQMOnINk4YtuQLHKHVkEvadPgmEkipuNmHxv31VnbcETo2tMBhjtu/ajuO6jixK4VBYkWUAiKvJpa0V85sXJ4Wa7IL3vO+iy2VRH873b9jyTF9Pl4yNec3LzzvzPatXvEuXJvPOX29lUt4VJ9GS+Qs+Tv/qF3fvy+eKAQT76IGOOYfntM5ZOn/F9qX7I1r08ksuD4cir84v9wLPD2gQ+AijkKoL470B4aSHXmn+00Ih92//wkBB4IKkTdIsLNT90nrBcgX5qLZGwAASYwLCxd6+Qy9sW/7/vlLzySvx7DkIMAOAWYz5AT1zqbdifvezjx68+yHVhWgy7Ja8pGygwJdElyKPMlQS6EGA1ctWgTj+e18zANu2s4Xcnp6Dg+lh0ywbWqippn56YzNmKB6NqYqqyOrpy88AxKJGDAAy+SHXsxe1nzZr+rw5s+a3Nrcpb7Px36SGGOP56cfGcZ2u3oOFYn7Dlhey+XQiFf/IFR9XRD3wgNKXf2FDI0O275iWNTQ80js4kCvlMIJZ02a0Ns2QRDEWjYa0cd6IfNIr7965ac68+VrqJTs9a/1TjaefNd4lOglKhetXzl3xg+vbLzz/6N9EitbPPvVPTbPbLvnYx9G0qjcewAAc3+q49ff+nffuu/M+Q5TngVwlKaJbAkBl6m0Alrly9Zob75eUcfsZE0rLptk32L//8KGh9HDJKR8e6XJtRxBFEWHi+hWxmIRxU23TojnzpzVOj4ZjuUI2Go4yynoyB/b37azUGhfNPn28yn+K4E8Ax0xV1FktcwEgFklkcgNYQAcOHmhtaQ8pMVGQbNfqHOzasGNjZ39vOp+O6pW5YskPXGDsYHfH9qrdhqY3VNe1z2iNR+KRcFjg6YknA6Owc6cOIGEwAMTJ1cjxRzLFjk4ZodKzz/g7eqtntR7T2wc7O+WwcfZn/gZVVrzVMZqkz77iI7D8XVpl5eDvb0MO8gVJwMzCdMhj0uKmC67+8jjW/gDAGPN8z7Ss9Eimq6vbAVfV5cDzJUFQJYkgPJweDnx3x+4djz77yHtWX7h0wVLPc4cVWVOV2upaLaT2daUZsCmeoMEDwPHDgdgQn97QMm3L5he2bt2uKGrbzDl3Pnr7vc/dXyauoetYwpamCTHFsUnguDZ4Xm5QSCNF1kK9vbSGGaEQDwAng1fIFR66pxE03ywaAOop0FMxWij42/7wq22fvSYKEABcvOyiiH5sFbFRX/Wxa7+vae/U5S2rMKO16aMfH3xhfbB1t83KIYSIF+APXNj+r1+JLFl+/NcwGkRBSCUqUomK0xYs6uzpHhjqBwGKdql7qMeyTcu2EvEoRmh6fXN1ssY27eH0UF1t/cNPPXDuynOB0ZCku64zxTcDAB4ATkQilZQlwfe9xqZpjz/1ZGNzU6GUVwT105f9veO7Ww9slUKqQ5CIlVRdc1UkWZVICQjrstbaPF1XNf7jO3nM4aHOrVtmGZJTLnoACE+e75ls34x/f+P8aFIGpa/QF7vqYiEaOaYzRBNv2fA/Ar0mk0rYuSc2mNdU0YjqW4eKqb+7ouWfr4H2hcdb/NGHAKY1NE5raAQABlAoF7KFnOs6oiBKkpiMJw3NoIwCAEb4ry79sCrptlsSMc4VM57nqspUHPt9FQ8Ax6+Qz+u6KoqiLGlLFpzWMmMGADS9rxkAGGMrF57h+r7ru5qqVyYqJPz6YTpe+588su+jkSGxXDSwPEQ9NlnG3os7nk2ffebiLPiSKglRBIDOOQvUox/AfDlD6igOZIBQeXg4ffdjyrApqPTAULH0qfOav/0DSDYfZ+lPPgQQM6Ix4/VbgL26kmNFLNXZfbgiEUciYEFxXIcHAO54UErTxcF6vd71/FK5NG369Ne+ihCqTPDZv+OF4YH+5GA+AEFVdd/yCJtosdYtQyEDTAImgaaDLIPnuAe3dn73q0EWqBYuOlZBcNmVV6rTm47lvAgAwPesTZuGh4bDqh6WBXnFSlBeH0IQQtDVM/i9H2Qeuk0V1CGLalecN/vfviecwrX/0aCUhkNhQAIgf+a0GcViIRaJj3ehxhMPAMdppJhxkBVPxKyyGw4f2zM4d1Ixzx384+/jPoCEGfMYADo1ctWPkt3de2jtn+z+3SESlVmUhBLU0FF5pOdLXzQAlqgGtj0FiOX0Nvz1R4TIO6f//yU2tGnD7lVn2gQQQMXqVfFrvjzjvAtfFyEZQO/d93i/+GmrmjCdbA6g6rNXCzMXwWt6hyYijHFFRapnoNOIKyE1NJLOjXeJxhkPAMfsSOZArpghxPOCoGAWmmqn4cnSyTAJUEL3XH/z6QA6I65LEYAgT5hBYH9waMs3v7v3+p/FAJIAMQAG4AMwAFGNRVOR7UODNngSQMtPfhJevOSYz//Mi4e/8HlCYElNVSmbHnnq2d6nLpr20hZx8cI/1+u+N3jPPdl//mwCoMPJ2gCn3fALdfGZR158Q+1/1N1Kp4xUvKo/2yMLCN46CT5XyiEMru8GgZcv5DAWptXPUN+wi8BExwPAn1FK8uWC73sASBRETdUUSX6rrRwLZk4xZAYsGU+NcTm5d4AFDyAEIAq0HGAXgE2cPZ7Kg/39a9fNisp1ml+dYRKRA8ZEqApkYdhzOnu6CQD+9N/p5787dM45YuwdhnNfh1pWx1e+H3txY1NcjQ8PJ0XUIIt5L+i/5Y761lYc1o8cVti+Zdf3vrMcZAnLg7Rcf90PlTVXQej1HeuvnhUATpH5wEdJVpTApfGKCvcN9bnjOkPpwe7e7s7hTiNq5AsjAXFsp8wobp8xr71xdk1lvTiJtnedPFdyIgpmtuQW93XuOtR72HPcgICI5VSiSpPUkBSqSCRrq2pT8dSRYdsjicM+cRHgzt7Dsxrnvi6V80h6DwMWEF/EIgBCCPGcnzHDAl8AQAA0AElXiWUxPGF+58TzxbxZgWI4OywJSFDCvu/byD/gDmRrm6q//IuWWTPUBQsgmTyOk5deemlw3d11iYQHZS8kiMVA1RQNWO/Pf1+5fIl61WVA/OL6Z7d98+upTVt7U01D6a5F3/tW9MOfAONtlvxEp07zP5fL7j+0LxQOBcQfKWYopYl4PKSHQ5pRk6wVX03EYBAzYj19fYiB6zqK8uc4kB4ZvnPt7U+/9KRmhDzi20EhltBikbjvBi/uXdeYal46Z0VrY9uMxlZNOdbOt1PRhLkxThJCSTo/sH7r09s7Nh8a2C+JsioZjuOapitJums6ClJbp7Vdes77krHkqzV40cqWy9molkpWVuG/TDEcTg8Wy0VArFDMprNDqXhKEpRkMuV7pKlx+psVgRtlzCoduTV9AoKmgGWZxeKxNZXHDwIE5a4q0GKi4AZE8C2FoTTLukCmf+1L0z7xcTi6VR/eyMnn999610wARgomZkRCelwzC05EraxxDnf8z/+2r1iY273rpa9fo764fW6i5en0IeXTH4585h/gHYZJT6HOz0Ipf/Ptv4sn4yPmyEh5SFVVSoNUvLK5bsaqhavmzFgoSwoAYIxTFZVPvfiELMiypLTObHt1Oli+mDPd0oLFCw90HLTKNpWDdGmQSJ4iqEZUy1iDDz5356bddWcvOe+sZefJ4oRfQGKqB4BthzY/9My93UN7qOTLqsgYlJ1SMW+algO0gKgwp61J1ESE/iJrs7enNzuUN2oqUolKRX65+eATr3eg57b7fp8zM0UnN1TsJiRQhZgEISwKl59zJQ8AYwMRqr/SKLVdjwCUsxNmrE+gJAURVTcYEagqDCpu14i5D2DFNZ+fduUVx137A0Bx07Yt1/14kYTKkuiaxKeopCFBi9mMCSBCx372fz/v/PYPbBFamlsPd+6PfO3/Lfr01WhCJcnU1tatPvfsx154mAhE0AUqEAY0bQ93bD747IuPX7DiknPPOr+pqgUAAKGVS991z31316YaXq39R3KZZCJ5yTmX3fLwjQHxauqq+kY6ym5BKGJFVKke0WTdCIcAkwfW3Wnb9pnLz4kbE6Vp8eambgCwXHvj7hceWHdnyS6pWsiBAiH+SCE/kitiLGlGJKpHHTeoqqq6dNWlldHK4ZHhquTLC6foip7uGFo+7yz5lTWkSuXS2sfXvrDlua6Rg3pUJrIvRWRVEgCHsBhb0DzvXStWHzmSzz4/2Zgg+ABIAFmEkbJVAqjFE6SHmgRo83YRAmRZGAqWC3vLoF2xePnff77u9ItAf6te+HdGM/n1195QBdWiMijm3RTFLlOdQKrQ9KKV1RFN2uWuX/9WBFiWqhrp3I9h1pzP/auQqB7FixsDsqisXnXOvuFdB4b2CJgNDPQaaggARyqi5Zz5rZv/PWNm/mbNZyoiSYRQKpGqr6/zfe/Ie0tmyff9msq6mso6Laz96E//lfXz0foIK4+YZmE42x+xYzE14sgJX3WiWsUzzz+yf+/e9559+fQZMyfuWnJTNADs6drx5AtPPL/zqapUIhxRR3KDI0G2r7dHFnRDjRKX1oQrZaSXXevyVZe1Ns6ijI3kMvliIRaJAoDl2ZFUqrqm7shjgemU71r7x1se/bmiKUZFyMeOY7sI4aiejNLkrObZl666PK6/vI0wmlhpdIQObtrqxELNrbMCYPjIavKjbdf69Yna2pqmY0ppf0tIkikAI4BEEIE1LF1U2VQ3Kmc+6QRWKPfEwM2CFpm/SvvHj7ZGjVRbi7RgMcDxt/2BEH/dk+ieGxZEqpgLlGIakRlhCoLAGlFYIIV05jqK5eFozZ6BAfzey07/ty8oiTdZJ+7UV6ElL1l62XW3HCoytzpS0zXYiyXQDK2iLjY3WPDMlgeiUemTl3xekmRZUlYsXbl551bP9yijlJFUxctzd1rr2v7hks+ufeDeXSPbxHCjDU5E8J2ya1MWOCVRVEcGOkNKqPPws0VauIhesnj2UgXr43vhx+cU6r8bK2x357Yb7v3Z4xvudLxC92DH4d59w7nBrJ3Xk2EtqhsRo7qyRpdCUSV+9VX/MrNhFgBghJLxJEbI9mwAKFmlxQuXadrLf/Jde7fcsvYncjwI1yJT7B8sHbC8AsIQeKA6yrL25bXJ2iNHIgCYUEPBdlffU9/6EdgWADA4KWuq9e/f98hvfiuN4lwtho40+KkHGCAxry2UPP49vikhhIzRbmIUUCmGa0BHoDrz54Uuv6z2qg9JC5afUO0PwBy7/8kHGwFS5SHkAhaFIoCHAtMvoMDRUSD4jut7SRDUQjkK4sIvfUk564wJ1U55LdQ+fd4lZ66hFqUUwomo6Zs7Du/oSR9WwgzE4h8f/VIQ+EcOlWQlFo/tOLDjQMeBcCjy2myO+TMXXrr6smnatIAABIIkqaIshQwjwDRdzlhgZsmIklT7/J4/PP3bp3c9lnWGfeaP0yUfvykXALr6O+98+Lb8SLkq3hTXkthXsCdLTNV8LYoi5Vw2sFxdDFkFc1H7wvlt81+trhFCkXCEUrZj33Ys49pX9g5lwDZt21gqe5joxMXFrBfYYkRPqdjwrWD2nHmt7bMm6q0UkI7f3IxNu2lGKwAIgEe988pND6/9rx/OX7w4WV87aielwZF/EQABQKKCTyDodu7ckx8YGqWSvQMEoDjEAyEAm1bEQDqhev9VZKB/4K576jFgSTFFRESsUMqCABHAgoBkjXgEmLybupuhlPrFddGlp9BSP8dBFKWzV5333rMuLaVzESHcmJpWG2sIbFzKO5aFXAcc3zlyZEgPabp2x9o7tu/fuv3ANss1X3ueumlNs9rnhiF+7qILP3Tux+sTTVbRiUmxWr2eWszJu8XB0sDhwc59Pbt37jnYdcC0yuNxuSdkCnUBMcYG0gM33fbbfDmfzWZlVUKYCAiLsqLIhuAWQmroox/8dEjVb3/wtlmNs85advar64QEJPA8N1fMp0fSP/j5tz/4/g/Nn/nyTZIr5rbu2IGY4PvUGslTwmoq62Ja3C65K5esvvC89xpGePwu+gQwVnph4+ZvX9P+r99AoRCcnMZCz4sbHv/1r75x/0Mwils2vvIwgREEDEBWsXicNSl1vUf/ePuFH7yyYhTj01tDIBoN7RSYBWmiq6CPxjI1JOi89VanN50AEbCUFykTEQKGGAgYMIggisgFBbDPvJpPXFXx3nNBlif4hF/Q1fB7znpf2Sqt27tOlmRJkAEJCBOz5AxlYPvObWetOIcBM+3yvY/cu2HbCyOF4ee2r6tO1Jw+7/Szlp8tSwoCFIpG5s9ZMmANrVpw9tzp85dMW5HJpQ1VD4eNQrkYECIhiTGQZdkwDBELqjjxlhWaQgEAAASEVyw5qzKVwqIQEM9xLUppPJ7IFUbS+XQsGls2Z2Vn76GZVbMuPW9Nbarh1Tdu2PrcngN78qXcYGYwU07vPLxnwdzTGlMNANDZ07m3Y0+qtsYKypJshEMVihDJDhdbqlsvPueyVHKCrgjEWBAcvO8eAaBxzrEtN3/0yHC697a7zweIH4mRjI1W/9irj20eMEkLCccbXTo2bpH6Mqnqsfsjhirq8kCyANVtLTAaQ4vMsjte3NgEECAi0IAIWHCJTghhDBAKKCHUswEVwYlefn7Nh9aIVRP0F/t6iUjl+85Z89CL9zMsu4SGQwaWWTgitkVX5exsySp19h5+cv1TT7/0uBGNDGaHEEbrt2/Y33XADty2lvZZDbMQoOlNMy7V35+IJhDDLY0tLY0t431Zo2wKBQCEUFWquir1dokNhAYRNfY3V/xDKvXybdA32HPg8L7/+93/DBYGNDWEZTFREX/wmccLBfPcZasrqyq7M12NLQ0EeYQQSVICz+7N97am5n7w4r9uqGoeiws7KVDQuW/D734746wLU6ctOkmfUdix8+CN169Y88mKmTMBRm90BKEjgxUMEAUmhKPH2Zfi+Zvvun/RpRfolccz6+r4CL7vAREAjJkzRqUNTgeHoT9dF6qSzGGX+F5I1l3f8CkVRRCx5wVeQAWgAFBzzVfFxQt8HJImRaIaAlSbav7GJ/4rT/I3PnJTf3+frKjt7QvOXLni9BnLDvbtve/Je5/b8HypXM6Vi0Y0LKtKVWUlkeDGB2+cXjf9by77m7amdlXRWupnAgCdOJPJj8kUCgBHAzFUmaoWXska7B3sufXB32/evYGGxLheTWggykJHbxej+iPPP+Ixe/7cOWcvPSdVH7v9gTsgK1quM6dl2ayG9rOXvLuxqnF8r+X4MQYISrffEx8aEj8wA5r//CREAdhozfovl4M/3GUAiMvnQ+1btzqP57EAvTxoizGjFCUqQDqepnR6w9ZQf6bttMXH8d7jJ0olcHSYqWmjk1kYFIvUdYsYQqIG1E+6KjAEyMdYAgBREGzCKERq/+/bwmmrAADeZn2cCWjxvNMokPamuY9veeq+dQ+KUkjSwsQNNm577rx3nZvOp3fu2elSki8VGuONgii6gR9LJHZ27P31nb/+7Eevbkq+nJk2WRf7mpxXddywILxa+2ey6Z/f8LPNe7eE4zEqUJBBj2udAx0EB6GIUVNX855L3kMRdakjKXJFqlKStOULzvj3j33twxd8rKmqaQK3oRCyO3Y9e/udMYBYLALqn1dSIwAERiUZiAa7tm65/tppAOgtJjelu7oc0zyRxwIMSAbA4Sgcy7ZrR5KdWDr79L9/p+bM5VrzGKaQUp9s25GHwFhQpx/DKv9vB0uiEFCrNAxSSKVYNm0lCIAR6jnEdgLfJ+CkP3AOWvP+I8ezVxY7mTQw4CAgrkOMUCybK6197Jnrb/vVjGktbTNmJasT0XjE9h0QWK5U9EhguubuQ/sK5fJL+7f9180/2rhjUxCMUQ7YuOAB4E1Qxg53d1x3yy8PDHYMZrN7Dh/OOZaHoH84W/Q8rGqZbG7lopUrW1cuaJv3yz9e98DjD/T294iKPlIsH+g95AfBeF/BiUrf9uC8zZtnAXhe8NqOCBFAes3/GSHZ/t7jaDJS09x8w40zABrACFe8PEPitZwdO5/+4CeHvvRN2LrzmM9PyZE/AFa0HIAXCR9ThXak+iv29GSeu3va6ce83OYJCai/eUcZIPSxy3Dj6DxBClWV4ruWPQzsETt9IGr0xOJ7MDqsSZ4RxmpYjlXbAL01lUx7eUL7JKv9CSV7Dh/4zd03r9vyAgbBc4LOw10PP/rgroO7fdE/6/TVnUP9mOGwFivkin09A2bJSYQTVclKQzPW73pp0+7NEypt+5jxAPAmEIJdB/Y+8cI6LIqReDSSiDEJDaSHh3KZcDzik0DU5DMXrtJAM8v2E8+u3bRpE2UMYyGdy9762L37ug6M9xWcCAZmqefuJ6qgPgrA/rIH5nXrftmF/NNrHwhemUt59PJ9vZ3Pv1QHrQ6UaeDBX56WFAvP//znpfVP7Lv2Bzu/9M3S/oPHdvZXlmdyfc8GYMexFrTn73riiZn/7yux6c3H/N4TwcAczDCAUmUKjnGn37eCU8lFn/rb0y66gAGUCiOZ/ABQt2i75XKh6JhFq6QDntnaKpzAIhOnsnK5tG3ntgOdnYqi0YCZppNO5xVNX/fCU26RLpi+ZMXClYRSSZJkSaGMEUIoZQQYwaBIcldPRyaTGe+LOIl4AHgTQ5nMSzu2xmNxxyOuF9iONzJUdiwW1hI40MySu2T63ObqxqJTeOLphyOK3t3bYftOwJAgG8OFwh8evvdAdweboF2phJRuvaN6/VoF+QhAcorgmG91bH7rzsEDHcfcQqJB12+ub96+RZbKPoAz2Pu6BwAy1O/96qYz1YZ2nPIfvi23e9exnV8UAMABKHkuAhD1Y56iWTp46IV/+3xs8RyIjWkKLy1be9fe5QIgdfQ2MMBCdNGS5b/+9ek3Xc/+7qODH1qT+N7X2n7y7ejHPkZrGgbc4gBEm9a8H443U/ZURkjw8NNPbNy7XTVUygIKFFjAPFPBslW2e7q641LF+951sVUq5QZGVKZUGilDMLJ92eHOQcWX6iN1m/dsf+LZJyfrCDDwQeA3YgAdfT3Pb39JkkCVVct081ZRlrSQFgYACsQTzaVzl6QSyR0Htxzs3mPoIZexoeHBqloDCBUFuWtocP3mjfWVNZo68baPCAr5vU8+OQMAY1ck4BzY7fR0qG0L3uRQL+jfsj0STwjHWHeYvT0Hf/HjeTiOGZUBSru2UjuPtVcWHfPt0vpnYoFjBFYSsAdADh4Cz4Ojb8i/MnGXAUsA6KFjDACU5Z55TgexdcnJSn96K8SyDwDMrp1ZO21U1w3EGGrrI2uumrX67GmMRsKa6HpW9obcwI0qGMqcpVBTM5ofd8ooFouHe7oc4mma7vq24zqBH4RUhfgWIDqUHgCAxpqm8844X8Di4b4+BlQWpHBNuGyWcrl8Uk598NKrTps/tt2AY4sHgDdgbEZj039e/cUHn3xo3ZbnZElqStRpmlYql3sG+qsqKhuqapbNP02VteGhPk1kPcWRisrqousWTTOkqYqip2oj63duamtpOW3uold3o54gWP8D96g33SgIelEuF20crF3Xe99dM14fAChQ4m3Ylv7dQ4lPXHBU5z3SyUMp2Hb/9Tc0FEgi5AD2oyVcvvkO78L3KGv+Cqk6ALCRkaFbb60H38AOAtGmwPZsJrmMUHXUU7EoJQAugAkQu/LKqHGMfSn50pbPfH7xN772/9u77zC7qnJh4O9au+/Ty/TeMpNkMimkkE5LpIMKKlU/5YoF8OLj/axXVOyIDflQUUEULEAQkI5ACIEUSC+TZGaS6X1O32e3tdb3R0IJJCEnmSQzzPo9/JF5mHPO2ntm1rtXe19ffX1uLzxuKGN5AQLnn6HUjH7iWKR5vKVVB75IJIf7hpMAqYhnxjc/M+qfNRY4jrN1T/OwlRR0iQjUdexkfMBMJ3y6Rg0ZC4JXDzBgmqxfcdGVU2qnbNm5/cnnn3p984bJdQ351Y2lRSVzZ82pLqvyqKMzFzc28QDwbgihvFAkGgxHw9GiwqL2rn3xdLq1o60wXPjFL1/fWDt1R/N2n+oBAFEUBcQMI+mDAlkWY7G4z1PoMkaBiYq0c2/zlJp6rz6eqkYYPd2v3nnbfPBIKo27LlHB9MLWe39ffcHlePKUdywGYOjbue/ue2JbX5gXuuoo3vjNY6UYJ1ev7frjA0UAHkRsK+vTkWTA9l/eUVtYGjhrOSBgI/F0V1cpgFdTwYh5ATKqiHNJ58kYUIAsQBrAWz9JiOaWsDe2q2UQkjP2r8EyCiczhCczIoDp98EJGzvuX9MZ3rF97z0P+nCgd1L1zAVzT9BnnVouJd1DfWnbRBpyiUMotS3DyCRDXo0gkVFUUlCCAFGXBvRA2BeeP31uWbTo81d/1nEcWZKDwUDQf4QyOB8QPAAcGkKotry6IHpFKpNKZwzLsmRJrq2sFrCAKUumEwBQVVqVfSo1lwAAIABJREFUF8iPRMIYMduyMgxlnawuqUkjHVX03pG+tJEeRwGAuW7fCytr1u6KiLoCLiJQHAWIQXaoN/3l7/lv/RabM23/EQHUvw8efqD9vgdDkF9TNxneb4u0CwwBCIxB1jRvu7Omu0UWRBkR0wavgko9rP/1TeYXb5Zv+a5cXJh59ong5t0KIMvOuIhJDEhAQUoOs0zIttmbhQrlqioI5ZAJzk2mX//7I7WLLiw5UG733Qsc+zdFnZDs0o7rvrEpA6AHfDCKawAHQwigLzH0qweyVr8PIoHGWjXHADleuK7bPTRAFSRKyDRM28mIElJkLAuQBTp3xuJJVZMBQEA4k0wDgKIoNdW1p7rVJxsPAEfi030+3QcHF/3NGllJlAGgpnJKVWn9K9tW+D0F6WRSDgQHY/GGaKVrGZSx3qFeNK4Oj+xo3v3i7+77BIheUchkjEgBEAJhFyORtj3z2Iio7j1/jkKoYAyW7NuurV7pguCBSpg8CQgF4UhXKgCmAIDQzmeeIc+vqBb9QJK2C1oxNvqoF0AE1Ldr5yvf+XmiOBh+6elqAFGSbcfUJDRAgWoyKDl0iNQ2XQC/LnoMVwkEcsoyZFr2i8+uvPiM2WJBEcC7Dyez0TkDcWgkndrz0sragkn1i5ec0N0ZsW17h/7xm0C43hnZteQrXxU94+YZJSeWZW3esytQHlZUYSA5mEolBEY0VREoCYZDi+csEZEIAIqkiOOnYuiom7hXfswSmZgkiwAgIPncpZ8Y6DU3t2yMUio6JEv7jMTuoD+MHNlxFTRWf7EYAGEgvLXlmxK6c4vxrW/NfuVZUfb0u6bs81DbTSbsAt0DtlsBTviJ+/Qn7sMAMkAIQAHcD57EFeUQ9jL2PqmcEQDLxN2XXtZ+eicFELx5JGW5pmWlmKIAUBAIysO4sfW1gd1QqoGfIiwz0cFA8zqhP1izAHKpv4qSGQ2g23CVyz8WXbo0h/tCibJy9czmVcmrz4OI/5AXcuJ+oiRrtb68tvaCZeq0phP1GdR2Xnq27Y6/IgAPyQwCyCXl4zrp2xGoqjp/2pSN7VtNTJN93aaZDvi9gldpMTp/dOHXZk+bCwCMMcM2kPLBvANHY4z2UGOZz+dLZGKEugIWiworFs5burNth8/jp6KTzqaHB7sQpZoU9GsRYawGAAQgIKCMCggzStBQ7+CalV2PPtkAoBHXFbDlWoxJPlkWKGO2HUAogKUywCAILqGMuoyhEBRWL14EAEdT7J7sbW2/9Va2trcCV+KUiZGs6GIsmxEUAAABUR3TAhV5KHglJpkMsq4g+WyHBgByS6jHqNDbWwwgAXhmzYZgLhUNHafv308oAOU1VYdLH3TiuorYpo2hvn04/6OgnajSIqSzK/WNi9haqK8o39veMfn+BwVpHGxUc4lLCMEYS7nsNxME7A/4KbWBUqDUNM2MlfYGlXmNi+fNma/tLwSPgGEQhTH6d3oSTNwrP2aCIABClDEBAAHMbDrtouGP3LPiD45EjaSlCC7yIUkQivKjwMbu9mEEgBAGAERI5m8P9tz16xkgJ2XcXhr1O+B2dgdFJEuyZRoupkxEjgOaIkqinMnaqiC5rpUqxoH6hv3vRoChI6yWpmKZFQ+2r329wJeXzDoiswkzA6oiI2AuuAwYAiBIBDUgSthOuxYllImS1AWD9KLL8utymZm17OTadXGhWCU9FVUVuSWB2LGjbdWrGoQqmw617fWEMszNf/jzEKRKqopBG9VOmdL9izRsJNZ/7/3xtaDnRzqp1dU0derCOcdTZPjkGEkN727b3T/YH/AFaqrqyvJLj/KFCLCGFGyAIOCI7Nd0MN3s4qmLLzz7kgO9PwAwcF2X0A9ysocj4wHgbYQSx7ERwrIkocP3ZpZlIYSkN58avB7feWed3xvrfb11vQsUY8FxHMM1/DVe8Sh6H0KJZVkY4+HYcP/wgOu6oiAURAvDwRBCCBCSJekE7SXFAGBmOx9Zsf3b3y9KJv2gua4VmdHkdvRJnT3UJcBsSqmkIgcz6oLNGHMdRoioeR03Ky2YLjZO3b+t5Ah1Iqlltv17Rd8tP5FFSURAXZPKiCExljJ8XkxtSiggAVyH2bYjKoIiYwIMy0rWyVgA3uVnCxVlh3vzQ3ycY+/u2DtEeso+crk4//Qcbgdjgy17Ym1by5acp5acjOz/B314b3/3+i0jANWTGwCP6jADY6DU2NX8yI9+ZPzlr+dKYFjZtgFj9k9+plWc+nyFlFKE0P5B5P6O2CVkX+e+9q6OdDo1kuzr6NmbMW1KiesyURC9enB6Q1PT5KaSoiJN1Y7wpyGKQl444lhWxjKH40MVJSVL5i9dOves0ry3K48yYIySQ47r9h/kzFrZnqFe0zQd2xFFqSCSnx/Je+83j188AAAAMMZSZqp3oKe1o1UVtcqyyqK8IkVS3vrVfCdJlk0jZjm28maOSY/uu/Lia8SnRa/U3DPUz0zHMBNeUZGPmIWYMeZQsqNl5+ad213b7hvpS1kxxijGyK8Hi/MLvR6/KimVZZUVRRVe9aBJ8NGpLG9lU88+tfXm/1FTGV9BaaK/F8+b6b30vJZHns17facgMAAiYhBEZsggiiBYwAiVBZ+NhAGAshmNot+3f5n0cE1hI33Jhx5I/PbuEIAU9ieGh8qXL2lpac1LJtyk5beY4IIAgAEDBQmQbIMoKLrkOJK+jzl9Dsyur83pKZ5Y1lDWHACYeuYiyCmdDqU93T0agK7roJ7cyh6uy156Ja+ra2RSNZ5axRhFaNT2GdFMzPrPS8l77m/618MaSGpeRdtAX+D8pcVLFp3C2X/KKKXMtM32nk5VVYrzi1LZdO9g72B8qH+or7WrtX9oIJFKArKJSwRBRAjblmvaFulv27p3S8Ub5VPqJp+14My6isMWqxAFsaygNNk3snDuommTG6c0TA0Eg5qi43cssBNCMobxroE6pQyA2bZtO/bLb6x6vW2zJEoYYVmUov7wmXOWFkUKJWGsj5yOEg8AwID19Hdt37t9+77tyVQSu8Lq11eH/NFzz/hQUX6hrmqADsqQJctK1jKzZlZ5R5LhSCBy5fnXuMx9Zctrazes6esaCgeCR55b7OrvfXrl869uXJvIJONGyiUmZeloJOLz+elA5/qda7EgSwxF/KGa0po5TadXlpX7PH4K1LYd27QDvqAiy5IoHVOiWgbZdPeTj7381f+pFuX8+tru5u214cmhi84X5s8zX1xjQVZkOhaRQJ10FjIYvAJgRFwCqigPGkMuQM2116IjRji3r2P3PXd0fONnxQD5urdraLgopGvnL0P/dkeeX12U53EThkpBEAEhJCFJZDKmAsmmkS4NWxnkoMiVnwwsXZzThZFs1s6aXhALp07O6YWUkPauDi8AYATSSf27sHfvabv7Lwqklt34HQiXjuLMYfe+jW/ce7f93bvmAEwT8l1irutpYQDzv/U9saTi/V9/wqQzxmtvrN3RviuWiA/H+gvzi6hAuwe72/vbHWL5PT5BFF3HdR2LEEooQQwjQAwAEwQCa+3Z89qW1es2rrnxUzdOa2g63GJbRUnFr279tcfjDYXCh1ypclw7baQigSgAUEYRINd2DSPr9XtkWXZce2frzo2t23yqx+f1eGS9p7+7o6fjjJlLFp62YLyd8Ty0iR4AGLD+kf5//eexrmw3oa6RMu2MnYqnp9cpQX9AVRQAsCxLFCUBYwBACGGMsIDeWyE94AsAwIfmLps/Za4oiJqqC4d5dLVcu61n30NPrnhs5ZNevzfg8+uiSJmi+3TbsoeTg9SlIhZUiYmKRhWycvOLr25bPamy3ucLWNlsKpHMKygtCBTnB0NzZsyOhqJHswz7DtRp3Ra7/+/dv/nVaYO2GC3oBWMvQN7Xri687noI+KPzF3Xdc3+IYg9jLgBQ8KRBRqAAIxQSHnWHDQVf+KxQUnaEXM1ma/PgnT93f3H3LAAlGO2UlR1G+qwbPyfMmVkU71vz/OoyUdedLMYMMQBKEXIREhlFNpNdKbor3a5U19V95Nxcq2LZLumNp06//afa3Pm5HeOyLXU47gdQZfS+JxtGk2V2rnh459pnpMlNVXNmwtEtqr8/xuxt281f/cr3xz+HAEmyf8BNJSDbDHD6b3+rzz+Vj/8A4NH00uLSWCqeTMUBodfeeIUg4g14wkEvpYrt2JQ5siKkLdulhFCCEcJYQAghRk2XeVXd5/e+suUF4X527WXXLpi5FB/qbAbGuKzsSHEOAfL7g4X5hQAwPDysSIrX59U9GsYYISTLSkVZ2arON1JWimJXViVVl5Nucv2eDWVlZSV5JdJY3eVx9Mb9BRyn3sHeR597dDA2yDzMpTSeiDMHBEX0BXySJO6vDSCJMkKQMQyMsa5pQX9YlATLsQ75hqqsqOH32bXSO9T//bt+unnXRp/qFyQhlkkwRiUZZ0ZSju0AY17NJ8gyQ2DYRtY0CTBZQq29LYNbB5nj1lXVuDHBr4bqaub6vL5c+4tYx+Z1P/uW9tsnvQBRNUKy7qah7pLygoorr4JQBADKLr506Cd349YN4MiKimQduzahFggIZBCQ5tGcQMUnP3WEXrKnb+9/bvvO0O/+cYmI8wGnkslhas9YPidyzXVQUpoXygv85Dfp3sEgEkHGzHVdwkSgCFwCjqaELVFjAOTiC/Iu/nBOlwYAib6B7La90/95DeS4vR3ZjjedZgDCaBRiPHrWjg3rf/hDGSCwYJ63ac5ba7bHae8rL2+87LrAQEu1GMoDLNnxLBAvwIV33Re55rJTngVSEPCU2klFBQXle0vW797oUHM4NggYjGzGdrOu69quZTkWElRKmUNdyhhGGBhjDhGxlEwnBBeVFlVsaF6//aev3Xvbv+pKcxvw7UcINbNZSZISqQShRNM1jDGWD9wcjHF5ScXk6vq93e2AUMpIpylTJbl3uPevj/3txis+H/AGRvWunAITOgD0jwy8+MbKPd1tTKROlqRSKUVVNZ+WzWRL8ot9+oFMkIKAAUDTNMs0MxnDcS1BENRj7SZ2tTX/4r7bm3ev8aiqN4QTmR7TshRNsQjGIGKEMQIjY2SNLEJYFJAoyF7dywihhEUCkXAw1NBQVxyqWTR9cXHkSOUt34uCYz7zGPrh96a/vCUEgiToWZN1wHDojPOafnSL+uacAIpE0QXnPPPrDbN8QQVnpWQqHIxmvcgacRw98HDPrtqffss348Be9XesRjAA5Az3sz/fn3fvnz+6dQuGEKaUUbQF4h2fvm7hr24XvX4AQKWTMo0zh9ZvizJNsW3EKAFqYqp4mKh4m5Ns42BzxQUXzvvmN46hktcL/3r8488+hKM5F3Fsf+Lf9kMPFQD4YwNAHDgpk7ykbWfyv7+3OBt+AboXXfsJpI3CmSzW0R//7u3Wnx5cDBINzdwTa9tQqnVPXlRz7qwF518ZmnTaKC8yHyuEUNgfPH3a3NL84iIt9PhzjySHE6pXDXiCWTMjerzRaEGaMMdxTNsGxiRZwhgZRsa0zMGePkkXCHazWUMQtfv+/fuPn/3JhqppoigAAGPMdV0sYMYYAnS4gTgAOK6z8tWVm7ZtuurDVxXkFbzrWUoSpdKCMoGhkNfHCGWUgQAEMdMxDNt45IV/nTXnrPKiHHYojEETNwCkMqmV617a1LzV6/UNJwcHE8P5eXmKoCRHUoXRwsb6xnfNrQsYa5pmmtaqNatX71hZ8NHCoPd99pgTlwAG4R15bLr7u+5d8YeW9mbExIyRpojYyI1GIwUlBYwwM2spoiyKoiRIGGEEAIx2dfYCYy4lpmmBgE8rm3la/bwZdbO9uZyNIgB2ZqT58Qd2fP3GqfugAYkyo1QQGRmRAWZf/xnf6fMAgDGKEAZRnHTOmfDrP5qpIaZiv6KyRMwBokUnJwfSEsD0q6/D8oEMWe9YHUGkdeOWX/1SvOO+aQCSWMpc26VZE1IlC5fV3/hF0es/kBTIF1hw05e7r7kGABBFIAgywgyImbWYSZOOU1cya8oNNwrRY9luce6nrs6rqz2G6Y1Yd7cLIAAgxgC9lb3oRGHAAMi+F/+TePmZAPgKGxqj0489+ehbrc3sbG752d3xP/08DwABGDHwQnnDd/9XPGepWhBVlMBYO/aFMS4vKss752J/0PfPJ/5q2qauKR6fQhFDIjIt0yY2xljAoihKAIRQIohiZWVlMhknttMwebKRST798j8723uuPu/6psYmXdc6e7o6ursEhAGgvLhsUnXN4a5aEAVNV+bNmufT/YccSauKWhgp2NezNxwKa4o2MDhIXLc0v4g6rLu/O2tlT+zdOfEmcAAw0r3x/qyZFlSwiIVcHPCEbMPOJDJNM84syT/ERkCEkKapTY2NK9b85ch7h5PpxNatW4OBYEdfm8erlxaVOa7z9KqnUpnkwGCfqkjFRXmqLiMBjcRiguum+voV2VcYLstk0mbGZCL2aLKmeWUshKvzgZChoWExKJ25YOkl51ymyLkdXqdW1nj26ZabbxZa2y8ASUCqEvT1ifSFwT4yp+nMW271nb38rQvc/w/P2Uvy7r399a9+O9XfMTm/qMBBdtYSBwa3ePUlv/yjnl9w4K3f7HhobGTw97/t+do3qwB0UDGoxDU2wEg/SKRyauP3vxmdMeOdTQpe+pH2GzZt+c3tuhrWZERViGM3bqbNuONdeN7cW7+lL81lB+c7FExuOJaXmSZKpgIAfgA5lQBCED7RIwDq/PN+5bpvlkHEgti0b/xffBypxxAAMc3Y48+t/dgNw9AxacqyvfkqXPPhujPPLlcVIRwE5aTOa+UIaaq+eNaS5FCib7B3xvSZ4VDQsmzDNOKZzHB8eOOON0aScZuYhBGwmZ3Nqn5fQAuARCQB5eVXfeW6/5leO29d645v3H5LLJnQVQ8gHA74NY/nvIXLKsoqlMPsVjCMTFVZdVPD9MPNo4a94U+efaVooe1tOwSM/KKasTOWmfWoHoSwYRoOccb1jqAJGgAsx87apq7oCKG0kZYUJaxorusm08mm+mmLZi/SlMNuBKwsqbpw6aWu6xzuGyijnd0da9a/ahpW3B4yzKTX61VVdcacmbOnXOaa9M6//WJ3+3aEJFXRIqGg4zhYRqIgJhJJQtyQLzSpoi4/WhAKhBVRDvtD8fhI8+5d/kBg0ewzck5Om0x2PvTAju9919veNxkFMEs4zEnFUsMA9eeeVfGl/w4vO/cd0x1v/hnoeuE550y/ft+uu+5MDHTuzwBRGFyw5E/f9p9/JsEIAUVwYPc/6RvY++c/7rvtVgGgDCADpgGmDpFgfpVv/sLo5671zJ397vf36g1XXZFK27vuvSNuQsQRY1mXeaHx6kvyr/mSZ8Hsk7oMCwC2bWcyGEACsNauo617PA3TTugHZrqbu353RwQyCoT8U5dI8xcfT/Vjx852rVr92s23hCpDSxZdVvSpq2htoZgXkEaprNhJ4NF95y27kFCiKbqAMWPUJYQxAAxTaiev27y2a6DXdLLJbCKdToqS5PVq2USqqqzqM5d/vjhamLRSA4NDmq4Gw0HHci3bYYAd2y0uKHzvfo23xJNxSZCP8DiFEQpo/ouWXhjwBl7Z9IqiSOFg2LAMI2VINPbyulXlReWRQA7ZBseaCRoAkqnki+te2rFvl4UcQRAVWcWWmB20p5Q0XHnxJ/KCR5pBRoAqCiq379k8tabxkOfFMMLxTLI30SsAShMbFMUXzdu0dUvT3Nl+bygQCX7tv77d2rnnocf+sbezJRAIipqImSsgVVXzFsydN33q9LxInoAFURARwqIgEEoWzlzCgB0hLB0CIan29pf+z03hl5/wAFCAbqYa4eIBnzDpS58uWjI/VFGNQ2EmiIc8VSCWlFR+5WZt+dn71q0fads3Y9myyLQZqKIUMAhvfn+6pzf7wJNbf3sXa30jCIVyeaSlJLgl0esEows/dvXkD31ICYchGjnkpLMyd5bSUCt/5vI1v//da1s2NM487cwbblCrqiEQOXJquRPCscWsqQGokhxz7F2PPjqvbkpO5w9yYrfsTH3ly/oLb6hCdDMZqvvcFQWVR3vA9RAIJR39EhPPfvzeQDCshoIQHJf53Xyeg/IvvfXUPnvKnEkV9ZRS13W2794+NDLQ3NY8Z+acmZNPQwD54cKBRO8jLzzYvy9Wnl8iitKsxpmTaxssy1q7cb1lZtXDPP47rtM/NGDbDmX0yHs6y6IlFyw8Nz0ca+ltURRREDUXubKkdw109vb3Bn0BIZd05WPKRAwADFjazMTisWQ6KXtkTdcS8YTOvGVFpcsWnXPk3n8/TdZiqaGsmdW1Qz9hqZpaW1177hnn+32B3pG+rt6OysKq1zdswC5eOuvsaCA/6A1PKp/cN9z9+qa13b1d1eVVc2YsiAQKFUWWJfldA1Is4FyHmZl4fNfLL695eEX85SemAxTXVVXPO0dpaGQL5pKGKjnglTTtQCoIgMPNkCKfP//0+aGm6XY67Y1E0P6aXIztb16ss/3Vu/6Y+dH9dXLAnbdYyItEkFxz5UcnT53EiksVWVF8R6qnyDBCwYB//vzFU6bOJa4iyWrAf1KT7x9M2P8fYhQg2dsLmRScmHTwNBlvvu3H4qPP+vRQ1kh5AbxnLc4pZem7MAEr5SUlZcUol5yp4whGOOg98LMIzAq6rnvW/GWapumqDgCx9MhTLzzWsqv1zLnL5s6ar4iyqqiSJAFA8IxgZ0+nS4iAhfdO8lBKEol4OBA8mjOVQW/ww+d+ZFf7rjXbXjOyacs2EcaWaW3avrk4vygcHK+DgIkYADJGZsOOTQkzFQoHqUS9Pl1RlOVTl0+vawz6jmpfl9frJcxMpROHDABJI6Gq6pUfvsav+wEg7A8XRos0UancWdvRtW/9pvUVRRUNdQ0hfzjkD5cXVpmWqauaNnqFhyhxNz//9B8uv+I0UD99xx1kemkoWqVX1QISQZJz2gSCBUHx+Q7qytH+xWn2p+9+IfbHJ2svXlZ09XX58xYxr44sC/t9cBQlGAkwBkwAjARRC4dP7rnbQ0FYJAwDACVeAPW5p3sWLyr+6BWj/jnpjo7m23/s//19pYBt6u4AK3PPTxprj7f+FxrzKX1GiyIriqx43pzayhjpex64e0/bjs9de1Njw/R3nQjzaZ6KorJ4fETXvfp7Uuy5LkEI1VbXHeVG6vxwQTSUV1dZOxQf3rN3l0uoImkhT9gl4ziV0EQMAIZhpNOpWfUzHOSmrFRJQWFNWW1FsFwRj/oBijEja9BDlX23HXs4GSvNL93f++8X8YYA4PSmOeFA6Knnn1z92upPX/XpytJKAPBoXs9obP57JyyIp11wcVMsJmNB1lSQxFHf+4Ew+uztfxV+jkVBkFQVvePM89Hsn8GAxth2FMYYowCUUllT4vHUv37wv5+b3oRrp47aJxCa7ep89Ktfc17410JvUM0iYtKEB2bOXy4e38mDMXUfTyYG9O8r7l/5ynO3fe/XkyonH/JOeHQPMDYyMiTmFcoHl5V2XMfn9YVyeXjHCBeGigtDxfVlDehAEhQ0vsp+vMtEDACRUOSjyy+VJIkBUEolQcwpzSwAVBXWnzPzw/RQkX9wcETBSsBziJGEKIhTqhu086Uf3/2dr/38pv936z1hz4kqxqRounLCsgrv5wvkkmn5YGOuzzIMkokRAMMLgmsv6hmyegbNW76nf+lmmD13FFakB0ecDdtaf3LLmS++5EUgMJqR8zeQrqZ7VhTWz3j/l3PvwYC9sOaZB/5zb3VlQziSd4TfKY/Hm0ylOrs7qyur33rYJ5Q0t+zQVU09poTYufYYY9Y4jl3HTBAEr+5VJEWVFF3Rju1n6RKnuWWnffB54I6urlQqWVxYdIQXFhcUz2iY1Tq4/dlXn7TcQx8nHtfGXOd+NCjFlOL9ZRIo86oaAnXbA/9s//EP7G1bwLGP8W0tmw0PGy88t/ayK586dyl68aWCKNIEVQoXd9hdhZddUTJ/3qhexgRi2sbTLz4qYGnJnKVR3/scGSkqLMJYaNvXSumBPEuEuB29nYl48sS3dEybiAFgVHg8ng2b3xgaHoID6QMhnoh39/TU1rzPfK4iaQ01UyL+wkeffXBwpP9ktJV7f9TQZALgsUA1gVHIC+eFPYE3Hvn389d8cuipJ3J+P4ey7gHz0Wf6rvr0G2cvh5efOaOoul4WIYmHiLWFJLcA6P91LZSe7LzTHxgdPfta29uCerDw6M7Dl5WUDgwM9PR27/9SEiXTMnxH3KcwEUzEKaBREQqGiwuL9q8sYYwy2XRzS/PM6TPEo9jOUZRfUhAp7O/rX7ttddEZxWO2cNgE4g9Qn98BcGwsiixrm24yGQjr1R7P9i1bnrz0I5U3fHHaJ/+Pnp8vyxJSFPD7AQsA9O1HKOJCMunYNnFct3lP/9337/vnnxxgxQDFvgKHWIOJvgLKVN2XpenhxMic235UtvxDp/SaxzEGdOVrL3g0PRwqDPqPaipSFMXpTTO27dzq9/v9voBDbBELdbV1J7qpYxzveo6RqmpVFTUOtQDAsqx1m9Y01ExVlaOaT0QCivoiRiqzasPzlyz96AluKXcUfH4SCqYBbAAZywp2bZIKxpyQHqrW8oazI5k77mx/6j+kqMBfURSaOkleuhhCIddOA+iC4mOM0IG++KqX+na32p294V0dBT1tjQACgCbJkB0xdKZ7VbVfpLY64Cadjy0PX7xsnM6WjQVZMzs40IcYVmQ1eNS7dXVNV2Rlb0fr9KmzBmODjFK/9xCVnycUHgCOUSgQMjLGqnXPX7z8stbO3V6PrzDvaFOzeVRPMBDu7e9u7dieyiZD3pwzl3GjTBBLa2p79s/mUSQA0kSFubaV7MUg5ct+U5ZTvQMDLc0tqwABoErV8gUyRj92woocIpjSZL/ZZwgAYQABsIzVIBOQqjAZmJU2HMfMmJoS6jf648AWXH9jeNL39wQ7AAALk0lEQVRpBzIvcblzXAdhob+/Z8a0eZGjOLjzlrrqSX9/+K/5BXnrN63Rdc/4PcA1WngAOHaGYbbs271597o1r75+3dVfOPq0zH5PsCBUsI1uYsBMy4RxeWzzgyZ/0eLW2dPF1zeDCwwRcE3KmISYLAOwrGBlQ5JaqvqJ7VDqGPtMBqYCgCCJIA5AAQBhHbyKwAh2LeY6NrWJbdo2EKACAkTJCJHaIKp/5ROh05ooMDRald0mHkVWMAh+X6Sxvimnp3hN0xYvWHLfg78fGO4794xLKWMTPAJP8Ms/LlVVVUba/NOf766vm6LkspnMo/uK88sUSXYJOcpZI+5EU4vL5KlTKYCFbKSACxQwCAJmjg22JUsKMw1iJhm1VEmLeINRSdORoAHyYI9HCnuEgEhNkoyTVIqYlukQQEzCRBOoR0GqChixAbcn+pXrlvzwNhQoxYAQwrz3PzaKpCiSVlRcXJRXLOaStg8hVFfT4NeDjm0GA8HRqb0znvEAcOx8Ho/f758/a8nS08/M6YUCCI11M4ryyspC1brKn//HBKxp+QvOaIX8PqaPiMxRgOlgY0ZFxjQ24mQSOkuqUkwVYiIzDGI7sgBRBBoTKSMpgyREDF4BaRgpquLTVRHLtgME6RQHEmmhz4SBaz9b++2vgqTwv7vjhBA+96zzw2qkKO9IW64P58wlyxVVr6uq51NA/Bfx2AWDIWAoL5on5p4PVpFVhODy869RRD4CGBswrr/kUt/pswHSlikaJgIkyKrg2kAIRH2yjDFQigADIADMAFFGkSARx81SR0QYPCqTJUIptW1EGHJcCaQscWLZDAISOee8JTd9UT66XCPc+6qtmXTD9V8Oh47lKGVbe0t+tCjoPVHHMMcRvgZw7IL+yIym2d297YRQUcwtlOaHC7/0yW/mtH7FnWAICvJS139i75onL/H7rESSpFxAgBAwFw/FssQrZnXBplgEUUaCYokeIlPZHCGOCcjjkRFzRUL8oii4GBNEIGTLnj6/+PpQa+mXblr6jW/i/PepFcodPUmQo6FjvJ+te1vKi6r5LizgI4Dj5Pf629r3uPSwtQEOR8BiUbRYPvrsQ9xJUb94Yf5Fl+wbiaUpo4oOgqpgVZFVCZBAqEKQxEBkVKJMAiqAC4TIgEO66hGkbNJmNlN0jUqiKeOkKvTaA3HILvraN5f895dF3vuPDal0cjg+WFlWdaobMibwEcBxKSwoSmeS3X0d1WWT+ILSB4BaU13+o1u6Hn/UZGJICxe4GKWThJo+BigLDJGM6DLqCEyQqSwCiJSpWMaOQLOEUOSRZANgABHXG9o80jcIcOHDT5ctmA8flNQx4x2ldOeu7QWRsvqaxlPdljGBjwCOS0GkqKSgfNvOrS7JeRDAjU3FDY0zf/krtXHq3nhXn5nJiK6FKRJFBIARQxgYowwYCAwQI4zaxDWzWdsydYwxQDKbTdrW8Ehf+IzTL3/owdIlS3jvP3YghBKJOKNMkcZyjcyTh48AjosoygFfuHVvCz/R88HAALAgKTfdgGZO6bn1u/3PvzIFoBaHkOiCmwIAjwsOASbaomgjBoAQpaBSJgAgCqZFAMCdkYcuvnTedTd5yqac6gvi3oUZRhYhgRB6qlsyJvAAcJxYKBzJWIZpG15toh8r/wA4MIuHcMWSc4pui3Tf/0Dm1VUdr65FFnhkRRBExAjCIgLkIoIRtjDK0kwcGAPQAJSrro0WRPOXzIHl5wka3/Az5owkR1o7WxomTZElvvwGwAPAcUIIFxeVrdq0qq2zpWnSrFPdHG7UIABlxszqaU1Du3euefAfVks7/cvfCFgAUAgQBGAADMAF3zDMy55TJ9aW1509v27ZEjHgBUZPYW1L7gjW7Xj1P52P/dc1n39XcZgJiweA4zWpuj7ijwyODJ7qhnAngCBEJzde+L9TAcD42McHtu5IZTMaCF4jjdIJO1ocySvRps+CGfUooMFbuwB47z8mZd2s5VrTSk7z6Ce2VtI4wgPA8Qr4QmWF5Xs72szTDFXiv1gfRAgBgH7hBZXnnw+MAUIsm2Z2BgcKAAHw3V/jRFtH247WrSFfmBCKJ/wZ4P34o8ooyI8WbN2zsXXfHsb4ytIHFQNggBEIGDBCHh8OFQJGvPcfR1zbIoQtmLGYj9Dewu/E8WKUlRaXTa1pJIQcokg89wEx1qrYczmLhqLVxdVVxbXHkLvlg4pPAR0vjHFlaTWj1O8L8uSOHDdmeXTvnKnz8oNHW7djIuAjgFGgSCoCrCk6f0jkuDGLEqqrXgHzTu9t/F6MAoyQ1+OjhPAJYY4bmxijtmOpsooRX/59Gw8AowBjobSonBDCGF8F4LixyCUEAfbpfp6z6514ABglDGRZmmABgG954sYNBFhTdcx7vIPx2zFqFFl13ImUEo73/9z4gTHyaB5R4vt/DoIm2EPricIYcxwbISTxHCMcx40TPACMJsbYBJlhpJnsrhUrFEUpXnC6WlrCtz9x3HjEp4BG0wet92cH/fPtr2x3+NnVr1979baPX773F3daW3ecgrZxHHfceADgDo3EjeYnV7a+sZXQd48RrUR621+fvAjKFkLtrp//buUPfpru7z0ljeQ47njwAMC9B6MA0PnwP/9z4Rnbvv71+IpHIJ54OxMCo85rryVXPGOGxYRmFUJG+sd9xsOPQyJ9ShvNcVzO+BoA917M7t/33Kc+Xvj0+hqAEYCCx5/0nP8hwBioZbTudK++wV63ur0UzBQsTKtATAtAeeYVWL7wVLec47gc8BEA916o4w93Fz+9PqwgQ1NB1F793veHX34JhpKwbXfLj2/ds241qogGLWGSjAFpcSG0GyC5YSNkMqe65RzH5YAHAO7dzP6+fQ8/VwlQQTSNUiGgpdavefnMs5P3ruh//KWhP60wKmCXNSSmSDQDlDqapFkAA8N9zLJOdds5jssBzwbKHcxx2u+7P7LxdQVLIIGHMDuRmFZaY6Vs4wffR3GzXERWBvs9xOsCZRSopWAJAVh5QaRrp7r1HMflgI8AuIPEW1oHVq0pBKRhARMbO64fYzkRK6BmHgOvFxUTnC8wywSfCwIVBSRadtoAEKMh4HVWOW5c4SMA7h0oiz/2lPL4QwA6FR2wKQBTRCRJKMac3kRa8kFIkUTX1mwvRjZg1RblvVYiC1JeQz3wMnscN67wEQD3Ntbd57/nkTCAJrhIQVlKBVmwTVukbsgXFqdXmJQSUZFTQoFLMcKMuC7gLDiBr9wQbJxyqpvPcVxueADg3ja4fdvgrlVJUWS6SFwkBzwMISxprfFYu49MueWmsq9f35pODNgsTX1JUXOCoc3WgDV56rQrrsL+8KluPsdxueEBgHubER9xADwSlTwAxHEowRZ1CWQB/F/9ClxyQfTmm4tffK7TW5a0zCQVUi42AYq+fIM+67RT3XaO43LG1wC4t0UbJ7UAkCx1JKteDzkm60N0yM3iZYtrli4HCIIKtWecE37uH8/MX+J1EzQNc7/17aKLP3KqG85x3LHgIwDubd7GmdNee9SYGe5OEmpCUNEYk02Amd/+Li6vfuvbwqfPWbx1i3f5hYVXXJN3w+cgP/8UtpnjuGPGU0FwB3Oz8S1bRv7wl3133SlDMA3xqi98of5nPwXN8+5vbN4lyDKqrABeZZvjxiceALiDMAAE4O7tbP3NPet+fsvs7/+0+pOfUErL3voGQilCCH/AEl9z3ITEAwB3KJSRfV1D23dE584SCvIO+j+UIoQ+aJUPOG5C4gGA4zhuguKztxzHcRMUDwAcx3ETFA8AHMdxExQPABzHcRMUDwAcx3ETFA8AHMdxExQPABzHcRMUDwAcx3ETFA8AHMdxExQPABzHcRMUDwAcx3ETFA8AHMdxExQPABzHcRMUDwAcx3ETFA8AHMdxExQPABzHcRMUDwAcx3ETFA8AHMdxExQPABzHcRMUDwAcx3ET1P8HuSFXah8msYIAAAAASUVORK5CYII="></p></div><div class="ql-clipboard" contenteditable="true" tabindex="-1"></div><div class="ql-tooltip ql-hidden"><a class="ql-preview" target="_blank" href="about:blank"></a><input type="text" data-formula="e=mc^2" data-link="https://quilljs.com" data-video="Embed URL"><a class="ql-action"></a><a class="ql-remove"></a></div>', N'نیکاتک', N'fa')
SET IDENTITY_INSERT [dbo].[Tbl_Blog] OFF
SET IDENTITY_INSERT [dbo].[tbl_category] ON 

INSERT [dbo].[tbl_category] ([Id], [NameCat], [FatherIdCat], [Language]) VALUES (1, N'معرفی', -2, N'fa')
INSERT [dbo].[tbl_category] ([Id], [NameCat], [FatherIdCat], [Language]) VALUES (2, N'معرفی مدیران', 1, N'fa')
INSERT [dbo].[tbl_category] ([Id], [NameCat], [FatherIdCat], [Language]) VALUES (3, N'معرفی نمایندگان', 1, N'fa')
INSERT [dbo].[tbl_category] ([Id], [NameCat], [FatherIdCat], [Language]) VALUES (4, N'درباره ما', 1, N'fa')
INSERT [dbo].[tbl_category] ([Id], [NameCat], [FatherIdCat], [Language]) VALUES (5, N'خدمات', -2, N'fa')
INSERT [dbo].[tbl_category] ([Id], [NameCat], [FatherIdCat], [Language]) VALUES (6, N'خدمات ما', 5, N'fa')
INSERT [dbo].[tbl_category] ([Id], [NameCat], [FatherIdCat], [Language]) VALUES (7, N'سازمان ها ', -1, N'fa')
INSERT [dbo].[tbl_category] ([Id], [NameCat], [FatherIdCat], [Language]) VALUES (8, N'سازمانها و مراکز طرف قرارداد', 7, N'fa')
INSERT [dbo].[tbl_category] ([Id], [NameCat], [FatherIdCat], [Language]) VALUES (11, N'اطلاعیه ها ', -2, N'fa')
INSERT [dbo].[tbl_category] ([Id], [NameCat], [FatherIdCat], [Language]) VALUES (12, N'اطلاعیه های جدید ', 11, N'fa')
SET IDENTITY_INSERT [dbo].[tbl_category] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Slider] ON 

INSERT [dbo].[Tbl_Slider] ([Id], [TitleSlid], [CategoryIdSlid], [CategoryProductIdSlid], [TypeSlid], [ImageMainSlid], [Language]) VALUES (1, NULL, 0, 1, NULL, N'f311037d-f466-4e99-b041-0afdca7eb874.jpg', N'fa')
INSERT [dbo].[Tbl_Slider] ([Id], [TitleSlid], [CategoryIdSlid], [CategoryProductIdSlid], [TypeSlid], [ImageMainSlid], [Language]) VALUES (2, NULL, 0, 2, NULL, N'e692ee5f-d67b-438a-b045-8e53e0666478.jpg', N'fa')
INSERT [dbo].[Tbl_Slider] ([Id], [TitleSlid], [CategoryIdSlid], [CategoryProductIdSlid], [TypeSlid], [ImageMainSlid], [Language]) VALUES (3, NULL, 0, 3, NULL, N'cf67b52d-b3bf-453a-9c38-0d6e6a98b4ca.png', N'fa')
SET IDENTITY_INSERT [dbo].[Tbl_Slider] OFF
SET IDENTITY_INSERT [dbo].[Tbl_User] ON 

INSERT [dbo].[Tbl_User] ([Id], [CodeMeli], [NameFamily], [state], [AddressUs], [EmailUS], [Language], [PasswordUs], [PhoneUs], [ProfileImageUs], [UserNameUs]) VALUES (1, NULL, N'سعید عطایی', 1, NULL, NULL, NULL, N'nikatak5250', NULL, NULL, N'info@nikatak.ir')
INSERT [dbo].[Tbl_User] ([Id], [CodeMeli], [NameFamily], [state], [AddressUs], [EmailUS], [Language], [PasswordUs], [PhoneUs], [ProfileImageUs], [UserNameUs]) VALUES (2, NULL, N'سعید عطایی', 1, N'تهران', NULL, N'fa', N'nikatak5250', N'09920648677', N'a624dd41-b43b-4910-a9fc-b00f01bbcbb8.png', N'admin')
SET IDENTITY_INSERT [dbo].[Tbl_User] OFF
ALTER TABLE [dbo].[Tbl_Comments] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [DateComment]
GO
ALTER TABLE [dbo].[Tbl_Comments] ADD  DEFAULT ((0)) FOR [blog_id]
GO
ALTER TABLE [dbo].[Tbl_Comments] ADD  DEFAULT ((0)) FOR [product_id]
GO
ALTER TABLE [dbo].[Tbl_Order] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [Date_Order]
GO
ALTER TABLE [dbo].[Tbl_Order] ADD  DEFAULT ((0)) FOR [Id_user]
GO
USE [master]
GO
ALTER DATABASE [nikatek_db] SET  READ_WRITE 
GO
