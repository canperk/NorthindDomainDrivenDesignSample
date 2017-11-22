USE [NorthwindDomainDriven]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 11/22/2017 2:04:14 PM ******/
DROP TABLE IF EXISTS [dbo].[Suppliers]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 11/22/2017 2:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Suppliers]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Suppliers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[City] [nvarchar](max) NULL,
	[CompanyName] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[Created] [datetime2](7) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[Fax] [nvarchar](max) NULL,
	[Manager] [nvarchar](max) NULL,
	[Modified] [datetime2](7) NOT NULL,
	[Phone] [nvarchar](max) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[Suppliers] ON 
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (1, N'London', N'Exotic Liquids', N'UK', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', NULL, N'Charlotte Cooper', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'(171) 555-2222')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (2, N'New Orleans', N'New Orleans Cajun Delights', N'USA', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', NULL, N'Shelley Burke', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'(100) 555-4822')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (3, N'Ann Arbor', N'Grandma Kelly''s Homestead', N'USA', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', N'(313) 555-3349', N'Regina Murphy', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'(313) 555-5735')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (4, N'Tokyo', N'Tokyo Traders', N'Japan', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', NULL, N'Yoshi Nagase', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'(03) 3555-5011')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (5, N'Oviedo', N'Cooperativa de Quesos ''Las Cabras''', N'Spain', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', NULL, N'Antonio del Valle Saavedra', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'(98) 598 76 54')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (6, N'Osaka', N'Mayumi''s', N'Japan', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', NULL, N'Mayumi Ohno', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'(06) 431-7877')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (7, N'Melbourne', N'Pavlova, Ltd.', N'Australia', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', N'(03) 444-6588', N'Ian Devling', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'(03) 444-2343')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (8, N'Manchester', N'Specialty Biscuits, Ltd.', N'UK', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', NULL, N'Peter Wilson', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'(161) 555-4448')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (9, N'Göteborg', N'PB Knäckebröd AB', N'Sweden', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', N'031-987 65 91', N'Lars Peterson', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'031-987 65 43')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (10, N'Sao Paulo', N'Refrescos Americanas LTDA', N'Brazil', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', NULL, N'Carlos Diaz', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'(11) 555 4640')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (11, N'Berlin', N'Heli Süßwaren GmbH & Co. KG', N'Germany', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', NULL, N'Petra Winkler', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'(010) 9984510')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (12, N'Frankfurt', N'Plutzer Lebensmittelgroßmärkte AG', N'Germany', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', NULL, N'Martin Bein', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'(069) 992755')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (13, N'Cuxhaven', N'Nord-Ost-Fisch Handelsgesellschaft mbH', N'Germany', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', N'(04721) 8714', N'Sven Petersen', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'(04721) 8713')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (14, N'Ravenna', N'Formaggi Fortini s.r.l.', N'Italy', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', N'(0544) 60603', N'Elio Rossi', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'(0544) 60323')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (15, N'Sandvika', N'Norske Meierier', N'Norway', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', NULL, N'Beate Vileid', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'(0)2-953010')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (16, N'Bend', N'Bigfoot Breweries', N'USA', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', NULL, N'Cheryl Saylor', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'(503) 555-9931')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (17, N'Stockholm', N'Svensk Sjöföda AB', N'Sweden', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', NULL, N'Michael Björn', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'08-123 45 67')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (18, N'Paris', N'Aux joyeux ecclésiastiques', N'France', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', N'(1) 03.83.00.62', N'Guylène Nodier', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'(1) 03.83.00.68')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (19, N'Boston', N'New England Seafood Cannery', N'USA', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', N'(617) 555-3389', N'Robb Merchant', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'(617) 555-3267')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (20, N'Singapore', N'Leka Trading', N'Singapore', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', NULL, N'Chandra Leka', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'555-8787')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (21, N'Lyngby', N'Lyngbysild', N'Denmark', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', N'43844115', N'Niels Petersen', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'43844108')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (22, N'Zaandam', N'Zaanse Snoepfabriek', N'Netherlands', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', N'(12345) 1210', N'Dirk Luchte', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'(12345) 1212')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (23, N'Lappeenranta', N'Karkki Oy', N'Finland', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', NULL, N'Anne Heikkonen', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'(953) 10956')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (24, N'Sydney', N'G''day, Mate', N'Australia', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', N'(02) 555-4873', N'Wendy Mackenzie', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'(02) 555-5914')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (25, N'Montréal', N'Ma Maison', N'Canada', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', NULL, N'Jean-Guy Lauzon', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'(514) 555-9022')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (26, N'Salerno', N'Pasta Buttini s.r.l.', N'Italy', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', N'(089) 6547667', N'Giovanni Giudici', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'(089) 6547665')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (27, N'Montceau', N'Escargots Nouveaux', N'France', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', NULL, N'Marie Delamare', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'85.57.00.07')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (28, N'Annecy', N'Gai pâturage', N'France', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', N'38.76.98.58', N'Eliane Noz', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'38.76.98.06')
GO
INSERT [dbo].[Suppliers] ([Id], [City], [CompanyName], [Country], [Created], [Email], [Fax], [Manager], [Modified], [Phone]) VALUES (29, N'Ste-Hyacinthe', N'Forêts d''érables', N'Canada', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'company@mail.com', N'(514) 555-2921', N'Chantal Goulet', CAST(N'2017-11-22T13:59:57.0900000' AS DateTime2), N'(514) 555-2955')
GO
SET IDENTITY_INSERT [dbo].[Suppliers] OFF
GO
