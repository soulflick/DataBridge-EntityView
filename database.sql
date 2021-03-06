USE [master]
GO
/****** Object:  Database [CompanyBaseData]    Script Date: 16.06.2021 20:14:07 ******/
CREATE DATABASE [CompanyBaseData]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CompanyBaseData', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CompanyBaseData.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CompanyBaseData_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CompanyBaseData_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CompanyBaseData] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CompanyBaseData].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CompanyBaseData] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CompanyBaseData] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CompanyBaseData] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CompanyBaseData] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CompanyBaseData] SET ARITHABORT OFF 
GO
ALTER DATABASE [CompanyBaseData] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CompanyBaseData] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CompanyBaseData] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CompanyBaseData] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CompanyBaseData] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CompanyBaseData] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CompanyBaseData] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CompanyBaseData] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CompanyBaseData] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CompanyBaseData] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CompanyBaseData] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CompanyBaseData] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CompanyBaseData] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CompanyBaseData] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CompanyBaseData] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CompanyBaseData] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CompanyBaseData] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CompanyBaseData] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CompanyBaseData] SET  MULTI_USER 
GO
ALTER DATABASE [CompanyBaseData] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CompanyBaseData] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CompanyBaseData] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CompanyBaseData] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CompanyBaseData] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CompanyBaseData] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CompanyBaseData] SET QUERY_STORE = OFF
GO
USE [CompanyBaseData]
GO
/****** Object:  Table [dbo].[Companies]    Script Date: 16.06.2021 20:14:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Companies](
	[Id] [uniqueidentifier] NOT NULL,
	[CompanyName] [nvarchar](255) NOT NULL,
	[InternalName] [nvarchar](120) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Created] [datetime] NOT NULL,
	[Creator] [uniqueidentifier] NULL,
	[Modified] [datetime] NULL,
	[Modifier] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factories]    Script Date: 16.06.2021 20:14:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factories](
	[Id] [uniqueidentifier] NOT NULL,
	[FactoryName] [nvarchar](200) NOT NULL,
	[Location] [nvarchar](max) NOT NULL,
	[CompanyId] [uniqueidentifier] NOT NULL,
	[Created] [datetime] NOT NULL,
	[Creator] [uniqueidentifier] NOT NULL,
	[Modified] [datetime] NULL,
	[Modifier] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Factories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 16.06.2021 20:14:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [uniqueidentifier] NOT NULL,
	[UserName] [nvarchar](200) NOT NULL,
	[CompanyId] [uniqueidentifier] NOT NULL,
	[FactoryId] [uniqueidentifier] NOT NULL,
	[Created] [datetime] NOT NULL,
	[Creator] [uniqueidentifier] NOT NULL,
	[Modified] [datetime] NULL,
	[Modifier] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Companies] ADD  CONSTRAINT [DF_Companies_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Companies] ADD  CONSTRAINT [DF_Companies_Created]  DEFAULT (getdate()) FOR [Created]
GO
ALTER TABLE [dbo].[Factories] ADD  CONSTRAINT [DF_Factories_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Factories] ADD  CONSTRAINT [DF_Factories_Created]  DEFAULT (getdate()) FOR [Created]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_Created]  DEFAULT (getdate()) FOR [Created]
GO
USE [master]
GO
ALTER DATABASE [CompanyBaseData] SET  READ_WRITE 
GO
