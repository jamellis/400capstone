USE [comp400_2012]
GO
ALTER TABLE [dbo].[tire] DROP CONSTRAINT [DF_tire_retailPrice]
GO
ALTER TABLE [dbo].[tire] DROP CONSTRAINT [DF_tire_dealerPrice]
GO
ALTER TABLE [dbo].[tire] DROP CONSTRAINT [DF_tire_wholesaleCost]
GO
/****** Object:  ForeignKey [fkEmpSecurity]    Script Date: 08/19/2012 09:34:33 ******/
ALTER TABLE [dbo].[employee] DROP CONSTRAINT [fkEmpSecurity]
GO
/****** Object:  ForeignKey [fkEmpStore]    Script Date: 08/19/2012 09:34:33 ******/
ALTER TABLE [dbo].[employee] DROP CONSTRAINT [fkEmpStore]
GO
/****** Object:  ForeignKey [fkStoreInv]    Script Date: 08/19/2012 09:34:33 ******/
ALTER TABLE [dbo].[inventory] DROP CONSTRAINT [fkStoreInv]
GO
/****** Object:  ForeignKey [fkTireInv]    Script Date: 08/19/2012 09:34:33 ******/
ALTER TABLE [dbo].[inventory] DROP CONSTRAINT [fkTireInv]
GO
/****** Object:  ForeignKey [fkPoTireCode]    Script Date: 08/19/2012 09:34:33 ******/
ALTER TABLE [dbo].[purchaseOrder] DROP CONSTRAINT [fkPoTireCode]
GO
/****** Object:  ForeignKey [fkPoVendor]    Script Date: 08/19/2012 09:34:33 ******/
ALTER TABLE [dbo].[purchaseOrder] DROP CONSTRAINT [fkPoVendor]
GO
/****** Object:  ForeignKey [fkRtlOrderCust]    Script Date: 08/19/2012 09:34:33 ******/
ALTER TABLE [dbo].[retailOrder] DROP CONSTRAINT [fkRtlOrderCust]
GO
/****** Object:  ForeignKey [fkRtlOrderEmp]    Script Date: 08/19/2012 09:34:33 ******/
ALTER TABLE [dbo].[retailOrder] DROP CONSTRAINT [fkRtlOrderEmp]
GO
/****** Object:  ForeignKey [fkRtlOrderStore]    Script Date: 08/19/2012 09:34:33 ******/
ALTER TABLE [dbo].[retailOrder] DROP CONSTRAINT [fkRtlOrderStore]
GO
/****** Object:  ForeignKey [FK_wholesaleOrder_dealer]    Script Date: 08/19/2012 09:34:33 ******/
ALTER TABLE [dbo].[wholesaleOrder] DROP CONSTRAINT [FK_wholesaleOrder_dealer]
GO
/****** Object:  ForeignKey [FK_wholesaleOrder_tire]    Script Date: 08/19/2012 09:34:33 ******/
ALTER TABLE [dbo].[wholesaleOrder] DROP CONSTRAINT [FK_wholesaleOrder_tire]
GO
/****** Object:  Table [dbo].[retailOrder]    Script Date: 08/19/2012 09:34:33 ******/
DROP TABLE [dbo].[retailOrder]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 08/19/2012 09:34:33 ******/
DROP TABLE [dbo].[employee]
GO
/****** Object:  Table [dbo].[inventory]    Script Date: 08/19/2012 09:34:33 ******/
DROP TABLE [dbo].[inventory]
GO
/****** Object:  Table [dbo].[purchaseOrder]    Script Date: 08/19/2012 09:34:33 ******/
DROP TABLE [dbo].[purchaseOrder]
GO
/****** Object:  Table [dbo].[wholesaleOrder]    Script Date: 08/19/2012 09:34:33 ******/
DROP TABLE [dbo].[wholesaleOrder]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 08/19/2012 09:34:33 ******/
DROP TABLE [dbo].[customer]
GO
/****** Object:  Table [dbo].[dealer]    Script Date: 08/19/2012 09:34:33 ******/
DROP TABLE [dbo].[dealer]
GO
/****** Object:  Table [dbo].[securityClearance]    Script Date: 08/19/2012 09:34:33 ******/
DROP TABLE [dbo].[securityClearance]
GO
/****** Object:  Table [dbo].[store]    Script Date: 08/19/2012 09:34:33 ******/
DROP TABLE [dbo].[store]
GO
/****** Object:  Table [dbo].[tire]    Script Date: 08/19/2012 09:34:33 ******/
DROP TABLE [dbo].[tire]
GO
/****** Object:  Table [dbo].[vendor]    Script Date: 08/19/2012 09:34:33 ******/
DROP TABLE [dbo].[vendor]
GO
/****** Object:  Table [dbo].[vendor]    Script Date: 08/19/2012 09:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vendor](
	[vendorID] [int] IDENTITY(1000,1) NOT NULL,
	[vendorName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_vendor] PRIMARY KEY CLUSTERED 
(
	[vendorID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[vendor] ON
INSERT [dbo].[vendor] ([vendorID], [vendorName]) VALUES (1000, N'Bridgestone')
SET IDENTITY_INSERT [dbo].[vendor] OFF
/****** Object:  Table [dbo].[tire]    Script Date: 08/19/2012 09:34:33 ******/
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
	[manufacturerSize] [varchar](20) NOT NULL,
	[retailPrice] [decimal](6, 2) NOT NULL,
	[dealerPrice] [decimal](6, 2) NOT NULL,
	[wholesaleCost] [decimal](6, 2) NOT NULL,
 CONSTRAINT [pkTire] PRIMARY KEY CLUSTERED 
(
	[tireCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'87T', N'Premier Touring', N'BF Goodrich', N'185/70R14', CAST(73.00 AS Decimal(6, 2)), CAST(59.21 AS Decimal(6, 2)), CAST(48.75 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'A123', N'All Weather Radials', N'Cooper Tires', N'R215', CAST(104.95 AS Decimal(6, 2)), CAST(99.95 AS Decimal(6, 2)), CAST(85.45 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'A231', N'Summer Tire', N'Kumho', N'45R17', CAST(145.70 AS Decimal(6, 2)), CAST(124.23 AS Decimal(6, 2)), CAST(104.00 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'AT3', N'Off Road AT', N'Firestone', N'215/75R15', CAST(108.00 AS Decimal(6, 2)), CAST(86.32 AS Decimal(6, 2)), CAST(74.45 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'B378', N'All Terrain', N'Bridgestone', N'R235', CAST(235.95 AS Decimal(6, 2)), CAST(195.00 AS Decimal(6, 2)), CAST(165.00 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'D423', N'Fierce', N'Dunlop', N'180/60/45', CAST(170.00 AS Decimal(6, 2)), CAST(155.00 AS Decimal(6, 2)), CAST(125.00 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'F185', N'All Season', N'Falkin', N'R235', CAST(109.00 AS Decimal(6, 2)), CAST(100.00 AS Decimal(6, 2)), CAST(95.00 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'F186', N'All Season/Touring', N'Falkin', N'R225', CAST(154.00 AS Decimal(6, 2)), CAST(136.00 AS Decimal(6, 2)), CAST(120.00 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'F453', N'Mud Terrain', N'Yokojama', N'R285', CAST(200.00 AS Decimal(6, 2)), CAST(175.00 AS Decimal(6, 2)), CAST(125.00 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'FCII', N'Off Road', N'Dick Cepek', N'75R16', CAST(218.00 AS Decimal(6, 2)), CAST(189.36 AS Decimal(6, 2)), CAST(153.66 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'G134', N'Mud Terrain', N'Goodyear', N'R265', CAST(225.00 AS Decimal(6, 2)), CAST(210.00 AS Decimal(6, 2)), CAST(200.00 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'G135', N'Towing/Hauling', N'Goodyear', N'R285', CAST(245.00 AS Decimal(6, 2)), CAST(225.00 AS Decimal(6, 2)), CAST(210.00 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'G345', N'Work Tire-Heavy Duty', N'Goodyear', N'R265', CAST(185.00 AS Decimal(6, 2)), CAST(160.00 AS Decimal(6, 2)), CAST(120.00 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'IR5', N'Perfomance All', N'Firestone', N'295/50R15', CAST(142.00 AS Decimal(6, 2)), CAST(126.21 AS Decimal(6, 2)), CAST(115.23 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'J475', N'Rain Warrior', N'Michelin', N'R205', CAST(137.99 AS Decimal(6, 2)), CAST(129.99 AS Decimal(6, 2)), CAST(105.50 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'KU31', N'High Performance ', N'Kumbo', N'55R16', CAST(129.63 AS Decimal(6, 2)), CAST(111.22 AS Decimal(6, 2)), CAST(98.76 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'N111', N'All Weather', N'Nokian', N'R225', CAST(102.00 AS Decimal(6, 2)), CAST(98.00 AS Decimal(6, 2)), CAST(76.00 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'N198', N'Touring', N'Nokian', N'R245', CAST(134.00 AS Decimal(6, 2)), CAST(126.00 AS Decimal(6, 2)), CAST(115.00 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'N199', N'Performance', N'Nokian', N'R250', CAST(200.00 AS Decimal(6, 2)), CAST(185.00 AS Decimal(6, 2)), CAST(150.00 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'RT3', N'Crusher', N'Dick Cepek', N'285/75R16', CAST(233.00 AS Decimal(6, 2)), CAST(198.21 AS Decimal(6, 2)), CAST(179.55 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'T123', N'All Weather', N'Toyo', N'R275', CAST(185.00 AS Decimal(6, 2)), CAST(165.00 AS Decimal(6, 2)), CAST(140.00 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'T125', N'Off-Road', N'Toyo', N'R310', CAST(290.00 AS Decimal(6, 2)), CAST(270.00 AS Decimal(6, 2)), CAST(245.00 AS Decimal(6, 2)))
/****** Object:  Table [dbo].[store]    Script Date: 08/19/2012 09:34:33 ******/
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
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0001', N'987 SE Hall St', N'Portland', N'OR', N'97222', N'503-746-8175', N'503-746-8760', N'store0001@store.com')
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0002', N'736 SW Elk Lane 2', N'Gresham', N'OR', N'97220', N'503-564-1237', N'503-564-1238', N'store0002@store.com')
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0003', N'Happy Hooker Lane', N'Happy Valley', N'OR', N'88888', N'222-255-5522', N'222-222-2222', N'store0003@store.com')
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0004', N'2925 Santiam Hwy SE', N'Albany', N'OR', N'97322', N'541-926-2226', N'541-924-5698', N'store0004@store.com')
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0005', N'8379 SW 10th Ave', N'Eugene', N'OR', N'97378', N'541-876-1283', N'541-876-1290', N'store0005@store.com')
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0006', N'3294 Main St ', N'Sprinfield', N'OR', N'97478', N'541-747-4289', N'541-748-5896', N'store0006@store.com')
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0007', N'1719 W Main St', N'Battle Ground', N'OR', N'98604', N'360-687-0960', N'360-584-5214', N'store0007@store.com')
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0008', N'1140 N Pacific Hwy ', N'Woodburn', N'OR', N'97071', N'503-981-1875', N'503-269-5417', N'store0008@store.com')
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0009', N'1707 Main Street ', N'Sweet Home', N'OR', N'97389', N'541-367-6131', N'541-367-2698', N'store0009@store.com')
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0010', N'2308 Ashland St ', N'Ashland', N'OR', N'97520', N'541-482-4181', N'541-482-6352', N'store0010@store.com')
/****** Object:  Table [dbo].[securityClearance]    Script Date: 08/19/2012 09:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[securityClearance](
	[Clearance] [varchar](20) NOT NULL,
 CONSTRAINT [PK_securityClearance] PRIMARY KEY CLUSTERED 
(
	[Clearance] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[securityClearance] ([Clearance]) VALUES (N'Admin')
INSERT [dbo].[securityClearance] ([Clearance]) VALUES (N'Manager')
INSERT [dbo].[securityClearance] ([Clearance]) VALUES (N'Sales')
INSERT [dbo].[securityClearance] ([Clearance]) VALUES (N'Temp')
INSERT [dbo].[securityClearance] ([Clearance]) VALUES (N'Warehouse')
INSERT [dbo].[securityClearance] ([Clearance]) VALUES (N'Warehouse Manager')
/****** Object:  Table [dbo].[dealer]    Script Date: 08/19/2012 09:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[dealer](
	[dealerId] [int] IDENTITY(7000,1) NOT NULL,
	[dealerName] [varchar](30) NOT NULL,
	[dealerStreet] [varchar](30) NOT NULL,
	[dealerCity] [varchar](30) NOT NULL,
	[dealerState] [varchar](30) NOT NULL,
	[dealerZip] [varchar](10) NOT NULL,
	[dealerPhone] [varchar](16) NOT NULL,
 CONSTRAINT [pkDealer] PRIMARY KEY CLUSTERED 
(
	[dealerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[dealer] ON
INSERT [dbo].[dealer] ([dealerId], [dealerName], [dealerStreet], [dealerCity], [dealerState], [dealerZip], [dealerPhone]) VALUES (7000, N'Joe''s Shell', N'1234 Main St', N'Detroit', N'OR', N'97456', N'503-645-3456')
SET IDENTITY_INSERT [dbo].[dealer] OFF
/****** Object:  Table [dbo].[customer]    Script Date: 08/19/2012 09:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[customer](
	[customerID] [int] IDENTITY(4000,1) NOT NULL,
	[custFirstName] [varchar](30) NOT NULL,
	[custLastName] [varchar](30) NOT NULL,
	[custStreet] [varchar](30) NOT NULL,
	[custCity] [varchar](30) NOT NULL,
	[custState] [varchar](30) NOT NULL,
	[custZip] [varchar](10) NOT NULL,
	[custPhone] [varchar](16) NOT NULL,
 CONSTRAINT [pkCustomer] PRIMARY KEY CLUSTERED 
(
	[customerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[customer] ON
INSERT [dbo].[customer] ([customerID], [custFirstName], [custLastName], [custStreet], [custCity], [custState], [custZip], [custPhone]) VALUES (4000, N'Ken', N'Adams', N'7356 Sampson Dr', N'Portland', N'OR', N'97026', N'503-563-7356')
INSERT [dbo].[customer] ([customerID], [custFirstName], [custLastName], [custStreet], [custCity], [custState], [custZip], [custPhone]) VALUES (4001, N'Joel', N'Smith', N'4332 NW Dickey Rd', N'McMinnville', N'OR', N'97128', N'503-474-2747')
INSERT [dbo].[customer] ([customerID], [custFirstName], [custLastName], [custStreet], [custCity], [custState], [custZip], [custPhone]) VALUES (4002, N'Jennifer', N'Sampson', N'4217 N Umbridge Blvd', N'Dallas', N'WA', N'97127', N'360-441-7411')
SET IDENTITY_INSERT [dbo].[customer] OFF
/****** Object:  Table [dbo].[wholesaleOrder]    Script Date: 08/19/2012 09:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[wholesaleOrder](
	[whlslOrderNbr] [int] IDENTITY(1000,1) NOT NULL,
	[dealerID] [int] NOT NULL,
	[salesDate] [date] NOT NULL,
	[tireCode] [varchar](4) NOT NULL,
	[tireQty] [int] NULL,
	[whlslOrderTotal] [decimal](7, 2) NULL,
	[isClosed] [bit] NULL,
	[comments] [varchar](max) NULL,
 CONSTRAINT [PK_wholesaleOrder] PRIMARY KEY CLUSTERED 
(
	[whlslOrderNbr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[wholesaleOrder] ON
INSERT [dbo].[wholesaleOrder] ([whlslOrderNbr], [dealerID], [salesDate], [tireCode], [tireQty], [whlslOrderTotal], [isClosed], [comments]) VALUES (1002, 7000, CAST(0xEA350B00 AS Date), N'J475', 15, CAST(1949.85 AS Decimal(7, 2)), NULL, NULL)
INSERT [dbo].[wholesaleOrder] ([whlslOrderNbr], [dealerID], [salesDate], [tireCode], [tireQty], [whlslOrderTotal], [isClosed], [comments]) VALUES (1003, 7000, CAST(0x09360B00 AS Date), N'A123', 2, CAST(199.90 AS Decimal(7, 2)), 0, N'Still waiting...')
SET IDENTITY_INSERT [dbo].[wholesaleOrder] OFF
/****** Object:  Table [dbo].[purchaseOrder]    Script Date: 08/19/2012 09:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[purchaseOrder](
	[poNbr] [int] IDENTITY(3000,1) NOT NULL,
	[vendorID] [int] NOT NULL,
	[poDate] [date] NOT NULL,
	[tireCode] [varchar](4) NULL,
	[tireQty] [int] NULL,
	[poTotal] [decimal](7, 2) NULL,
	[isClosed] [bit] NULL,
	[comments] [varchar](max) NULL,
 CONSTRAINT [pkPurchaseOrder] PRIMARY KEY CLUSTERED 
(
	[poNbr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[purchaseOrder] ON
INSERT [dbo].[purchaseOrder] ([poNbr], [vendorID], [poDate], [tireCode], [tireQty], [poTotal], [isClosed], [comments]) VALUES (3000, 1000, CAST(0xEA350B00 AS Date), N'A123', 4, CAST(399.80 AS Decimal(7, 2)), 0, N'Waiting for 2 more tires')
INSERT [dbo].[purchaseOrder] ([poNbr], [vendorID], [poDate], [tireCode], [tireQty], [poTotal], [isClosed], [comments]) VALUES (3002, 1000, CAST(0x0C360B00 AS Date), N'A123', 4, CAST(341.80 AS Decimal(7, 2)), 0, N'Hurray updated ')
SET IDENTITY_INSERT [dbo].[purchaseOrder] OFF
/****** Object:  Table [dbo].[inventory]    Script Date: 08/19/2012 09:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[inventory](
	[inventoryNbr] [int] IDENTITY(10000,1) NOT NULL,
	[tireCode] [varchar](4) NOT NULL,
	[storeNbr] [varchar](5) NOT NULL,
	[tireQty] [decimal](4, 0) NOT NULL,
 CONSTRAINT [pkInvID] PRIMARY KEY CLUSTERED 
(
	[inventoryNbr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[inventory] ON
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10000, N'A123', N'0001', CAST(8 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10002, N'B378', N'0002', CAST(8 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10003, N'J475', N'0005', CAST(8 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10008, N'F453', N'0001', CAST(22 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10009, N'G345', N'0005', CAST(14 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10010, N'N111', N'0002', CAST(2 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10011, N'F185', N'0001', CAST(0 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10012, N'F186', N'0002', CAST(15 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10013, N'F186', N'0009', CAST(5 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10014, N'F186', N'0008', CAST(4 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10015, N'G134', N'0005', CAST(4 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10016, N'G135', N'0006', CAST(30 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10017, N'N198', N'0004', CAST(13 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10018, N'N199', N'0007', CAST(0 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10019, N'T123', N'0003', CAST(8 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10020, N'T125', N'0002', CAST(11 AS Decimal(4, 0)))
SET IDENTITY_INSERT [dbo].[inventory] OFF
/****** Object:  Table [dbo].[employee]    Script Date: 08/19/2012 09:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[employee](
	[employeeID] [int] IDENTITY(9000,1) NOT NULL,
	[firstName] [varchar](30) NOT NULL,
	[lastName] [varchar](30) NOT NULL,
	[userID] [varchar](15) NOT NULL,
	[password] [varchar](10) NOT NULL,
	[storeNbr] [varchar](5) NOT NULL,
	[userSecurityLevel] [varchar](20) NOT NULL,
 CONSTRAINT [PK_employee] PRIMARY KEY CLUSTERED 
(
	[employeeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[employee] ON
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (9000, N'Stanley', N'Harris', N'sharris', N'sh1234', N'0001', N'Temp')
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (9001, N'Susan', N'Barnes', N'abarnes', N'sb1234', N'0002', N'Sales')
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (9002, N'Howard', N'Newton', N'hnewton', N'hn1234', N'0001', N'Manager')
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (9004, N'Alan', N'Rankin', N'arankin', N'ar1234', N'0001', N'Admin')
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (9005, N'Barb', N'Mason', N'bmason', N'bm1234', N'0005', N'Warehouse')
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (9006, N'James', N'Ellis', N'jellis', N'je1234', N'0003', N'Manager')
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (9007, N'IP', N'Freely', N'IPF', N'Free123', N'0002', N'Manager')
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (9008, N'Frank', N'Smith', N'fsmith', N'fs1234', N'0001', N'Warehouse Manager')
SET IDENTITY_INSERT [dbo].[employee] OFF
/****** Object:  Table [dbo].[retailOrder]    Script Date: 08/19/2012 09:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[retailOrder](
	[retailOrderNbr] [int] IDENTITY(5000,1) NOT NULL,
	[customerID] [int] NOT NULL,
	[storeNbr] [varchar](5) NOT NULL,
	[employeeID] [int] NOT NULL,
	[salesDate] [date] NOT NULL,
	[tireCode] [varchar](4) NULL,
	[tireQty] [int] NULL,
	[retailOrderTotal] [decimal](7, 2) NULL,
 CONSTRAINT [pkRetailOrder] PRIMARY KEY CLUSTERED 
(
	[retailOrderNbr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[retailOrder] ON
INSERT [dbo].[retailOrder] ([retailOrderNbr], [customerID], [storeNbr], [employeeID], [salesDate], [tireCode], [tireQty], [retailOrderTotal]) VALUES (5000, 4000, N'0001', 9001, CAST(0x05360B00 AS Date), N'A123', 2, CAST(209.90 AS Decimal(7, 2)))
INSERT [dbo].[retailOrder] ([retailOrderNbr], [customerID], [storeNbr], [employeeID], [salesDate], [tireCode], [tireQty], [retailOrderTotal]) VALUES (5001, 4001, N'0002', 9002, CAST(0x05360B00 AS Date), N'A123', 4, CAST(419.90 AS Decimal(7, 2)))
INSERT [dbo].[retailOrder] ([retailOrderNbr], [customerID], [storeNbr], [employeeID], [salesDate], [tireCode], [tireQty], [retailOrderTotal]) VALUES (5002, 4000, N'0001', 9001, CAST(0x06360B00 AS Date), N'F453', 4, CAST(800.00 AS Decimal(7, 2)))
INSERT [dbo].[retailOrder] ([retailOrderNbr], [customerID], [storeNbr], [employeeID], [salesDate], [tireCode], [tireQty], [retailOrderTotal]) VALUES (5003, 4001, N'0002', 9002, CAST(0x06360B00 AS Date), N'G345', 4, CAST(740.00 AS Decimal(7, 2)))
INSERT [dbo].[retailOrder] ([retailOrderNbr], [customerID], [storeNbr], [employeeID], [salesDate], [tireCode], [tireQty], [retailOrderTotal]) VALUES (5004, 4002, N'0003', 9006, CAST(0x08360B00 AS Date), N'F185', 4, CAST(436.00 AS Decimal(7, 2)))
INSERT [dbo].[retailOrder] ([retailOrderNbr], [customerID], [storeNbr], [employeeID], [salesDate], [tireCode], [tireQty], [retailOrderTotal]) VALUES (5006, 4001, N'0001', 9006, CAST(0x08360B00 AS Date), N'T123', 6, CAST(1110.00 AS Decimal(7, 2)))
INSERT [dbo].[retailOrder] ([retailOrderNbr], [customerID], [storeNbr], [employeeID], [salesDate], [tireCode], [tireQty], [retailOrderTotal]) VALUES (5007, 4002, N'0001', 9004, CAST(0x09360B00 AS Date), N'F453', 1, CAST(200.00 AS Decimal(7, 2)))
SET IDENTITY_INSERT [dbo].[retailOrder] OFF
/****** Object:  Default [DF_tire_retailPrice]    Script Date: 08/19/2012 09:34:33 ******/
ALTER TABLE [dbo].[tire] ADD  CONSTRAINT [DF_tire_retailPrice]  DEFAULT ((0)) FOR [retailPrice]
GO
/****** Object:  Default [DF_tire_dealerPrice]    Script Date: 08/19/2012 09:34:33 ******/
ALTER TABLE [dbo].[tire] ADD  CONSTRAINT [DF_tire_dealerPrice]  DEFAULT ((0)) FOR [dealerPrice]
GO
/****** Object:  Default [DF_tire_wholesaleCost]    Script Date: 08/19/2012 09:34:33 ******/
ALTER TABLE [dbo].[tire] ADD  CONSTRAINT [DF_tire_wholesaleCost]  DEFAULT ((0)) FOR [wholesaleCost]
GO
/****** Object:  ForeignKey [fkEmpSecurity]    Script Date: 08/19/2012 09:34:33 ******/
ALTER TABLE [dbo].[employee]  WITH CHECK ADD  CONSTRAINT [fkEmpSecurity] FOREIGN KEY([userSecurityLevel])
REFERENCES [dbo].[securityClearance] ([Clearance])
GO
ALTER TABLE [dbo].[employee] CHECK CONSTRAINT [fkEmpSecurity]
GO
/****** Object:  ForeignKey [fkEmpStore]    Script Date: 08/19/2012 09:34:33 ******/
ALTER TABLE [dbo].[employee]  WITH CHECK ADD  CONSTRAINT [fkEmpStore] FOREIGN KEY([storeNbr])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[employee] CHECK CONSTRAINT [fkEmpStore]
GO
/****** Object:  ForeignKey [fkStoreInv]    Script Date: 08/19/2012 09:34:33 ******/
ALTER TABLE [dbo].[inventory]  WITH CHECK ADD  CONSTRAINT [fkStoreInv] FOREIGN KEY([storeNbr])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[inventory] CHECK CONSTRAINT [fkStoreInv]
GO
/****** Object:  ForeignKey [fkTireInv]    Script Date: 08/19/2012 09:34:33 ******/
ALTER TABLE [dbo].[inventory]  WITH CHECK ADD  CONSTRAINT [fkTireInv] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[inventory] CHECK CONSTRAINT [fkTireInv]
GO
/****** Object:  ForeignKey [fkPoTireCode]    Script Date: 08/19/2012 09:34:33 ******/
ALTER TABLE [dbo].[purchaseOrder]  WITH CHECK ADD  CONSTRAINT [fkPoTireCode] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[purchaseOrder] CHECK CONSTRAINT [fkPoTireCode]
GO
/****** Object:  ForeignKey [fkPoVendor]    Script Date: 08/19/2012 09:34:33 ******/
ALTER TABLE [dbo].[purchaseOrder]  WITH CHECK ADD  CONSTRAINT [fkPoVendor] FOREIGN KEY([vendorID])
REFERENCES [dbo].[vendor] ([vendorID])
GO
ALTER TABLE [dbo].[purchaseOrder] CHECK CONSTRAINT [fkPoVendor]
GO
/****** Object:  ForeignKey [fkRtlOrderCust]    Script Date: 08/19/2012 09:34:33 ******/
ALTER TABLE [dbo].[retailOrder]  WITH CHECK ADD  CONSTRAINT [fkRtlOrderCust] FOREIGN KEY([customerID])
REFERENCES [dbo].[customer] ([customerID])
GO
ALTER TABLE [dbo].[retailOrder] CHECK CONSTRAINT [fkRtlOrderCust]
GO
/****** Object:  ForeignKey [fkRtlOrderEmp]    Script Date: 08/19/2012 09:34:33 ******/
ALTER TABLE [dbo].[retailOrder]  WITH CHECK ADD  CONSTRAINT [fkRtlOrderEmp] FOREIGN KEY([employeeID])
REFERENCES [dbo].[employee] ([employeeID])
GO
ALTER TABLE [dbo].[retailOrder] CHECK CONSTRAINT [fkRtlOrderEmp]
GO
/****** Object:  ForeignKey [fkRtlOrderStore]    Script Date: 08/19/2012 09:34:33 ******/
ALTER TABLE [dbo].[retailOrder]  WITH CHECK ADD  CONSTRAINT [fkRtlOrderStore] FOREIGN KEY([storeNbr])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[retailOrder] CHECK CONSTRAINT [fkRtlOrderStore]
GO
/****** Object:  ForeignKey [FK_wholesaleOrder_dealer]    Script Date: 08/19/2012 09:34:33 ******/
ALTER TABLE [dbo].[wholesaleOrder]  WITH CHECK ADD  CONSTRAINT [FK_wholesaleOrder_dealer] FOREIGN KEY([dealerID])
REFERENCES [dbo].[dealer] ([dealerId])
GO
ALTER TABLE [dbo].[wholesaleOrder] CHECK CONSTRAINT [FK_wholesaleOrder_dealer]
GO
/****** Object:  ForeignKey [FK_wholesaleOrder_tire]    Script Date: 08/19/2012 09:34:33 ******/
ALTER TABLE [dbo].[wholesaleOrder]  WITH CHECK ADD  CONSTRAINT [FK_wholesaleOrder_tire] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[wholesaleOrder] CHECK CONSTRAINT [FK_wholesaleOrder_tire]
GO
