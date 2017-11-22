USE [NorthwindDomainDriven]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Products]') AND type in (N'U'))
ALTER TABLE [dbo].[Products] DROP CONSTRAINT IF EXISTS [FK_Products_Suppliers_SupplierId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Products]') AND type in (N'U'))
ALTER TABLE [dbo].[Products] DROP CONSTRAINT IF EXISTS [FK_Products_Categories_CategoryId]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 11/22/2017 2:03:25 PM ******/
DROP TABLE IF EXISTS [dbo].[Products]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 11/22/2017 2:03:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Products]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Products](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Created] [datetime2](7) NOT NULL,
	[Modified] [datetime2](7) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[SupplierId] [int] NOT NULL,
	[UnitPrice] [decimal](18, 2) NOT NULL,
	[UnitsInStock] [float] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[Products] ON 
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (1, 1, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Chai', 1, CAST(18.00 AS Decimal(18, 2)), 39)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (2, 1, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Chang', 1, CAST(19.00 AS Decimal(18, 2)), 17)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (3, 2, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Aniseed Syrup', 1, CAST(10.00 AS Decimal(18, 2)), 13)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (4, 2, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Chef Anton''s Cajun Seasoning', 2, CAST(22.00 AS Decimal(18, 2)), 53)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (5, 2, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Chef Anton''s Gumbo Mix', 2, CAST(21.35 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (6, 2, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Grandma''s Boysenberry Spread', 3, CAST(25.00 AS Decimal(18, 2)), 120)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (7, 7, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Uncle Bob''s Organic Dried Pears', 3, CAST(30.00 AS Decimal(18, 2)), 15)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (8, 2, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Northwoods Cranberry Sauce', 3, CAST(40.00 AS Decimal(18, 2)), 6)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (9, 6, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Mishi Kobe Niku', 4, CAST(97.00 AS Decimal(18, 2)), 29)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (10, 8, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Ikura', 4, CAST(31.00 AS Decimal(18, 2)), 31)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (11, 4, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Queso Cabrales', 5, CAST(21.00 AS Decimal(18, 2)), 22)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (12, 4, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Queso Manchego La Pastora', 5, CAST(38.00 AS Decimal(18, 2)), 86)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (13, 8, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Konbu', 6, CAST(6.00 AS Decimal(18, 2)), 24)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (14, 7, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Tofu', 6, CAST(23.25 AS Decimal(18, 2)), 35)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (15, 2, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Genen Shouyu', 6, CAST(15.50 AS Decimal(18, 2)), 39)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (16, 3, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Pavlova', 7, CAST(17.45 AS Decimal(18, 2)), 29)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (17, 6, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Alice Mutton', 7, CAST(39.00 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (18, 8, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Carnarvon Tigers', 7, CAST(62.50 AS Decimal(18, 2)), 42)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (19, 3, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Teatime Chocolate Biscuits', 8, CAST(9.20 AS Decimal(18, 2)), 25)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (20, 3, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Sir Rodney''s Marmalade', 8, CAST(81.00 AS Decimal(18, 2)), 40)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (21, 3, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Sir Rodney''s Scones', 8, CAST(10.00 AS Decimal(18, 2)), 3)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (22, 5, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Gustaf''s Knäckebröd', 9, CAST(21.00 AS Decimal(18, 2)), 104)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (23, 5, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Tunnbröd', 9, CAST(9.00 AS Decimal(18, 2)), 61)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (24, 1, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Guaraná Fantástica', 10, CAST(4.50 AS Decimal(18, 2)), 20)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (25, 3, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'NuNuCa Nuß-Nougat-Creme', 11, CAST(14.00 AS Decimal(18, 2)), 76)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (26, 3, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Gumbär Gummibärchen', 11, CAST(31.23 AS Decimal(18, 2)), 15)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (27, 3, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Schoggi Schokolade', 11, CAST(43.90 AS Decimal(18, 2)), 49)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (28, 7, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Rössle Sauerkraut', 12, CAST(45.60 AS Decimal(18, 2)), 26)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (29, 6, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Thüringer Rostbratwurst', 12, CAST(123.79 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (30, 8, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Nord-Ost Matjeshering', 13, CAST(25.89 AS Decimal(18, 2)), 10)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (31, 4, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Gorgonzola Telino', 14, CAST(12.50 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (32, 4, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Mascarpone Fabioli', 14, CAST(32.00 AS Decimal(18, 2)), 9)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (33, 4, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Geitost', 15, CAST(2.50 AS Decimal(18, 2)), 112)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (34, 1, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Sasquatch Ale', 16, CAST(14.00 AS Decimal(18, 2)), 111)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (35, 1, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Steeleye Stout', 16, CAST(18.00 AS Decimal(18, 2)), 20)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (36, 8, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Inlagd Sill', 17, CAST(19.00 AS Decimal(18, 2)), 112)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (37, 8, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Gravad lax', 17, CAST(26.00 AS Decimal(18, 2)), 11)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (38, 1, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Côte de Blaye', 18, CAST(263.50 AS Decimal(18, 2)), 17)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (39, 1, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Chartreuse verte', 18, CAST(18.00 AS Decimal(18, 2)), 69)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (40, 8, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Boston Crab Meat', 19, CAST(18.40 AS Decimal(18, 2)), 123)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (41, 8, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Jack''s New England Clam Chowder', 19, CAST(9.65 AS Decimal(18, 2)), 85)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (42, 5, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Singaporean Hokkien Fried Mee', 20, CAST(14.00 AS Decimal(18, 2)), 26)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (43, 1, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Ipoh Coffee', 20, CAST(46.00 AS Decimal(18, 2)), 17)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (44, 2, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Gula Malacca', 20, CAST(19.45 AS Decimal(18, 2)), 27)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (45, 8, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Rogede sild', 21, CAST(9.50 AS Decimal(18, 2)), 5)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (46, 8, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Spegesild', 21, CAST(12.00 AS Decimal(18, 2)), 95)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (47, 3, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Zaanse koeken', 22, CAST(9.50 AS Decimal(18, 2)), 36)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (48, 3, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Chocolade', 22, CAST(12.75 AS Decimal(18, 2)), 15)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (49, 3, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Maxilaku', 23, CAST(20.00 AS Decimal(18, 2)), 10)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (50, 3, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Valkoinen suklaa', 23, CAST(16.25 AS Decimal(18, 2)), 65)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (51, 7, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Manjimup Dried Apples', 24, CAST(53.00 AS Decimal(18, 2)), 20)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (52, 5, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Filo Mix', 24, CAST(7.00 AS Decimal(18, 2)), 38)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (53, 6, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Perth Pasties', 24, CAST(32.80 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (54, 6, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Tourtière', 25, CAST(7.45 AS Decimal(18, 2)), 21)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (55, 6, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Pâté chinois', 25, CAST(24.00 AS Decimal(18, 2)), 115)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (56, 5, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Gnocchi di nonna Alice', 26, CAST(38.00 AS Decimal(18, 2)), 21)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (57, 5, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Ravioli Angelo', 26, CAST(19.50 AS Decimal(18, 2)), 36)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (58, 8, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Escargots de Bourgogne', 27, CAST(13.25 AS Decimal(18, 2)), 62)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (59, 4, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Raclette Courdavault', 28, CAST(55.00 AS Decimal(18, 2)), 79)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (60, 4, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Camembert Pierrot', 28, CAST(34.00 AS Decimal(18, 2)), 19)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (61, 2, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Sirop d''érable', 29, CAST(28.50 AS Decimal(18, 2)), 113)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (62, 3, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Tarte au sucre', 29, CAST(49.30 AS Decimal(18, 2)), 17)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (63, 2, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Vegie-spread', 7, CAST(43.90 AS Decimal(18, 2)), 24)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (64, 5, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Wimmers gute Semmelknödel', 12, CAST(33.25 AS Decimal(18, 2)), 22)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (65, 2, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Louisiana Fiery Hot Pepper Sauce', 2, CAST(21.05 AS Decimal(18, 2)), 76)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (66, 2, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Louisiana Hot Spiced Okra', 2, CAST(17.00 AS Decimal(18, 2)), 4)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (67, 1, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Laughing Lumberjack Lager', 16, CAST(14.00 AS Decimal(18, 2)), 52)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (68, 3, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Scottish Longbreads', 8, CAST(12.50 AS Decimal(18, 2)), 6)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (69, 4, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Gudbrandsdalsost', 15, CAST(36.00 AS Decimal(18, 2)), 26)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (70, 1, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Outback Lager', 7, CAST(15.00 AS Decimal(18, 2)), 15)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (71, 4, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Flotemysost', 15, CAST(21.50 AS Decimal(18, 2)), 26)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (72, 4, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Mozzarella di Giovanni', 14, CAST(34.80 AS Decimal(18, 2)), 14)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (73, 8, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Röd Kaviar', 17, CAST(15.00 AS Decimal(18, 2)), 101)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (74, 7, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Longlife Tofu', 4, CAST(10.00 AS Decimal(18, 2)), 4)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (75, 1, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Rhönbräu Klosterbier', 12, CAST(7.75 AS Decimal(18, 2)), 125)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (76, 1, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Lakkalikööri', 23, CAST(18.00 AS Decimal(18, 2)), 57)
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Created], [Modified], [Name], [SupplierId], [UnitPrice], [UnitsInStock]) VALUES (77, 2, CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), CAST(N'2017-11-22T14:01:16.1133333' AS DateTime2), N'Original Frankfurter grüne Soße', 12, CAST(13.00 AS Decimal(18, 2)), 32)
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Products_Categories_CategoryId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Products]'))
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Products_Categories_CategoryId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Products]'))
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories_CategoryId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Products_Suppliers_SupplierId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Products]'))
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Suppliers_SupplierId] FOREIGN KEY([SupplierId])
REFERENCES [dbo].[Suppliers] ([Id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Products_Suppliers_SupplierId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Products]'))
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Suppliers_SupplierId]
GO
