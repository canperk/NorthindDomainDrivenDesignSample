USE [NorthwindDomainDriven]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 11/8/2017 4:15:24 PM ******/
DROP TABLE [dbo].[Employees]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 11/8/2017 4:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[HireDate] [datetime2](7) NULL,
	[BirthDate] [datetime2](7) NULL,
	[City] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[Created] [datetime2](7) NOT NULL,
	[EMail] [nvarchar](max) NULL,
	[ManagerId] [bigint] NULL,
	[Modified] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [HireDate], [BirthDate], [City], [Country], [Created], [EMail], [ManagerId], [Modified]) VALUES (1, N'Nancy', N'Davolio', CAST(N'2015-05-01T00:00:00.0000000' AS DateTime2), CAST(N'1982-12-08T00:00:00.0000000' AS DateTime2), N'Seattle', N'USA', CAST(N'2017-11-08T16:10:19.2266667' AS DateTime2), N'mail@mail.com', 2, CAST(N'2017-11-08T16:10:19.2266667' AS DateTime2))
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [HireDate], [BirthDate], [City], [Country], [Created], [EMail], [ManagerId], [Modified]) VALUES (2, N'Andrew', N'Fuller', CAST(N'2016-08-14T00:00:00.0000000' AS DateTime2), CAST(N'1982-02-19T00:00:00.0000000' AS DateTime2), N'Tacoma', N'USA', CAST(N'2017-11-08T16:10:19.2266667' AS DateTime2), N'mail@mail.com', NULL, CAST(N'2017-11-08T16:10:19.2266667' AS DateTime2))
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [HireDate], [BirthDate], [City], [Country], [Created], [EMail], [ManagerId], [Modified]) VALUES (3, N'Janet', N'Leverling', CAST(N'2014-04-01T00:00:00.0000000' AS DateTime2), CAST(N'1983-08-30T00:00:00.0000000' AS DateTime2), N'Kirkland', N'USA', CAST(N'2017-11-08T16:10:19.2266667' AS DateTime2), N'mail@mail.com', 2, CAST(N'2017-11-08T16:10:19.2266667' AS DateTime2))
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [HireDate], [BirthDate], [City], [Country], [Created], [EMail], [ManagerId], [Modified]) VALUES (4, N'Margaret', N'Peacock', CAST(N'2016-05-03T00:00:00.0000000' AS DateTime2), CAST(N'1987-09-19T00:00:00.0000000' AS DateTime2), N'Redmond', N'USA', CAST(N'2017-11-08T16:10:19.2266667' AS DateTime2), N'mail@mail.com', 2, CAST(N'2017-11-08T16:10:19.2266667' AS DateTime2))
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [HireDate], [BirthDate], [City], [Country], [Created], [EMail], [ManagerId], [Modified]) VALUES (5, N'Steven', N'Buchanan', CAST(N'2015-10-17T00:00:00.0000000' AS DateTime2), CAST(N'1985-03-04T00:00:00.0000000' AS DateTime2), N'London', N'UK', CAST(N'2017-11-08T16:10:19.2266667' AS DateTime2), N'mail@mail.com', 2, CAST(N'2017-11-08T16:10:19.2266667' AS DateTime2))
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [HireDate], [BirthDate], [City], [Country], [Created], [EMail], [ManagerId], [Modified]) VALUES (6, N'Michael', N'Suyama', CAST(N'2014-10-17T00:00:00.0000000' AS DateTime2), CAST(N'1983-07-02T00:00:00.0000000' AS DateTime2), N'London', N'UK', CAST(N'2017-11-08T16:10:19.2266667' AS DateTime2), N'mail@mail.com', 5, CAST(N'2017-11-08T16:10:19.2266667' AS DateTime2))
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [HireDate], [BirthDate], [City], [Country], [Created], [EMail], [ManagerId], [Modified]) VALUES (7, N'Robert', N'King', CAST(N'2013-01-02T00:00:00.0000000' AS DateTime2), CAST(N'1980-05-29T00:00:00.0000000' AS DateTime2), N'London', N'UK', CAST(N'2017-11-08T16:10:19.2266667' AS DateTime2), N'mail@mail.com', 5, CAST(N'2017-11-08T16:10:19.2266667' AS DateTime2))
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [HireDate], [BirthDate], [City], [Country], [Created], [EMail], [ManagerId], [Modified]) VALUES (8, N'Laura', N'Callahan', CAST(N'1994-03-05T00:00:00.0000000' AS DateTime2), CAST(N'1988-01-09T00:00:00.0000000' AS DateTime2), N'Seattle', N'USA', CAST(N'2017-11-08T16:10:19.2266667' AS DateTime2), N'mail@mail.com', 2, CAST(N'2017-11-08T16:10:19.2266667' AS DateTime2))
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [HireDate], [BirthDate], [City], [Country], [Created], [EMail], [ManagerId], [Modified]) VALUES (9, N'Anne', N'Dodsworth', CAST(N'2016-11-15T00:00:00.0000000' AS DateTime2), CAST(N'1986-01-27T00:00:00.0000000' AS DateTime2), N'London', N'UK', CAST(N'2017-11-08T16:10:19.2266667' AS DateTime2), N'mail@mail.com', 5, CAST(N'2017-11-08T16:10:19.2266667' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
