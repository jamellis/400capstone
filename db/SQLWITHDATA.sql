USE [comp400_2012]
GO
/****** Object:  Table [dbo].[vendor]    Script Date: 08/15/2012 20:05:21 ******/
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
/****** Object:  Table [dbo].[tire]    Script Date: 08/15/2012 20:05:21 ******/
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
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'F185', N'All Season', N'Falkin', N'R235', CAST(109.00 AS Decimal(6, 2)), CAST(100.00 AS Decimal(6, 2)), CAST(95.00 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'F186', N'All Season/Touring', N'Falkin', N'R225', CAST(154.00 AS Decimal(6, 2)), CAST(136.00 AS Decimal(6, 2)), CAST(120.00 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'G134', N'Mud Terrain', N'Goodyear', N'R265', CAST(225.00 AS Decimal(6, 2)), CAST(210.00 AS Decimal(6, 2)), CAST(200.00 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'G135', N'Towing/Hauling', N'Goodyear', N'R285', CAST(245.00 AS Decimal(6, 2)), CAST(225.00 AS Decimal(6, 2)), CAST(210.00 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'N198', N'Touring', N'Nokian', N'R245', CAST(134.00 AS Decimal(6, 2)), CAST(126.00 AS Decimal(6, 2)), CAST(115.00 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'N199', N'Performance', N'Nokian', N'R250', CAST(200.00 AS Decimal(6, 2)), CAST(185.00 AS Decimal(6, 2)), CAST(150.00 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'T123', N'All Weather', N'Toyo', N'R275', CAST(185.00 AS Decimal(6, 2)), CAST(165.00 AS Decimal(6, 2)), CAST(140.00 AS Decimal(6, 2)))
INSERT [dbo].[tire] ([tireCode], [description], [manufacturer], [manufacturerSize], [retailPrice], [dealerPrice], [wholesaleCost]) VALUES (N'T125', N'Off-Road', N'Toyo', N'R310', CAST(290.00 AS Decimal(6, 2)), CAST(270.00 AS Decimal(6, 2)), CAST(245.00 AS Decimal(6, 2)))
/****** Object:  Table [dbo].[store]    Script Date: 08/15/2012 20:05:21 ******/
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
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0001', N'1800 Happy Lane', N'Clackamas', N'OR', N'88888', N'1111111111', N'2222222222', N'store01@store.com')
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0002', N'1900 crap lane', N'Happy Valley', N'OR', N'88888', N'3602639899', N'3603334545', N'store02@store.com')
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0003', N'2000 kiss my ass', N'LaCenter', N'WA', N'98629', N'3605551212', N'3602223535', N'store03@store.com')
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0004', N'201 Carp Lane', N'Woodland', N'WA', N'97015', N'50344455555', N'50312233333', N'store04@store.com')
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0005', N'123 Salmon Lane', N'Ilwaco', N'WA', N'54784', N'5419896541', N'541698965', N'store05@store.com')
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0006', N'123 Astore Shore', N'Astoria', N'OR', N'25478', N'5412365478', N'8974563215', N'store06@store.com')
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0007', N'431 Bull Shit', N'LaPine', N'OR', N'44329', N'5412346798', N'5413453221', N'store07@store.com')
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0008', N'4533 Wilsonville', N'Wilsonville', N'OR', N'54654', N'5414320943', N'5414539908', N'Store08@store.com')
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0009', N'2802 NW', N'Vancouver', N'WA', N'98685', N'3602637130', N'236547897', N'store09@store.com')
INSERT [dbo].[store] ([storeNbr], [streetAddress], [city], [state], [zip], [phone], [fax], [email]) VALUES (N'0010', N'23405', N'Seattle', N'WA', N'857458', N'456214789', N'4123654789', N'store10@store.com')
/****** Object:  Table [dbo].[securityClearance]    Script Date: 08/15/2012 20:05:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[securityClearance](
	[Clearance] [varchar](15) NOT NULL,
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
/****** Object:  Table [dbo].[dealer]    Script Date: 08/15/2012 20:05:21 ******/
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
/****** Object:  Table [dbo].[customer]    Script Date: 08/15/2012 20:05:21 ******/
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
INSERT [dbo].[customer] ([customerID], [custFirstName], [custLastName], [custStreet], [custCity], [custState], [custZip], [custPhone]) VALUES (4000, N'Jason', N'Bourne', N'123 Shit House Lane', N'St Louis', N'MO', N'85214', N'5236547893')
INSERT [dbo].[customer] ([customerID], [custFirstName], [custLastName], [custStreet], [custCity], [custState], [custZip], [custPhone]) VALUES (4001, N'Marry', N'Pooping', N'Big Hole', N'Missoula', N'MA', N'65478', N'123456789')
INSERT [dbo].[customer] ([customerID], [custFirstName], [custLastName], [custStreet], [custCity], [custState], [custZip], [custPhone]) VALUES (4002, N'Moob', N'Manny', N'Short Stack 1232 Lane', N'Weiser', N'ID', N'45785', N'1234568745')
INSERT [dbo].[customer] ([customerID], [custFirstName], [custLastName], [custStreet], [custCity], [custState], [custZip], [custPhone]) VALUES (4003, N'Rob', N'Mate', N'543 Short Nuts', N'Kalama', N'WA', N'98765', N'12354789')
INSERT [dbo].[customer] ([customerID], [custFirstName], [custLastName], [custStreet], [custCity], [custState], [custZip], [custPhone]) VALUES (4004, N'Crappy', N'Person', N'432 Smells Bad Lane', N'Winchels', N'NB', N'09843', N'435-455-5555')
SET IDENTITY_INSERT [dbo].[customer] OFF
/****** Object:  Table [dbo].[purchaseOrderDetail]    Script Date: 08/15/2012 20:05:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[purchaseOrderDetail](
	[poDtlLineID] [int] IDENTITY(2000,1) NOT NULL,
	[poNbr] [int] NOT NULL,
	[tireCode] [varchar](4) NOT NULL,
	[tireQtyOrdered] [decimal](4, 0) NOT NULL,
	[tireQtyReceived] [decimal](4, 0) NULL,
	[comments] [varchar](max) NULL,
 CONSTRAINT [PK_purchaseOrderDetail] PRIMARY KEY CLUSTERED 
(
	[poDtlLineID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[purchaseOrder]    Script Date: 08/15/2012 20:05:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[purchaseOrder](
	[poNbr] [int] IDENTITY(3000,1) NOT NULL,
	[vendorID] [int] NOT NULL,
	[storeNbr] [varchar](5) NOT NULL,
	[poDate] [date] NOT NULL,
	[closed] [bit] NULL,
 CONSTRAINT [pkPurchaseOrder] PRIMARY KEY CLUSTERED 
(
	[poNbr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[inventory]    Script Date: 08/15/2012 20:05:21 ******/
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
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10000, N'F185', N'0001', CAST(0 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10001, N'F186', N'0002', CAST(15 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10002, N'F186', N'0009', CAST(5 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10003, N'F186', N'0008', CAST(4 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10004, N'G134', N'0005', CAST(4 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10005, N'G135', N'0006', CAST(30 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10006, N'N198', N'0004', CAST(13 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10007, N'N199', N'0007', CAST(0 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10010, N'T123', N'0003', CAST(8 AS Decimal(4, 0)))
INSERT [dbo].[inventory] ([inventoryNbr], [tireCode], [storeNbr], [tireQty]) VALUES (10011, N'T125', N'0002', CAST(11 AS Decimal(4, 0)))
SET IDENTITY_INSERT [dbo].[inventory] OFF
/****** Object:  Table [dbo].[employee]    Script Date: 08/15/2012 20:05:21 ******/
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
	[userSecurityLevel] [varchar](15) NOT NULL,
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
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (9001, N'Susan', N'Barnes', N'sbarnes', N'sb1234', N'0002', N'Sales')
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (9003, N'Howard', N'Newton', N'hnewton', N'hn1234', N'0001', N'Manager')
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (9004, N'Alan', N'Rankin', N'arankin', N'ar1234', N'0001', N'Admin')
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (9005, N'Barb', N'Mason', N'bmason', N'mb1234', N'0005', N'Warehouse')
INSERT [dbo].[employee] ([employeeID], [firstName], [lastName], [userID], [password], [storeNbr], [userSecurityLevel]) VALUES (9006, N'James', N'Ellis', N'jellis', N'je1234', N'0003', N'Manager')
SET IDENTITY_INSERT [dbo].[employee] OFF
/****** Object:  Table [dbo].[wholesaleOrder]    Script Date: 08/15/2012 20:05:21 ******/
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
/****** Object:  Table [dbo].[transferOrder]    Script Date: 08/15/2012 20:05:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[transferOrder](
	[transferOrderNbr] [int] IDENTITY(8000,1) NOT NULL,
	[shipStore] [varchar](5) NOT NULL,
	[receiveStore] [varchar](5) NOT NULL,
	[transferDate] [date] NOT NULL,
 CONSTRAINT [pkTransferOrder] PRIMARY KEY CLUSTERED 
(
	[transferOrderNbr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[transferOrderDetail]    Script Date: 08/15/2012 20:05:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[transferOrderDetail](
	[tnfrDtlLineID] [int] IDENTITY(9000,1) NOT NULL,
	[transferOrderNbr] [int] NOT NULL,
	[tireCode] [varchar](4) NOT NULL,
	[tireQty] [decimal](4, 0) NOT NULL,
 CONSTRAINT [pkTnfrOrderDtl] PRIMARY KEY CLUSTERED 
(
	[tnfrDtlLineID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[retailOrder]    Script Date: 08/15/2012 20:05:21 ******/
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
INSERT [dbo].[retailOrder] ([retailOrderNbr], [customerID], [storeNbr], [employeeID], [salesDate], [tireCode], [tireQty], [retailOrderTotal]) VALUES (5000, 4000, N'0001', 9001, CAST(0x08360B00 AS Date), N'F185', 4, CAST(436.00 AS Decimal(7, 2)))
INSERT [dbo].[retailOrder] ([retailOrderNbr], [customerID], [storeNbr], [employeeID], [salesDate], [tireCode], [tireQty], [retailOrderTotal]) VALUES (5001, 4002, N'0001', 9001, CAST(0x08360B00 AS Date), N'F185', 2, CAST(218.00 AS Decimal(7, 2)))
INSERT [dbo].[retailOrder] ([retailOrderNbr], [customerID], [storeNbr], [employeeID], [salesDate], [tireCode], [tireQty], [retailOrderTotal]) VALUES (5002, 4004, N'0003', 9006, CAST(0x08360B00 AS Date), N'T123', 6, CAST(1110.00 AS Decimal(7, 2)))
INSERT [dbo].[retailOrder] ([retailOrderNbr], [customerID], [storeNbr], [employeeID], [salesDate], [tireCode], [tireQty], [retailOrderTotal]) VALUES (5003, 4003, N'0001', 9004, CAST(0x09360B00 AS Date), N'F185', 2, CAST(218.00 AS Decimal(7, 2)))
INSERT [dbo].[retailOrder] ([retailOrderNbr], [customerID], [storeNbr], [employeeID], [salesDate], [tireCode], [tireQty], [retailOrderTotal]) VALUES (5004, 4002, N'0001', 9004, CAST(0x09360B00 AS Date), N'F185', 2, CAST(218.00 AS Decimal(7, 2)))
SET IDENTITY_INSERT [dbo].[retailOrder] OFF
/****** Object:  Default [DF_tire_retailPrice]    Script Date: 08/15/2012 20:05:21 ******/
ALTER TABLE [dbo].[tire] ADD  CONSTRAINT [DF_tire_retailPrice]  DEFAULT ((0)) FOR [retailPrice]
GO
/****** Object:  Default [DF_tire_dealerPrice]    Script Date: 08/15/2012 20:05:21 ******/
ALTER TABLE [dbo].[tire] ADD  CONSTRAINT [DF_tire_dealerPrice]  DEFAULT ((0)) FOR [dealerPrice]
GO
/****** Object:  Default [DF_tire_wholesaleCost]    Script Date: 08/15/2012 20:05:21 ******/
ALTER TABLE [dbo].[tire] ADD  CONSTRAINT [DF_tire_wholesaleCost]  DEFAULT ((0)) FOR [wholesaleCost]
GO
/****** Object:  Default [DF_transferOrderDetail_tireQty]    Script Date: 08/15/2012 20:05:21 ******/
ALTER TABLE [dbo].[transferOrderDetail] ADD  CONSTRAINT [DF_transferOrderDetail_tireQty]  DEFAULT ((0)) FOR [tireQty]
GO
/****** Object:  ForeignKey [fkTireCode]    Script Date: 08/15/2012 20:05:21 ******/
ALTER TABLE [dbo].[purchaseOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkTireCode] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[purchaseOrderDetail] CHECK CONSTRAINT [fkTireCode]
GO
/****** Object:  ForeignKey [fkPOStore]    Script Date: 08/15/2012 20:05:21 ******/
ALTER TABLE [dbo].[purchaseOrder]  WITH CHECK ADD  CONSTRAINT [fkPOStore] FOREIGN KEY([storeNbr])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[purchaseOrder] CHECK CONSTRAINT [fkPOStore]
GO
/****** Object:  ForeignKey [fkPoVendor]    Script Date: 08/15/2012 20:05:21 ******/
ALTER TABLE [dbo].[purchaseOrder]  WITH CHECK ADD  CONSTRAINT [fkPoVendor] FOREIGN KEY([vendorID])
REFERENCES [dbo].[vendor] ([vendorID])
GO
ALTER TABLE [dbo].[purchaseOrder] CHECK CONSTRAINT [fkPoVendor]
GO
/****** Object:  ForeignKey [fkStoreInv]    Script Date: 08/15/2012 20:05:21 ******/
ALTER TABLE [dbo].[inventory]  WITH CHECK ADD  CONSTRAINT [fkStoreInv] FOREIGN KEY([storeNbr])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[inventory] CHECK CONSTRAINT [fkStoreInv]
GO
/****** Object:  ForeignKey [fkTireInv]    Script Date: 08/15/2012 20:05:21 ******/
ALTER TABLE [dbo].[inventory]  WITH CHECK ADD  CONSTRAINT [fkTireInv] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[inventory] CHECK CONSTRAINT [fkTireInv]
GO
/****** Object:  ForeignKey [fkEmpSecurity]    Script Date: 08/15/2012 20:05:21 ******/
ALTER TABLE [dbo].[employee]  WITH CHECK ADD  CONSTRAINT [fkEmpSecurity] FOREIGN KEY([userSecurityLevel])
REFERENCES [dbo].[securityClearance] ([Clearance])
GO
ALTER TABLE [dbo].[employee] CHECK CONSTRAINT [fkEmpSecurity]
GO
/****** Object:  ForeignKey [fkEmpStore]    Script Date: 08/15/2012 20:05:21 ******/
ALTER TABLE [dbo].[employee]  WITH CHECK ADD  CONSTRAINT [fkEmpStore] FOREIGN KEY([storeNbr])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[employee] CHECK CONSTRAINT [fkEmpStore]
GO
/****** Object:  ForeignKey [FK_wholesaleOrder_dealer]    Script Date: 08/15/2012 20:05:21 ******/
ALTER TABLE [dbo].[wholesaleOrder]  WITH CHECK ADD  CONSTRAINT [FK_wholesaleOrder_dealer] FOREIGN KEY([dealerID])
REFERENCES [dbo].[dealer] ([dealerId])
GO
ALTER TABLE [dbo].[wholesaleOrder] CHECK CONSTRAINT [FK_wholesaleOrder_dealer]
GO
/****** Object:  ForeignKey [FK_wholesaleOrder_tire]    Script Date: 08/15/2012 20:05:21 ******/
ALTER TABLE [dbo].[wholesaleOrder]  WITH CHECK ADD  CONSTRAINT [FK_wholesaleOrder_tire] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[wholesaleOrder] CHECK CONSTRAINT [FK_wholesaleOrder_tire]
GO
/****** Object:  ForeignKey [fkTrnRecStore]    Script Date: 08/15/2012 20:05:21 ******/
ALTER TABLE [dbo].[transferOrder]  WITH CHECK ADD  CONSTRAINT [fkTrnRecStore] FOREIGN KEY([receiveStore])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[transferOrder] CHECK CONSTRAINT [fkTrnRecStore]
GO
/****** Object:  ForeignKey [fkTrnShipStore]    Script Date: 08/15/2012 20:05:21 ******/
ALTER TABLE [dbo].[transferOrder]  WITH CHECK ADD  CONSTRAINT [fkTrnShipStore] FOREIGN KEY([shipStore])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[transferOrder] CHECK CONSTRAINT [fkTrnShipStore]
GO
/****** Object:  ForeignKey [fkTnfrDtlOrder]    Script Date: 08/15/2012 20:05:21 ******/
ALTER TABLE [dbo].[transferOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkTnfrDtlOrder] FOREIGN KEY([transferOrderNbr])
REFERENCES [dbo].[transferOrder] ([transferOrderNbr])
GO
ALTER TABLE [dbo].[transferOrderDetail] CHECK CONSTRAINT [fkTnfrDtlOrder]
GO
/****** Object:  ForeignKey [fkTnfrDtlTire]    Script Date: 08/15/2012 20:05:21 ******/
ALTER TABLE [dbo].[transferOrderDetail]  WITH CHECK ADD  CONSTRAINT [fkTnfrDtlTire] FOREIGN KEY([tireCode])
REFERENCES [dbo].[tire] ([tireCode])
GO
ALTER TABLE [dbo].[transferOrderDetail] CHECK CONSTRAINT [fkTnfrDtlTire]
GO
/****** Object:  ForeignKey [fkRtlOrderCust]    Script Date: 08/15/2012 20:05:21 ******/
ALTER TABLE [dbo].[retailOrder]  WITH CHECK ADD  CONSTRAINT [fkRtlOrderCust] FOREIGN KEY([customerID])
REFERENCES [dbo].[customer] ([customerID])
GO
ALTER TABLE [dbo].[retailOrder] CHECK CONSTRAINT [fkRtlOrderCust]
GO
/****** Object:  ForeignKey [fkRtlOrderEmp]    Script Date: 08/15/2012 20:05:21 ******/
ALTER TABLE [dbo].[retailOrder]  WITH CHECK ADD  CONSTRAINT [fkRtlOrderEmp] FOREIGN KEY([employeeID])
REFERENCES [dbo].[employee] ([employeeID])
GO
ALTER TABLE [dbo].[retailOrder] CHECK CONSTRAINT [fkRtlOrderEmp]
GO
/****** Object:  ForeignKey [fkRtlOrderStore]    Script Date: 08/15/2012 20:05:21 ******/
ALTER TABLE [dbo].[retailOrder]  WITH CHECK ADD  CONSTRAINT [fkRtlOrderStore] FOREIGN KEY([storeNbr])
REFERENCES [dbo].[store] ([storeNbr])
GO
ALTER TABLE [dbo].[retailOrder] CHECK CONSTRAINT [fkRtlOrderStore]
GO
