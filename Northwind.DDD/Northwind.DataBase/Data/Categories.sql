USE [NorthwindDomainDriven]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 11/22/2017 1:24:27 PM ******/
DROP TABLE IF EXISTS [dbo].[Categories]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 11/22/2017 1:24:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Categories]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Created] [datetime2](7) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Modified] [datetime2](7) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 
GO
INSERT [dbo].[Categories] ([Id], [Created], [Description], [Modified], [Name]) VALUES (1, CAST(N'2017-11-22T13:23:20.5900000' AS DateTime2), N'Soft drinks, coffees, teas, beers, and ales', CAST(N'2017-11-22T13:23:20.5900000' AS DateTime2), N'Beverages')
GO
INSERT [dbo].[Categories] ([Id], [Created], [Description], [Modified], [Name]) VALUES (2, CAST(N'2017-11-22T13:23:20.5900000' AS DateTime2), N'Sweet and savory sauces, relishes, spreads, and seasonings', CAST(N'2017-11-22T13:23:20.5900000' AS DateTime2), N'Condiments')
GO
INSERT [dbo].[Categories] ([Id], [Created], [Description], [Modified], [Name]) VALUES (3, CAST(N'2017-11-22T13:23:20.5900000' AS DateTime2), N'Desserts, candies, and sweet breads', CAST(N'2017-11-22T13:23:20.5900000' AS DateTime2), N'Confections')
GO
INSERT [dbo].[Categories] ([Id], [Created], [Description], [Modified], [Name]) VALUES (4, CAST(N'2017-11-22T13:23:20.5900000' AS DateTime2), N'Cheeses', CAST(N'2017-11-22T13:23:20.5900000' AS DateTime2), N'Dairy Products')
GO
INSERT [dbo].[Categories] ([Id], [Created], [Description], [Modified], [Name]) VALUES (5, CAST(N'2017-11-22T13:23:20.5900000' AS DateTime2), N'Breads, crackers, pasta, and cereal', CAST(N'2017-11-22T13:23:20.5900000' AS DateTime2), N'Grains/Cereals')
GO
INSERT [dbo].[Categories] ([Id], [Created], [Description], [Modified], [Name]) VALUES (6, CAST(N'2017-11-22T13:23:20.5900000' AS DateTime2), N'Prepared meats', CAST(N'2017-11-22T13:23:20.5900000' AS DateTime2), N'Meat/Poultry')
GO
INSERT [dbo].[Categories] ([Id], [Created], [Description], [Modified], [Name]) VALUES (7, CAST(N'2017-11-22T13:23:20.5900000' AS DateTime2), N'Dried fruit and bean curd', CAST(N'2017-11-22T13:23:20.5900000' AS DateTime2), N'Produce')
GO
INSERT [dbo].[Categories] ([Id], [Created], [Description], [Modified], [Name]) VALUES (8, CAST(N'2017-11-22T13:23:20.5900000' AS DateTime2), N'Seaweed and fish', CAST(N'2017-11-22T13:23:20.5900000' AS DateTime2), N'Seafood')
GO
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
