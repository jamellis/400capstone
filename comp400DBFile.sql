USE [comp400_2012]
GO
/****** Object:  ForeignKey [fkStoreinv]    Script Date: 07/08/2012 16:35:25 ******/
ALTER TABLE [dbo].[inventory] DROP CONSTRAINT [fkStoreinv]
GO
/****** Object:  ForeignKey [fkTireinv]    Script Date: 07/08/2012 16:35:25 ******/
ALTER TABLE [dbo].[inventory] DROP CONSTRAINT [fkTireinv]
GO
/****** Object:  Table [dbo].[inventory]    Script Date: 07/08/2012 16:35:25 ******/
ALTER TABLE [dbo].[inventory] DROP CONSTRAINT [fkStoreinv]
GO
ALTER TABLE [dbo].[inventory] DROP CONSTRAINT [fkTireinv]
GO
DROP TABLE [dbo].[inventory]
GO
/****** Object:  Table [dbo].[store]    Script Date: 07/08/2012 16:35:25 ******/
DROP TABLE [dbo].[store]
GO
/****** Object:  Table [dbo].[tire]    Script Date: 07/08/2012 16:35:25 ******/
DROP TABLE [dbo].[tire]
GO
/****** Object:  Table [dbo].[tire]    Script Date: 07/08/2012 16:35:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tire](
	[tireCode] [varchar](4) NOT NULL,
	[description] [varchar](50) NOT NULL,
	[manufacturer] [varchar](30) NOT NULL,
	[manufacturerSize] [varchar](4) NOT NULL,
	[wholesalePrice] [decimal](6, 2) NOT NULL,
	[retailPrice] [decimal](6, 2) NOT NULL,
 CONSTRAINT [pkTire] PRIMARY KEY CLUSTERED 
(
	[tireCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [wholesalePrice], [retailPrice]) VALUES (N'A123', N'Cooper All Weather Thread', N'Cooper Tires', N'R215', CAST(79.95 AS Decimal(6, 2)), CAST(104.95 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [wholesalePrice], [retailPrice]) VALUES (N'B378', N'All Terrian ', N'Bridgestone', N'R235', CAST(199.95 AS Decimal(6, 2)), CAST(235.95 AS Decimal(6, 2)))
/****** Object:  Table [dbo].[store]    Script Date: 07/08/2012 16:35:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[store](
	[storeNbr] [varchar](5) NOT NULL,
	[streetAddress] [varchar](50) NOT NULL,
	[city] [varchar](30) NOT NULL,
	[state] [varchar](30) NOT NULL,
	[zip] [varchar](10) NOT NULL,
	[phone] [varchar](16) NOT NULL,
	[fax] [varchar](16) NOT NULL,
	[email] [varchar](50) NOT NULL,
 CONSTRAINT [pkStore] PRIMARY KEY CLUSTERED 
(
	[storeNbr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0001', N'987 SE Hall St', N'Portland', N'OR', N'97222', N'503 746-8267', N'503 746-8376', N'store0001@store.com')
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0002', N'736 SW Elk Lane', N'Gresham', N'OR', N'97220', N'503 564-1237', N'503 564-1238', N'store0002@store.com')
/****** Object:  Table [dbo].[inventory]    Script Date: 07/08/2012 16:35:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[inventory](
	[inventoryNbr] [varchar](8) NOT NULL,
	[tireCode] [varchar](4) NOT NULL,
	[storeNbr] [varchar](5) NOT NULL,
	[tireQty] [decimal](4, 0) NOT NULL,
 CONSTRAINT [pkInventory] PRIMARY KEY CLUSTERED 
(
	[inventoryNbr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (N'T00001', N'A123', N'0001', CAST(3 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (N'T00002', N'A123', N'0002', CAST(6 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (N'T00003', N'B378', N'0002', CAST(1 AS Decimal(4, 0)))
/****** Object:  ForeignKey [fkStoreinv]    Script Date: 07/08/2012 16:35:25 ******/
ALTER TABLE [dbo].[inventory]  WITH CHECK ADD  CONSTRAINT [fkStoreinv] FOREIGN KEY([storeNbr])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[inventory] CHECK CONSTRAINT [fkStoreinv]
GO
/****** Object:  ForeignKey [fkTireinv]    Script Date: 07/08/2012 16:35:25 ******/
ALTER TABLE [dbo].[inventory]  WITH CHECK ADD  CONSTRAINT [fkTireinv] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[inventory] CHECK CONSTRAINT [fkTireinv]
GO