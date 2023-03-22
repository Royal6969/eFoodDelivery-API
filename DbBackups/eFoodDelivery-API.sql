USE [master]
GO
/****** Object:  Database [eFoodDelivery-API]    Script Date: 22/03/2023 16:40:58 ******/
CREATE DATABASE [eFoodDelivery-API]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'eFoodDelivery-API', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\eFoodDelivery-API.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'eFoodDelivery-API_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\eFoodDelivery-API_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [eFoodDelivery-API] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [eFoodDelivery-API].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [eFoodDelivery-API] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [eFoodDelivery-API] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [eFoodDelivery-API] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [eFoodDelivery-API] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [eFoodDelivery-API] SET ARITHABORT OFF 
GO
ALTER DATABASE [eFoodDelivery-API] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [eFoodDelivery-API] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [eFoodDelivery-API] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [eFoodDelivery-API] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [eFoodDelivery-API] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [eFoodDelivery-API] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [eFoodDelivery-API] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [eFoodDelivery-API] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [eFoodDelivery-API] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [eFoodDelivery-API] SET  ENABLE_BROKER 
GO
ALTER DATABASE [eFoodDelivery-API] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [eFoodDelivery-API] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [eFoodDelivery-API] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [eFoodDelivery-API] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [eFoodDelivery-API] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [eFoodDelivery-API] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [eFoodDelivery-API] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [eFoodDelivery-API] SET RECOVERY FULL 
GO
ALTER DATABASE [eFoodDelivery-API] SET  MULTI_USER 
GO
ALTER DATABASE [eFoodDelivery-API] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [eFoodDelivery-API] SET DB_CHAINING OFF 
GO
ALTER DATABASE [eFoodDelivery-API] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [eFoodDelivery-API] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [eFoodDelivery-API] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [eFoodDelivery-API] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'eFoodDelivery-API', N'ON'
GO
ALTER DATABASE [eFoodDelivery-API] SET QUERY_STORE = ON
GO
ALTER DATABASE [eFoodDelivery-API] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [eFoodDelivery-API]
GO
/****** Object:  Schema [dlk_efooddelivery_api]    Script Date: 22/03/2023 16:40:59 ******/
CREATE SCHEMA [dlk_efooddelivery_api]
GO
/****** Object:  Schema [dwh_efooddelivery_api]    Script Date: 22/03/2023 16:40:59 ******/
CREATE SCHEMA [dwh_efooddelivery_api]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 22/03/2023 16:40:59 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dlk_efooddelivery_api].[dlk_role_claim]    Script Date: 22/03/2023 16:40:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dlk_efooddelivery_api].[dlk_role_claim](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dlk_role_claim] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dlk_efooddelivery_api].[dlk_roles]    Script Date: 22/03/2023 16:40:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dlk_efooddelivery_api].[dlk_roles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_dlk_roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dlk_efooddelivery_api].[dlk_user_claim]    Script Date: 22/03/2023 16:40:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dlk_efooddelivery_api].[dlk_user_claim](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dlk_user_claim] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dlk_efooddelivery_api].[dlk_user_login]    Script Date: 22/03/2023 16:40:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dlk_efooddelivery_api].[dlk_user_login](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_dlk_user_login] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dlk_efooddelivery_api].[dlk_user_roles]    Script Date: 22/03/2023 16:40:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dlk_efooddelivery_api].[dlk_user_roles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_dlk_user_roles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dlk_efooddelivery_api].[dlk_user_tokens]    Script Date: 22/03/2023 16:40:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dlk_efooddelivery_api].[dlk_user_tokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_dlk_user_tokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dlk_efooddelivery_api].[dlk_users]    Script Date: 22/03/2023 16:40:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dlk_efooddelivery_api].[dlk_users](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](20) NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_dlk_users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dwh_efooddelivery_api].[product]    Script Date: 22/03/2023 16:40:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dwh_efooddelivery_api].[product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Md_uuid] [uniqueidentifier] NOT NULL,
	[Md_date] [datetime2](7) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
	[Description] [nvarchar](250) NULL,
	[Tag] [nvarchar](20) NULL,
	[Category] [nvarchar](20) NULL,
	[Price] [float] NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_dlk_role_claim_RoleId]    Script Date: 22/03/2023 16:40:59 ******/
CREATE NONCLUSTERED INDEX [IX_dlk_role_claim_RoleId] ON [dlk_efooddelivery_api].[dlk_role_claim]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 22/03/2023 16:40:59 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dlk_efooddelivery_api].[dlk_roles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_dlk_user_claim_UserId]    Script Date: 22/03/2023 16:40:59 ******/
CREATE NONCLUSTERED INDEX [IX_dlk_user_claim_UserId] ON [dlk_efooddelivery_api].[dlk_user_claim]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_dlk_user_login_UserId]    Script Date: 22/03/2023 16:40:59 ******/
CREATE NONCLUSTERED INDEX [IX_dlk_user_login_UserId] ON [dlk_efooddelivery_api].[dlk_user_login]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_dlk_user_roles_RoleId]    Script Date: 22/03/2023 16:40:59 ******/
CREATE NONCLUSTERED INDEX [IX_dlk_user_roles_RoleId] ON [dlk_efooddelivery_api].[dlk_user_roles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 22/03/2023 16:40:59 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dlk_efooddelivery_api].[dlk_users]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 22/03/2023 16:40:59 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dlk_efooddelivery_api].[dlk_users]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dlk_efooddelivery_api].[dlk_role_claim]  WITH CHECK ADD  CONSTRAINT [FK_dlk_role_claim_dlk_roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dlk_efooddelivery_api].[dlk_roles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dlk_efooddelivery_api].[dlk_role_claim] CHECK CONSTRAINT [FK_dlk_role_claim_dlk_roles_RoleId]
GO
ALTER TABLE [dlk_efooddelivery_api].[dlk_user_claim]  WITH CHECK ADD  CONSTRAINT [FK_dlk_user_claim_dlk_users_UserId] FOREIGN KEY([UserId])
REFERENCES [dlk_efooddelivery_api].[dlk_users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dlk_efooddelivery_api].[dlk_user_claim] CHECK CONSTRAINT [FK_dlk_user_claim_dlk_users_UserId]
GO
ALTER TABLE [dlk_efooddelivery_api].[dlk_user_login]  WITH CHECK ADD  CONSTRAINT [FK_dlk_user_login_dlk_users_UserId] FOREIGN KEY([UserId])
REFERENCES [dlk_efooddelivery_api].[dlk_users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dlk_efooddelivery_api].[dlk_user_login] CHECK CONSTRAINT [FK_dlk_user_login_dlk_users_UserId]
GO
ALTER TABLE [dlk_efooddelivery_api].[dlk_user_roles]  WITH CHECK ADD  CONSTRAINT [FK_dlk_user_roles_dlk_roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dlk_efooddelivery_api].[dlk_roles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dlk_efooddelivery_api].[dlk_user_roles] CHECK CONSTRAINT [FK_dlk_user_roles_dlk_roles_RoleId]
GO
ALTER TABLE [dlk_efooddelivery_api].[dlk_user_roles]  WITH CHECK ADD  CONSTRAINT [FK_dlk_user_roles_dlk_users_UserId] FOREIGN KEY([UserId])
REFERENCES [dlk_efooddelivery_api].[dlk_users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dlk_efooddelivery_api].[dlk_user_roles] CHECK CONSTRAINT [FK_dlk_user_roles_dlk_users_UserId]
GO
ALTER TABLE [dlk_efooddelivery_api].[dlk_user_tokens]  WITH CHECK ADD  CONSTRAINT [FK_dlk_user_tokens_dlk_users_UserId] FOREIGN KEY([UserId])
REFERENCES [dlk_efooddelivery_api].[dlk_users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dlk_efooddelivery_api].[dlk_user_tokens] CHECK CONSTRAINT [FK_dlk_user_tokens_dlk_users_UserId]
GO
USE [master]
GO
ALTER DATABASE [eFoodDelivery-API] SET  READ_WRITE 
GO
