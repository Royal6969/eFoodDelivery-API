/****** Object:  Database [eFoodDelivery-database]    Script Date: 04/06/2023 12:31:32 ******/
CREATE DATABASE [eFoodDelivery-database]  (EDITION = 'Basic', SERVICE_OBJECTIVE = 'Basic', MAXSIZE = 1 GB) WITH CATALOG_COLLATION = SQL_Latin1_General_CP1_CI_AS, LEDGER = OFF;
GO
ALTER DATABASE [eFoodDelivery-database] SET COMPATIBILITY_LEVEL = 150
GO
ALTER DATABASE [eFoodDelivery-database] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [eFoodDelivery-database] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [eFoodDelivery-database] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [eFoodDelivery-database] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [eFoodDelivery-database] SET ARITHABORT OFF 
GO
ALTER DATABASE [eFoodDelivery-database] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [eFoodDelivery-database] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [eFoodDelivery-database] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [eFoodDelivery-database] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [eFoodDelivery-database] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [eFoodDelivery-database] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [eFoodDelivery-database] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [eFoodDelivery-database] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [eFoodDelivery-database] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [eFoodDelivery-database] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [eFoodDelivery-database] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [eFoodDelivery-database] SET  MULTI_USER 
GO
ALTER DATABASE [eFoodDelivery-database] SET ENCRYPTION ON
GO
ALTER DATABASE [eFoodDelivery-database] SET QUERY_STORE = ON
GO
ALTER DATABASE [eFoodDelivery-database] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 7), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 10, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
/*** The scripts of database scoped configurations in Azure should be executed inside the target database connection. ***/
GO
-- ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 8;
GO
/****** Object:  Schema [dlk_efooddelivery_api]    Script Date: 04/06/2023 12:31:32 ******/
CREATE SCHEMA [dlk_efooddelivery_api]
GO
/****** Object:  Schema [dwh_efooddelivery_api]    Script Date: 04/06/2023 12:31:32 ******/
CREATE SCHEMA [dwh_efooddelivery_api]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 04/06/2023 12:31:32 ******/
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
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dlk_efooddelivery_api].[dlk_role_claim]    Script Date: 04/06/2023 12:31:32 ******/
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
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dlk_efooddelivery_api].[dlk_roles]    Script Date: 04/06/2023 12:31:32 ******/
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
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dlk_efooddelivery_api].[dlk_user_claim]    Script Date: 04/06/2023 12:31:33 ******/
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
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dlk_efooddelivery_api].[dlk_user_login]    Script Date: 04/06/2023 12:31:33 ******/
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
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dlk_efooddelivery_api].[dlk_user_roles]    Script Date: 04/06/2023 12:31:33 ******/
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
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dlk_efooddelivery_api].[dlk_user_tokens]    Script Date: 04/06/2023 12:31:33 ******/
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
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dlk_efooddelivery_api].[dlk_users]    Script Date: 04/06/2023 12:31:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dlk_efooddelivery_api].[dlk_users](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](40) NULL,
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
	[Code] [nvarchar](6) NULL,
 CONSTRAINT [PK_dlk_users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dwh_efooddelivery_api].[dwh_cart]    Script Date: 04/06/2023 12:31:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dwh_efooddelivery_api].[dwh_cart](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Md_uuid] [uniqueidentifier] NOT NULL,
	[Md_date] [datetime2](7) NOT NULL,
	[UserId] [nvarchar](max) NULL,
 CONSTRAINT [PK_dwh_cart] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dwh_efooddelivery_api].[dwh_cartItem]    Script Date: 04/06/2023 12:31:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dwh_efooddelivery_api].[dwh_cartItem](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Md_uuid] [uniqueidentifier] NOT NULL,
	[Md_date] [datetime2](7) NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[CartId] [int] NOT NULL,
 CONSTRAINT [PK_dwh_cartItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dwh_efooddelivery_api].[dwh_logger]    Script Date: 04/06/2023 12:31:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dwh_efooddelivery_api].[dwh_logger](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Md_uuid] [uniqueidentifier] NOT NULL,
	[Md_date] [datetime2](7) NOT NULL,
	[Log] [nvarchar](max) NOT NULL,
	[Level] [nvarchar](20) NULL,
 CONSTRAINT [PK_dwh_logger] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dwh_efooddelivery_api].[dwh_order]    Script Date: 04/06/2023 12:31:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dwh_efooddelivery_api].[dwh_order](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[Md_uuid] [uniqueidentifier] NOT NULL,
	[Md_date] [datetime2](7) NOT NULL,
	[ClientName] [nvarchar](max) NOT NULL,
	[ClientPhone] [nvarchar](max) NOT NULL,
	[ClientEmail] [nvarchar](max) NOT NULL,
	[ClientId] [nvarchar](450) NULL,
	[OrderTotal] [float] NOT NULL,
	[OrderDate] [datetime2](7) NOT NULL,
	[OrderPaymentID] [nvarchar](max) NULL,
	[OrderStatus] [nvarchar](max) NULL,
	[OrderQuantityItems] [int] NOT NULL,
 CONSTRAINT [PK_dwh_order] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dwh_efooddelivery_api].[dwh_orderDetails]    Script Date: 04/06/2023 12:31:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dwh_efooddelivery_api].[dwh_orderDetails](
	[OrderDetailsId] [int] IDENTITY(1,1) NOT NULL,
	[Md_uuid] [uniqueidentifier] NOT NULL,
	[Md_date] [datetime2](7) NOT NULL,
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Price] [float] NOT NULL,
 CONSTRAINT [PK_dwh_orderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderDetailsId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dwh_efooddelivery_api].[dwh_product]    Script Date: 04/06/2023 12:31:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dwh_efooddelivery_api].[dwh_product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Md_uuid] [uniqueidentifier] NOT NULL,
	[Md_date] [datetime2](7) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
	[Description] [nvarchar](250) NULL,
	[Tag] [nvarchar](20) NULL,
	[Category] [nvarchar](20) NULL,
	[Price] [float] NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dwh_product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_dlk_role_claim_RoleId]    Script Date: 04/06/2023 12:31:33 ******/
CREATE NONCLUSTERED INDEX [IX_dlk_role_claim_RoleId] ON [dlk_efooddelivery_api].[dlk_role_claim]
(
	[RoleId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, DROP_EXISTING = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 04/06/2023 12:31:33 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dlk_efooddelivery_api].[dlk_roles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_dlk_user_claim_UserId]    Script Date: 04/06/2023 12:31:33 ******/
CREATE NONCLUSTERED INDEX [IX_dlk_user_claim_UserId] ON [dlk_efooddelivery_api].[dlk_user_claim]
(
	[UserId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, DROP_EXISTING = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_dlk_user_login_UserId]    Script Date: 04/06/2023 12:31:33 ******/
CREATE NONCLUSTERED INDEX [IX_dlk_user_login_UserId] ON [dlk_efooddelivery_api].[dlk_user_login]
(
	[UserId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, DROP_EXISTING = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_dlk_user_roles_RoleId]    Script Date: 04/06/2023 12:31:33 ******/
CREATE NONCLUSTERED INDEX [IX_dlk_user_roles_RoleId] ON [dlk_efooddelivery_api].[dlk_user_roles]
(
	[RoleId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, DROP_EXISTING = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 04/06/2023 12:31:33 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dlk_efooddelivery_api].[dlk_users]
(
	[NormalizedEmail] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, DROP_EXISTING = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 04/06/2023 12:31:33 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dlk_efooddelivery_api].[dlk_users]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_dwh_cartItem_CartId]    Script Date: 04/06/2023 12:31:33 ******/
CREATE NONCLUSTERED INDEX [IX_dwh_cartItem_CartId] ON [dwh_efooddelivery_api].[dwh_cartItem]
(
	[CartId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, DROP_EXISTING = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_dwh_cartItem_ProductId]    Script Date: 04/06/2023 12:31:33 ******/
CREATE NONCLUSTERED INDEX [IX_dwh_cartItem_ProductId] ON [dwh_efooddelivery_api].[dwh_cartItem]
(
	[ProductId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, DROP_EXISTING = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_dwh_order_ClientId]    Script Date: 04/06/2023 12:31:33 ******/
CREATE NONCLUSTERED INDEX [IX_dwh_order_ClientId] ON [dwh_efooddelivery_api].[dwh_order]
(
	[ClientId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, DROP_EXISTING = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_dwh_orderDetails_OrderId]    Script Date: 04/06/2023 12:31:33 ******/
CREATE NONCLUSTERED INDEX [IX_dwh_orderDetails_OrderId] ON [dwh_efooddelivery_api].[dwh_orderDetails]
(
	[OrderId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, DROP_EXISTING = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_dwh_orderDetails_ProductId]    Script Date: 04/06/2023 12:31:33 ******/
CREATE NONCLUSTERED INDEX [IX_dwh_orderDetails_ProductId] ON [dwh_efooddelivery_api].[dwh_orderDetails]
(
	[ProductId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, DROP_EXISTING = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
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
ALTER TABLE [dwh_efooddelivery_api].[dwh_cartItem]  WITH CHECK ADD  CONSTRAINT [FK_dwh_cartItem_dwh_cart_CartId] FOREIGN KEY([CartId])
REFERENCES [dwh_efooddelivery_api].[dwh_cart] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dwh_efooddelivery_api].[dwh_cartItem] CHECK CONSTRAINT [FK_dwh_cartItem_dwh_cart_CartId]
GO
ALTER TABLE [dwh_efooddelivery_api].[dwh_cartItem]  WITH CHECK ADD  CONSTRAINT [FK_dwh_cartItem_dwh_product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dwh_efooddelivery_api].[dwh_product] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dwh_efooddelivery_api].[dwh_cartItem] CHECK CONSTRAINT [FK_dwh_cartItem_dwh_product_ProductId]
GO
ALTER TABLE [dwh_efooddelivery_api].[dwh_order]  WITH CHECK ADD  CONSTRAINT [FK_dwh_order_dlk_users_ClientId] FOREIGN KEY([ClientId])
REFERENCES [dlk_efooddelivery_api].[dlk_users] ([Id])
GO
ALTER TABLE [dwh_efooddelivery_api].[dwh_order] CHECK CONSTRAINT [FK_dwh_order_dlk_users_ClientId]
GO
ALTER TABLE [dwh_efooddelivery_api].[dwh_orderDetails]  WITH CHECK ADD  CONSTRAINT [FK_dwh_orderDetails_dwh_order_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dwh_efooddelivery_api].[dwh_order] ([OrderId])
ON DELETE CASCADE
GO
ALTER TABLE [dwh_efooddelivery_api].[dwh_orderDetails] CHECK CONSTRAINT [FK_dwh_orderDetails_dwh_order_OrderId]
GO
ALTER TABLE [dwh_efooddelivery_api].[dwh_orderDetails]  WITH CHECK ADD  CONSTRAINT [FK_dwh_orderDetails_dwh_product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dwh_efooddelivery_api].[dwh_product] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dwh_efooddelivery_api].[dwh_orderDetails] CHECK CONSTRAINT [FK_dwh_orderDetails_dwh_product_ProductId]
GO
ALTER DATABASE [eFoodDelivery-database] SET  READ_WRITE 
GO
