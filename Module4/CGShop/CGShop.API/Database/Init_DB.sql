USE [master]
GO
/****** Object:  Database [CGShopDB]    Script Date: 8/11/2021 10:11:36 AM ******/
CREATE DATABASE [CGShopDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CGShopDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\CGShopDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CGShopDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\CGShopDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CGShopDB] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CGShopDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CGShopDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CGShopDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CGShopDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CGShopDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CGShopDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [CGShopDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CGShopDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CGShopDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CGShopDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CGShopDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CGShopDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CGShopDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CGShopDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CGShopDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CGShopDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CGShopDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CGShopDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CGShopDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CGShopDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CGShopDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CGShopDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CGShopDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CGShopDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CGShopDB] SET  MULTI_USER 
GO
ALTER DATABASE [CGShopDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CGShopDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CGShopDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CGShopDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CGShopDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CGShopDB] SET QUERY_STORE = OFF
GO
USE [CGShopDB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [CGShopDB]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 8/11/2021 10:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
	[Status] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 8/11/2021 10:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](20) NOT NULL,
	[Price] [bigint] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[SupplierId] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 8/11/2021 10:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[SupplierId] [int] IDENTITY(1,1) NOT NULL,
	[SupplierName] [nvarchar](200) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
	[Phone] [nvarchar](15) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[SupplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Status], [IsDeleted]) VALUES (1, N'Laptop', 1, 0)
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Status], [IsDeleted]) VALUES (2, N'Mobile', 1, 0)
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Status], [IsDeleted]) VALUES (3, N'Accessories', 1, 0)
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Status], [IsDeleted]) VALUES (4, N'PC', 1, 0)
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Status], [IsDeleted]) VALUES (5, N'Screen', 1, 0)
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Status], [IsDeleted]) VALUES (6, N'Screen2', 1, 0)
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Status], [IsDeleted]) VALUES (7, N'Screem 311', 0, 1)
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Status], [IsDeleted]) VALUES (9, N'Screen 3', 1, 1)
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductId], [ProductName], [Price], [Quantity], [Discount], [Status], [CategoryId], [SupplierId]) VALUES (1, N'DELL', 18000000, 5, 0, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Product] OFF
SET IDENTITY_INSERT [dbo].[Supplier] ON 

INSERT [dbo].[Supplier] ([SupplierId], [SupplierName], [Email], [Address], [Phone], [Status]) VALUES (1, N'FPTSoft', N'fsoft@gmail.com', N'28 Nguyễn Tri Phương', N'02343123123', 1)
INSERT [dbo].[Supplier] ([SupplierId], [SupplierName], [Email], [Address], [Phone], [Status]) VALUES (2, N'Phi Long', N'philong@gmail.com', N'30 Nguyễn Tri Phương', N'02342345345', 1)
SET IDENTITY_INSERT [dbo].[Supplier] OFF
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [DF_Category_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [DF_Category_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_Discount]  DEFAULT ((0)) FOR [Discount]
GO
ALTER TABLE [dbo].[Supplier] ADD  CONSTRAINT [DF_Supplier_Status]  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Supplier] FOREIGN KEY([SupplierId])
REFERENCES [dbo].[Supplier] ([SupplierId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Supplier]
GO
/****** Object:  StoredProcedure [dbo].[sp_CreateCategory]    Script Date: 8/11/2021 10:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Khoa Nguyen
-- Create date: 11/8/2021
-- Description:	Create category
-- =============================================
CREATE PROCEDURE [dbo].[sp_CreateCategory]
	@categoryName	NVARCHAR(50),
	@status			BIT
AS
BEGIN
	BEGIN TRY
		INSERT INTO [dbo].[Category]
			   ([CategoryName]
			   ,[Status]
			   ,IsDeleted)
		 VALUES
			   (@categoryName
			   ,@status
			   ,0)
		
		SELECT * FROM Category 
		WHERE CategoryId = SCOPE_IDENTITY()

	END TRY
	BEGIN CATCH
		SELECT ERROR_NUMBER()
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetCategories]    Script Date: 8/11/2021 10:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Khoa Nguyen
-- Create date: 9/8/2021
-- Description:	Get all category
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetCategories]
AS
BEGIN
	SELECT * FROM Category
	WHERE IsDeleted = 0
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetCategory]    Script Date: 8/11/2021 10:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Khoa Nguyen
-- Create date: 11/8/2021
-- Description:	Get category by Id
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetCategory]
	@categoryId INT
AS
BEGIN
	SELECT * FROM Category
	WHERE CategoryId = @categoryId AND IsDeleted = 0
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetCategoryByName]    Script Date: 8/11/2021 10:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Khoa Nguyen
-- Create date: 11/8/2021
-- Description:	Get category by category name
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetCategoryByName]
	@categoryName NVARCHAR(50),
	@categoryId		INT = 0
AS
BEGIN
	IF(@categoryId = 0)
	BEGIN
		SELECT * FROM Category
		WHERE LOWER(CategoryName) = LOWER(RTRIM(LTRIM(@categoryName)))
				AND IsDeleted = 0
	END
	ELSE
	BEGIN
		SELECT * FROM Category
		WHERE LOWER(CategoryName) = LOWER(RTRIM(LTRIM(@categoryName)))
				AND CategoryId <> @categoryId
				AND IsDeleted = 0
	END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ModifyCategory]    Script Date: 8/11/2021 10:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Khoa Nguyen
-- Create date: 11/8/2021
-- Description:	Modify category
-- =============================================
CREATE PROCEDURE [dbo].[sp_ModifyCategory]
	@categoryId		INT,
	@categoryName	NVARCHAR(50),
	@status			BIT
AS
BEGIN
	BEGIN TRY
		UPDATE [dbo].[Category]
		   SET [CategoryName] = @categoryName
			  ,[Status] = @status
		 WHERE CategoryId = @categoryId

		 SELECT * FROM Category WHERE CategoryId = @categoryId
	END TRY
	BEGIN CATCH
		SELECT ERROR_NUMBER()
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_RemoveCategory]    Script Date: 8/11/2021 10:11:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Khoa Nguyen
-- Create date: 11/8/2021
-- Description:	remove category by categoryId
-- =============================================
CREATE PROCEDURE [dbo].[sp_RemoveCategory]
	@categoryId		INT
AS
BEGIN
	BEGIN TRY
		UPDATE [dbo].[Category]
			   SET [IsDeleted] = 1
			 WHERE CategoryId = @categoryId
		SELECT @categoryId
	END TRY
	BEGIN CATCH
		SELECT 0
	END CATCH
END
GO
USE [master]
GO
ALTER DATABASE [CGShopDB] SET  READ_WRITE 
GO
