CREATE  DATABASE [Restaurants]

GO

USE [Restaurants]
GO

CREATE TABLE [dbo].[Orders](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[WaiterID] [int] NOT NULL,
	[OrderAmount] [int] NULL,
	[OrderContents] [nvarchar](200) NULL,
	[OrderTable] [nvarchar](20) NULL,
	[OrderDate] [date] NULL,
	[OrderStatus] [bit] NULL,
	[TableStatus] [bit] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Staff](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NULL,
	[Surname] [nvarchar](20) NULL,
	[Password] [nvarchar](15) NULL,
	[Job] [nvarchar](15) NULL,
	[Status] [bit] NULL,
	[Email] [nvarchar](50) NULL
) ON [PRIMARY]
GO

SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([ID], [WaiterID], [OrderAmount], [OrderContents], [OrderTable], [OrderDate], [OrderStatus], [TableStatus]) VALUES (9, 11, 220, N'Nước ngọt 10Kx1
Trà đá 5Kx0
Chanh dây 10Kx0
Nước cam 10Kx1
Phở bò 40Kx1
Bánh xèo 20Kx0
Bánh mì 60Kx0
Bún bò 80Kx1
Chè thập cẩm 30Kx1
Bánh chuối 25Kx0
Bánh khoai 45Kx0
Bánh flan 50Kx1', N'Bàn 10', CAST(N'2022-08-15' AS Date), 1, 0)
INSERT [dbo].[Orders] ([ID], [WaiterID], [OrderAmount], [OrderContents], [OrderTable], [OrderDate], [OrderStatus], [TableStatus]) VALUES (12, 11, 200, N'Nước ngọt 10Kx0
Trà đá 5Kx0
Chanh dây 10Kx0
Nước cam 10Kx0
Phở bò 40Kx1
Bánh xèo 20Kx1
Bánh mì 60Kx1
Bún bò 80Kx1
Chè thập cẩm 30Kx0
Bánh chuối 25Kx0
Bánh khoai 45Kx0
Bánh flan 50Kx0', N'Bàn 4', CAST(N'2022-09-16' AS Date), 1, 0)
INSERT [dbo].[Orders] ([ID], [WaiterID], [OrderAmount], [OrderContents], [OrderTable], [OrderDate], [OrderStatus], [TableStatus]) VALUES (10, 11, 165, N'Nước ngọt 10Kx0
Trà đá 5Kx1
Chanh dây 10Kx1
Nước cam 10Kx0
Phở bò 40Kx0
Bánh xèo 20Kx1
Bánh mì 60Kx1
Bún bò 80Kx0
Chè thập cẩm 30Kx0
Bánh chuối 25Kx1
Bánh khoai 45Kx1
Bánh flan 50Kx0', N'Bàn 6', CAST(N'2022-12-15' AS Date), 1, 0)

SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Staff] ON

INSERT [dbo].[Staff] ([ID], [Name], [Surname], [Password], [Job], [Status], [Email]) VALUES (1, N'Nguyen A', N'Nguyen', N'123456', N'Admin', 1, N'nguyena@gmail.com')
INSERT [dbo].[Staff] ([ID], [Name], [Surname], [Password], [Job], [Status], [Email]) VALUES (2, N'Le B', N'Le', N'123456', N'Cashier', 1, N'leb@gmail.com')
INSERT [dbo].[Staff] ([ID], [Name], [Surname], [Password], [Job], [Status], [Email]) VALUES (11, N'Pham C', N'Pham', N'123456', N'Waiter', 1, N'phamc@gmail.com')
INSERT [dbo].[Staff] ([ID], [Name], [Surname], [Password], [Job], [Status], [Email]) VALUES (12, N'Hoang D', N'Hoang', N'123456', N'Waiter', 1, N'hoangd@gmail.com')
INSERT [dbo].[Staff] ([ID], [Name], [Surname], [Password], [Job], [Status], [Email]) VALUES (13, N'Tran E', N'Tran', N'123456', N'KitchenWorker', 1, N'trane@gmail.com')
INSERT [dbo].[Staff] ([ID], [Name], [Surname], [Password], [Job], [Status], [Email]) VALUES (16, N'Vu F', N'Vu', N'123456', N'Cashier', 1, N'vuf@gmail.com')
INSERT [dbo].[Staff] ([ID], [Name], [Surname], [Password], [Job], [Status], [Email]) VALUES (16, N'Nguyen Thang', N'Thang', N'123456', N'Admin', 1, N'nguyenthang@gmail.com')
SET IDENTITY_INSERT [dbo].[Staff] OFF
GO